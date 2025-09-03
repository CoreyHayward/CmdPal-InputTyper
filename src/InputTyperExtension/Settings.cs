// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace InputTyperExtension;

/// <summary>
/// Settings for the Input Typer extension.
/// </summary>
internal static class Settings
{
    /// <summary>
    /// Gets or sets a value indicating whether to hide the clipboard text in the command palette display.
    /// When true, clipboard content will be shown as "[hidden]" instead of the actual text.
    /// </summary>
    public static bool HideClipboardText { get; set; } = false;
}