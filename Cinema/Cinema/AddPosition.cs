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
    public partial class AddPosition : Form
    {
        public String connection;
        public AddPosition(String connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() != "" && numericUpDown1.Value.ToString() != "0" && numericUpDown2.Value.ToString() != "0"
                && numericUpDown3.Value.ToString() != "0")
            {
                numericUpDown1.Minimum = 0;
                numericUpDown2.Minimum = 0;
                numericUpDown3.Minimum = 0;
                numericUpDown1.Maximum = 10000;
                numericUpDown2.Maximum = 10000;
                numericUpDown3.Maximum = 10000;
                SqlConnection selectConnection = new SqlConnection(connection);
                selectConnection.Open();
                String hours = numericUpDown1.Value.ToString();
                String min = numericUpDown2.Value.ToString();
                String max = numericUpDown3.Value.ToString();
                String name = textBox1.Text.ToString();
                int num1 = (int)MessageBox.Show(hours, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                SqlCommand insert = new SqlCommand("INSERT INTO POSITIONS VALUES(" + hours + "," + min + "," + max + ",'" + name + "')",  selectConnection);
                insert.ExecuteNonQuery();
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
