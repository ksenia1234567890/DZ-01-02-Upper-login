using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_01_02_Upper_login
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            
            Label login = new Label();
            login.Parent = this;
            login.Location = new Point(286, 9);
            login.Text = Login.textLogin;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
