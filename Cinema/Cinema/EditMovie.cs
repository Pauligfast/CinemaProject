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
    public partial class EditMovie : Form
    {
        public String movieid;
        public String connection;
        public String Title;
        AdminForm parent;
        public EditMovie(String Title, String connection, AdminForm parent)
        {
            this.parent = parent;
            this.Title = Title;
            this.connection = connection;
            InitializeComponent();
        }

        private void EditMovie_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 2020;
            numericUpDown2.Maximum = 2020;
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM MOVIES WHERE MOVIE_TITLE='" + Title + "'", selectConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            movieid = dataTable.Rows[0][0].ToString();
            textBox1.Text = dataTable.Rows[0]["MOVIE_TITLE"].ToString();
            numericUpDown1.Value = decimal.Parse(dataTable.Rows[0]["RELEASE_YEAR"].ToString());
            numericUpDown2.Value = decimal.Parse(dataTable.Rows[0]["DURATION"].ToString());
            textBox3.Text = dataTable.Rows[0]["DESCRIPTION"].ToString();
            dataAdapter = new SqlDataAdapter("SELECT * FROM RATING", selectConnection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            foreach (DataRow r in dataTable.Rows)
            {
                comboBox1.Items.Add(r["RATING"].ToString());
            }
            dataAdapter = new SqlDataAdapter("SELECT RATING FROM RATING r JOIN MOVIES m ON m.ID_RATING=r.ID_RATING WHERE MOVIE_TITLE='" + Title + "'", selectConnection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            comboBox1.SelectedItem = dataTable.Rows[0][0].ToString();


            dataAdapter = new SqlDataAdapter("SELECT * FROM DIRECTORS", selectConnection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            foreach (DataRow r in dataTable.Rows)
            {
                comboBox2.Items.Add(r["LAST_NAME"].ToString());
            }
            dataAdapter = new SqlDataAdapter("SELECT LAST_NAME FROM DIRECTORS d JOIN MOVIES m ON m.ID_DIRECTOR=d.ID_DIRECTOR WHERE MOVIE_TITLE='" + Title + "'", selectConnection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            comboBox2.SelectedItem = dataTable.Rows[0][0].ToString();

            dataAdapter = new SqlDataAdapter("SELECT * FROM GENRES", selectConnection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            foreach (DataRow r in dataTable.Rows)
            {
                comboBox3.Items.Add(r["GENRE_NAME"].ToString());
            }
            dataAdapter = new SqlDataAdapter("SELECT GENRE_NAME FROM GENRES d JOIN MOVIES m ON m.ID_GENRE=d.ID_GENRE WHERE MOVIE_TITLE='" + Title + "'", selectConnection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            comboBox3.SelectedItem = dataTable.Rows[0][0].ToString();


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
               
                SqlCommand insert = new SqlCommand("UPDATE MOVIES SET  MOVIE_TITLE='" + title + "',  DURATION=" + duration + ", ID_RATING= (SELECT ID_RATING FROM RATING WHERE RATING='" + rating + "'), ID_DIRECTOR=(SELECT ID_DIRECTOR FROM DIRECTORS WHERE LAST_NAME='" + director + "'), ID_GENRE=(SELECT ID_GENRE FROM GENRES WHERE GENRE_NAME='" + genre + "'), RELEASE_YEAR=" + year + ", DESCRIPTION='" + descritpion + "' WHERE ID_MOVIE=" + movieid, selectConnection);
                insert.ExecuteNonQuery();

                parent.refresh_movies();
                this.Close();
            }
            else {
                int num1 = (int)MessageBox.Show("Empty fields are not allowed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
