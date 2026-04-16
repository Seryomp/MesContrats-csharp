namespace CyberForm
{
    partial class Form1
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
            txtNiveau = new TextBox();
            txtIDProfil = new TextBox();
            btnVProfil = new Button();
            MFAcheckBox = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listBoxUsers = new ListBox();
            btnVUsers = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            IDProfilcomboBox = new ComboBox();
            txtMDP = new TextBox();
            txtEmail = new TextBox();
            txtNom = new TextBox();
            txtIDusers = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNiveau);
            groupBox1.Controls.Add(txtIDProfil);
            groupBox1.Controls.Add(btnVProfil);
            groupBox1.Controls.Add(MFAcheckBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(201, 263);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profil";
            // 
            // txtNiveau
            // 
            txtNiveau.Location = new Point(67, 91);
            txtNiveau.Name = "txtNiveau";
            txtNiveau.Size = new Size(125, 27);
            txtNiveau.TabIndex = 6;
            txtNiveau.TextChanged += txtNiveau_TextChanged;
            // 
            // txtIDProfil
            // 
            txtIDProfil.Location = new Point(67, 52);
            txtIDProfil.Name = "txtIDProfil";
            txtIDProfil.Size = new Size(125, 27);
            txtIDProfil.TabIndex = 5;
            txtIDProfil.TextChanged += textBox1_TextChanged;
            // 
            // btnVProfil
            // 
            btnVProfil.Location = new Point(36, 197);
            btnVProfil.Name = "btnVProfil";
            btnVProfil.Size = new Size(94, 29);
            btnVProfil.TabIndex = 4;
            btnVProfil.Text = "Valider";
            btnVProfil.UseVisualStyleBackColor = true;
            btnVProfil.Click += button1_Click;
            // 
            // MFAcheckBox
            // 
            MFAcheckBox.AutoSize = true;
            MFAcheckBox.Location = new Point(46, 140);
            MFAcheckBox.Name = "MFAcheckBox";
            MFAcheckBox.Size = new Size(60, 24);
            MFAcheckBox.TabIndex = 3;
            MFAcheckBox.Text = "MFA";
            MFAcheckBox.UseVisualStyleBackColor = true;
            MFAcheckBox.CheckedChanged += MFAcheckBox_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 91);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Niveau";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 52);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxUsers);
            groupBox2.Controls.Add(btnVUsers);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(IDProfilcomboBox);
            groupBox2.Controls.Add(txtMDP);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtNom);
            groupBox2.Controls.Add(txtIDusers);
            groupBox2.Location = new Point(291, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(286, 389);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Utilisateur";
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.Location = new Point(25, 283);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(237, 84);
            listBoxUsers.TabIndex = 2;
            listBoxUsers.SelectedIndexChanged += listBoxUsers_SelectedIndexChanged;
            // 
            // btnVUsers
            // 
            btnVUsers.Location = new Point(102, 234);
            btnVUsers.Name = "btnVUsers";
            btnVUsers.Size = new Size(94, 29);
            btnVUsers.TabIndex = 10;
            btnVUsers.Text = "Valider";
            btnVUsers.UseVisualStyleBackColor = true;
            btnVUsers.Click += btnVUsers_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 201);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 9;
            label7.Text = "IDProfil";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 151);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 8;
            label6.Text = "MDP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 114);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 81);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 6;
            label4.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 48);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 5;
            label3.Text = "ID";
            // 
            // IDProfilcomboBox
            // 
            IDProfilcomboBox.FormattingEnabled = true;
            IDProfilcomboBox.Location = new Point(111, 197);
            IDProfilcomboBox.Name = "IDProfilcomboBox";
            IDProfilcomboBox.Size = new Size(151, 28);
            IDProfilcomboBox.TabIndex = 4;
            IDProfilcomboBox.SelectedIndexChanged += IDProfilcomboBox_SelectedIndexChanged;
            // 
            // txtMDP
            // 
            txtMDP.Location = new Point(137, 144);
            txtMDP.Name = "txtMDP";
            txtMDP.Size = new Size(125, 27);
            txtMDP.TabIndex = 3;
            txtMDP.TextChanged += txtMDP_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(137, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(137, 78);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 1;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // txtIDusers
            // 
            txtIDusers.Location = new Point(137, 45);
            txtIDusers.Name = "txtIDusers";
            txtIDusers.Size = new Size(125, 27);
            txtIDusers.TabIndex = 0;
            txtIDusers.TextChanged += txtIDusers_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 607);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtIDProfil;
        private Button btnVProfil;
        private CheckBox MFAcheckBox;
        private TextBox txtNiveau;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox IDProfilcomboBox;
        private TextBox txtMDP;
        private TextBox txtEmail;
        private TextBox txtNom;
        private TextBox txtIDusers;
        private Button btnVUsers;
        private Label label7;
        private ListBox listBoxUsers;
    }
}
