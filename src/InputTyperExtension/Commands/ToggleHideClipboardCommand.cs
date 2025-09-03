// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;

namespace InputTyperExtension.Commands;

internal sealed class ToggleHideClipboardCommand : InvokableCommand
{
    public ToggleHideClipboardCommand()
    {
        Icon = IconHelpers.FromRelativePath("Assets\\InputTyper.dark.png");
        UpdateDisplayName();
    }

    private void UpdateDisplayName()
    {
        var status = Settings.HideClipboardText ? "ON" : "OFF";
        Name = $"Hide Clipboard Text: {status}";
    }

    public override ICommandResult Invoke()
    {
        Settings.HideClipboardText = !Settings.HideClipboardText;
        UpdateDisplayName();
        
        var status = Settings.HideClipboardText ? "enabled" : "disabled";
        return CommandResult.KeepOpen($"Clipboard text hiding {status}");
    }
}