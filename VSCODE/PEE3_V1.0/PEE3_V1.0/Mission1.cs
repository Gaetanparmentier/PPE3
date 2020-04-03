using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PEE3_V1._0
{
    // Création d'une nouvelle classe (mission1) héritant de Form
    public partial class Mission1 : Form
    {
        // on déclare un objet de la classe LienBdd
        private DataTable dt = new DataTable();

        internal LienBdd c;

        public Mission1()
        {
            InitializeComponent();
            c = new LienBdd();
        }


        //**************************** ONGLET CAMPAGNE DE SENSIBILISATION ***********************************

        private void BTN_Afficher_Click(object sender, EventArgs e)
        {
            try
            {
                //Remplit le DataGridView (DGV) Campagne
                dt = c.ObtenirAgence(); // On appelle la méthode ObtenirAgence de la classe LienBdd
                this.DGV_Agences.DataSource = dt;
                this.DGV_Agences.DataMember = dt.TableName;
                this.DGV_Agences.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
