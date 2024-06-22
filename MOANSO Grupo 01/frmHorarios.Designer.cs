namespace MOANSO_Grupo_01
{
    partial class frmHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorarios));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelarHorario = new System.Windows.Forms.Button();
            this.btnElegirHorario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(32, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "HORARIOS Y PROFESORES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 274);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 67);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelarHorario
            // 
            this.btnCancelarHorario.BackColor = System.Drawing.Color.Red;
            this.btnCancelarHorario.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelarHorario.ForeColor = System.Drawing.Color.White;
            this.btnCancelarHorario.Location = new System.Drawing.Point(37, 402);
            this.btnCancelarHorario.Name = "btnCancelarHorario";
            this.btnCancelarHorario.Size = new System.Drawing.Size(104, 34);
            this.btnCancelarHorario.TabIndex = 8;
            this.btnCancelarHorario.Text = "Cancelar";
            this.btnCancelarHorario.UseVisualStyleBackColor = false;
            // 
            // btnElegirHorario
            // 
            this.btnElegirHorario.BackColor = System.Drawing.Color.Green;
            this.btnElegirHorario.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnElegirHorario.ForeColor = System.Drawing.Color.White;
            this.btnElegirHorario.Location = new System.Drawing.Point(246, 402);
            this.btnElegirHorario.Name = "btnElegirHorario";
            this.btnElegirHorario.Size = new System.Drawing.Size(104, 34);
            this.btnElegirHorario.TabIndex = 9;
            this.btnElegirHorario.Text = "Elegir";
            this.btnElegirHorario.UseVisualStyleBackColor = false;
            // 
            // frmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 448);
            this.Controls.Add(this.btnElegirHorario);
            this.Controls.Add(this.btnCancelarHorario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHorarios";
            this.Text = "Horarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelarHorario;
        private System.Windows.Forms.Button btnElegirHorario;
    }
}