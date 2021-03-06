﻿using System;
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
    public partial class AddGenre : Form
    {
        String connection;
        public AddGenre(String connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() != "" && textBox2.Text.ToString() != "")
            {
                SqlConnection selectConnection = new SqlConnection(connection);
                selectConnection.Open();
                String name = textBox1.Text.ToString();
                String description = textBox2.Text.ToString();
                      

                SqlCommand insert = new SqlCommand("INSERT INTO GENRES VALUES('" + name + "','" + description + "')", selectConnection);
                insert.ExecuteNonQuery();
                
                this.Close();
            }
            else {
                int num1 = (int)MessageBox.Show("Empty fields are not allowed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
