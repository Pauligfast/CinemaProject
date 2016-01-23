using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public EditMovie(String connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void EditMovie_Load(object sender, EventArgs e)
        {

        }
    }
}
