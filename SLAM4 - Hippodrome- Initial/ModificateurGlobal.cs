using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace hippodrome
{
    class ModificateurGlobal
    {
        internal LienBdd uneCn;
        private DataTable dt = new DataTable();
        private void Fgeneral_Load(object sender, EventArgs e)
        {
            // connection à la bdd hippo sous sqlserver
            uneCn = new LienBdd();
        }
        public void ajouterBTN(string tableBDD) {
            dt= uneCn.obtenirColonnes(tableBDD);
             string[] a;         
            // On all tables' rows
            foreach (DataRow dtRow in dt.Rows)
            {
                // On all tables' columns
                foreach (DataColumn dc in dt.Columns)
                {
                  
                    
                }
            }
        }
    }
}
