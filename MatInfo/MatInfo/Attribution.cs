// File:    Attribution.cs
// Author:  phamhuyt
// Created: mercredi 17 mai 2023 15:34:21
// Purpose: Definition of Class Attribution

using MatInfo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Text.RegularExpressions;

public class Attribution : Crud<Attribution>
{
    private Personnel personnel;
    private Materiel materiel;
    private String commentaire;
    private DateTime dateAttribution;
    private long fk_idMateriel;
    private long fk_idPersonnel;

    public Personnel Personnel
    {
        get
        {
            return personnel;
        }

        set
        {
            personnel = value;
        }
    }

    public Materiel Materiel
    {
        get
        {
            return materiel;
        }

        set
        {
            materiel = value;
        }
    }

    public string Commentaire
    {
        get
        {
            return commentaire;
        }

        set
        {
            commentaire = value;
        }
    }

    public DateTime DateAttribution
    {
        get
        {
            return dateAttribution;
        }

        set
        {
            dateAttribution = value;
        }
    }

    public long Fk_idMateriel
    {
        get
        {
            return fk_idMateriel;
        }

        set
        {
            fk_idMateriel = value;
        }
    }

    public long Fk_idPersonnel
    {
        get
        {
            return fk_idPersonnel;
        }

        set
        {
            fk_idPersonnel = value;
        }
    }

    public Attribution()
    {
     
    }

    public Attribution(long iDPerso, long iDMateriel, DateTime dateAttribution, string commentaire)
    {
        this.Fk_idPersonnel = iDPerso;
        this.Fk_idMateriel = iDMateriel;
        this.DateAttribution = dateAttribution;
        this.Commentaire = commentaire;
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

    public ObservableCollection<Attribution> FindAll()
    {
        ObservableCollection<Attribution> lesAttributions = new ObservableCollection<Attribution>();
        DataAccess accesBD = new DataAccess();
        String requete = "select idpersonnel, idmateriel, dateattribution, commentaireattribution from est_attribue;";
        DataTable datas = accesBD.GetData(requete);
        if (datas != null)
        {
            foreach (DataRow row in datas.Rows)
            {
                Attribution a = new Attribution(long.Parse(row["idpersonnel"].ToString()), long.Parse(row["idmateriel"].ToString()), (DateTime)row["dateattribution"],(String)row["commentaireattribution"]);
                lesAttributions.Add(a);
            }
        }
        return lesAttributions;
    }

    public ObservableCollection<Attribution> FindBySelection(string criteres)
    {
        throw new NotImplementedException();
    }
}