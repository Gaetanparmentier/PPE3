using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace hippodrome
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
        /// <summary>
        /// constructeur de la connexion
        /// </summary>
        public LienBdd()
        {
            try
            {
                // on commence par récupérer dans ch les informations contenues dans le fichier app.config
                // pour la connectionString de nom MaConnection
                string ch = ConfigurationManager.ConnectionStrings["MaConnection"].ConnectionString;
                cn = new SqlConnection(ch);
                cn.Open();
            }
            catch (SqlException)
            {
                throw new Exception("Erreur à la connexion");
            }
        }
        /// <summary>
        /// Méthode permettant de fermer la connexion
        /// </summary>
        public void FermerConnexion()
        {
            this.cn.Close();
        }
        ///// <summary>
        ///// permet de récupérer le contenu de la table course. 
        ///// </summary>
        ///// <returns>un objet de type datatable contenant les données récupérées</returns>
        public DataTable ObtenirCourses()
        {
            String req = "select * from course";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            //Le DataAdapter da va se charger ensuite de remplir la DataTable 
            da.Fill(dt);
            
            return dt;
        }
        ///// <summary>
        ///// permet de mettre à jour  la table course  
        ///// </summary>
        public void MajCourse(int i, string pHippodrome, DateTime pDate, int pDistance)
        {

        }
        public DataTable ObtenirChevaux()
        {
            String req = "select * from cheval";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            //Le DataAdapter da va se charger ensuite de remplir la DataTable 
            da.Fill(dt);

            return dt;
        }
        public DataTable ObtenirParticipe()
        {
            String req = "select * from participe";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            //Le DataAdapter da va se charger ensuite de remplir la DataTable 
            da.Fill(dt);

            return dt;
        }
        public DataTable ObtenirHippodromes()
        {
            String req = "select hippodrome from course group by hippodrome";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            //Le DataAdapter da va se charger ensuite de remplir la DataTable 
            da.Fill(dt);

            return dt;
        }
        public DataTable ObtenirNomChevaux()
        {
            String req = "select nomche from cheval";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            //Le DataAdapter da va se charger ensuite de remplir la DataTable 
            da.Fill(dt);

            return dt;
        }
        public DataTable ObtenirResultats(string pUnIdCourse)
        {
            String req = "select nomche,place from cheval INNER JOIN participe ON idche= id where idcourse= @UnIdCourse order by place";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@UnIdCourse", SqlDbType.VarChar).Value = pUnIdCourse;

            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            //Le DataAdapter da va se charger ensuite de remplir la DataTable 
            da.Fill(dt);

            return dt;
        }

        public void AjouterCheval(string Id,string Nom,string Date,string Sexe,string NomProprio,int Gains)
        {
            DateTime dateConvertie = Convert.ToDateTime(Date);
            String req = "insert into cheval (id, nomche, datenais, sexe, nomproprio, nbgains) VALUES(@Id, @Nom, @Date, @Sexe, @NomProprio, @Gains)";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            this.cde.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Nom;
            this.cde.Parameters.Add("@Date", SqlDbType.Date).Value = Date;
            this.cde.Parameters.Add("@Sexe", SqlDbType.VarChar).Value = Sexe;
            this.cde.Parameters.Add("@NomProprio", SqlDbType.VarChar).Value = NomProprio;
            this.cde.Parameters.Add("@Gains", SqlDbType.Int).Value = Gains;
            this.cde.ExecuteNonQuery();
        }
        public void SupprimerCheval(string Id, string Nom, string Date, string Sexe, string NomProprio, int Gains)
        {
            DateTime dateConvertie = Convert.ToDateTime(Date);
            String req = "delete from cheval where id=@Id AND nomche= @Nom AND datenais= @Date AND sexe= @Sexe AND nomproprio= @NomProprio AND nbgains= @Gains";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            this.cde.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Nom;
            this.cde.Parameters.Add("@Date", SqlDbType.Date).Value = Date;
            this.cde.Parameters.Add("@Sexe", SqlDbType.VarChar).Value = Sexe;
            this.cde.Parameters.Add("@NomProprio", SqlDbType.VarChar).Value = NomProprio;
            this.cde.Parameters.Add("@Gains", SqlDbType.Int).Value = Gains;
            this.cde.ExecuteNonQuery();
        }
        public void MAJCheval(string Id, string Nom, string Date, string Sexe, string NomProprio, int Gains)
        {
            DateTime dateConvertie = Convert.ToDateTime(Date);
            String req = "update cheval set nomche= @Nom, datenais= @Date, sexe= @Sexe, nomproprio= @NomProprio, nbgains= @Gains where id=@Id";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            this.cde.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Nom;
            this.cde.Parameters.Add("@Date", SqlDbType.Date).Value = Date;
            this.cde.Parameters.Add("@Sexe", SqlDbType.VarChar).Value = Sexe;
            this.cde.Parameters.Add("@NomProprio", SqlDbType.VarChar).Value = NomProprio;
            this.cde.Parameters.Add("@Gains", SqlDbType.Int).Value = Gains;
            this.cde.ExecuteNonQuery();
        }

        public DataTable obtenirColonnes(string pTable)
        {
            String req = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'@Table'";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@Table", SqlDbType.VarChar).Value = pTable;
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            //Le DataAdapter da va se charger ensuite de remplir la DataTable 
            da.Fill(dt);

            return dt;
        }

        public DataTable ObtenirCavaliers()
        {
            String req = "select * from cavalier";
            this.cde = new SqlCommand(req, cn);
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            //Le DataAdapter da va se charger ensuite de remplir la DataTable 
            da.Fill(dt);

            return dt;
        }
        public void AjouterCavalier(string Id, string Nom, string Prenom, string Date, string Sexe)
        {
            DateTime dateConvertie = Convert.ToDateTime(Date);
            String req = "insert into cavalier (id, nomcav, prenomcav, datenais, sexe) VALUES(@Id, @Nom, @Prenom,@Date , @Sexe)";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            this.cde.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Nom;
            this.cde.Parameters.Add("@Date", SqlDbType.Date).Value = Date;
            this.cde.Parameters.Add("@Sexe", SqlDbType.VarChar).Value = Sexe;
            this.cde.Parameters.Add("@Prenom", SqlDbType.VarChar).Value = Prenom;

            this.cde.ExecuteNonQuery();
        }

        public void SupprimerCavalier(string Id, string Nom,string Prenom ,string Date, string Sexe)
        {
            DateTime dateConvertie = Convert.ToDateTime(Date);
            String req = "delete from cavalier where id=@Id AND nomcav= @Nom AND prenomcav= @Prenom AND datenais= @Date AND sexe= @Sexe";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            this.cde.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Nom;
            this.cde.Parameters.Add("@Date", SqlDbType.Date).Value = Date;
            this.cde.Parameters.Add("@Sexe", SqlDbType.VarChar).Value = Sexe;
            this.cde.Parameters.Add("@Prenom", SqlDbType.VarChar).Value = Prenom;
            this.cde.ExecuteNonQuery();
        }

        public void MAJCavalier(string Id, string Nom, string Prenom, string Date, string Sexe)
        {
            DateTime dateConvertie = Convert.ToDateTime(Date);
            String req = "update cavalier set nomcav= @Nom, prenomcav= @Prenom, datenais= @Date, sexe= @Sexe where id=@Id";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            this.cde.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Nom;
            this.cde.Parameters.Add("@Date", SqlDbType.Date).Value = Date;
            this.cde.Parameters.Add("@Sexe", SqlDbType.VarChar).Value = Sexe;
            this.cde.Parameters.Add("@Prenom", SqlDbType.VarChar).Value = Prenom;
            this.cde.ExecuteNonQuery();
        }

        public DataTable NbCavSexe(string Sexe)
        {
            String req = "Select COUNT(id) From Cavalier WHERE Sexe= @Sexe";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@sexe", SqlDbType.VarChar).Value = Sexe;
            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
            
            
        }

        public DataTable ObtenirResultatsCav(string pUnIdCav)
        {
            String req = "Select idcourse, nomche, place FROM participe, cheval WHERE idche= cheval.id AND idnumcav= (SELECT idnumcav From participe where idnumcav= @unIdCav group by idnumcav)";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@UnIdCav", SqlDbType.VarChar).Value = pUnIdCav;

            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            //Le DataAdapter da va se charger ensuite de remplir la DataTable 
            da.Fill(dt);

            return dt;
        }

        public DataTable ObtenirResultatsCheval(string pUnIdCheval)
        {
            String req = "Select nomche, place, idcourse, nbgains FROM participe, cheval WHERE idche= cheval.id AND cheval.id= @UnIdCheval";
            this.cde = new SqlCommand(req, cn);
            this.cde.Parameters.Add("@UnIdCheval", SqlDbType.VarChar).Value = pUnIdCheval;

            da = new SqlDataAdapter();
            da.SelectCommand = this.cde;
            dt = new DataTable();
            //Le DataAdapter da va se charger ensuite de remplir la DataTable 
            da.Fill(dt);

            return dt;
        }
    }

}
     
    
        

