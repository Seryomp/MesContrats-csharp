namespace MesContrats
{
       public class Categorie
       {
           private string _categLoc;
           private string _description;
           private double _tarifJour;
           private double _mtnCaution;  
           public Categorie(string categLoc, string description, double tarifJour, double mtnCaution)
           {
                this._categLoc = categLoc;
                this._description = description;
                this._tarifJour = tarifJour;     
                this._mtnCaution = mtnCaution;   
            }
        public Categorie()
        { 
        }
        public string GetNom()
        {
            return _categLoc;
        }
    }
}

