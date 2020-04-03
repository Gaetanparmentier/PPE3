using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEE3_V1._0
{
    public partial class Connexion : Form
    {
        //on déclare un objet de la classe LienBdd
        private DataTable dt = new DataTable();

        internal LienBdd uneCn;

        public Connexion()
        {
            InitializeComponent();
            uneCn = new LienBdd();
        }

        private void CB_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_ShowPassword.Checked == true)
            {
                TXT_Password.UseSystemPasswordChar = false;
            }
            else
            {
                TXT_Password.UseSystemPasswordChar = true;
            }
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TXT_Username.Text) && (!string.IsNullOrEmpty(TXT_Password.Text)))
                {
                    try
                    {
                        if (TXT_Username.Text == uneCn.VerifUsername(TXT_Username.Text).Rows[0]["username"].ToString()
                            && TXT_Password.Text == uneCn.VerifPassword(TXT_Password.Text).Rows[0]["password"].ToString())
                        {
                                TXT_Username.Clear();
                                TXT_Password.Clear();
                                CB_ShowPassword.Checked = false;

                                this.Hide();

                                Mission1 formMain = new Mission1();
                                formMain.ShowDialog();
                                formMain = null;

                                this.Show();
                                this.TXT_Username.Select();
                            
                        }
                        else
                        {
                            MessageBox.Show("L'Username ou le Password est incorect. Essayer encore.", " ",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            TXT_Username.Focus();
                            TXT_Username.SelectAll();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Probleme de login");
                    }

                }
                else
                {
                    MessageBox.Show("S'il vous plait entrer un Username et un Password.", " ",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_Username.Select();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Probleme de connexion");
            }
        }
    }
}
