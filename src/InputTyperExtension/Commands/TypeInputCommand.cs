using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputTyperExtension.Commands;
internal sealed partial class TypeInputCommand : InvokableCommand
{
    private readonly char[] _specialCharacters = { '{', '}', '+', '^', '%', '~', '(', ')' };
    private readonly string _text;
    private const int INTERKEYDELAY = 10;

    public TypeInputCommand(string text, string displayPrefix = "Type:")
    {
        Icon = IconHelpers.FromRelativePath("Assets\\InputTyper.dark.png");
        _text = text;
        Name = $"{displayPrefix} '{_text}'";
        return;
    }

    public override ICommandResult Invoke()
    {
        var _ = Task.Run(() =>
        {
            Thread.Sleep(500);
            foreach (var c in _text.ToString())
            {
                // Some characters have special meaning and must be surrounded by '{}'
                // https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/sendkeys-statement
                if (_specialCharacters.Contains(c))
                {
                    SendKeys.SendWait("{" + c + "}");
                }
                else
                {
                    SendKeys.SendWait(c.ToString());
                }

                Thread.Sleep(INTERKEYDELAY);
            }
        });
        
        return CommandResult.Dismiss();
    }
}
