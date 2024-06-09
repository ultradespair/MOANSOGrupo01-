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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnElegir = new FontAwesome.Sharp.IconButton();
            this.btnAnular = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
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
            // btnElegir
            // 
            this.btnElegir.BackColor = System.Drawing.Color.Green;
            this.btnElegir.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnElegir.ForeColor = System.Drawing.Color.White;
            this.btnElegir.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnElegir.IconColor = System.Drawing.Color.White;
            this.btnElegir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnElegir.IconSize = 20;
            this.btnElegir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElegir.Location = new System.Drawing.Point(256, 399);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(94, 32);
            this.btnElegir.TabIndex = 4;
            this.btnElegir.Text = "  Elegir";
            this.btnElegir.UseVisualStyleBackColor = false;
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Red;
            this.btnAnular.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnAnular.IconColor = System.Drawing.Color.White;
            this.btnAnular.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAnular.IconSize = 20;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(37, 397);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(94, 34);
            this.btnAnular.TabIndex = 5;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 67;
            this.iconPictureBox1.Location = new System.Drawing.Point(163, 37);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(67, 67);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // frmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 448);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHorarios";
            this.Text = "Horarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnElegir;
        private FontAwesome.Sharp.IconButton btnAnular;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}