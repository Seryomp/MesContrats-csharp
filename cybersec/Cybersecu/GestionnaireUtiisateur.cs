namespace Cybersecu
{
    public class GestionnaireUtiisateur
    {
        public class GestionnaireUtilisateur
        {
            private int _prochainIdProfil {  get; set; }
            private int _prochainIdUtilisateur { get; set; }

            private List<string> _profils { get; set; }
            private List<string> _utilisateurs { get; set; }

            public Utilisateurclass Utilisateur { get; set; }

            // --- Constructeur ---
            public GestionnaireUtilisateur()
            {
                _prochainIdProfil = 1;
                _prochainIdUtilisateur = 1;
                _profils = new List<string>();
                _utilisateurs = new List<string>();
            }

            // --- Méthodes ---

            public void CreerProfilSecurite(string nomProfil)
            {
                _profils.Add(nomProfil);
                _prochainIdProfil++;
                Console.WriteLine($"Profil '{nomProfil}' créé avec l'ID : {_prochainIdProfil - 1}");
            }

            public void CreerUtilisateur(string nomUtilisateur)
            {
                _utilisateurs.Add(nomUtilisateur);
                _prochainIdUtilisateur++;
                Console.WriteLine($"Utilisateur '{nomUtilisateur}' créé.");
            }

            public string ObtenirProfilSecurite(int id)
            {
                return $"Profil ID: {id}";
            }

            public List<string> ObtenirTousLesProfils()
            {
                return _profils;
            }

            public List<string> ObtenirTousLesUtilisateurs()
            {
                return _utilisateurs;
            }

            public string ObtenirUtilisateur(int id)
            {
                return $"Utilisateur ID: {id}";
            }
        }
    }
}
