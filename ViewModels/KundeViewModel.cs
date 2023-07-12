using System.ComponentModel;
using System.Windows.Input;
using VetSoft_EF.Model;

namespace VetSoft_Aldera.ViewModels
{
    public class KundeViewModel : INotifyPropertyChanged
    {
        // Hier ist die Klasse zum Anlegen einen neuen Kunde mit Name
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public ICommand SaveCommand { get; }

        public KundeViewModel()
        {
            SaveCommand = new Command(OnSave);
        }

        private void OnSave()
        {
            // Methode zum Einfügen neuen Kunde
            using (var db = new VetSoft_EF.KundeContext())
            {
                try
                {
                    var person = new Kunde { Name = Name };
                    db.Kunden.Add(person);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    Console.WriteLine(e.InnerException);
                 
                }
               
            }

          
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
