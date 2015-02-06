﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using BLL;

namespace Clinique
{
    public partial class EcranClients : Form
    {

        private int _courant = 0;
        private Clients _clientCourant;
        MgtAnimal _animal = new MgtAnimal();
        Clients pCodeClient = new Clients();

        private int IndiceCourant
        {
            get { return _courant; }
            set
            {
                _courant = value;
                _clientCourant = MgtClient.GetInstance().ClientsListe.ElementAt(_courant);
                NavBarre.ApresEnable = (_courant != MgtClient.GetInstance().ClientsListe.Count - 1);
                NavBarre.AvantEnable = (_courant != 0);
                AfficherClientCourant();
            }
        }

        private void AfficherClientCourant()
        {
            _clientCourant = MgtClient.GetInstance().ClientsListe.ElementAt(_courant);
            TXT_clients_code.Text = _clientCourant.CodeClient.ToString();
            TXT_clients_nom.Text = _clientCourant.NomClient;
            TXT_clients_prenom.Text = _clientCourant.PrenomClient;
            TXT_clients_adresse1.Text = _clientCourant.Adresse1;
            TXT_clients_adresse2.Text = _clientCourant.Adresse2;
            TXT_clients_CP.Text = _clientCourant.CodePostal;
            TXT_clients_ville.Text = _clientCourant.Ville;
        }

        private Clients ClientCourant
        {
            get { return _clientCourant; }
        }

        public EcranClients()
        {
            InitializeComponent();
            AfficherClientCourant();
            pCodeClient =  MgtClient.GetInstance().ClientsListe.ElementAt(_courant);
            dataGrid_clients.DataSource = _animal.AfficherTout().FindAll(x => x.CodeClient == pCodeClient.CodeClient.Value);
        }

        private void NavBarre_Navigation(object sender, ControlsLibrary.NavBarEventArgs e)
        {
            switch (e.NavAction)
            {
                case ControlsLibrary.NavBar.NavActionEnum.premier:
                    IndiceCourant = 0;
                    break;
                case ControlsLibrary.NavBar.NavActionEnum.precedent:
                    IndiceCourant--;
                    break;
                case ControlsLibrary.NavBar.NavActionEnum.suivant:
                    IndiceCourant++;
                    break;
                case ControlsLibrary.NavBar.NavActionEnum.dernier:
                    IndiceCourant = MgtClient.GetInstance().ClientsListe.Count() - 1;
                    break;
                default:
                    break;
            }
            pCodeClient = MgtClient.GetInstance().ClientsListe.ElementAt(_courant);
            dataGrid_clients.DataSource = _animal.AfficherTout().FindAll(x => x.CodeClient == pCodeClient.CodeClient.Value);
        }

        private void BTN_clients_ajouter2_Click(object sender, EventArgs e)
        {
            Clients monClient = new Clients();
            
            monClient.NomClient= TXT_clients_nom.Text;
            monClient.PrenomClient = TXT_clients_prenom.Text;
            monClient.Adresse1 = TXT_clients_adresse1.Text;
            monClient.Adresse2 = TXT_clients_adresse2.Text;
            monClient.CodePostal= TXT_clients_CP.Text;
            monClient.Ville= TXT_clients_ville.Text;

            MgtClient.GetInstance().Ajouter(monClient);
            dataGrid_clients.DataSource = MgtClient.GetInstance().AfficherTout();
        }

        private void BTN_clients_ajouter_Click(object sender, EventArgs e)
        {

            BTN_clients_ValiderAjout.Visible = true;
            BTN_client_AnnulerAjout.Visible = true;
            TXT_clients_recherche.Enabled = false;
            BTN_clients_recherche.Enabled = false;
            TXT_clients_code.Enabled = false;

            TXT_clients_code.Text = null;
            TXT_clients_nom.Text = null;
            TXT_clients_prenom.Text = null;
            TXT_clients_adresse1.Text = null;
            TXT_clients_adresse2.Text = null;
            TXT_clients_CP.Text = null;
            TXT_clients_ville.Text = null;

            dataGrid_clients = null;

        }

        private void BTN_clients_supprimer2_Click(object sender, EventArgs e)
        {
            Clients pCodeClient = (Clients)dataGrid_clients.CurrentRow.DataBoundItem;
            MgtClient.GetInstance().Supprimer(pCodeClient.CodeClient.Value);
            dataGrid_clients.DataSource = MgtClient.GetInstance().AfficherTout();
        }

        private void BTN_clients_editer_Click(object sender, EventArgs e)
        {

        }

        private void BTN_clients_ValiderAjout_Click(object sender, EventArgs e)
        {
            Clients monClient = new Clients();

            monClient.NomClient = TXT_clients_nom.Text;
            monClient.PrenomClient = TXT_clients_prenom.Text;
            monClient.Adresse1 = TXT_clients_adresse1.Text;
            monClient.Adresse2 = TXT_clients_adresse2.Text;
            monClient.CodePostal = TXT_clients_CP.Text;
            monClient.Ville = TXT_clients_ville.Text;

            MgtClient.GetInstance().Ajouter(monClient);

            TXT_clients_code.Text = _clientCourant.CodeClient.ToString();
            TXT_clients_nom.Text = _clientCourant.NomClient;
            TXT_clients_prenom.Text = _clientCourant.PrenomClient;
            TXT_clients_adresse1.Text = _clientCourant.Adresse1;
            TXT_clients_adresse2.Text = _clientCourant.Adresse2;
            TXT_clients_CP.Text = _clientCourant.CodePostal;
            TXT_clients_ville.Text = _clientCourant.Ville;

            
        }

        private void BTN_client_AnnulerAjout_Click(object sender, EventArgs e)
        {
            BTN_clients_ValiderAjout.Visible = false;
            BTN_client_AnnulerAjout.Visible = false;
            TXT_clients_recherche.Enabled = true;
            BTN_clients_recherche.Enabled = true;
            TXT_clients_code.Enabled = true;

            AfficherClientCourant();
        }
    }
}
