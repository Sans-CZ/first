using Adventure;
using Adventure.Commands;
using Spectre.Console;

var world = new World();
var commands = new Dictionary<string, BaseCommand>()
{
    { "look", new LookAroundCommand() },

    { "help", new HelpCommand() },
    { "quit", new QuitCommand() }
};

AnsiConsole.MarkupLine(world.Intro);

while (true)
{
    var commandChoice = AnsiConsole.Prompt(
        new TextPrompt<string>("What do you want to do?")
            .DefaultValue("help"));

    var parsedCommandText = commandChoice.Trim().Split(" ");
    var command = commands.GetValueOrDefault(parsedCommandText[0]) ?? commands["help"];
    
    command.Execute(world, parsedCommandText.Skip(1).ToArray());

    AnsiConsole.WriteLine();
    AnsiConsole.WriteLine("----------");
}
