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
        private String CinemaId;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView2;
        private ListBox listBox2;
        private NumericUpDown numericUpDown2;
        private Label label2;
        private DataTable dataSet;
        private Button button7;
        private SqlDataAdapter dataAdapter;

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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabPage1.Controls.Add(this.button7);
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(791, 272);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 22);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 300);
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
            this.label1.Location = new System.Drawing.Point(611, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "How many tickets?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 300);
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
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(651, 227);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ticket refunds";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(800, 223);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "How many tickets remove?";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(725, 251);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "Delete ticket";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(725, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "Show sessions";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(725, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(725, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Show orders";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(243, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(442, 308);
            this.dataGridView2.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(21, 21);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(192, 308);
            this.listBox2.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(275, 300);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 41);
            this.button7.TabIndex = 12;
            this.button7.Text = "Add new client";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

    }

        private void UserForm_Load(object sender, EventArgs e)
        {
            selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            SqlDataAdapter sql = new SqlDataAdapter("SELECT ID_CINEMA FROM EMPLOYEES WHERE ID_EMPLOYEE =" + loginEmployee_ID, selectConnection);
            DataTable t = new DataTable();
            sql.Fill(t);
            CinemaId = t.Rows[0][0].ToString();
            dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.SESSIONS_IN_CINEMA ("+CinemaId+")", selectConnection);
            dataSet = new DataTable();
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
                listBox2.Items.Add(r["LAST_NAME"].ToString() + " " + r["FIRST_NAME"].ToString());
            }
            dataAdapter = new SqlDataAdapter("SELECT * FROM SESSIONS WHERE ID_CINEMA="+CinemaId, selectConnection);
            dataAdapter.Fill(dataSet);
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
                int num = (int)MessageBox.Show("select client first", "Client failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (OrderId == null)
                {
                    int num = (int)MessageBox.Show("Create new order first", "Order failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                }
                else
                {
                    SqlDataAdapter dataAda = new SqlDataAdapter("SELECT ID_CLIENT FROM ORDERS WHERE ID_ORDER ='" + OrderId + "'", selectConnection);
                    DataTable datah = new DataTable();
                    dataAda.Fill(datah);
                    SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT ID_CLIENT FROM CLIENTS WHERE FIRST_NAME='" + listBox1.SelectedItem.ToString().Split(' ')[1] + "' AND LAST_NAME='" + listBox1.SelectedItem.ToString().Split(' ')[0] + "'", selectConnection);
                    DataTable dataSet3 = new DataTable();
                    dataAdapter3.Fill(dataSet3);
                    if (dataSet3.Rows[0][0].ToString().Equals(datah.Rows[0][0].ToString()))
                    {
                        SqlDataAdapter data = new SqlDataAdapter("SELECT ID_ROOM FROM ROOMS WHERE ROOM_NAME='" + dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + "' AND ID_CINEMA='" + CinemaId + "'", selectConnection);
                        DataTable dataT = new DataTable();
                        data.Fill(dataT); 
                        data = new SqlDataAdapter("SELECT ID_SESSION FROM SESSIONS WHERE SESSION_DATE='"
                                                    + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' AND SESSION_TIME='"
                                                    + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "' AND ID_ROOM='"
                                                    + dataT.Rows[0][0].ToString() + "'", selectConnection);
                        DataTable d = new DataTable();
                        data.Fill(d);
                        int i = (int)numericUpDown1.Value;
                        SqlCommand insert = new SqlCommand("INSERT INTO TICKETS VALUES(" + OrderId + "," + d.Rows[0][0].ToString() + ")", selectConnection);
                        try {
                            if (i == 1)
                            {
                                insert.ExecuteNonQuery();
                                SqlDataAdapter sql = new SqlDataAdapter("SELECT ID_CINEMA FROM EMPLOYEES WHERE ID_EMPLOYEE =" + loginEmployee_ID, selectConnection);
                                DataTable t = new DataTable();
                                sql.Fill(t);
                                CinemaId = t.Rows[0][0].ToString();
                                dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.SESSIONS_IN_CINEMA (" + CinemaId + ")", selectConnection);
                                dataSet = new DataTable();
                                dataAdapter.Fill(dataSet);
                                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                                dataGridView1.DataSource = dataSet;
                            }
                            else
                            {
                               
                                SqlCommand dat = new SqlCommand("select dbo.SELL_TICKETS (" + i+", "+OrderId+", "+ d.Rows[0][0].ToString()+")", selectConnection);
                                int a = (int)dat.ExecuteScalar();
                                if (a == 1)
                                {
                                    for(int h=0; h< i; h++)
                                    {
                                        insert.ExecuteNonQuery();
                                    }
                                    SqlDataAdapter sql = new SqlDataAdapter("SELECT ID_CINEMA FROM EMPLOYEES WHERE ID_EMPLOYEE =" + loginEmployee_ID, selectConnection);
                                    DataTable t = new DataTable();
                                    sql.Fill(t);
                                    CinemaId = t.Rows[0][0].ToString();
                                    dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.SESSIONS_IN_CINEMA (" + CinemaId + ")", selectConnection);
                                    dataSet = new DataTable();
                                    dataAdapter.Fill(dataSet);
                                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                                    dataGridView1.DataSource = dataSet;
                                }
                                else
                                {
                                    int num = (int)MessageBox.Show("Not enough room for so many tickets", "Full room", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                            }
                        }
                        catch (SqlException a)
                        {
                            handleException(a);
                        }
                    }
                    else
                    {
                        int num = (int)MessageBox.Show("Create new order for this client first", "Order failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
            }
        }

        private void handleException(SqlException e)
        {
            int num = (int)MessageBox.Show("Not enough room for even one ticket", "Full room", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                int num = (int)MessageBox.Show("select client first", "Client failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                int num = (int)MessageBox.Show("select client first", "Client failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT ID_CLIENT FROM CLIENTS WHERE FIRST_NAME='" + listBox2.SelectedItem.ToString().Split(' ')[1] + "' AND LAST_NAME='" + listBox2.SelectedItem.ToString().Split(' ')[0] + "'", selectConnection);
                DataTable dataSet = new DataTable();
                dataAdapter.Fill(dataSet);
                dataAdapter = new SqlDataAdapter("SELECT ID_ORDER AS ID, ID_EMPLOYEE AS [SOLD BY], SUM, QUANTITY FROM ORDERS WHERE ID_CLIENT='" + dataSet.Rows[0][0].ToString()+"'", selectConnection);
                dataSet = new DataTable();
                dataAdapter.Fill(dataSet);
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                dataGridView2.DataSource = dataSet;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                int num = (int)MessageBox.Show("select client first", "Client failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {

                SqlCommand delete = new SqlCommand("DELETE FROM TICKETS WHERE ID_ORDER='" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "'", selectConnection);
                delete.ExecuteNonQuery();
                delete = new SqlCommand("DELETE FROM ORDERS WHERE ID_ORDER='" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "'", selectConnection);
                delete.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT ID_CLIENT FROM CLIENTS WHERE FIRST_NAME='" + listBox2.SelectedItem.ToString().Split(' ')[1] + "' AND LAST_NAME='" + listBox2.SelectedItem.ToString().Split(' ')[0] + "'", selectConnection);
                DataTable dataSet = new DataTable();
                dataAdapter.Fill(dataSet);
                dataAdapter = new SqlDataAdapter("SELECT ID_ORDER AS ID, ID_EMPLOYEE AS [SOLD BY], SUM, QUANTITY FROM ORDERS WHERE ID_CLIENT='" + dataSet.Rows[0][0].ToString() + "'", selectConnection);
                dataSet = new DataTable();
                dataAdapter.Fill(dataSet);
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                dataGridView2.DataSource = dataSet;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                int num = (int)MessageBox.Show("select client first", "Client failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT ID_CLIENT FROM CLIENTS WHERE FIRST_NAME='" + listBox2.SelectedItem.ToString().Split(' ')[1] + "' AND LAST_NAME='" + listBox2.SelectedItem.ToString().Split(' ')[0] + "'", selectConnection);
                DataTable dataSet = new DataTable();
                dataAdapter.Fill(dataSet);
                SqlDataAdapter dataAd = new SqlDataAdapter("SELECT DISTINCT S.SESSION_DATE AS [DATE], S.SESSION_TIME AS [TIME], M.MOVIE_TITLE AS [TITLE], S.TICKET_PRICE AS [PRICE], (SELECT COUNT(*) FROM TICKETS T WHERE T.ID_SESSION=S.ID_SESSION GROUP BY T.ID_SESSION ) AS QUANTITY, O.ID_ORDER FROM [SESSIONS] S, MOVIES M, ORDERS O, TICKETS TT WHERE '" + dataSet.Rows[0][0].ToString() + "'= O.ID_CLIENT AND O.ID_ORDER=TT.ID_ORDER AND TT.ID_SESSION=S.ID_SESSION AND M.ID_MOVIE=S.ID_MOVIE", selectConnection);
                DataTable data = new DataTable();
                dataAd.Fill(data);
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                dataGridView2.DataSource = data;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                int num = (int)MessageBox.Show("select client first", "Client failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                if (numericUpDown2.Value < 1)
                {
                    int num = (int)MessageBox.Show("incorrect number of tickets", "Number of tickets", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    if(numericUpDown2.Value > (int)dataGridView2.SelectedRows[0].Cells[4].Value)
                    {
                        int num = (int)MessageBox.Show("incorrect number of tickets", "Number of tickets", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT ID_CLIENT FROM CLIENTS WHERE FIRST_NAME='" + listBox2.SelectedItem.ToString().Split(' ')[1] + "' AND LAST_NAME='" + listBox2.SelectedItem.ToString().Split(' ')[0] + "'", selectConnection);
                        DataTable dataSet1 = new DataTable();
                        dataAdapter1.Fill(dataSet1);
                        SqlCommand delete1 = new SqlCommand("DELETE TOP("+numericUpDown2.Value+") FROM TICKETS WHERE ID_ORDER = '" + (int)dataGridView2.SelectedRows[0].Cells[5].Value + "'", selectConnection);
                        delete1.ExecuteNonQuery();
                        SqlDataAdapter dataAd1 = new SqlDataAdapter("SELECT DISTINCT S.SESSION_DATE AS [DATE], S.SESSION_TIME AS [TIME], M.MOVIE_TITLE AS [TITLE], S.TICKET_PRICE AS [PRICE], (SELECT COUNT(*) FROM TICKETS T WHERE T.ID_SESSION=S.ID_SESSION GROUP BY T.ID_SESSION ) AS QUANTITY, O.ID_ORDER  FROM [SESSIONS] S, MOVIES M, ORDERS O, TICKETS TT WHERE '" + dataSet1.Rows[0][0].ToString() + "'= O.ID_CLIENT AND O.ID_ORDER=TT.ID_ORDER AND TT.ID_SESSION=S.ID_SESSION AND M.ID_MOVIE=S.ID_MOVIE", selectConnection);
                        DataTable data1 = new DataTable();
                        dataAd1.Fill(data1);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                        dataGridView2.DataSource = data1;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
