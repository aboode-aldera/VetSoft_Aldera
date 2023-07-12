using VetSoft_Aldera.ViewModels;

namespace VetSoft_Aldera.Views;

public partial class KundenEingabe : ContentPage
{
	public KundenEingabe()
	{
		InitializeComponent();
		// binding der View mit der Viewmodell
        BindingContext = new KundeViewModel();
    }
}