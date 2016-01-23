﻿// Decompiled with JetBrains decompiler
// Type: Cinema.AdminForm
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
    public class AdminForm : Form
    {
        private IContainer components = (IContainer)null;
        private TabControl Main;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private DataGridView dataGridView1;
        private MonthCalendar monthCalendar1;
        private ComboBox comboBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        public ListBox listBox2;
        private Button button2;
        private Button button3;
        private Button button7;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox11;
        public ListBox listBox1;
        private Button button10;
        private Button button9;
        private Button button8;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
        private Button button14;
        private Button button15;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox10;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private Form1 parent;
        private String connection;
        private DataGridView dataGridView2;
        private ComboBox comboBox2;
        private MonthCalendar monthCalendar2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private ComboBox comboBox3;
        private Button button16;
        private Button button11;
        private Button button1;
        private Button button12;
        private Button button13;
        private String loginCinema_ID;

        public AdminForm(Form1 parent, String con, String logid)

        {
            loginCinema_ID = logid;
            this.connection = con;
            this.parent = parent;
            this.InitializeComponent();
        }

        public void refresh_listbox1()
        {
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM EMPLOYEES", selectConnection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            listBox1.Items.Clear();
            foreach (DataRow r in dataTable.Rows)
            {
                listBox1.Items.Add(r["LAST_NAME"].ToString() + " " + r["FIRST_NAME"].ToString());
            }
        }

        public void refresh_listbox2()
        {
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM CLIENTS", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow r in dataTable.Rows)
            {
                listBox2.Items.Add(r["LAST_NAME"].ToString() + " " + r["FIRST_NAME"].ToString());
            }
        }

        public void refresh_movies()
        {
            comboBox2.Items.Clear();
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT MOVIE_TITLE FROM MOVIES", selectConnection);
            DataSet data = new DataSet();
            dataAdapter.Fill(data);
            foreach (DataRow dataRow in data.Tables[0].Rows)
            {
                comboBox2.Items.Add(dataRow[0].ToString());
            }
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.SESSIONS_IN_CINEMA ('" + loginCinema_ID + "')", selectConnection);
            DataTable dataSet = new DataTable();
            dataAdapter.Fill(dataSet);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.DataSource = dataSet;

            dataAdapter = new SqlDataAdapter("SELECT MOVIE_TITLE FROM MOVIES", selectConnection);
            DataSet data = new DataSet();
            dataAdapter.Fill(data);
            foreach (DataRow dataRow in data.Tables[0].Rows)
            {
                comboBox2.Items.Add(dataRow[0].ToString());
            }

            dataAdapter = new SqlDataAdapter("SELECT * FROM CLIENTS", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow r in dataTable.Rows)
            {
                listBox2.Items.Add(r["LAST_NAME"].ToString() + " " + r["FIRST_NAME"].ToString());
            }

            dataAdapter = new SqlDataAdapter("SELECT * FROM EMPLOYEES", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow r in dataTable.Rows)
            {
                listBox1.Items.Add(r["LAST_NAME"].ToString() + " " + r["FIRST_NAME"].ToString());
            }

            dataAdapter = new SqlDataAdapter("SELECT * FROM POSITIONS", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow r in dataTable.Rows)
            {
                comboBox3.Items.Add(r["POSITION_NAME"].ToString());
            }

        }

        private void dataGridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Main_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void selectedColumnsButton_Click(object sender, System.EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.Main = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.Main.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.tabPage2);
            this.Main.Controls.Add(this.tabPage3);
            this.Main.Controls.Add(this.tabPage4);
            this.Main.Controls.Add(this.tabPage5);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(845, 349);
            this.Main.TabIndex = 0;
            this.Main.SelectedIndexChanged += new System.EventHandler(this.Main_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.button16);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(837, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employees";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(341, 184);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(98, 45);
            this.button16.TabIndex = 32;
            this.button16.Text = "New positon";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(310, 52);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(129, 21);
            this.comboBox3.TabIndex = 31;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(453, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(384, 321);
            this.dataGridView4.TabIndex = 30;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 45);
            this.button2.TabIndex = 28;
            this.button2.Text = "New employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 45);
            this.button3.TabIndex = 27;
            this.button3.Text = "Save changes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(341, 133);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 45);
            this.button7.TabIndex = 26;
            this.button7.Text = "Undo";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Salary";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Position";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Surname";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(310, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(310, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(310, 1);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(129, 20);
            this.textBox11.TabIndex = 16;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 316);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.monthCalendar1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(837, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sessions";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(695, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(723, 273);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(723, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(723, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 313);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(680, 3);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Controls.Add(this.button10);
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.textBox8);
            this.tabPage4.Controls.Add(this.textBox7);
            this.tabPage4.Controls.Add(this.textBox6);
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.listBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(837, 319);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Clients";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(458, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(379, 320);
            this.dataGridView3.TabIndex = 15;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(227, 222);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 55);
            this.button10.TabIndex = 13;
            this.button10.Text = "Add new client";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(227, 147);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 55);
            this.button9.TabIndex = 12;
            this.button9.Text = "Save changes";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(339, 147);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 55);
            this.button8.TabIndex = 11;
            this.button8.Text = "Undo";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Discount ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Phone number";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "LAST NAME";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "FIRST NAME";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(308, 107);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(129, 20);
            this.textBox8.TabIndex = 5;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(308, 81);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(129, 20);
            this.textBox7.TabIndex = 4;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(308, 29);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(129, 20);
            this.textBox6.TabIndex = 3;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(308, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 20);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(308, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(205, 316);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button12);
            this.tabPage5.Controls.Add(this.button11);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.comboBox2);
            this.tabPage5.Controls.Add(this.monthCalendar2);
            this.tabPage5.Controls.Add(this.dataGridView2);
            this.tabPage5.Controls.Add(this.button14);
            this.tabPage5.Controls.Add(this.button15);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.textBox10);
            this.tabPage5.Controls.Add(this.textBox12);
            this.tabPage5.Controls.Add(this.textBox13);
            this.tabPage5.Controls.Add(this.textBox14);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(837, 323);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Movies";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 21);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(269, 4);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 31;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(446, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(388, 315);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(283, 178);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(121, 23);
            this.button14.TabIndex = 27;
            this.button14.Text = "Edit movie";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(283, 207);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(121, 23);
            this.button15.TabIndex = 26;
            this.button15.Text = "Add movie";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Description";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Release year";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Director";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Genre";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(19, 148);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(238, 156);
            this.textBox10.TabIndex = 20;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(89, 91);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(129, 20);
            this.textBox12.TabIndex = 19;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(89, 39);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(129, 20);
            this.textBox13.TabIndex = 18;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(89, 65);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(129, 20);
            this.textBox14.TabIndex = 17;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Add Genre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(283, 294);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(121, 23);
            this.button11.TabIndex = 34;
            this.button11.Text = "Add director";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(283, 236);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(121, 23);
            this.button12.TabIndex = 35;
            this.button12.Text = "Delete Movie";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(229, 235);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(96, 45);
            this.button13.TabIndex = 33;
            this.button13.Text = "Delete employee";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 349);
            this.Controls.Add(this.Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.Main.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddMovie add = new AddMovie(connection, this);
            add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            monthCalendar1.MaxSelectionCount = 1;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.MOVIES_ON_DAY ('" + monthCalendar1.SelectionRange.Start.ToString() + "')", selectConnection);
            DataTable dataSet = new DataTable();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet;

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddEmployee add = new AddEmployee(this, loginCinema_ID, connection);
            add.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            String last = textBox3.Text.ToString();
            String first = textBox11.Text.ToString();
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();

            decimal d = decimal.Parse(textBox2.Text.ToString(), System.Globalization.CultureInfo.InvariantCulture) / 10000;
            // decimal.Format(Convert.ToDecimal(textBox2.Text.ToString()));
            SqlCommand command = new SqlCommand("UPDATE EMPLOYEES SET FIRST_NAME='" + textBox11.Text.ToString() + "', LAST_NAME='" + textBox3.Text.ToString() + "', SALARY=" + d + " WHERE FIRST_NAME='" + first + "' AND LAST_NAME='" + last + "'", selectConnection);
            command.ExecuteNonQuery();
            command = new SqlCommand("UPDATE EMPLOYEES SET SALARY = (SELECT MIN_SALARY FROM POSITIONS WHERE POSITION_NAME = '" + comboBox3.SelectedItem.ToString() + "'), ID_POSITION = (SELECT ID_POSITION FROM POSITIONS WHERE POSITION_NAME = '" + comboBox3.SelectedItem.ToString() + "') WHERE FIRST_NAME = '" + textBox11.Text.ToString() + "' AND LAST_NAME = '" + textBox3.Text.ToString() + "'", selectConnection);
            command.ExecuteNonQuery();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM EMPLOYEES", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            last = textBox3.Text.ToString();
            first = textBox11.Text.ToString();
            listBox1.Items.Clear();
            foreach (DataRow r in dataTable.Rows)
            {
                listBox1.Items.Add(r["LAST_NAME"].ToString() + " " + r["FIRST_NAME"].ToString());
            }

            dataAdapter = new SqlDataAdapter("SELECT SALARY FROM EMPLOYEES WHERE FIRST_NAME='" + textBox11.Text.ToString() + "' AND LAST_NAME='" + textBox3.Text.ToString() + "'", connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            textBox2.Text = dataTable.Rows[0]["SALARY"].ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                String last = listBox1.SelectedItem.ToString().Split(' ')[0];
                String first = listBox1.SelectedItem.ToString().Split(' ')[1];
                SqlConnection selectConnection = new SqlConnection(connection);
                selectConnection.Open();
                // SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM RAPORT_BY_EMPLOYEE WHERE FIRST_NAME='" + first + "' AND LAST_NAME='" + last + "'", selectConnection);
                DataTable dataSet = new DataTable();
                //  dataAdapter.Fill(dataSet);
                dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView4.DataSource = dataSet;

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM EMPLOYEES e JOIN POSITIONS p ON p.ID_POSITION=e.ID_POSITION WHERE FIRST_NAME='" + first + "' AND LAST_NAME='" + last + "'", selectConnection);
                dataSet = new DataTable();
                dataAdapter.Fill(dataSet);

                textBox11.Text = dataSet.Rows[0]["FIRST_NAME"].ToString();
                textBox3.Text = dataSet.Rows[0]["LAST_NAME"].ToString();
                //  textBox9.Text = dataSet.Rows[0]["POSITION_NAME"].ToString();
                textBox2.Text = dataSet.Rows[0]["SALARY"].ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String last = listBox1.SelectedItem.ToString().Split(' ')[0];
            String first = listBox1.SelectedItem.ToString().Split(' ')[1];
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM RAPORT_BY_EMPLOYEE WHERE FIRST_NAME='" + first + "' AND LAST_NAME='" + last + "'", selectConnection);
            DataTable dataSet = new DataTable();
            dataAdapter.Fill(dataSet);
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.DataSource = dataSet;

            dataAdapter = new SqlDataAdapter("SELECT * FROM EMPLOYEES e JOIN POSITIONS p ON p.ID_POSITION=e.ID_POSITION WHERE FIRST_NAME='" + first + "' AND LAST_NAME='" + last + "'", selectConnection);
            dataSet = new DataTable();
            dataAdapter.Fill(dataSet);

            textBox11.Text = dataSet.Rows[0]["FIRST_NAME"].ToString();
            textBox3.Text = dataSet.Rows[0]["LAST_NAME"].ToString();
            // textBox9.Text = dataSet.Rows[0]["POSITION_NAME"].ToString();
            textBox2.Text = dataSet.Rows[0]["SALARY"].ToString();

            comboBox3.SelectedItem = dataSet.Rows[0]["POSITION_NAME"].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddClient add = new AddClient(this, loginCinema_ID, connection);
            add.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            String last = listBox2.SelectedItem.ToString().Split(' ')[0];
            String first = listBox2.SelectedItem.ToString().Split(' ')[1];
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM CLIENTS WHERE FIRST_NAME='" + first + "' AND LAST_NAME='" + last + "'", selectConnection);
            DataTable dataSet = new DataTable();
            dataAdapter.Fill(dataSet);

            textBox4.Text = dataSet.Rows[0]["FIRST_NAME"].ToString();
            textBox6.Text = dataSet.Rows[0]["LAST_NAME"].ToString();
            textBox5.Text = dataSet.Rows[0]["EMAIL_ADRESS"].ToString();
            textBox7.Text = dataSet.Rows[0]["PHONE_NUMBER"].ToString();
            textBox8.Text = dataSet.Rows[0]["DISCOUNT"].ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String last = listBox2.SelectedItem.ToString().Split(' ')[0];
            String first = listBox2.SelectedItem.ToString().Split(' ')[1];
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT ID_ORDER, QUANTITY, SUM FROM ORDERS o JOIN CLIENTS c ON o.ID_CLIENT=c.ID_CLIENT WHERE c.FIRST_NAME='" + first + "' AND c.LAST_NAME='" + last + "'", selectConnection);
            DataTable dataSet = new DataTable();
            dataAdapter.Fill(dataSet);
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.DataSource = dataSet;

            dataAdapter = new SqlDataAdapter("SELECT * FROM CLIENTS WHERE FIRST_NAME='" + first + "' AND LAST_NAME='" + last + "'", selectConnection);
            dataSet = new DataTable();
            dataAdapter.Fill(dataSet);

            textBox4.Text = dataSet.Rows[0]["FIRST_NAME"].ToString();
            textBox6.Text = dataSet.Rows[0]["LAST_NAME"].ToString();
            textBox5.Text = dataSet.Rows[0]["EMAIL_ADRESS"].ToString();
            textBox7.Text = dataSet.Rows[0]["PHONE_NUMBER"].ToString();
            textBox8.Text = dataSet.Rows[0]["DISCOUNT"].ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                EditMovie edit = new EditMovie(comboBox2.SelectedItem.ToString(), connection, this);
                edit.Show();
            }
            else {
                int num1 = (int)MessageBox.Show("Select a movie to edit", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            monthCalendar2.MaxSelectionCount = 1;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.MOVIES_ON_DAY ('" + monthCalendar2.SelectionRange.Start.ToString() + "')", selectConnection);
            DataTable dataSet = new DataTable();
            dataAdapter.Fill(dataSet);
            // dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.DataSource = dataSet;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection selectConnection = new SqlConnection(connection);
            selectConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM DIRECTORS d  JOIN(MOVIES m JOIN GENRES g ON m.ID_GENRE=g.ID_GENRE)  ON m.ID_DIRECTOR=d.ID_DIRECTOR WHERE MOVIE_TITLE='" + comboBox2.SelectedItem.ToString() + "'", selectConnection);
            DataTable data = new DataTable();
            dataAdapter.Fill(data);
            //DataRow r =data.Rows[0];

            textBox13.Text = data.Rows[0]["GENRE_NAME"].ToString();
            textBox14.Text = data.Rows[0]["FIRST_NAME"].ToString() + " " + data.Rows[0]["LAST_NAME"].ToString();
            textBox12.Text = data.Rows[0]["RELEASE_YEAR"].ToString();
            textBox10.Text = data.Rows[0]["DESCRIPTION"].ToString();
        }

        public void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Determine if text has changed in the textbox by comparing to original text.
            parent.Show();
            parent.textBox1.Clear();
            parent.textBox2.Clear();
            // parent.comboBox1.Refresh();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            AddPosition add = new AddPosition(connection);
            add.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            AddDirector add = new AddDirector(connection);
            add.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            AddGenre add = new AddGenre(connection);
            add.Show();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                SqlConnection selectConnection = new SqlConnection(connection);
                selectConnection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM SESSIONS WHERE ID_MOVIE=(SELECT ID_MOVIE FROM MOVIES WHERE MOVIE_TITLE='" + comboBox2.SelectedItem.ToString() + "')", selectConnection);
                DataTable d = new DataTable();
                dataAdapter.Fill(d);
                if (decimal.Parse(d.Rows[0][0].ToString()) == 0)
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM MOVIES WHERE MOVIE_TITLE='" + comboBox2.SelectedItem.ToString() + "'", selectConnection);
                    delete.ExecuteNonQuery();
                    refresh_movies();
                    MessageBox.Show("Movie has been deleted", "Succes");
                }
                else {
                    int num1 = (int)MessageBox.Show("Deletetion movie with active sessions is not permitted", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else {
                int num1 = (int)MessageBox.Show("Select a movie to delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SqlConnection selectConnection = new SqlConnection(connection);
                selectConnection.Open();
                String last = listBox1.SelectedItem.ToString().Split(' ')[0];
                String first = listBox1.SelectedItem.ToString().Split(' ')[1];


                SqlCommand delete = new SqlCommand("DELETE FROM LOG_IN WHERE ID_EMPLOYEE=(SELECT ID_EMPLOYEE FROM EMPLOYEES WHERE FIRST_NAME='"+first+"' AND LAST_NAME='"+last+"')", selectConnection);
                delete.ExecuteNonQuery();
               
                MessageBox.Show("Employee has been deleted", "Succes");
                
               
            }
            else {
                int num1 = (int)MessageBox.Show("Select employee", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
