
using System.Runtime.CompilerServices;

public class Program
{
    
    static void Main(string[] args)
    {
        var cars = Csv.Read();
        Controller controller = new Controller();
        controller.Run(cars);
    }
}