namespace Practica_V2
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mejoresVinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vinosAActualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.Red;
            this.lblBienvenido.Location = new System.Drawing.Point(235, 38);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(136, 38);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "HOLA :)";
            this.lblBienvenido.Visible = false;
            this.lblBienvenido.Click += new System.EventHandler(this.lblBienvenido_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.vinosToolStripMenuItem,
            this.personasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem});
            this.usuarioToolStripMenuItem.Image = global::Practica_V2.Properties.Resources.iconoPerfil;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // vinosToolStripMenuItem
            // 
            this.vinosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mejoresVinosToolStripMenuItem,
            this.vinosAActualizarToolStripMenuItem});
            this.vinosToolStripMenuItem.Name = "vinosToolStripMenuItem";
            this.vinosToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.vinosToolStripMenuItem.Text = "Vinos";
            // 
            // mejoresVinosToolStripMenuItem
            // 
            this.mejoresVinosToolStripMenuItem.Name = "mejoresVinosToolStripMenuItem";
            this.mejoresVinosToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.mejoresVinosToolStripMenuItem.Text = "Mejores Vinos";
            // 
            // vinosAActualizarToolStripMenuItem
            // 
            this.vinosAActualizarToolStripMenuItem.Name = "vinosAActualizarToolStripMenuItem";
            this.vinosAActualizarToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.vinosAActualizarToolStripMenuItem.Text = "Vinos a actualizar";
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaPersonasToolStripMenuItem});
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.personasToolStripMenuItem.Text = "Personas";
            // 
            // altaPersonasToolStripMenuItem
            // 
            this.altaPersonasToolStripMenuItem.Name = "altaPersonasToolStripMenuItem";
            this.altaPersonasToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.altaPersonasToolStripMenuItem.Text = "Alta personas";
            this.altaPersonasToolStripMenuItem.Click += new System.EventHandler(this.altaPersonasToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 445);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mejoresVinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vinosAActualizarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaPersonasToolStripMenuItem;
    }
}