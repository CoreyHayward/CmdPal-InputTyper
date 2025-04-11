// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;

namespace InputTyperExtension;

public partial class InputTyperExtensionCommandsProvider : CommandProvider
{
    private readonly ICommandItem[] _commands;

    public InputTyperExtensionCommandsProvider()
    {
        DisplayName = "Input Typer";
        Icon = Constants.Icon;
        _commands = [
            new CommandItem(new InputTyperExtensionPage()) { Title = DisplayName, Subtitle= "Type text as if it was sent from the keyboard" },
        ];
    }

    public override ICommandItem[] TopLevelCommands() => _commands;



}
