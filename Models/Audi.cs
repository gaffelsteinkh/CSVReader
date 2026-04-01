namespace Formatting
{
        
    public class Audi
    {
        public string model { get ; set ;} = "";
        public int year { get ; set ;}
        public int price { get ; set ;}
        public string transmission { get ; set ;} = "";
        public int mileage { get ; set ;}
        public string fuelType { get ; set ;} = "";
        public int tax { get ; set ;}
        public double mpg { get ; set ;}
        public double engineSize { get ; set ;}

        public string AllTheInfo()
        {
            return ($"{model}\t{year}\t{price}\t{transmission}   \t{mileage} \t{fuelType}   \t{tax}\t{mpg}\t{engineSize}"); 
        }
    }
    
}
