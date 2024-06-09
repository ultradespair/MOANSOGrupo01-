namespace MOANSO_Grupo_01
{
    partial class frmCuotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnpagar = new System.Windows.Forms.Button();
            this.cbEfectivo = new System.Windows.Forms.CheckBox();
            this.cbTarjeta = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Suscripción a pagar";
            // 
            // btnpagar
            // 
            this.btnpagar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnpagar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.ForeColor = System.Drawing.Color.White;
            this.btnpagar.Location = new System.Drawing.Point(339, 344);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(95, 34);
            this.btnpagar.TabIndex = 8;
            this.btnpagar.Text = "Pagar";
            this.btnpagar.UseVisualStyleBackColor = false;
            // 
            // cbEfectivo
            // 
            this.cbEfectivo.AutoSize = true;
            this.cbEfectivo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.cbEfectivo.Location = new System.Drawing.Point(65, 354);
            this.cbEfectivo.Name = "cbEfectivo";
            this.cbEfectivo.Size = new System.Drawing.Size(72, 18);
            this.cbEfectivo.TabIndex = 7;
            this.cbEfectivo.Text = "Efectivo";
            this.cbEfectivo.UseVisualStyleBackColor = true;
            // 
            // cbTarjeta
            // 
            this.cbTarjeta.AutoSize = true;
            this.cbTarjeta.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.cbTarjeta.Location = new System.Drawing.Point(190, 354);
            this.cbTarjeta.Name = "cbTarjeta";
            this.cbTarjeta.Size = new System.Drawing.Size(64, 18);
            this.cbTarjeta.TabIndex = 6;
            this.cbTarjeta.Text = "Tarjeta";
            this.cbTarjeta.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 205);
            this.dataGridView1.TabIndex = 5;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 63;
            this.iconPictureBox1.Location = new System.Drawing.Point(205, 50);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(64, 63);
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            // 
            // frmCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 393);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.cbEfectivo);
            this.Controls.Add(this.cbTarjeta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCuotas";
            this.Text = "frmCuotas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.CheckBox cbEfectivo;
        private System.Windows.Forms.CheckBox cbTarjeta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}