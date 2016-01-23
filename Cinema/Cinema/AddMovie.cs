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
    public partial class AddMovie : Form
    {
        public String movieid;
        public String connection;
        //public String Title;
        AdminForm parent;
        public AddMovie(String connection, AdminForm parent)
        {
            this.parent = parent;
            // this.Title = Title;
            this.connection = connection;
            InitializeComponent();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 2020;
            numericUpDown2.Maximum = 2020;
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM RATING", selectConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            foreach (DataRow r in dataTable.Rows)
            {
                comboBox1.Items.Add(r["RATING"].ToString());
            }
           

            dataAdapter = new SqlDataAdapter("SELECT * FROM DIRECTORS", selectConnection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            foreach (DataRow r in dataTable.Rows)
            {
                comboBox2.Items.Add(r["LAST_NAME"].ToString());
            }
            

            dataAdapter = new SqlDataAdapter("SELECT * FROM GENRES", selectConnection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            foreach (DataRow r in dataTable.Rows)
            {
                comboBox3.Items.Add(r["GENRE_NAME"].ToString());
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() != "" && textBox3.Text.ToString() != "" && numericUpDown1.Value.ToString() != "" &&
                  numericUpDown2.Value.ToString() != "" && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                SqlConnection selectConnection = new SqlConnection(connection);
                selectConnection.Open();

                String title = textBox1.Text.ToString();
                String descritpion = textBox3.Text.ToString();
                String duration = numericUpDown2.Value.ToString();
                String year = numericUpDown1.Value.ToString();
                String rating = comboBox1.SelectedItem.ToString();
                String director = comboBox2.SelectedItem.ToString();
                String genre = comboBox3.SelectedItem.ToString();
                int num1 = (int)MessageBox.Show(rating+duration, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                SqlCommand insert = new SqlCommand("INSERT INTO MOVIES VALUES('" + title + "'," + duration + ",(SELECT TOP(1) ID_RATING FROM RATING WHERE RATING='" + rating + "'),(SELECT TOP(1) ID_DIRECTOR FROM DIRECTORS WHERE LAST_NAME='" + director + "'),(SELECT ID_GENRE FROM GENRES WHERE GENRE_NAME='" + genre + "'), " + year + ",'" + descritpion + "')", selectConnection);
                insert.ExecuteNonQuery();

                parent.refresh_movies();
                this.Close();
            }
            else {
                int num1 = (int)MessageBox.Show("Empty fields are not allowed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
