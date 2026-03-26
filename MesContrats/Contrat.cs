using System;
using System.Collections.Generic;
using System.Text;

namespace MesContrats
{
    public class Contrat
    {
        int _numContrat;
        string _dateContrat;
        string _datePrise;
        string  _dateRetour;
        int _kmprise;
        int _kmRetour;
        string vehicule;

        public Contrat(int numContrat, string dateContrat, string datePrise, string dateRetour, int kmprise, int kmRetour, string vehicule)
        {
            _numContrat = numContrat;
            _dateContrat = dateContrat;
            _datePrise = datePrise;
            _dateRetour = dateRetour;
            _kmprise = kmprise;
            _kmRetour = kmRetour;
            this.vehicule = vehicule;
        }
    }
}
