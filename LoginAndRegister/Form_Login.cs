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
    public partial class Form_Login : Form
    {
        MySqlConnection conn = connection.getConnection();
               public Form_Login()
        {
            InitializeComponent();
        }

        private void LoginProcess()
        {
            if (login(tbuser.Text, tbpass.Text))
            {
                MessageBox.Show("Welcome " + tbuser.Text);
                this.Hide();
                Form_Menu oFormMenu = new Form_Menu();
                oFormMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }

        private Boolean login(string sUsername, string sPassword)
        {
            string SQL = "SELECT user,password FROM tb_user";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(SQL, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((sUsername == reader.GetString(0)) && (sPassword == reader.GetString(1)))
                {
                    conn.Close();
                    return true;
                }
            }
            conn.Close();
            return false;
        }



        private void Form_Login_Load(object sender, EventArgs e)
        {
            tbpass.UseSystemPasswordChar = true;
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            Registerrrr oRegisterrr = new Registerrrr();
            oRegisterrr.ShowDialog();
        }

        private void cbseepass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbseepass.Checked == true)
            {
                tbpass.UseSystemPasswordChar = false;
            }
            else if (cbseepass.Checked == false)
            {
                tbpass.UseSystemPasswordChar = true;
            }
        }
    }
}
