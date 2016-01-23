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
        public String connection;
        public String Title;
        public EditMovie(String Title, String connection)
        {
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
            textBox1.Text = dataTable.Rows[0]["MOVIE_TITLE"].ToString();
            numericUpDown1.Value = decimal.Parse(dataTable.Rows[0]["RELEASE_YEAR"].ToString());
            numericUpDown2.Value = decimal.Parse(dataTable.Rows[0]["DURATION"].ToString());
            textBox3.Text = dataTable.Rows[0]["DESCRIPTION"].ToString();
            dataAdapter = new SqlDataAdapter("SELECT * FROM RATING", selectConnection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            foreach (DataRow r in dataTable.Rows) {
                comboBox1.Items.Add(r["RATING"].ToString());
            }
            dataAdapter = new SqlDataAdapter("SELECT RATING FROM RATING r JOIN MOVIES m ON m.ID_RATING=r.ID_RATING WHERE MOVIE_TITLE='" + Title+"'", selectConnection);
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
