
using System.Runtime.ExceptionServices;

public class Program
{

    static void Main(string[] args)
    {
        var cars = Csv.Read();
        Controller controller = new Controller();
        controller.Run(cars);

        // SpectreShow Spec = new();
        // Spec.ShowSearch(cars);
        
       /* string[] csvFile = File.ReadAllLines(@"Models\audi.csv");
        Console.WriteLine("Enter what you wanna search for:");
        string search = Console.ReadLine() ?? string.Empty;

        var firstSearch = csvFile.Where(csvFile => csvFile.Contains(search));

        List<string> cars = new List<string>();

        foreach (var line in firstSearch)
        {
            string searchNar = line.Replace(",", " ");
            cars.Add(searchNar);
        }

        bool isTrue = true;
        while (isTrue)
        {
            if (cars.Count == 0)
            {
                throw new Exception("Invalid search");
            }

            if (cars.Count > 0)
            {
                string secSearch = Console.ReadLine().ToLower() ?? string.Empty;
                if (secSearch == "year")
                {
                    
                    
                }
            }

        }
        Console.WriteLine(cars.Count);
        */
    }
}



/*
var cars = Csv.Read();
        Controller controller = new Controller();
        controller.Run(cars);
*/