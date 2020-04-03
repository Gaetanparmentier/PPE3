namespace PEE3_V1._0
{
    partial class Mission1
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
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.TAB_General = new System.Windows.Forms.TabControl();
            this.TAB_Agences = new System.Windows.Forms.TabPage();
            this.DGV_Agences = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTN_Afficher = new System.Windows.Forms.Button();
            this.TAB_General.SuspendLayout();
            this.TAB_Agences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Agences)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(591, 458);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(122, 40);
            this.BTN_Quitter.TabIndex = 22;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // TAB_General
            // 
            this.TAB_General.Controls.Add(this.TAB_Agences);
            this.TAB_General.Controls.Add(this.tabPage2);
            this.TAB_General.Location = new System.Drawing.Point(-1, 5);
            this.TAB_General.Name = "TAB_General";
            this.TAB_General.SelectedIndex = 0;
            this.TAB_General.Size = new System.Drawing.Size(1161, 447);
            this.TAB_General.TabIndex = 24;
            // 
            // TAB_Agences
            // 
            this.TAB_Agences.Controls.Add(this.DGV_Agences);
            this.TAB_Agences.Location = new System.Drawing.Point(4, 25);
            this.TAB_Agences.Name = "TAB_Agences";
            this.TAB_Agences.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_Agences.Size = new System.Drawing.Size(1153, 418);
            this.TAB_Agences.TabIndex = 0;
            this.TAB_Agences.Text = "Les Agences";
            this.TAB_Agences.UseVisualStyleBackColor = true;
            // 
            // DGV_Agences
            // 
            this.DGV_Agences.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_Agences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Agences.Location = new System.Drawing.Point(57, 40);
            this.DGV_Agences.Name = "DGV_Agences";
            this.DGV_Agences.RowTemplate.Height = 24;
            this.DGV_Agences.Size = new System.Drawing.Size(654, 330);
            this.DGV_Agences.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1153, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTN_Afficher
            // 
            this.BTN_Afficher.Location = new System.Drawing.Point(12, 454);
            this.BTN_Afficher.Name = "BTN_Afficher";
            this.BTN_Afficher.Size = new System.Drawing.Size(216, 40);
            this.BTN_Afficher.TabIndex = 25;
            this.BTN_Afficher.Text = "Afficher les Agences";
            this.BTN_Afficher.UseVisualStyleBackColor = true;
            this.BTN_Afficher.Click += new System.EventHandler(this.BTN_Afficher_Click);
            // 
            // Mission1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 533);
            this.Controls.Add(this.BTN_Afficher);
            this.Controls.Add(this.TAB_General);
            this.Controls.Add(this.BTN_Quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Mission1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mission1";
            this.TAB_General.ResumeLayout(false);
            this.TAB_Agences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Agences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Quitter;
        private System.Windows.Forms.TabControl TAB_General;
        private System.Windows.Forms.TabPage TAB_Agences;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGV_Agences;
        private System.Windows.Forms.Button BTN_Afficher;
    }
}