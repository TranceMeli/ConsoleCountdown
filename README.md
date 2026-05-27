# ConsoleGameTools - ASCII Countdown

A small reusable ASCII countdown component for console games in C#.

## Features

- ASCII progress bar
- Visual feedback (█░ style)
- Optional cancel with Q
- Simple integration
- No dependencies

## Usage

```csharp
var countdown = new AsciiCountdown();
countdown.Start(20);

if (countdown.Cancelled)
{
    Console.WriteLine("Cancelled");
}