// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using InputTyperExtension.Commands;
using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;

namespace InputTyperExtension;

internal sealed partial class InputTyperExtensionPage : DynamicListPage
{
    public InputTyperExtensionPage()
    {
        Icon = Constants.Icon;
        Title = "Input Typer";
        Name = "Open";
    }

    public override IListItem[] GetItems()
    {
        var clipboardItem = new ListItem(new TypeInputCommand(ClipboardHelper.GetText(), "Type (Clipboard):"));
        return string.IsNullOrWhiteSpace(SearchText) ? [clipboardItem] : [new ListItem(new TypeInputCommand(SearchText)), clipboardItem];
    }

    public override void UpdateSearchText(string _, string newSearch) => RaiseItemsChanged();
}
