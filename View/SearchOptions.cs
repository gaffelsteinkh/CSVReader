using Formatting;
using Spectre.Console;

public class SearchOpt
{
    public string SortByYear(List<Audi> cars)
    {
        var selectable = new SelectionPrompt<string>()
            .Title($"Model\tYear\tPrice\tTransmission\tMileage\tFuel-type\tTax\tMPG\tEngine (L)");

        var search = cars.OrderBy(n => n.year).ToList();
        foreach (var car in cars)
        {
            selectable.AddChoice(cars.OrderBy(n => n.year).ToString());
        }

        return AnsiConsole.Prompt(selectable);
        

        
    }

}