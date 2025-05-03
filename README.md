# Simple-C-Programs
A group of very simple C# programs developed for learning.

## Table of Contents
* [Setup (Git Bash)](#setupgitbash)
* [Setup (Windows-Friendly)](#setupwindowsfriendly)
* [Environment Variable Updates (Windows-Friendly)](#environmentvariableupdates)
* [Programs](#programs)

## Setup (Git Bash)
* `git clone <repo name>` to clone the repository to your computer
* `cd` into the simple program directory (e.g. HelloWorld)
* Follow instructions in `README.md` to compile and run

## Setup (Windows-Friendly)
* On the GitHub page, click the green "<> Code" button
* Click "Download ZIP"
* Right-click on the downloaded ZIP file, and click "Extract All..."
* Click "Extract"

## Environment Variable Updates (Windows-Friendly)
* Type "Environment" in your Windows Search Bar, and click on "Edit environment variables for your account"
* Under "User variables for <user>", click "Path" and then click "Edit..."
* Click "New" and add `/c/Windows/Microsoft.NET/Framework/<version>` to your Path (fill in <version> with whatever version directory is in there)
* Click "OK", and then click "OK" in the Environment Variables window
* Now, you should be able to call `csc` (C# compiler) from your command line

## Programs
### Hello World
An extremely basic C# program that was written just to get something to compile & run in C#!

### Advanced Hello World
A less-basic version of 'Hello World' that allows you to pass in options flags for fancy printing.
