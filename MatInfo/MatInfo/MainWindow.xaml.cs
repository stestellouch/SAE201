using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace MatInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            ApplicationData applicationData = new ApplicationData();
        }

        private void btAjouterAttribution_Click(object sender, RoutedEventArgs e)
        {
            WindowCreationAttribution windowCreationAttribution = new WindowCreationAttribution();
            this.Visibility = Visibility.Hidden;
            windowCreationAttribution.Show();
        }

        private void btModifPersonnel_Click(object sender, RoutedEventArgs e)
        {
            GestionPersonnel fenetreGestionPersonnel = new GestionPersonnel();
            this.Visibility = Visibility.Hidden;
            fenetreGestionPersonnel.Show();
        }

        private void btModifMateriel_Click(object sender, RoutedEventArgs e)
        {
            GestionMateriel fenetreGestionMateriel = new GestionMateriel();
            this.Visibility = Visibility.Hidden;
            fenetreGestionMateriel.Show();
        }

        private void btEnregistrerAttribution_Click(object sender, RoutedEventArgs e)
        {
            WindowCreationAttribution windowCreationAttribution = new WindowCreationAttribution();
            this.Visibility = Visibility.Hidden;
            windowCreationAttribution.Show();
        }

        private void btSupprimerAttribution_Click(object sender, RoutedEventArgs e)
        {
            //on fait une demande au cas où il s'agit d'un missclick
            MessageBoxResult validSuppr = MessageBox.Show("Etes-vous sûr de vouloir supprimer cet emprunt ?", "Supression", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (validSuppr == MessageBoxResult.Yes)
            {
                //si aucun item sélectionné
                if (dgAttribution.SelectedItem is null)
                {
                    MessageBox.Show("Vous n'avez sélectionné aucune ligne", "Supression", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                else
                {
                    //supprimer tt les lignes
                    foreach (Attribution lAttribution in dgAttribution.SelectedItems)
                    {
                        lAttribution.Delete();
                    }
                    //on remet à jour les données en mémoire
                    this.RefreshData();
                }
            }
        }
        public void RefreshData() //pour quand une donnée de la BDD est modifiée, supprimée, ajoutée
        {
            //on remet en mémoire tt les tables
            applicationData.loadApplicationData();
            //on redonne le datacontexte à dgconcess 
            //this.dgAttribution.ItemsSource = ApplicationData.;
            //on update la datagrid
            this.updateListeEmprunts();
        }
        
    }
}
