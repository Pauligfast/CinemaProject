using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{

    public partial class Form1 : Form
    {
        String connection = @"SERVER=PASHKO\SQLEXPRESS;Database=Cinema;Trusted_Connection=true";

        public Form1()
        {


            InitializeComponent();

            comboBox1.Items.Add("Pavlo");
            comboBox1.Items.Add("Klaudia");
            comboBox1.Items.Add("Doorota");
        }



        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() == "Pavlo")
            {
                connection = @"SERVER=PASHKO\SQLEXPRESS;Database=Cinema;Trusted_Connection=true";
            }
            else if (comboBox1.Text.ToString() == "Doorota")
            {
                connection = @"SERVER=PASHKO\SQLEXPRESS;Database=Cinema;Trusted_Connection=true";
            }
            else if (comboBox1.Text.ToString() == "Klaudia")
            {
                connection = @"SERVER=KLAUDIA\SQLEXPRESS;Database=Cinema;Trusted_Connection=true";
            }
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            String username = textBox1.Text;
            String password = textBox2.Text;
            SqlDataAdapter dataAdapted = new SqlDataAdapter("SELECT IS_ADMIN FROM LOG_IN WHERE USERNAME='" + username + "' AND PASSWORD='" + password + "'", con);
            DataTable dt = new DataTable();
            dataAdapted.Fill(dt);

            if (comboBox1.Text.ToString() != "")
            {
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][0].ToString() == "True")
                    {

                        AdminForm admin = new AdminForm();
                        this.Visible = false;
                        admin.Show();



                    }
                    else if (dt.Rows[0][0].ToString() == "False")
                    {

                        UserForm user = new UserForm();
                        this.Visible = false;
                        user.Show();
                    }
                }
                else {
                    MessageBox.Show("Username or password is incorrect", "authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else {
                MessageBox.Show("Choose server first", "Server failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
