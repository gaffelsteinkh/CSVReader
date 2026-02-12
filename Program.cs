
using System.Runtime.CompilerServices;

public class Program
{
    
    static void Main(string[] args)
    {
        var cars = Csv.Read();
        foreach (var car in cars)
        {
            Console.WriteLine(car.AllTheInfo());
        }
        /*Controller controller = new Controller();
        controller.Run();*/
    }
}