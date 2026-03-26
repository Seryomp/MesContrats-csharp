namespace MesContratsVehicules
{
    partial class FtrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtCaution = new TextBox();
            txtTarifJour = new TextBox();
            txtDescription = new TextBox();
            txtCategorie = new TextBox();
            btnValiderC = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Vehicule = new GroupBox();
            cmbCategorie = new ComboBox();
            label11 = new Label();
            txtMarque = new TextBox();
            label10 = new Label();
            txtImmat = new TextBox();
            label9 = new Label();
            txtKm = new TextBox();
            txtModel = new TextBox();
            txtPrestation = new TextBox();
            txtAnnee = new TextBox();
            btnValiderV = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            dtpDateContrat = new DateTimePicker();
            dtpDatePrise = new DateTimePicker();
            dtpDateRetour = new DateTimePicker();
            txtKmPrise = new TextBox();
            txtKmRetour = new TextBox();
            txtVehicule = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            txtNumContrat = new TextBox();
            btnValiderCt = new Button();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            groupBox1.SuspendLayout();
            Vehicule.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCaution);
            groupBox1.Controls.Add(txtTarifJour);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtCategorie);
            groupBox1.Controls.Add(btnValiderC);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 206);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categorie";
            // 
            // txtCaution
            // 
            txtCaution.Location = new Point(76, 137);
            txtCaution.Name = "txtCaution";
            txtCaution.Size = new Size(100, 27);
            txtCaution.TabIndex = 8;
            txtCaution.TextChanged += txtCaution_TextChanged;
            // 
            // txtTarifJour
            // 
            txtTarifJour.Location = new Point(84, 95);
            txtTarifJour.Name = "txtTarifJour";
            txtTarifJour.Size = new Size(100, 27);
            txtTarifJour.TabIndex = 7;
            txtTarifJour.TextChanged += txtTarifJour_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(84, 59);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 27);
            txtDescription.TabIndex = 6;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // txtCategorie
            // 
            txtCategorie.Location = new Point(84, 23);
            txtCategorie.Name = "txtCategorie";
            txtCategorie.Size = new Size(100, 27);
            txtCategorie.TabIndex = 5;
            txtCategorie.TextChanged += txtCategorie_TextChanged;
            // 
            // btnValiderC
            // 
            btnValiderC.Location = new Point(39, 170);
            btnValiderC.Name = "btnValiderC";
            btnValiderC.Size = new Size(94, 29);
            btnValiderC.TabIndex = 4;
            btnValiderC.Text = "Valider";
            btnValiderC.UseVisualStyleBackColor = true;
            btnValiderC.Click += btnValiderC_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 133);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Caution";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "TarifJour";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 59);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "categorie";
            // 
            // Vehicule
            // 
            Vehicule.Controls.Add(cmbCategorie);
            Vehicule.Controls.Add(label11);
            Vehicule.Controls.Add(txtMarque);
            Vehicule.Controls.Add(label10);
            Vehicule.Controls.Add(txtImmat);
            Vehicule.Controls.Add(label9);
            Vehicule.Controls.Add(txtKm);
            Vehicule.Controls.Add(txtModel);
            Vehicule.Controls.Add(txtPrestation);
            Vehicule.Controls.Add(txtAnnee);
            Vehicule.Controls.Add(btnValiderV);
            Vehicule.Controls.Add(label5);
            Vehicule.Controls.Add(label6);
            Vehicule.Controls.Add(label7);
            Vehicule.Controls.Add(label8);
            Vehicule.Location = new Point(393, 12);
            Vehicule.Name = "Vehicule";
            Vehicule.Size = new Size(244, 333);
            Vehicule.TabIndex = 1;
            Vehicule.TabStop = false;
            Vehicule.Text = "Vehicule";
            Vehicule.Enter += Vehicule_Enter;
            // 
            // cmbCategorie
            // 
            cmbCategorie.FormattingEnabled = true;
            cmbCategorie.Location = new Point(87, 255);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.Size = new Size(151, 28);
            cmbCategorie.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(0, 255);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 9;
            label11.Text = "Categorie";
            // 
            // txtMarque
            // 
            txtMarque.Location = new Point(87, 222);
            txtMarque.Name = "txtMarque";
            txtMarque.Size = new Size(100, 27);
            txtMarque.TabIndex = 12;
            txtMarque.TextChanged += txtMarque_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 222);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 11;
            label10.Text = "Marque";
            // 
            // txtImmat
            // 
            txtImmat.Location = new Point(130, 179);
            txtImmat.Name = "txtImmat";
            txtImmat.Size = new Size(100, 27);
            txtImmat.TabIndex = 10;
            txtImmat.TextChanged += txtImmat_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 179);
            label9.Name = "label9";
            label9.Size = new Size(114, 20);
            label9.TabIndex = 9;
            label9.Text = "Immatriculation";
            // 
            // txtKm
            // 
            txtKm.Location = new Point(107, 137);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(100, 27);
            txtKm.TabIndex = 8;
            txtKm.TextChanged += txtKm_TextChanged;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(84, 95);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 27);
            txtModel.TabIndex = 7;
            txtModel.TextChanged += txtModel_TextChanged;
            // 
            // txtPrestation
            // 
            txtPrestation.Location = new Point(90, 59);
            txtPrestation.Name = "txtPrestation";
            txtPrestation.Size = new Size(100, 27);
            txtPrestation.TabIndex = 6;
            txtPrestation.TextChanged += txtPrestation_TextChanged;
            // 
            // txtAnnee
            // 
            txtAnnee.Location = new Point(84, 23);
            txtAnnee.Name = "txtAnnee";
            txtAnnee.Size = new Size(100, 27);
            txtAnnee.TabIndex = 5;
            txtAnnee.TextChanged += txtAnnee_TextChanged;
            // 
            // btnValiderV
            // 
            btnValiderV.Location = new Point(70, 289);
            btnValiderV.Name = "btnValiderV";
            btnValiderV.Size = new Size(94, 29);
            btnValiderV.TabIndex = 4;
            btnValiderV.Text = "Valider";
            btnValiderV.UseVisualStyleBackColor = true;
            btnValiderV.Click += btnValiderV_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 133);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 3;
            label5.Text = "Kilometrage";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 95);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 2;
            label6.Text = "Modele";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 59);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 1;
            label7.Text = "Prestation";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 23);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 0;
            label8.Text = "Annee";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpDateContrat);
            groupBox3.Controls.Add(dtpDatePrise);
            groupBox3.Controls.Add(dtpDateRetour);
            groupBox3.Controls.Add(txtKmPrise);
            groupBox3.Controls.Add(txtKmRetour);
            groupBox3.Controls.Add(txtVehicule);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(txtNumContrat);
            groupBox3.Controls.Add(btnValiderCt);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label15);
            groupBox3.Location = new Point(12, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(375, 328);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contrat";
            // 
            // dtpDateContrat
            // 
            dtpDateContrat.Location = new Point(105, 56);
            dtpDateContrat.Name = "dtpDateContrat";
            dtpDateContrat.Size = new Size(250, 27);
            dtpDateContrat.TabIndex = 16;
            dtpDateContrat.ValueChanged += dtpDateContrat_ValueChanged;
            // 
            // dtpDatePrise
            // 
            dtpDatePrise.Location = new Point(105, 94);
            dtpDatePrise.Name = "dtpDatePrise";
            dtpDatePrise.Size = new Size(250, 27);
            dtpDatePrise.TabIndex = 15;
            dtpDatePrise.ValueChanged += dtpDatePrise_ValueChanged;
            // 
            // dtpDateRetour
            // 
            dtpDateRetour.Location = new Point(118, 129);
            dtpDateRetour.Name = "dtpDateRetour";
            dtpDateRetour.Size = new Size(250, 27);
            dtpDateRetour.TabIndex = 14;
            dtpDateRetour.ValueChanged += dtpDateRetour_ValueChanged;
            // 
            // txtKmPrise
            // 
            txtKmPrise.Location = new Point(113, 162);
            txtKmPrise.Name = "txtKmPrise";
            txtKmPrise.Size = new Size(100, 27);
            txtKmPrise.TabIndex = 12;
            txtKmPrise.TextChanged += txtKmPrise_TextChanged;
            // 
            // txtKmRetour
            // 
            txtKmRetour.Location = new Point(118, 195);
            txtKmRetour.Name = "txtKmRetour";
            txtKmRetour.Size = new Size(100, 27);
            txtKmRetour.TabIndex = 11;
            txtKmRetour.TextChanged += txtKmRetour_TextChanged;
            // 
            // txtVehicule
            // 
            txtVehicule.Location = new Point(84, 228);
            txtVehicule.Name = "txtVehicule";
            txtVehicule.Size = new Size(100, 27);
            txtVehicule.TabIndex = 10;
            txtVehicule.TextChanged += txtVehicule_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(14, 235);
            label19.Name = "label19";
            label19.Size = new Size(64, 20);
            label19.TabIndex = 9;
            label19.Text = "Vehicule";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(20, 198);
            label18.Name = "label18";
            label18.Size = new Size(79, 20);
            label18.TabIndex = 8;
            label18.Text = "Km Retour";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(22, 162);
            label17.Name = "label17";
            label17.Size = new Size(66, 20);
            label17.TabIndex = 7;
            label17.Text = "Km Prise";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 129);
            label16.Name = "label16";
            label16.Size = new Size(106, 20);
            label16.TabIndex = 6;
            label16.Text = "Date de retour";
            // 
            // txtNumContrat
            // 
            txtNumContrat.Location = new Point(84, 23);
            txtNumContrat.Name = "txtNumContrat";
            txtNumContrat.Size = new Size(100, 27);
            txtNumContrat.TabIndex = 5;
            txtNumContrat.TextChanged += txtNumContrat_TextChanged;
            // 
            // btnValiderCt
            // 
            btnValiderCt.Location = new Point(84, 293);
            btnValiderCt.Name = "btnValiderCt";
            btnValiderCt.Size = new Size(94, 29);
            btnValiderCt.TabIndex = 4;
            btnValiderCt.Text = "Valider";
            btnValiderCt.UseVisualStyleBackColor = true;
            btnValiderCt.Click += btnValiderCt_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 91);
            label12.Name = "label12";
            label12.Size = new Size(97, 20);
            label12.TabIndex = 3;
            label12.Text = "Date de Prise";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 53);
            label14.Name = "label14";
            label14.Size = new Size(94, 20);
            label14.TabIndex = 1;
            label14.Text = "Date Contrat";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 23);
            label15.Name = "label15";
            label15.Size = new Size(63, 20);
            label15.TabIndex = 0;
            label15.Text = "Numero";
            // 
            // FtrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 560);
            Controls.Add(groupBox3);
            Controls.Add(Vehicule);
            Controls.Add(groupBox1);
            Name = "FtrmMenu";
            Text = "Menu";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Vehicule.ResumeLayout(false);
            Vehicule.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnValiderC;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCaution;
        private TextBox txtTarifJour;
        private TextBox txtDescription;
        private TextBox txtCategorie;
        private GroupBox Vehicule;
        private Label label11;
        private TextBox txtMarque;
        private Label label10;
        private TextBox txtImmat;
        private Label label9;
        private TextBox txtKm;
        private TextBox txtModel;
        private TextBox txtPrestation;
        private TextBox txtAnnee;
        private Button btnValiderV;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox3;
        private Label label17;
        private Label label16;
        private TextBox txtNumContrat;
        private Button btnValiderCt;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label19;
        private Label label18;
        private DateTimePicker dtpDateContrat;
        private DateTimePicker dtpDatePrise;
        private DateTimePicker dtpDateRetour;
        private TextBox txtKmPrise;
        private TextBox txtKmRetour;
        private TextBox txtVehicule;
        private ComboBox cmbCategorie;
    }
}
