// File:    Materiel.cs
// Author:  phamhuyt
// Created: mercredi 17 mai 2023 15:34:23
// Purpose: Definition of Class Materiel

using MatInfo;
using System;
using System.Collections.ObjectModel;
using System.Data;

public class Materiel : Crud<Materiel>
{
    private long iDMateriel;
    private int fk_idCategorie;
    private String nomMateriel;
    private String refConstructeur;
    private String codeBarre;
    private Categorie uneCategorie;

    public int Fk_idCategorie { get => fk_idCategorie; set => fk_idCategorie = value; }

    public long IDMateriel
    {
        get
        {
            return iDMateriel;
        }

        set
        {
            iDMateriel = value;
        }
    }

    public string NomMateriel
    {
        get
        {
            return nomMateriel;
        }

        set
        {
            nomMateriel = value;
        }
    }

    public string RefConstructeur
    {
        get
        {
            return refConstructeur;
        }

        set
        {
            refConstructeur = value;
        }
    }

    public string CodeBarre
    {
        get
        {
            return codeBarre;
        }

        set
        {
            codeBarre = value;
        }
    }

    public Categorie UneCategorie { get => uneCategorie; set => uneCategorie = value; }

    public Materiel()
    {

    }

    public Materiel(long iDMateriel, int fk_idCategorie, string nomMateriel, string refConstructeur, string codeBarre)
    {
        this.IDMateriel = iDMateriel;
        Fk_idCategorie = fk_idCategorie;
        this.NomMateriel = nomMateriel;
        this.RefConstructeur = refConstructeur;
        this.CodeBarre = codeBarre;
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

    public ObservableCollection<Materiel> FindAll()
    {
        ObservableCollection<Materiel> lesMateriels = new ObservableCollection<Materiel>();
        DataAccess accesBD = new DataAccess();
        String requete = "select idmateriel, idcategorie, nommateriel, referenceconstructeurmateriel, codebarreinventaire from materiel;";
        DataTable datas = accesBD.GetData(requete);
        if (datas != null)
        {
            foreach (DataRow row in datas.Rows)
            {
                Materiel m = new Materiel(int.Parse(row["idmateriel"].ToString()), int.Parse(row["idcategorie"].ToString()), (String)row["nommateriel"], (String)row["referenceconstructeurmateriel"], (String)row["codebarreinventaire"]);
                lesMateriels.Add(m);
            }
        }
        return lesMateriels;
    }

    public ObservableCollection<Materiel> FindBySelection(string criteres)
    {
        throw new NotImplementedException();
    }
}