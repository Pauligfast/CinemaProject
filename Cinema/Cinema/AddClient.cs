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
    public partial class AddClient : Form
    {
        public String connection;
        public AdminForm parent;
        public AddClient(AdminForm parent, String loginid, String connection)
        {
            this.parent = parent;
            this.connection = connection;
            InitializeComponent();
        }

        void HandleSqlException(SqlException e)
        {

            int num1 = (int)MessageBox.Show("Phone number has to contain 9 numbers", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.ToString() != "" && textBox2.Text.ToString() != "" && textBox3.Text.ToString() != "" &&
                    textBox4.Text.ToString() != "")
                {
                    SqlConnection selectConnection = new SqlConnection(connection);
                    selectConnection.Open();
                    String first = textBox1.Text.ToString();
                    String last = textBox2.Text.ToString();
                    
                    String phone = textBox3.Text.ToString();
                    String mail = textBox4.Text.ToString();
                    
                    SqlCommand insert = new SqlCommand("INSERT INTO CLIENTS VALUES('" + first + "','" + last + "','" + phone + "','" + mail + "', 0)", selectConnection);
                    insert.ExecuteNonQuery();
                    parent.refresh_listbox2();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }
    }
}
