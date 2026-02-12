using CsvHelper;
using Formatting;
using System.Globalization;
using System.Linq;
public class Csv
{
    public static List<Audi> Read()
    {
        List<Audi> cars = new ();
        using (var reader = new StreamReader("C:\\Users\\Morten\\Desktop\\Prosjekter\\C# BackEnd\\Modul 1\\Uke 4\\CSVReader\\Models\\audi.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            cars = csv.GetRecords<Audi>().OrderBy(n => n.model).ToList<Audi>();
        }
        return cars;
    }  
}