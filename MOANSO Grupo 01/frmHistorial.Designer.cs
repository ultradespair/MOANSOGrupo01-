namespace MOANSO_Grupo_01
{
    partial class frmHistorial
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegresarCliente = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de pagos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(321, 195);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnRegresarCliente
            // 
            this.btnRegresarCliente.BackColor = System.Drawing.Color.Red;
            this.btnRegresarCliente.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRegresarCliente.ForeColor = System.Drawing.Color.White;
            this.btnRegresarCliente.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnRegresarCliente.IconColor = System.Drawing.Color.White;
            this.btnRegresarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegresarCliente.IconSize = 20;
            this.btnRegresarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresarCliente.Location = new System.Drawing.Point(134, 336);
            this.btnRegresarCliente.Name = "btnRegresarCliente";
            this.btnRegresarCliente.Size = new System.Drawing.Size(106, 46);
            this.btnRegresarCliente.TabIndex = 2;
            this.btnRegresarCliente.Text = "Regresar";
            this.btnRegresarCliente.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 63;
            this.iconPictureBox1.Location = new System.Drawing.Point(154, 55);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(86, 63);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 403);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btnRegresarCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmHistorial";
            this.Text = "frmHistorial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnRegresarCliente;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}