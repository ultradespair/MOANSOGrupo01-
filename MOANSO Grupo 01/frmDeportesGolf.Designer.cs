namespace MOANSO_Grupo_01
{
    partial class frmDeportesGolf
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
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMostrarGolf = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbInhabilitadoGolf = new System.Windows.Forms.RadioButton();
            this.rbOcupadoGolf = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbActivoGolf = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvReservasGolf = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVecesGolf = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasGolf)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Buscar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 102);
            this.button2.TabIndex = 35;
            this.button2.Text = "Ocultar Reservas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(601, 441);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 32;
            // 
            // btnMostrarGolf
            // 
            this.btnMostrarGolf.Location = new System.Drawing.Point(16, 333);
            this.btnMostrarGolf.Name = "btnMostrarGolf";
            this.btnMostrarGolf.Size = new System.Drawing.Size(101, 102);
            this.btnMostrarGolf.TabIndex = 34;
            this.btnMostrarGolf.Text = "Mostrar Reservas";
            this.btnMostrarGolf.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbInhabilitadoGolf);
            this.groupBox4.Controls.Add(this.rbOcupadoGolf);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.rbActivoGolf);
            this.groupBox4.Location = new System.Drawing.Point(16, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 121);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            // 
            // rbInhabilitadoGolf
            // 
            this.rbInhabilitadoGolf.AutoSize = true;
            this.rbInhabilitadoGolf.Location = new System.Drawing.Point(18, 89);
            this.rbInhabilitadoGolf.Name = "rbInhabilitadoGolf";
            this.rbInhabilitadoGolf.Size = new System.Drawing.Size(79, 17);
            this.rbInhabilitadoGolf.TabIndex = 2;
            this.rbInhabilitadoGolf.TabStop = true;
            this.rbInhabilitadoGolf.Text = "Inhabilitado";
            this.rbInhabilitadoGolf.UseVisualStyleBackColor = true;
            // 
            // rbOcupadoGolf
            // 
            this.rbOcupadoGolf.AutoSize = true;
            this.rbOcupadoGolf.Location = new System.Drawing.Point(119, 51);
            this.rbOcupadoGolf.Name = "rbOcupadoGolf";
            this.rbOcupadoGolf.Size = new System.Drawing.Size(69, 17);
            this.rbOcupadoGolf.TabIndex = 1;
            this.rbOcupadoGolf.TabStop = true;
            this.rbOcupadoGolf.Text = "Ocupado";
            this.rbOcupadoGolf.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, -17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "Buscar reserva";
            // 
            // rbActivoGolf
            // 
            this.rbActivoGolf.AutoSize = true;
            this.rbActivoGolf.Location = new System.Drawing.Point(20, 19);
            this.rbActivoGolf.Name = "rbActivoGolf";
            this.rbActivoGolf.Size = new System.Drawing.Size(55, 17);
            this.rbActivoGolf.TabIndex = 0;
            this.rbActivoGolf.TabStop = true;
            this.rbActivoGolf.Text = "Activo";
            this.rbActivoGolf.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvReservasGolf);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(251, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 421);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reservas";
            // 
            // dgvReservasGolf
            // 
            this.dgvReservasGolf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasGolf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservasGolf.Location = new System.Drawing.Point(3, 16);
            this.dgvReservasGolf.Name = "dgvReservasGolf";
            this.dgvReservasGolf.Size = new System.Drawing.Size(447, 402);
            this.dgvReservasGolf.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblVecesGolf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 150);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "4500 m";
            // 
            // lblVecesGolf
            // 
            this.lblVecesGolf.AutoSize = true;
            this.lblVecesGolf.Location = new System.Drawing.Point(125, 60);
            this.lblVecesGolf.Name = "lblVecesGolf";
            this.lblVecesGolf.Size = new System.Drawing.Size(15, 14);
            this.lblVecesGolf.TabIndex = 5;
            this.lblVecesGolf.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medida del área: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veces reservado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capacidad máxima:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hoyos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "8";
            // 
            // frmDeportesGolf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 475);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMostrarGolf);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDeportesGolf";
            this.Text = "frmDeportesGolf";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasGolf)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMostrarGolf;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbInhabilitadoGolf;
        private System.Windows.Forms.RadioButton rbOcupadoGolf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbActivoGolf;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvReservasGolf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVecesGolf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}