namespace MOANSO_Grupo_01
{
    partial class frmInstructores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstructores));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpfechainstructor = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailInstructor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonoInstructor = new System.Windows.Forms.TextBox();
            this.txtDniInstructor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreInstructor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkNatacion = new System.Windows.Forms.CheckBox();
            this.chkTenis = new System.Windows.Forms.CheckBox();
            this.chkGolf = new System.Windows.Forms.CheckBox();
            this.chkBasketball = new System.Windows.Forms.CheckBox();
            this.chkVolley = new System.Windows.Forms.CheckBox();
            this.chkFutbol = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbHorarios = new System.Windows.Forms.ComboBox();
            this.dgvInstructores = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarInstructor = new System.Windows.Forms.Button();
            this.btnRegistrarInstructor = new System.Windows.Forms.Button();
            this.btnInhabilitaInstructor = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(122, 17);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(70, 32);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Asignar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpfechainstructor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtEmailInstructor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTelefonoInstructor);
            this.groupBox2.Controls.Add(this.txtDniInstructor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNombreInstructor);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(181, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 128);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // dtpfechainstructor
            // 
            this.dtpfechainstructor.Location = new System.Drawing.Point(437, 54);
            this.dtpfechainstructor.Name = "dtpfechainstructor";
            this.dtpfechainstructor.Size = new System.Drawing.Size(159, 20);
            this.dtpfechainstructor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Correo electrónico";
            // 
            // txtEmailInstructor
            // 
            this.txtEmailInstructor.Location = new System.Drawing.Point(422, 19);
            this.txtEmailInstructor.Name = "txtEmailInstructor";
            this.txtEmailInstructor.Size = new System.Drawing.Size(159, 20);
            this.txtEmailInstructor.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Número Telefónico";
            // 
            // txtTelefonoInstructor
            // 
            this.txtTelefonoInstructor.Location = new System.Drawing.Point(130, 83);
            this.txtTelefonoInstructor.Name = "txtTelefonoInstructor";
            this.txtTelefonoInstructor.Size = new System.Drawing.Size(159, 20);
            this.txtTelefonoInstructor.TabIndex = 4;
            // 
            // txtDniInstructor
            // 
            this.txtDniInstructor.Location = new System.Drawing.Point(130, 54);
            this.txtDniInstructor.Name = "txtDniInstructor";
            this.txtDniInstructor.Size = new System.Drawing.Size(159, 20);
            this.txtDniInstructor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre completo";
            // 
            // txtNombreInstructor
            // 
            this.txtNombreInstructor.Location = new System.Drawing.Point(130, 25);
            this.txtNombreInstructor.Name = "txtNombreInstructor";
            this.txtNombreInstructor.Size = new System.Drawing.Size(159, 20);
            this.txtNombreInstructor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Instructores";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkNatacion);
            this.groupBox3.Controls.Add(this.chkTenis);
            this.groupBox3.Controls.Add(this.chkGolf);
            this.groupBox3.Controls.Add(this.chkBasketball);
            this.groupBox3.Controls.Add(this.chkVolley);
            this.groupBox3.Controls.Add(this.chkFutbol);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(181, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 84);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deportes";
            // 
            // chkNatacion
            // 
            this.chkNatacion.AutoSize = true;
            this.chkNatacion.Location = new System.Drawing.Point(513, 37);
            this.chkNatacion.Name = "chkNatacion";
            this.chkNatacion.Size = new System.Drawing.Size(78, 18);
            this.chkNatacion.TabIndex = 5;
            this.chkNatacion.Text = "Natación";
            this.chkNatacion.UseVisualStyleBackColor = true;
            // 
            // chkTenis
            // 
            this.chkTenis.AutoSize = true;
            this.chkTenis.Location = new System.Drawing.Point(419, 37);
            this.chkTenis.Name = "chkTenis";
            this.chkTenis.Size = new System.Drawing.Size(57, 18);
            this.chkTenis.TabIndex = 4;
            this.chkTenis.Text = "Tenis";
            this.chkTenis.UseVisualStyleBackColor = true;
            // 
            // chkGolf
            // 
            this.chkGolf.AutoSize = true;
            this.chkGolf.Location = new System.Drawing.Point(332, 37);
            this.chkGolf.Name = "chkGolf";
            this.chkGolf.Size = new System.Drawing.Size(49, 18);
            this.chkGolf.TabIndex = 3;
            this.chkGolf.Text = "Golf";
            this.chkGolf.UseVisualStyleBackColor = true;
            // 
            // chkBasketball
            // 
            this.chkBasketball.AutoSize = true;
            this.chkBasketball.Location = new System.Drawing.Point(119, 37);
            this.chkBasketball.Name = "chkBasketball";
            this.chkBasketball.Size = new System.Drawing.Size(85, 18);
            this.chkBasketball.TabIndex = 2;
            this.chkBasketball.Text = "Basketball";
            this.chkBasketball.UseVisualStyleBackColor = true;
            // 
            // chkVolley
            // 
            this.chkVolley.AutoSize = true;
            this.chkVolley.Location = new System.Drawing.Point(235, 37);
            this.chkVolley.Name = "chkVolley";
            this.chkVolley.Size = new System.Drawing.Size(63, 18);
            this.chkVolley.TabIndex = 1;
            this.chkVolley.Text = "Volley";
            this.chkVolley.UseVisualStyleBackColor = true;
            // 
            // chkFutbol
            // 
            this.chkFutbol.AutoSize = true;
            this.chkFutbol.Location = new System.Drawing.Point(34, 37);
            this.chkFutbol.Name = "chkFutbol";
            this.chkFutbol.Size = new System.Drawing.Size(63, 18);
            this.chkFutbol.TabIndex = 0;
            this.chkFutbol.Text = "Fútbol";
            this.chkFutbol.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(34, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 181);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbHorarios);
            this.groupBox5.Controls.Add(this.btnAceptar);
            this.groupBox5.Location = new System.Drawing.Point(603, 350);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(199, 57);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Horarios";
            // 
            // cmbHorarios
            // 
            this.cmbHorarios.FormattingEnabled = true;
            this.cmbHorarios.Location = new System.Drawing.Point(6, 23);
            this.cmbHorarios.Name = "cmbHorarios";
            this.cmbHorarios.Size = new System.Drawing.Size(111, 21);
            this.cmbHorarios.TabIndex = 0;
            // 
            // dgvInstructores
            // 
            this.dgvInstructores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstructores.Location = new System.Drawing.Point(43, 287);
            this.dgvInstructores.Name = "dgvInstructores";
            this.dgvInstructores.Size = new System.Drawing.Size(539, 166);
            this.dgvInstructores.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 20);
            this.textBox4.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarInstructor);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(603, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 57);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por código";
            // 
            // btnBuscarInstructor
            // 
            this.btnBuscarInstructor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarInstructor.Image")));
            this.btnBuscarInstructor.Location = new System.Drawing.Point(163, 19);
            this.btnBuscarInstructor.Name = "btnBuscarInstructor";
            this.btnBuscarInstructor.Size = new System.Drawing.Size(29, 32);
            this.btnBuscarInstructor.TabIndex = 30;
            this.btnBuscarInstructor.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarInstructor
            // 
            this.btnRegistrarInstructor.BackColor = System.Drawing.Color.Olive;
            this.btnRegistrarInstructor.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarInstructor.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarInstructor.Location = new System.Drawing.Point(35, 220);
            this.btnRegistrarInstructor.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarInstructor.Name = "btnRegistrarInstructor";
            this.btnRegistrarInstructor.Size = new System.Drawing.Size(141, 41);
            this.btnRegistrarInstructor.TabIndex = 28;
            this.btnRegistrarInstructor.Text = "Registrar Instructor";
            this.btnRegistrarInstructor.UseVisualStyleBackColor = false;
            this.btnRegistrarInstructor.Click += new System.EventHandler(this.btnRegistrarInstructor_Click);
            // 
            // btnInhabilitaInstructor
            // 
            this.btnInhabilitaInstructor.BackColor = System.Drawing.Color.DarkRed;
            this.btnInhabilitaInstructor.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInhabilitaInstructor.ForeColor = System.Drawing.Color.White;
            this.btnInhabilitaInstructor.Location = new System.Drawing.Point(603, 412);
            this.btnInhabilitaInstructor.Margin = new System.Windows.Forms.Padding(2);
            this.btnInhabilitaInstructor.Name = "btnInhabilitaInstructor";
            this.btnInhabilitaInstructor.Size = new System.Drawing.Size(199, 41);
            this.btnInhabilitaInstructor.TabIndex = 29;
            this.btnInhabilitaInstructor.Text = "Eliminar Instructor";
            this.btnInhabilitaInstructor.UseVisualStyleBackColor = false;
            // 
            // frmInstructores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 494);
            this.Controls.Add(this.btnInhabilitaInstructor);
            this.Controls.Add(this.btnRegistrarInstructor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dgvInstructores);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInstructores";
            this.Text = "frmInstructores";
            this.Load += new System.EventHandler(this.frmInstructores_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmailInstructor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonoInstructor;
        private System.Windows.Forms.TextBox txtDniInstructor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreInstructor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkNatacion;
        private System.Windows.Forms.CheckBox chkTenis;
        private System.Windows.Forms.CheckBox chkGolf;
        private System.Windows.Forms.CheckBox chkBasketball;
        private System.Windows.Forms.CheckBox chkVolley;
        private System.Windows.Forms.CheckBox chkFutbol;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbHorarios;
        private System.Windows.Forms.DataGridView dgvInstructores;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrarInstructor;
        private System.Windows.Forms.Button btnInhabilitaInstructor;
        private System.Windows.Forms.Button btnBuscarInstructor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpfechainstructor;
    }
}