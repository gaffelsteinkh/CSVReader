using Formatting;

public class Controller
{
    SpectreShow view = new SpectreShow();

    public void Run(List<Audi>cars)
    {
        view.ShowHeader();
        view.MainMenu(cars);

        
    }

}