<div align="center">

# PowerToys Command Palette: Input Typer
  
[![GitHub release](https://img.shields.io/github/v/release/CoreyHayward/CmdPal-InputTyper?style=flat-square)](https://github.com/CoreyHayward/CmdPal-InputTyper/releases/latest)
[![GitHub all releases](https://img.shields.io/github/downloads/CoreyHayward/CmdPal-InputTyper/total?style=flat-square)](https://github.com/CoreyHayward/CmdPal-InputTyper/releases/)
[![GitHub release (latest by date)](https://img.shields.io/github/downloads/CoreyHayward/CmdPal-InputTyper/latest/total?style=flat-square)](https://github.com/CoreyHayward/CmdPal-InputTyper/releases/latest)

</div>

Simple [PowerToys CmdPal](https://learn.microsoft.com/en-gb/windows/powertoys/command-palette/overview) plugin for easily typing input as if from a keyboard. Ideal for remote environments and other scenarios where pasting isn't possible.

![InputTyper Demonstration](/Images/InputTyper.gif)

## Requirements

- PowerToys minimum version 0.90.0

## Installation

- Download the [latest release](https://github.com/CoreyHayward/CmdPal-InputTyper/releases/) by selecting the architecture that matches your machine: `x64` (more common) or `ARM64`
- Extract the archive and run the Install.ps1
- This will install the certificate into the TrustedPublishers store and install the extension
- Open PowerToys CmdPal

## Usage
- Select/Place cursor where text should be typed 
- Open PowerToys CmdPal
- Search Input Typer and click enter
- Type the text you wish to input or leave blank for to type the clipboard
- Select the result (ENTER)
- \<text\> is typed into the selected location

## Setting an Alias
An alias can be set to allow for quick activation of the Input Typer extension. 
This is fully managed via the Command Palette extensions page in the settings.
