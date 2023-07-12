using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VetSoft_EF.Model;

namespace VetSoft_Aldera.ViewModels
{
    // Hier ist die Klasse zum Laden Alle Kunden
    public class KundenViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Kunde> _kunden;

        public ObservableCollection<Kunde> Kunden
        {
            get => _kunden;
            set
            {
                _kunden = value;
                OnPropertyChanged();
            }
        }

        public KundenViewModel()
        {
            
            LoadPersons();
        }

        private void LoadPersons()
        {
            // Hier können alle gespiecherte Kunden geladen werden
            using (var db = new VetSoft_EF.KundeContext())
            {
                var persons = new ObservableCollection<Kunde>(db.Kunden);
                Kunden = persons;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



   
       
    }
}
