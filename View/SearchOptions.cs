using System.Runtime.CompilerServices;
using CsvHelper;
using Formatting;
using Spectre.Console;

public class SearchOpt
{
    public string Input()
    {
        Console.WriteLine("What model Audi, are you searching for?");
        
        return Console.ReadLine() ?? string.Empty;
    }
    
    public string SortByYear(List<Audi> cars, string saved)
    {
        var selectable = new SelectionPrompt<string>()
            .Title($"Model\tYear\tPrice\tTransmission\tMileage\tFuel-type\tTax\tMPG\tEngine (L)");


        var searched = cars.Where(car => car.model.Contains(saved));

        foreach (var car in searched.OrderBy(n => n.year))
        {
            
            selectable.AddChoice(car.AllTheInfo().ToString());
        }

        return AnsiConsole.Prompt(selectable);



    }

}