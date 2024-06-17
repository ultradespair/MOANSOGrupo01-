namespace MOANSO_Grupo_01
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFinanzas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInstructores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeportes = new System.Windows.Forms.ToolStripMenuItem();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.areasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuCliente,
            this.menuFinanzas,
            this.menuDeportes,
            this.menuInstructores});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 98);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUsuario
            // 
            this.menuUsuario.AutoSize = false;
            this.menuUsuario.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuUsuario.Image = ((System.Drawing.Image)(resources.GetObject("menuUsuario.Image")));
            this.menuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(130, 94);
            this.menuUsuario.Text = "Usuario";
            this.menuUsuario.Click += new System.EventHandler(this.menuUsuario_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.AutoSize = false;
            this.menuCliente.Image = ((System.Drawing.Image)(resources.GetObject("menuCliente.Image")));
            this.menuCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(131, 94);
            this.menuCliente.Text = "Cliente";
            this.menuCliente.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // menuFinanzas
            // 
            this.menuFinanzas.AutoSize = false;
            this.menuFinanzas.Image = ((System.Drawing.Image)(resources.GetObject("menuFinanzas.Image")));
            this.menuFinanzas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFinanzas.Name = "menuFinanzas";
            this.menuFinanzas.Size = new System.Drawing.Size(128, 94);
            this.menuFinanzas.Text = "Finanzas";
            this.menuFinanzas.Click += new System.EventHandler(this.finanzasToolStripMenuItem_Click);
            // 
            // menuInstructores
            // 
            this.menuInstructores.AutoSize = false;
            this.menuInstructores.Image = ((System.Drawing.Image)(resources.GetObject("menuInstructores.Image")));
            this.menuInstructores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuInstructores.Name = "menuInstructores";
            this.menuInstructores.Size = new System.Drawing.Size(145, 94);
            this.menuInstructores.Text = "Instructores";
            this.menuInstructores.Click += new System.EventHandler(this.instructoresToolStripMenuItem_Click);
            // 
            // menuDeportes
            // 
            this.menuDeportes.AutoSize = false;
            this.menuDeportes.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuDeportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areasToolStripMenuItem,
            this.eventosToolStripMenuItem});
            this.menuDeportes.Image = ((System.Drawing.Image)(resources.GetObject("menuDeportes.Image")));
            this.menuDeportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuDeportes.Name = "menuDeportes";
            this.menuDeportes.Size = new System.Drawing.Size(130, 94);
            this.menuDeportes.Text = "Deportes";
            this.menuDeportes.Click += new System.EventHandler(this.deportesToolStripMenuItem_Click);
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 122);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(845, 533);
            this.contenedor.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(845, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(818, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Centro de Sistemas - Golf y Country Club";
            // 
            // areasToolStripMenuItem
            // 
            this.areasToolStripMenuItem.Name = "areasToolStripMenuItem";
            this.areasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.areasToolStripMenuItem.Text = "Areas";
            this.areasToolStripMenuItem.Click += new System.EventHandler(this.areasToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eventosToolStripMenuItem.Text = "Eventos";
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuDeportes;
        private System.Windows.Forms.ToolStripMenuItem menuFinanzas;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuInstructores;
        private System.Windows.Forms.ToolStripMenuItem areasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
    }
}