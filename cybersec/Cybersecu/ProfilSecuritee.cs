namespace Cybersecu
{
    public class ProfilSecuritee
    {
        public bool CompteVerrouiller { get; set; }
        public DateTime Date_Verouillage { get; set; }
        public DateTime Derniere_Connexion { get; set; }
        public int ID { get; set; }
        public bool Mfa_Active { get; set; }
        public int Tentatives_Connexion_Echouees { get; set; }
        public int niveau_acces { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, CompteVerrouiller: {CompteVerrouiller}, Date_Verouillage: {Date_Verouillage}, Derniere_Connexion: {Derniere_Connexion}, Mfa_Active: {Mfa_Active}, Tentatives_Connexion_Echouees: {Tentatives_Connexion_Echouees}, niveau_acces: {niveau_acces}";
        }
        public ProfilSecuritee(int id, bool compteVerrouiller, DateTime date_Verouillage, DateTime derniere_Connexion, bool mfa_Active, int tentatives_Connexion_Echouees, int niveau_acces)
        {
            ID = id;
            CompteVerrouiller = compteVerrouiller;
            Date_Verouillage = date_Verouillage;
            Derniere_Connexion = derniere_Connexion;
            Mfa_Active = mfa_Active;
            Tentatives_Connexion_Echouees = tentatives_Connexion_Echouees;
            this.niveau_acces = niveau_acces;
        }
    }
}
