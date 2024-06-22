namespace MOANSO_Grupo_01
{
    partial class frmFinanzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinanzas));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnularSuscripcion = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnPagarSuscripcion = new System.Windows.Forms.Button();
            this.btnProgramacion = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtClientePago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldeporte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAnularSuscripcion);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btnPagarSuscripcion);
            this.groupBox2.Location = new System.Drawing.Point(439, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 325);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirmacion";
            // 
            // btnAnularSuscripcion
            // 
            this.btnAnularSuscripcion.BackColor = System.Drawing.Color.Red;
            this.btnAnularSuscripcion.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAnularSuscripcion.ForeColor = System.Drawing.Color.White;
            this.btnAnularSuscripcion.Location = new System.Drawing.Point(29, 274);
            this.btnAnularSuscripcion.Name = "btnAnularSuscripcion";
            this.btnAnularSuscripcion.Size = new System.Drawing.Size(105, 34);
            this.btnAnularSuscripcion.TabIndex = 14;
            this.btnAnularSuscripcion.Text = "Anular ";
            this.btnAnularSuscripcion.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(321, 243);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnPagarSuscripcion
            // 
            this.btnPagarSuscripcion.BackColor = System.Drawing.Color.Green;
            this.btnPagarSuscripcion.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPagarSuscripcion.ForeColor = System.Drawing.Color.White;
            this.btnPagarSuscripcion.Location = new System.Drawing.Point(245, 274);
            this.btnPagarSuscripcion.Name = "btnPagarSuscripcion";
            this.btnPagarSuscripcion.Size = new System.Drawing.Size(105, 34);
            this.btnPagarSuscripcion.TabIndex = 12;
            this.btnPagarSuscripcion.Text = "Pagar";
            this.btnPagarSuscripcion.UseVisualStyleBackColor = false;
            // 
            // btnProgramacion
            // 
            this.btnProgramacion.BackColor = System.Drawing.Color.Olive;
            this.btnProgramacion.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnProgramacion.ForeColor = System.Drawing.Color.White;
            this.btnProgramacion.Location = new System.Drawing.Point(71, 64);
            this.btnProgramacion.Name = "btnProgramacion";
            this.btnProgramacion.Size = new System.Drawing.Size(235, 34);
            this.btnProgramacion.TabIndex = 11;
            this.btnProgramacion.Text = "Programación";
            this.btnProgramacion.UseVisualStyleBackColor = false;
            this.btnProgramacion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarCliente);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.txtClientePago);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 465);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 74);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txtClientePago
            // 
            this.txtClientePago.Location = new System.Drawing.Point(134, 144);
            this.txtClientePago.Name = "txtClientePago";
            this.txtClientePago.Size = new System.Drawing.Size(100, 20);
            this.txtClientePago.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "DNI :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(114, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "Suscripción";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(319, 243);
            this.dataGridView1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldeporte);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnProgramacion);
            this.groupBox1.Location = new System.Drawing.Point(439, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 113);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horarios";
            // 
            // lbldeporte
            // 
            this.lbldeporte.AutoSize = true;
            this.lbldeporte.Location = new System.Drawing.Point(125, 39);
            this.lbldeporte.Name = "lbldeporte";
            this.lbldeporte.Size = new System.Drawing.Size(35, 13);
            this.lbldeporte.TabIndex = 13;
            this.lbldeporte.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Deporte: ";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(240, 137);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(29, 32);
            this.btnBuscarCliente.TabIndex = 29;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // frmFinanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmFinanzas";
            this.Text = "frmFinanzas";
            this.Load += new System.EventHandler(this.frmFinanzas_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnPagarSuscripcion;
        private System.Windows.Forms.Button btnAnularSuscripcion;
        private System.Windows.Forms.Button btnProgramacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtClientePago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldeporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscarCliente;
    }
}