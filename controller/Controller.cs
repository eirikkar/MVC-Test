class Controller
{
    private Model _model;
    private View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }

    public void ShowModel()
    {
        _view.DisplayModel(_model);
    }

    public string UpdateName()
    {
        while (true)
        {
            Console.Write("Enter name: ");
            string? newName = Console.ReadLine();
            if (string.IsNullOrEmpty(newName) || newName.Length < 2 || !newName.All(char.IsLetter))
            {
                _view.DisplayMessage("Name is invalid. Please enter a valid name.");
            }
            else
            {
                return _model.Name = newName;
            }
        }
    }

    public int UpdateAge()
    {
        while (true)
        {
            Console.Write("Enter Age: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int newAge) || newAge <= 122)
            {
                return _model.Age = newAge;
            }
            else
            {
                _view.DisplayMessage("Age is invalid, please enter a valid age number!");
            }
        }
    }
}
