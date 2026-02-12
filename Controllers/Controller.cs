public class Controller
{
    SpectreShow view = new SpectreShow();




    public void Run()
    {
        view.ShowHeader();
        while (true)
        {
            var select = view.ShowMainMenu();
                
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