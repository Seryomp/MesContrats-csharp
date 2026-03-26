using MesContrats;
namespace MesContratsVehicules
{
    public partial class FtrmMenu : Form
    {
        List<Categorie> listCategorie;
        List<Vehicule> listVehicule;
        public FtrmMenu()
        {
            InitializeComponent();
            listCategorie = new List<Categorie>();
            listVehicule = new List<Vehicule>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnValiderCt_Click(object sender, EventArgs e)
        {

        }

        private void txtPrestation_TextChanged(object sender, EventArgs e)
        {

        }
        //



        //
        private void btnValiderC_Click(object sender, EventArgs e)
        {
            listCategorie.Add( new Categorie(txtCategorie.Text, txtDescription.Text, Convert.ToDouble(txtTarifJour.Text), Convert.ToDouble(txtCaution.Text)));
            cmbCategorie.Items.Clear();
            foreach (Categorie cat in listCategorie)
            {
                cmbCategorie.Items.Add(cat.GetNom());
            }
            txtCategorie.Clear();
            txtDescription.Clear();
            txtTarifJour.Clear();
            txtCaution.Clear();
        }

        private void txtCaution_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTarifJour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnnee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImmat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarque_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnValiderV_Click(object sender, EventArgs e)
        {
            Categorie categorie = new Categorie();
            string catgr=cmbCategorie.SelectedItem.ToString();
            foreach (Categorie cat in listCategorie)
            {
                if (cat.GetNom() == catgr)
                {
                    categorie = cat;
                }
            }
            listVehicule.Add( new Vehicule(txtMarque.Text, txtModel.Text, Convert.ToInt32(txtAnnee.Text), txtImmat.Text, Convert.ToInt32(txtKm.Text),categorie));
        }

        private void txtNumContrat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateContrat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDatePrise_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateRetour_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtKmPrise_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKmRetour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVehicule_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vehicule_Enter(object sender, EventArgs e)
        {

        }
    }
}