
using VetSoft_Aldera.ViewModels;

namespace VetSoft_Aldera.Views;

public partial class KundenView : ContentPage
{
	public KundenView()
	{
		InitializeComponent();
        // binding der View mit der Viewmodell
        BindingContext = new KundenViewModel();
    }
}