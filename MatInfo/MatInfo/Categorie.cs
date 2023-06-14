// File:    Categorie.cs
// Author:  phamhuyt
// Created: mercredi 17 mai 2023 15:34:23
// Purpose: Definition of Class Categorie

using MatInfo;
using System;
using System.Collections.ObjectModel;
using System.Data;

public class Categorie : Crud<Categorie>
{
    private long iDCategorie;
    private String nomCategorie;
    private Materiel unMateriel;
    public ObservableCollection<Materiel> LesMateriels { get; set; }

    public Categorie()
    {

    }

    public Categorie(long iDCategorie, string nomCategorie)
    {
        this.IDCategorie = iDCategorie;
        this.NomCategorie = nomCategorie;
    }

    public void Create()
    {
        throw new NotImplementedException();
    }

    public void Read()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public System.Collections.Generic.List<Materiel> materiel;

    /// <summary>
    /// Property for collection of Materiel
    /// </summary>
    /// <pdGenerated>Default opposite class collection property</pdGenerated>
    public System.Collections.Generic.List<Materiel> Materiel
    {
        get
        {
            if (materiel == null)
                materiel = new System.Collections.Generic.List<Materiel>();
            return materiel;
        }
        set
        {
            RemoveAllMateriel();
            if (value != null)
            {
                foreach (Materiel oMateriel in value)
                    AddMateriel(oMateriel);
            }
        }
    }

    public long IDCategorie
    {
        get
        {
            return iDCategorie;
        }

        set
        {
            iDCategorie = value;
        }
    }

    public string NomCategorie
    {
        get
        {
            return nomCategorie;
        }

        set
        {
            nomCategorie = value;
        }
    }

    public Materiel UnMateriel { get => unMateriel; set => unMateriel = value; }

    /// <summary>
    /// Add a new Materiel in the collection
    /// </summary>
    /// <pdGenerated>Default Add</pdGenerated>
    public void AddMateriel(Materiel newMateriel)
    {
        if (newMateriel == null)
            return;
        if (this.materiel == null)
            this.materiel = new System.Collections.Generic.List<Materiel>();
        if (!this.materiel.Contains(newMateriel))
            this.materiel.Add(newMateriel);
    }

    /// <summary>
    /// Remove an existing Materiel from the collection
    /// </summary>
    /// <pdGenerated>Default Remove</pdGenerated>
    public void RemoveMateriel(Materiel oldMateriel)
    {
        if (oldMateriel == null)
            return;
        if (this.materiel != null)
            if (this.materiel.Contains(oldMateriel))
                this.materiel.Remove(oldMateriel);
    }

    /// <summary>
    /// Remove all instances of Materiel from the collection
    /// </summary>
    /// <pdGenerated>Default removeAll</pdGenerated>
    public void RemoveAllMateriel()
    {
        if (materiel != null)
            materiel.Clear();
    }

    public ObservableCollection<Categorie> FindAll()
    {
        ObservableCollection<Categorie> lesCategories = new ObservableCollection<Categorie>();
        DataAccess accesBD = new DataAccess();
        String requete = "select idcategorie, nomcategorie from categorie_materiel;";
        DataTable datas = accesBD.GetData(requete);
        if (datas != null)
        {
            foreach (DataRow row in datas.Rows)
            {
                Categorie c = new Categorie(int.Parse(row["idcategorie"].ToString()), (String)row["nomcategorie"]);
                lesCategories.Add(c);
            }
        }
        return lesCategories;
    }

    public ObservableCollection<Categorie> FindBySelection(string criteres)
    {
        throw new NotImplementedException();
    }

}