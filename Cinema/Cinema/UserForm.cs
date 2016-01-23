// Decompiled with JetBrains decompiler
// Type: Cinema.UserForm
// Assembly: Cinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 93C9DD96-8ED5-40E1-AA89-2D6DD39249D6
// Assembly location: C:\Users\Paulig\Source\Repos\CinemaProject\Cinema\Cinema\obj\Debug\Cinema.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema
{
  public class UserForm : Form
    {
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private String loginEmployee_ID;
        private Form1 parent;
        private String connection;
        private ListBox listBox1;
        private IContainer components = (IContainer) null;
        private Button button2;
        private SqlConnection selectConnection;
        private String OrderId;
        private NumericUpDown numericUpDown1;
        private String ClientId;
        private String SessionId;

    public UserForm(Form1 parent, String con, String logid)
    {
            loginEmployee_ID = logid;
            this.connection = con;
            this.parent = parent;
            this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "New order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(8, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 324);
            this.listBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "How many tickets?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add tickets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 17);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 227);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ticket refunds";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(554, 293);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 22);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 390);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

    }

        private void UserForm_Load(object sender, EventArgs e)
        {
            selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.SESSIONS_IN_CINEMA ( (SELECT ID_CINEMA FROM EMPLOYEES WHERE ID_EMPLOYEE ="+loginEmployee_ID+") )", selectConnection);
            DataTable dataSet = new DataTable();
            dataAdapter.Fill(dataSet);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.DataSource = dataSet;

            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT * FROM CLIENTS", selectConnection);
            DataTable dataSet2 = new DataTable();
            dataAdapter2.Fill(dataSet2);
            foreach(DataRow r in dataSet2.Rows)
            {
                listBox1.Items.Add(r["LAST_NAME"].ToString() + " " + r["FIRST_NAME"].ToString());
            }
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
            parent.textBox1.Clear();
            parent.textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                int num = (int)MessageBox.Show("unselected client", "Client failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (OrderId == null)
                {
                    int num = (int)MessageBox.Show("Create new order first", "Order failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
                else
                {


                    int i = (int)numericUpDown1.Value;
                    SqlCommand insert = new SqlCommand("INSERT INTO TICKETS VALUES(" + OrderId + ","+SessionId+")", selectConnection); //still session?
                    for (int j=0; j< i; j++)
                    {
                        insert.ExecuteNonQuery();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                int num = (int)MessageBox.Show("unselected client", "Client failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT ID_CLIENT FROM CLIENTS WHERE FIRST_NAME='" + listBox1.SelectedItem.ToString().Split(' ')[1] + "' AND LAST_NAME='" + listBox1.SelectedItem.ToString().Split(' ')[0] + "'", selectConnection);
                DataTable dataSet3 = new DataTable();
                dataAdapter3.Fill(dataSet3);
                ClientId = dataSet3.Rows[0][0].ToString();
                SqlCommand insert = new SqlCommand("INSERT INTO ORDERS VALUES(" + loginEmployee_ID + "," + ClientId + ",0,0)", selectConnection);
                insert.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT ID_ORDER FROM ORDERS WHERE ID_EMPLOYEE='" + loginEmployee_ID + "' AND ID_CLIENT='" + ClientId + "'", selectConnection);
                DataTable data = new DataTable();
                dataAdapter.Fill(data);
                OrderId = data.Rows[0][0].ToString();

            }
        }
    }
}
