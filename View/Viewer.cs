using Formatting;
using Spectre.Console;

public class SpectreShow
{
    

public void ShowHeader()
    {
        AnsiConsole.Write(new FigletText("Used Audi").LeftJustified());
        AnsiConsole.WriteLine();
    }
public string ShowMainMenu(List<Audi>cars)
    {
        var selectable = new SelectionPrompt<string>()
            .Title($"Model\tYear\tPrice\tTransmission\tMileage\tFuel-type\tTax\tMPG\tEngine (L)");
            foreach (var car in cars)
        {
            selectable.AddChoice(car.AllTheInfo());
        }
        return AnsiConsole.Prompt(selectable);

    }


}