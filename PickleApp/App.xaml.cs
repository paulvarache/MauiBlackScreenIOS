namespace PickleApp;

public partial class App : Application
{
    public App()
    {

        InitializeComponent();



        MainPage = new ContentPage { HeightRequest = 200, WidthRequest = 100, Background = Colors.Red, Content = new Label { Text = "Hello", TextColor = Colors.White } };
    }
}
