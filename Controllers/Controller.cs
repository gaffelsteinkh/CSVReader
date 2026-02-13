using Formatting;

public class Controller
{
    SpectreShow view = new SpectreShow();




    public void Run(List<Audi>cars)
    {
        view.ShowHeader();
        while (true)
        {
            var select = view.ShowMainMenu(cars);
                
            if (select == "Browse used Audis")
            {
                
            }
            if (select == "Exit")
            {
                return;
            }
        }

    }

}