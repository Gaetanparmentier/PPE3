namespace PEE3_V1._0
{
    partial class SGB_Mission1
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
            this.CB = new System.Windows.Forms.ComboBox();
            this.DGV_Affichage = new System.Windows.Forms.DataGridView();
            this.TXT_Titre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Affichage)).BeginInit();
            this.SuspendLayout();
            // 
            // CB
            // 
            this.CB.FormattingEnabled = true;
            this.CB.Items.AddRange(new object[] {
            "Agence",
            "Campagnes de sensibilisation",
            "Evènements",
            "Artiste"});
            this.CB.Location = new System.Drawing.Point(12, 60);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(208, 24);
            this.CB.TabIndex = 0;
            // 
            // DGV_Affichage
            // 
            this.DGV_Affichage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Affichage.Location = new System.Drawing.Point(388, 86);
            this.DGV_Affichage.Name = "DGV_Affichage";
            this.DGV_Affichage.RowTemplate.Height = 24;
            this.DGV_Affichage.Size = new System.Drawing.Size(499, 269);
            this.DGV_Affichage.TabIndex = 1;
            // 
            // TXT_Titre
            // 
            this.TXT_Titre.Location = new System.Drawing.Point(388, 14);
            this.TXT_Titre.Margin = new System.Windows.Forms.Padding(5);
            this.TXT_Titre.Name = "TXT_Titre";
            this.TXT_Titre.Size = new System.Drawing.Size(499, 22);
            this.TXT_Titre.TabIndex = 2;
            this.TXT_Titre.Text = "Campagne de sensibilisation de GSB";
            // 
            // SGB_Mission1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1249, 534);
            this.Controls.Add(this.TXT_Titre);
            this.Controls.Add(this.DGV_Affichage);
            this.Controls.Add(this.CB);
            this.Name = "SGB_Mission1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Affichage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.DataGridView DGV_Affichage;
        private System.Windows.Forms.TextBox TXT_Titre;
    }
}

