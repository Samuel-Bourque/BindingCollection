using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBindingCollection
{
    public class Prof : INotifyPropertyChanged
    {
        private string _nomProf;
        public string NomProf
        {
            get => _nomProf;
            set
            {
                _nomProf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NomProf"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public Prof(string nom) { NomProf = nom; }
    }

}
