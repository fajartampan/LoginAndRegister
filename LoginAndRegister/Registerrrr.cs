using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginAndRegister

{

    public partial class Registerrrr : Form
    {
        MySqlConnection conn = connection.getConnection();

        public Registerrrr()
        {
            InitializeComponent();
        }

        private void Registerrrr_Load(object sender, EventArgs e)
        {
            tbpass.UseSystemPasswordChar = true;
            tbrepass.UseSystemPasswordChar = true;
            btregis.Enabled = false;

        }

        bool _register()
        {
            int retval = 0;
            try
            {
                string SQLS = string.Empty;
                SQLS += "INSERT tb_user SET ";
                SQLS += "fullname='" + tbfullname.Text + "'";
                SQLS += ",user='" + tbuser.Text + "'";
                SQLS += ",password='" + tbpass.Text + "'";


                conn.Open();
                using (MySqlCommand com = new MySqlCommand(SQLS, conn))
                {
                    retval = com.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { conn.Close(); }
            return retval > 0;
        }

        private void btregis_Click(object sender, EventArgs e)
        {
            _register();
            MessageBox.Show("Register Success");


            this.Close();

        }

        private void btcancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbrepass_TextChanged(object sender, EventArgs e)
        {
            if (tbpass.Text == tbrepass.Text)
            {
                btregis.Enabled = true;
            }
            else
            {
                btregis.Enabled = false;
            }
        }
    }
}
