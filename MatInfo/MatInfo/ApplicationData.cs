using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatInfo;
using System.Text.RegularExpressions;

namespace MatInfo
{
    public class ApplicationData
    {
        public ObservableCollection<Categorie> LesCategories
        {
            get;
            set;
        }
        public  ObservableCollection<Personnel> LesPersonnels
        {
            get;
            set;
        }
        public  ObservableCollection<Materiel> LesMateriels
        {
            get;
            set;
        }
        public  ObservableCollection<Attribution> LesAttributions
        {
            get;
            set;
        }
        public ApplicationData()
        {

            loadApplicationData();

        }
        public void loadApplicationData()
        {

            //attribution
            Attribution uneAttribution = new Attribution();
            LesAttributions = uneAttribution.FindAll();
            //ListeEmpruntsBinding = new List<Emprunte>(ListeEmprunts);

            //catégorie
            Categorie uneCategorie = new Categorie();
            LesCategories = uneCategorie.FindAll();

            //personnel
            Personnel unPersonnel = new Personnel();
            LesPersonnels = unPersonnel.FindAll();
            //ListeEmployesBinding = new List<Employe>(ListeEmployes);

            //matériel
            Materiel unMateriel = new Materiel();
            LesMateriels = unMateriel.FindAll();
            //ListeVehiculesBinding = new List<Vehicule>(ListeVehicules);

            //Pour chaque attribution, on affecte la référence de son personnel
            foreach (Attribution lAttribution in LesAttributions.ToList())
                lAttribution.Personnel = LesPersonnels.ToList().Find(unPersonnel => unPersonnel.IDPerso == lAttribution.Fk_idPersonnel);

            //Pour chaque attribution, on a affecte la référence de son matériel
            foreach (Attribution lAttribution in LesAttributions.ToList())
                lAttribution.Materiel = LesMateriels.ToList().Find(unMateriel => unMateriel.IDMateriel == lAttribution.Fk_idMateriel);

            // pour chaque matériel, on affecte la référence de sa catégorie
            foreach (Materiel leMateriel in LesMateriels.ToList())
                leMateriel.UneCategorie = LesCategories.ToList().Find(uneCategorie => uneCategorie.IDCategorie == leMateriel.Fk_idCategorie);

            // pour chaque categorie, on affecte toutes les références des materiaux appartenant au groupe
            foreach (Categorie laCategorie in LesCategories.ToList())
            {
                uneCategorie.LesMateriels = new ObservableCollection<Materiel>(LesMateriels.ToList().FindAll(m => m.Fk_idCategorie == uneCategorie.IDCategorie));
            }


        }
    }
}

