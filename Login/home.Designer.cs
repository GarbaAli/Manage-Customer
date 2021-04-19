namespace Login
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateClt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ErrorAdresse = new System.Windows.Forms.Label();
            this.ErrorPhone = new System.Windows.Forms.Label();
            this.ErrorAge = new System.Windows.Forms.Label();
            this.ErrorNom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxStatut = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableauClient = new System.Windows.Forms.DataGridView();
            this.id_clt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_prenom_clt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableauClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnUpdateClt);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ErrorAdresse);
            this.panel1.Controls.Add(this.ErrorPhone);
            this.panel1.Controls.Add(this.ErrorAge);
            this.panel1.Controls.Add(this.ErrorNom);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbxStatut);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAdresse);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableauClient);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 602);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_2);
            // 
            // btnUpdateClt
            // 
            this.btnUpdateClt.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnUpdateClt.FlatAppearance.BorderSize = 2;
            this.btnUpdateClt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClt.ForeColor = System.Drawing.Color.Teal;
            this.btnUpdateClt.Location = new System.Drawing.Point(451, 200);
            this.btnUpdateClt.Name = "btnUpdateClt";
            this.btnUpdateClt.Size = new System.Drawing.Size(252, 55);
            this.btnUpdateClt.TabIndex = 26;
            this.btnUpdateClt.Text = "Mettre a jour";
            this.btnUpdateClt.UseVisualStyleBackColor = true;
            this.btnUpdateClt.Visible = false;
            this.btnUpdateClt.Click += new System.EventHandler(this.btnUpdateClt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(896, 218);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ErrorAdresse
            // 
            this.ErrorAdresse.AutoSize = true;
            this.ErrorAdresse.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorAdresse.ForeColor = System.Drawing.Color.Red;
            this.ErrorAdresse.Location = new System.Drawing.Point(712, 175);
            this.ErrorAdresse.Name = "ErrorAdresse";
            this.ErrorAdresse.Size = new System.Drawing.Size(143, 15);
            this.ErrorAdresse.TabIndex = 24;
            this.ErrorAdresse.Text = "Adresse du client requis !";
            this.ErrorAdresse.Visible = false;
            // 
            // ErrorPhone
            // 
            this.ErrorPhone.AutoSize = true;
            this.ErrorPhone.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.ErrorPhone.Location = new System.Drawing.Point(378, 172);
            this.ErrorPhone.Name = "ErrorPhone";
            this.ErrorPhone.Size = new System.Drawing.Size(166, 15);
            this.ErrorPhone.TabIndex = 23;
            this.ErrorPhone.Text = "Numero de  Telephone Requis";
            this.ErrorPhone.Visible = false;
            // 
            // ErrorAge
            // 
            this.ErrorAge.AutoSize = true;
            this.ErrorAge.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorAge.ForeColor = System.Drawing.Color.Red;
            this.ErrorAge.Location = new System.Drawing.Point(175, 169);
            this.ErrorAge.Name = "ErrorAge";
            this.ErrorAge.Size = new System.Drawing.Size(68, 15);
            this.ErrorAge.TabIndex = 22;
            this.ErrorAge.Text = "Age Requis!";
            this.ErrorAge.Visible = false;
            // 
            // ErrorNom
            // 
            this.ErrorNom.AutoSize = true;
            this.ErrorNom.Font = new System.Drawing.Font("Comic Sans MS", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorNom.ForeColor = System.Drawing.Color.Red;
            this.ErrorNom.Location = new System.Drawing.Point(175, 110);
            this.ErrorNom.Name = "ErrorNom";
            this.ErrorNom.Size = new System.Drawing.Size(131, 15);
            this.ErrorNom.TabIndex = 21;
            this.ErrorNom.Text = "Nom et Prenom Requis!";
            this.ErrorNom.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Location = new System.Drawing.Point(319, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 57);
            this.panel2.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(414, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(217, 57);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Nouveau Client";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(207, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(207, 57);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 57);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxStatut
            // 
            this.cbxStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatut.FormattingEnabled = true;
            this.cbxStatut.Items.AddRange(new object[] {
            "Celibataire",
            "Marié",
            "Divorcé",
            "Compliqué"});
            this.cbxStatut.Location = new System.Drawing.Point(178, 218);
            this.cbxStatut.Name = "cbxStatut";
            this.cbxStatut.Size = new System.Drawing.Size(246, 31);
            this.cbxStatut.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 46);
            this.label6.TabIndex = 18;
            this.label6.Text = "Statut \r\nMatrimoniale :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(715, 142);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(216, 30);
            this.txtAdresse.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Adresse : ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(381, 139);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(224, 30);
            this.txtPhone.TabIndex = 15;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone : ";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(178, 136);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(81, 30);
            this.txtAge.TabIndex = 13;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Age  : ";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(178, 77);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(753, 30);
            this.txtNom.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom et Prenom : ";
            // 
            // tableauClient
            // 
            this.tableauClient.AllowUserToAddRows = false;
            this.tableauClient.AllowUserToDeleteRows = false;
            this.tableauClient.BackgroundColor = System.Drawing.Color.White;
            this.tableauClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableauClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_clt,
            this.nom_prenom_clt,
            this.age,
            this.phone,
            this.Adresse,
            this.status});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableauClient.DefaultCellStyle = dataGridViewCellStyle7;
            this.tableauClient.Location = new System.Drawing.Point(3, 279);
            this.tableauClient.Name = "tableauClient";
            this.tableauClient.ReadOnly = true;
            this.tableauClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableauClient.Size = new System.Drawing.Size(950, 323);
            this.tableauClient.TabIndex = 9;
            // 
            // id_clt
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.id_clt.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_clt.HeaderText = "ID";
            this.id_clt.Name = "id_clt";
            this.id_clt.ReadOnly = true;
            // 
            // nom_prenom_clt
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nom_prenom_clt.DefaultCellStyle = dataGridViewCellStyle2;
            this.nom_prenom_clt.HeaderText = "Nom & Prenom";
            this.nom_prenom_clt.Name = "nom_prenom_clt";
            this.nom_prenom_clt.ReadOnly = true;
            this.nom_prenom_clt.Width = 200;
            // 
            // age
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.age.DefaultCellStyle = dataGridViewCellStyle3;
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // phone
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.phone.DefaultCellStyle = dataGridViewCellStyle4;
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 200;
            // 
            // Adresse
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Adresse.DefaultCellStyle = dataGridViewCellStyle5;
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            this.Adresse.Width = 150;
            // 
            // status
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.status.DefaultCellStyle = dataGridViewCellStyle6;
            this.status.HeaderText = "Statut Matrimoniale";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 53);
            this.label4.TabIndex = 7;
            this.label4.Text = "Clients";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(966, 602);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableauClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tableauClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_clt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_prenom_clt;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxStatut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label ErrorNom;
        private System.Windows.Forms.Label ErrorAge;
        private System.Windows.Forms.Label ErrorPhone;
        private System.Windows.Forms.Label ErrorAdresse;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnUpdateClt;
    }
}