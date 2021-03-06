### ManyConsole

Available on Nuget: http://nuget.org/List/Packages/ManyConsole

NDesk.Options is a great library for processing command-line parameters.  ManyConsole extends NDesk.Options to allow building console applications that support separate commands.

ManyConsole provides a console interface for the user to list available commands, call and get help for each.

To use ManyConsole:

- Create a command line app referencing the ManyConsole nuget.
- Have Program.Main call ConsoleCommandDispatcher (see https://github.com/fschwiet/ManyConsole/blob/master/SampleConsole/Program.cs)
  - You can use ConsoleCommandDispatcher to find commands in an assembly, or not.
- To add a command to your console application, inherit from ConsoleCommand.
  - See the sample comands at https://github.com/fschwiet/ManyConsole/tree/master/SampleConsole

Each command exposes an OptionSet, the docs on how to define an OptionSet are here: http://www.ndesk.org/Options

This code was pulled as-is from a closed-source personal project of mine in order to make it shareable.