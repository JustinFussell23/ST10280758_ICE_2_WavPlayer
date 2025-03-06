# FilePlayer

## Overview
This is a C# console application that plays WAV files using `System.Media`. It allows users to select from three WAV files stored in the `bin\Debug\Music` folder, displays a menu, and changes the text color to green for files that have been played.

## Features
- Load and play 3 WAV files: `Electronic_Beat.wav`, `Guitar_Beat.wav`, and `Tranquil_Beat.wav`.
- Menu options: Enter 1, 2, or 3 to play a file; 0 to exit.
- Played files turn green in the menu.

## Requirements
- .NET Framework (4.8)
- WAV files placed in `bin\Debug\Music` (update paths in `Program.cs` if different)

## How to Run
1. Clone the repository.
2. Open in Visual Studio.
3. Ensure WAV files are in `bin\Debug\Music` (or update `filePaths` in `Program.cs`).
4. Build and run (F5).

## Author
- **Name**: Justin Fussell
- **Student Number**: ST10280758
- **Group**: 3

## Notes
- Built as a learning project for C# basics.
- Uses two classes: `Program` and `AudioPlayer`.
