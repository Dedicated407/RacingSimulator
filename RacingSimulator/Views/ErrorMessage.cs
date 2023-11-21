namespace RacingSimulator.Views;

public partial class Menu
{
    private static void ShowErrorMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(new ArgumentException(message));
        Console.ResetColor();
    }
}