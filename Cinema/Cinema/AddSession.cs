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
    public partial class AddSession : Form
    {
        String connection;
        AdminForm parent;
        String cinema_id;
        public AddSession(String connection, AdminForm parent, String id)
        {

            this.connection = connection;
            this.parent = parent;
            cinema_id = id;
            InitializeComponent();
        }

        void HandleSqlException(SqlException e)
        {

            int num1 = (int)MessageBox.Show("Selected room is not avavible for chosen date/time", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }
        private void AddSession_Load(object sender, EventArgs e)
        {

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy MM dd HH mm ss";
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MOVIE_TITLE FROM MOVIES", selectConnection);
            DataSet data = new DataSet();
            dataAdapter.Fill(data);
            foreach (DataRow dataRow in data.Tables[0].Rows)
            {
                comboBox1.Items.Add(dataRow[0].ToString());
            }

            dataAdapter = new SqlDataAdapter("SELECT ROOM_NAME FROM ROOMS WHERE ID_CINEMA=" + cinema_id, selectConnection);
            data = new DataSet();
            dataAdapter.Fill(data);
            foreach (DataRow dataRow in data.Tables[0].Rows)
            {
                comboBox2.Items.Add(dataRow[0].ToString());
            }
            int num1 = (int)MessageBox.Show(dateTimePicker1.Value.ToLongTimeString().ToString() + " " + dateTimePicker1.Value.ToShortDateString().ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            for (int i = 0; i < 51; i++) {
                comboBox3.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1)
                {
                    SqlConnection selectConnection = new SqlConnection(connection);
                    selectConnection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID_MOVIE FROM MOVIES WHERE MOVIE_TITLE='" + comboBox1.SelectedItem.ToString() + "'", selectConnection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    SqlCommand insert = new SqlCommand("INSERT INTO SESSIONS VALUES('" + dateTimePicker1.Value.ToShortDateString().ToString() + "','" + dateTimePicker1.Value.ToLongTimeString().ToString() + "', (SELECT ID_MOVIE FROM MOVIES WHERE MOVIE_TITLE='" + comboBox1.SelectedItem.ToString() + "'), ( SELECT ID_ROOM FROM ROOMS WHERE ROOM_NAME='" + comboBox2.SelectedItem.ToString() + "')," + comboBox3.SelectedItem.ToString() + ")", selectConnection);
                    insert.ExecuteNonQuery();
                    Close();
                }
                else {
                    int num1 = (int)MessageBox.Show("Empty fields are not allowed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }



            }
            catch (SqlException exc)
            {
                HandleSqlException(exc);
            }
        }
    }
}
