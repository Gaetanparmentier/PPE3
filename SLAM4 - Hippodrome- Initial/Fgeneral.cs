using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace hippodrome
{
    public partial class Fgeneral : Form
    {
        public Fgeneral()
        {
            InitializeComponent();
        }
        // on déclare un objet de la classe LienBdd
        internal LienBdd uneCn;
        private DataTable dt= new DataTable();
        private int i=0;
        private int noLigne;
        private void Fgeneral_Load(object sender, EventArgs e)
        {
            // connection à la bdd hippo sous sqlserver
            uneCn = new LienBdd();
        }
        // ***************************** onglet Cheval **************************************

        
// ***************************** onglet Courses **************************************
        private void tabCourse_Enter(object sender, EventArgs e)
        {
            int a = 0;
            try
            {
                // remplissage de la data grid view
                dt = uneCn.ObtenirCourses();  // on appelle la méthode ObtenirCourses de la classe LienBdd
                this.dgCourses.DataSource = dt;
                this.dgCourses.DataMember = dt.TableName;
                this.dgCourses.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach(DataRow UneLigne in dt.Rows)
            {

                a = a + int.Parse(string.Format("{0}", (UneLigne["distance"])));
            }
            totalDistance.Text= (a.ToString());
        }

          private void dgCourses_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            noLigne = e.RowIndex;// n° de la ligne sélectionnée dans le dataGridView     
            this.dgCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // oblige la sélection pleine ligne
            // on remplit les textbox avec le contenu de la ligne sélectionné     
            this.tbIdCourse.Text=this.dgCourses[0,noLigne].Value.ToString();
            this.tbHippodrome.Text = this.dgCourses[1, noLigne].Value.ToString();
            this.tbDate.Text=this.dgCourses[2, noLigne].Value.ToString();
            this.tbDistance.Text=this.dgCourses[3, noLigne].Value.ToString();
          
        }
       
        private void btModifierCourse_Click(object sender, EventArgs e)
        {
            //modifie dans la DataTable puis sauve ds la Bdd
            uneCn.MajCourse(noLigne, this.tbHippodrome.Text, DateTime.Parse( this.tbDate.Text),int.Parse(this.tbDistance.Text));
        }

     
      
       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabCheval_Enter(object sender, EventArgs e)
        {
            try
            {
                // remplissage de la data grid view
                dt = uneCn.ObtenirChevaux();  // on appelle la méthode ObtenirCourses de la classe LienBdd
                this.dgChevaux.DataSource = dt;
                this.dgChevaux.DataMember = dt.TableName;
                this.dgChevaux.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgChevaux_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            noLigne = e.RowIndex;// n° de la ligne sélectionnée dans le dataGridView     
            this.dgChevaux.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // oblige la sélection pleine ligne
            // on remplit les textbox avec le contenu de la ligne sélectionné     
            this.IdChevalTxt.Text = this.dgChevaux[0, noLigne].Value.ToString();
            this.NomChevalTxt.Text = this.dgChevaux[1, noLigne].Value.ToString();
            this.DateNaisTxt.Text = this.dgChevaux[2, noLigne].Value.ToString();
            this.SexeTxt.Text = this.dgChevaux[3, noLigne].Value.ToString();
            this.NomProprioTxt.Text = this.dgChevaux[4, noLigne].Value.ToString();
            this.NbGainsTxt.Text = this.dgChevaux[5, noLigne].Value.ToString();

        }

        private void tabGeneral_Enter(object sender, EventArgs e)
        {
            
        }

        private void dgParticipants_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            noLigne = e.RowIndex;// n° de la ligne sélectionnée dans le dataGridView     
            this.dgParticipants.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // oblige la sélection pleine ligne
            // on remplit les textbox avec le contenu de la ligne sélectionné     
            this.IdLeChevalTxt.Text = this.dgCourses[0, noLigne].Value.ToString();
            this.IdLaCourse.Text = this.dgCourses[1, noLigne].Value.ToString();
            this.IdLeDriverTxt.Text = this.dgCourses[2, noLigne].Value.ToString();
            this.IdLaPlaceTxt.Text = this.dgCourses[3, noLigne].Value.ToString();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            string a ="";
            int b= 0;
            try
            {
                // remplissage de la data grid view
                dt = uneCn.ObtenirParticipe();  // on appelle la méthode ObtenirCourses de la classe LienBdd
                this.dgParticipants.DataSource = dt;
                this.dgParticipants.DataMember = dt.TableName;
                this.dgParticipants.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (DataRow UneLigne in dt.Rows)
            {
                if(UneLigne["driver"].ToString() != a)
                {
                    b++;
                    a = UneLigne["driver"].ToString();
                }
                
            }
            totalParticipants.Text= (b.ToString());
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            try
            {
                // remplissage de la data grid view
                dt = uneCn.ObtenirHippodromes();  // on appelle la méthode ObtenirCourses de la classe LienBdd
                this.dgHippodromes.DataSource = dt;
                this.dgHippodromes.DataMember = dt.TableName;
                this.dgHippodromes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabNomsChevaux_Enter(object sender, EventArgs e)
        {
            try
            {
                // remplissage de la data grid view
                dt = uneCn.ObtenirNomChevaux();  // on appelle la méthode ObtenirCourses de la classe LienBdd
                this.dgNomsChevaux.DataSource = dt;
                this.dgNomsChevaux.DataMember = dt.TableName;
                this.dgNomsChevaux.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResultat_Click(object sender, EventArgs e)
        {
            dt = uneCn.ObtenirResultats(cbChoixCourse.Text/*IdRecherche.Text*/);
            this.dgResultats.DataSource = dt;
            this.dgResultats.DataMember = dt.TableName;
            this.dgResultats.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void cbChoixCourse_Enter(object sender, EventArgs e)
        {
            // on remplit la combo box cbChoixCourse
            this.cbChoixCourse.DataSource = uneCn.ObtenirCourses();
            this.cbChoixCourse.DisplayMember = "idcourse"; // donnée qui s'affiche
            this.cbChoixCourse.ValueMember = "id"; // valeur gardée sur la sélection 
        }

        private void cbChoixCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = uneCn.ObtenirResultats(cbChoixCourse.Text/*IdRecherche.Text*/);
            this.dgResultats.DataSource = dt;
            this.dgResultats.DataMember = dt.TableName;
            this.dgResultats.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uneCn.AjouterCheval(IdChevalTxt.Text, NomChevalTxt.Text, DateNaisTxt.Text, SexeTxt.Text, NomProprioTxt.Text, int.Parse(NbGainsTxt.Text));
            dt = uneCn.ObtenirChevaux();  // on appelle la méthode ObtenirCourses de la classe LienBdd
            this.dgChevaux.DataSource = dt;
            this.dgChevaux.DataMember = dt.TableName;
            this.dgChevaux.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uneCn.SupprimerCheval(IdChevalTxt.Text, NomChevalTxt.Text, DateNaisTxt.Text, SexeTxt.Text, NomProprioTxt.Text, int.Parse(NbGainsTxt.Text));
            dt = uneCn.ObtenirChevaux();  // on appelle la méthode ObtenirCourses de la classe LienBdd
            this.dgChevaux.DataSource = dt;
            this.dgChevaux.DataMember = dt.TableName;
            this.dgChevaux.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NbGainsTxt.Text == ""){
                NbGainsTxt.Text = "0";
            }
            uneCn.MAJCheval(IdChevalTxt.Text, NomChevalTxt.Text, DateNaisTxt.Text, SexeTxt.Text, NomProprioTxt.Text, int.Parse(NbGainsTxt.Text));
            dt = uneCn.ObtenirChevaux();  // on appelle la méthode ObtenirCourses de la classe LienBdd
            this.dgChevaux.DataSource = dt;
            this.dgChevaux.DataMember = dt.TableName;
            this.dgChevaux.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }       
    }

