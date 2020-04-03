using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PEE3_V1._0
{
    class LienBdd
    {
        //
        // propriétés membres
        //
        private SqlConnection cn;
        private SqlCommand cde;
        private SqlDataAdapter da;
        private DataTable dt;
        //
        // méthodes
        //
        /// constructeur de la connexion
        public LienBdd()
        {
            try
            {
                cn = Utils.GetDBConnection();
                cn.Open();
            }
            catch (SqlException)
            {
                throw new Exception("BDD : Erreur à la connexion");
            }

        }
 
        public DataTable ObtenirAgence()
        {
            String req = "select * from Agence";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            //Le DataAdapter da va se charger ensuite de remplir la DataTable
            da.Fill(dt);
            return dt;
        }

        public DataTable VerifUsername(string username)
        {
            String req = "SELECT username FROM UTILISATEUR WHERE username = @username ";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable(); //Le DataAdapter da va se charger ensuite de remplir la DataTable
            da.Fill(dt);
            return dt;
        }

        public DataTable VerifPassword(string password)
        {
            String req = "SELECT password FROM UTILISATEUR WHERE password = @password";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable(); //Le DataAdapter da va se charger ensuite de remplir la DataTable
            da.Fill(dt);
            return dt;
        }
    }
}

    



