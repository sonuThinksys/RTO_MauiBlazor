namespace MauiBlazorNew;

public partial class App : Application
{
	public App()
	{
        Console.WriteLine("Started with App");

        InitializeComponent();

		MainPage = new MainPage();
	}
}

