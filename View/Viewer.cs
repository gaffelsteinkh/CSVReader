using Formatting;
using Spectre.Console;

public class SpectreShow
{


    public void ShowHeader()
    {
        AnsiConsole.Write(new FigletText("Used Audi").LeftJustified());
        AnsiConsole.WriteLine();
    }
    public string ShowSearch(List<Audi> cars)
    {
        var selectable = new SelectionPrompt<string>()
            .Title($"Model\tYear\tPrice\tTransmission\tMileage\tFuel-type\tTax\tMPG\tEngine (L)");

        foreach (var car in cars)
        {
            selectable.AddChoice(car.AllTheInfo());
        }

        return AnsiConsole.Prompt(selectable);

    }
    
    public void MainMenu(List<Audi> cars)
    {

        var available = new[]
        {
            "Search",
            "Exit"
        };

        var selected = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Main menu:")
            .AddChoices(available)
        );
        if (selected == "Search")
        {
            SearchOpt search = new();
            search.SortByYear(cars);
        }
        if (selected == "Exit")
        {
            return;
        }
    }

}