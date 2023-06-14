// File:    Personnel.cs
// Author:  phamhuyt
// Created: mercredi 17 mai 2023 15:34:24
// Purpose: Definition of Class Personnel

using MatInfo;
using System;
using System.Collections.ObjectModel;
using System.Data;

public class Personnel : Crud<Personnel>
{
    private long iDPerso;
    private String nomPerso;
    private String prenomPerso;
    private String mailPerso;

    public long IDPerso
    {
        get
        {
            return iDPerso;
        }

        set
        {
            iDPerso = value;
        }
    }

    public string NomPerso
    {
        get
        {
            return nomPerso;
        }

        set
        {
            nomPerso = value;
        }
    }

    public string PrenomPerso
    {
        get
        {
            return prenomPerso;
        }

        set
        {
            prenomPerso = value;
        }
    }

    public string MailPerso
    {
        get
        {
            return mailPerso;
        }

        set
        {
            mailPerso = value;
        }
    }

    public Personnel()
    {

    }

    public Personnel(long iDPerso, string mailPerso, string nomPerso, string prenomPerso)
    {
        this.IDPerso = iDPerso;
        this.NomPerso = nomPerso;
        this.PrenomPerso = prenomPerso;
        this.MailPerso = mailPerso;
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

    public ObservableCollection<Personnel> FindAll()
    {
        ObservableCollection<Personnel> lesPersonnel = new ObservableCollection<Personnel>();
        DataAccess accesBD = new DataAccess();
        String requete = "select idpersonnel, emailpersonnel, nompersonnel, prenompersonnel from personnel ;";
        DataTable datas = accesBD.GetData(requete);
        if (datas != null)
        {
            foreach (DataRow row in datas.Rows)
            {
                Personnel unPersonnel = new Personnel(int.Parse(row["idpersonnel"].ToString()), (String)row["emailpersonnel"], (String)row["nompersonnel"], (String)row["prenompersonnel"]);
                lesPersonnel.Add(unPersonnel);
            }
        }
        return lesPersonnel;
    }

    public ObservableCollection<Personnel> FindBySelection(string criteres)
    {
        throw new NotImplementedException();
    }

}