namespace MVC_Test;

class Program
{
    static void Main(string[] args)
    {
        Model model = new Model(null, 0);
        View view = new();
        Controller controller = new Controller(model, view);
        controller.UpdateName();
        controller.UpdateAge();
        controller.ShowModel();
    }
}
