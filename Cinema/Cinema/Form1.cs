// Decompiled with JetBrains decompiler
// Type: Cinema.Form1
// Assembly: Cinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 93C9DD96-8ED5-40E1-AA89-2D6DD39249D6
// Assembly location: C:\Users\Paulig\Source\Repos\CinemaProject\Cinema\Cinema\obj\Debug\Cinema.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cinema
{
  public class Form1 : Form
  {
        public  string connection = "SERVER=PASHKO\\SQLEXPRESS;Database=Cinema;Trusted_Connection=true";
        private IContainer components = (IContainer)null;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label1;
    private Label label2;
    private Button button2;
    private Button button1;
    private ComboBox comboBox1;
    private Label label3;
        public  String loggedinCinemaID;
        public  String connectionGlobal;
    public Form1()
    {
      this.InitializeComponent();
            this.comboBox1.Items.Add((object)"Pavlo");
            this.comboBox1.Items.Add((object)"Klaudia");
            this.comboBox1.Items.Add((object)"Doorota");
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }


    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.comboBox1.Text.ToString() == "Pavlo")
                this.connection = "SERVER=PAULIG\\SQLEXPRESS;Database=Cinema;Trusted_Connection=true";
      else if (this.comboBox1.Text.ToString() == "Doorota")
        this.connection = "SERVER=ZWIERZYNIEC;Database=Cinema;Trusted_Connection=true";
      else if (this.comboBox1.Text.ToString() == "Klaudia")
        this.connection = "SERVER=KLAUDIA\\SQLEXPRESS;Database=Cinema;Trusted_Connection=true";
      if (this.comboBox1.Text.ToString() != "")
      {
        SqlConnection selectConnection = new SqlConnection(this.connection);
        selectConnection.Open();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT IS_ADMIN FROM LOG_IN WHERE USERNAME='" + this.textBox1.Text + "' AND PASSWORD='" + this.textBox2.Text + "'", selectConnection);
        DataTable dataTable = new DataTable();
        sqlDataAdapter.Fill(dataTable);
                
        if (dataTable.Rows.Count == 1)
        {
          if (dataTable.Rows[0][0].ToString() == "True")
          {
                        sqlDataAdapter = new SqlDataAdapter("SELECT ID_LOGIN FROM LOG_IN WHERE USERNAME='" + this.textBox1.Text+"'", selectConnection);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);

                        sqlDataAdapter = new SqlDataAdapter("SELECT ID_CINEMA FROM EMPLOYEES e JOIN LOG_IN l ON l.ID_EMPLOYEE=e.ID_EMPLOYEE WHERE ID_LOGIN=" + dataTable.Rows[0][0].ToString(), selectConnection);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        AdminForm adminForm = new AdminForm(this,connection, dataTable.Rows[0][0].ToString());
            this.Visible = false;
            adminForm.Show();
          }
          else
          {
            if (!(dataTable.Rows[0][0].ToString() == "False"))
              return;
            UserForm userForm = new UserForm();
            this.Visible = false;
            userForm.Show();
          }
                    
        }
        else
        {
                    int num = (int)MessageBox.Show("Username or password is incorrect", "authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
                
      }
      else
      {
                int num1 = (int)MessageBox.Show("Choose server first", "Server failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }

           
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.comboBox1 = new ComboBox();
      this.label3 = new Label();
      this.SuspendLayout();
            componentResourceManager.ApplyResources((object)this.textBox1, "textBox1");
      this.textBox1.Name = "textBox1";
            componentResourceManager.ApplyResources((object)this.textBox2, "textBox2");
      this.textBox2.Name = "textBox2";
            this.textBox2.UseSystemPasswordChar = true;
      componentResourceManager.ApplyResources((object) this.button1, "button1");
      this.button1.Name = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
            componentResourceManager.ApplyResources((object)this.button2, "button2");
      this.button2.Name = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
            componentResourceManager.ApplyResources((object)this.label1, "label1");
      this.label1.Name = "label1";
      this.label1.Click += new EventHandler(this.label1_Click);
            componentResourceManager.ApplyResources((object)this.label2, "label2");
      this.label2.Name = "label2";
      this.label2.Click += new EventHandler(this.label2_Click);
      this.comboBox1.FormattingEnabled = true;
            componentResourceManager.ApplyResources((object)this.comboBox1, "comboBox1");
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            componentResourceManager.ApplyResources((object)this.label3, "label3");
      this.label3.Name = "label3";
            componentResourceManager.ApplyResources((object)this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.label3);
            this.Controls.Add((Control)this.comboBox1);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.label1);
            this.Controls.Add((Control)this.button2);
            this.Controls.Add((Control)this.button1);
            this.Controls.Add((Control)this.textBox2);
            this.Controls.Add((Control)this.textBox1);
      this.Name = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
