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
    public partial class Form_Registerr : Form
    {
        MySqlConnection conn = connection.getConnection();

        public Form_Registerr()
        {
            InitializeComponent();
        }

        bool _register()
        {
            int retval = 0;
            try
            {
                string SQLS = string.Empty;
                SQLS += "INSERT tb_user SET ";
                SQLS += "fullname='" + btfullname.Text + "'";
                SQLS += ",user='" + btuser.Text + "'";
                SQLS += ",password='" + btrepass.Text + "'";


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

        private void Form_Registerr_Load(object sender, EventArgs e)
        {
            btpass.UseSystemPasswordChar = true;
            btrepass.UseSystemPasswordChar = true;

        }

        private void btregister_Click(object sender, EventArgs e)
        {
            _register();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                btrepass.UseSystemPasswordChar = false; 
            }
            else
            {
                btrepass.UseSystemPasswordChar = true;
            }
        }
    }
}
