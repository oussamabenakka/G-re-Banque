namespace GereBanque
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comptesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deposerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvgarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ewAffichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des comptes bancaire";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Turquoise;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comptesToolStripMenuItem,
            this.comptesToolStripMenuItem1,
            this.sauvgarderToolStripMenuItem,
            this.restaurerToolStripMenuItem,
            this.fenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 477);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comptesToolStripMenuItem
            // 
            this.comptesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.afficherToolStripMenuItem,
            this.ewAffichageToolStripMenuItem});
            this.comptesToolStripMenuItem.Name = "comptesToolStripMenuItem";
            this.comptesToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.comptesToolStripMenuItem.Text = "Clients";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter Compte";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.afficherToolStripMenuItem.Text = "Afficher";
            this.afficherToolStripMenuItem.Click += new System.EventHandler(this.afficherToolStripMenuItem_Click);
            // 
            // comptesToolStripMenuItem1
            // 
            this.comptesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.supprimerToolStripMenuItem1,
            this.deposerToolStripMenuItem});
            this.comptesToolStripMenuItem1.Name = "comptesToolStripMenuItem1";
            this.comptesToolStripMenuItem1.Size = new System.Drawing.Size(71, 19);
            this.comptesToolStripMenuItem1.Text = "Comptes";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            this.supprimerToolStripMenuItem1.Click += new System.EventHandler(this.supprimerToolStripMenuItem1_Click);
            // 
            // deposerToolStripMenuItem
            // 
            this.deposerToolStripMenuItem.Name = "deposerToolStripMenuItem";
            this.deposerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deposerToolStripMenuItem.Text = "Deposer/Retierer";
            this.deposerToolStripMenuItem.Click += new System.EventHandler(this.deposerToolStripMenuItem_Click);
            // 
            // sauvgarderToolStripMenuItem
            // 
            this.sauvgarderToolStripMenuItem.Name = "sauvgarderToolStripMenuItem";
            this.sauvgarderToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.sauvgarderToolStripMenuItem.Text = "Sauvgarder";
            this.sauvgarderToolStripMenuItem.Click += new System.EventHandler(this.sauvgarderToolStripMenuItem_Click);
            // 
            // restaurerToolStripMenuItem
            // 
            this.restaurerToolStripMenuItem.Name = "restaurerToolStripMenuItem";
            this.restaurerToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.restaurerToolStripMenuItem.Text = "Restaurer";
            this.restaurerToolStripMenuItem.Click += new System.EventHandler(this.restaurerToolStripMenuItem_Click);
            // 
            // ewAffichageToolStripMenuItem
            // 
            this.ewAffichageToolStripMenuItem.Name = "ewAffichageToolStripMenuItem";
            this.ewAffichageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ewAffichageToolStripMenuItem.Text = "New Affichage";
            this.ewAffichageToolStripMenuItem.Click += new System.EventHandler(this.ewAffichageToolStripMenuItem_Click);
            // 
            // fenToolStripMenuItem
            // 
            this.fenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontaleToolStripMenuItem,
            this.verticaleToolStripMenuItem,
            this.iconsToolStripMenuItem});
            this.fenToolStripMenuItem.Name = "fenToolStripMenuItem";
            this.fenToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.fenToolStripMenuItem.Text = "Fenetres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontaleToolStripMenuItem
            // 
            this.horizontaleToolStripMenuItem.Name = "horizontaleToolStripMenuItem";
            this.horizontaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horizontaleToolStripMenuItem.Text = "Horizontale";
            this.horizontaleToolStripMenuItem.Click += new System.EventHandler(this.horizontaleToolStripMenuItem_Click);
            // 
            // verticaleToolStripMenuItem
            // 
            this.verticaleToolStripMenuItem.Name = "verticaleToolStripMenuItem";
            this.verticaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verticaleToolStripMenuItem.Text = "Verticale";
            this.verticaleToolStripMenuItem.Click += new System.EventHandler(this.verticaleToolStripMenuItem_Click);
            // 
            // iconsToolStripMenuItem
            // 
            this.iconsToolStripMenuItem.Name = "iconsToolStripMenuItem";
            this.iconsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iconsToolStripMenuItem.Text = "icons";
            this.iconsToolStripMenuItem.Click += new System.EventHandler(this.iconsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comptesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deposerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvgarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ewAffichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconsToolStripMenuItem;
    }
}

