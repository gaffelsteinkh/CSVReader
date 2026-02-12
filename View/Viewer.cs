using Spectre.Console;

public class SpectreShow
{
    

public void ShowHeader()
    {
        AnsiConsole.Write(new FigletText("Used Audi").LeftJustified());
        AnsiConsole.WriteLine();
    }
public string ShowMainMenu()
    {
        return AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Select an option:")
            .AddChoices("Browse used Audis", "Exit")
        );

    }


}