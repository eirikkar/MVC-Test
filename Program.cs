namespace MVC_Test;

class Program
{
    static void Main(string[] args)
    {
        Model model = new Model("John Doe", 40);
        View view = new();
        Controller controller = new Controller(model, view);
        controller.ShowModel();
        controller.UpdateName();
        controller.UpdateAge();
        controller.ShowModel();
    }
}
