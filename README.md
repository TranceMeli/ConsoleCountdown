# ConsoleGameTools - ASCII Countdown

A small reusable ASCII countdown component for console games in C#.

<img width="467" height="46" alt="image" src="https://github.com/user-attachments/assets/de2e1099-8fee-45b4-b286-d785cc15e632" />

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


