namespace Cybersecu
{
    public class Utilisateurclass
    {
        public DateTime DateCreation { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public string Mot_De_Passe_Hashuree { get; set; }
        public string Nom { get; set; }
        public string Profil_Securite_Id { get; set; }
        public ProfilSecuritee ProfilSecuritee { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Email: {Email}, Mot_De_Passe_Hashuree: {Mot_De_Passe_Hashuree}, Nom: {Nom}, DateCreation: {DateCreation}, Profil_Securite_Id: {Profil_Securite_Id}";
        }
        public Utilisateurclass(string id, string email, string motDePasseHashuree, string nom, DateTime dateCreation, string profilSecuriteId)
        {
            Id = id;
            Email = email;
            Mot_De_Passe_Hashuree = motDePasseHashuree;
            Nom = nom;
            DateCreation = dateCreation;
            Profil_Securite_Id = profilSecuriteId;
        }
    }

}
