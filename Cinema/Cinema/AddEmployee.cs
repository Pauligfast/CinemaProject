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
    public partial class AddEmployee : Form
    {
        public AdminForm parent;
        public String connection;
        public AddEmployee(AdminForm parent, String loginid, String connection)
        {
            this.parent = parent;
            this.connection = connection;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void HandleSqlException(SqlException e)
        {

            int num1 = (int)MessageBox.Show("Phone number has to contain 9 numbers", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }


        private void AddEmployee_Load(object sender, EventArgs e)
        {
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM POSITIONS", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow r in dataTable.Rows)
            {
                comboBox1.Items.Add(r["POSITION_NAME"].ToString());
            }

            dataAdapter = new SqlDataAdapter("SELECT * FROM CINEMAS", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow r in dataTable.Rows)
            {
                comboBox2.Items.Add(r["ID_CINEMA"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.ToString() != "" && textBox2.Text.ToString() != "" && textBox3.Text.ToString() != "" &&
                    textBox4.Text.ToString() != "" && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
                {
                    SqlConnection selectConnection = new SqlConnection(connection);
                    selectConnection.Open();
                    String first = textBox1.Text.ToString();
                    String last = textBox2.Text.ToString();
                    String position = comboBox1.SelectedItem.ToString();
                    String phone = textBox3.Text.ToString();
                    String mail = textBox4.Text.ToString();
                    String idcinema = comboBox2.SelectedItem.ToString();
                    SqlCommand insert = new SqlCommand("INSERT INTO EMPLOYEES VALUES('" + first + "','" + last + "',(SELECT ID_POSITION FROM POSITIONS WHERE POSITION_NAME='" + position + "'),'" + phone + "','" + mail + "', " + idcinema + ", (SELECT MIN_SALARY FROM POSITIONS WHERE POSITION_NAME='" + position + "'))", selectConnection);
                    insert.ExecuteNonQuery();
                    insert = new SqlCommand("INSERT INTO LOG_IN VALUES('" + first + "','" + last + "', 0,(SELECT ID_EMPLOYEE FROM EMPLOYEES WHERE FIRST_NAME='" + first + "' AND LAST_NAME='" + last + "'))", selectConnection);
                    insert.ExecuteNonQuery();
                    parent.refresh_listbox1();
                    this.Close();
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
