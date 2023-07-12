using VetSoft_Aldera.Views;

namespace VetSoft_Aldera;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		
        MainPage = new NavigationPage(new KundenEingabe());
    }
}
