using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoBindingCollection
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Prof> Profs { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Profs = new ObservableCollection<Prof>() {
        new Prof("Luc Forcier"),
        new Prof("Marco Guay"),
        new Prof("Noémie Rochette"),
        new Prof("Ridha Louati"),
        new Prof("Gilles Portelance")
    };
            listeProfs.ItemsSource = Profs;
        }

        private void BtnAjouterNouveauProf_Click(object sender, RoutedEventArgs e)
        {
            Profs.Add(new Prof(tbNom.Text));
        }

        private void BtnMajProfSelectionne_Click(object sender, RoutedEventArgs e)
        {
            Prof unProf = listeProfs.SelectedItem as Prof;
            if (unProf != null)
                unProf.NomProf = tbNom.Text;
        }

        private void BtnSupprimerProf_Click(object sender, RoutedEventArgs e)
        {
            Prof unProf = listeProfs.SelectedItem as Prof;
            Profs.Remove(unProf);

        }
    }
}
