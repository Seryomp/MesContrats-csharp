using System;
using System.Collections.Generic;
using System.Text;

namespace MesContrats
{
    public class Vehicule
    {
        public int Annee;
        public string Prestation;
        public string Modele;
        public int Kilometrage;
        public string Immatriculation;
        public string Marque;
        public string Categorie;
        private string text1;
        private string text2;
        private int v1;
        private string text3;
        private int v2;
        private Categorie categorie;

        public Vehicule(int annee, string prestation, string modele, int kilometrage, string immatriculation, string marque, string categorie)
        {
            Annee = annee;
            Prestation = prestation;
            Modele = modele;
            Kilometrage = kilometrage;
            Immatriculation = immatriculation;
            Marque = marque;
            Categorie = categorie;
        }
        public Vehicule()
        {
        }

        public Vehicule(string text1, string text2, int v1, string text3, int v2, Categorie categorie)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.v1 = v1;
            this.text3 = text3;
            this.v2 = v2;
            this.categorie = categorie;
        }
    }
}
