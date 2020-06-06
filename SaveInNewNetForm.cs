using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesh
{
    public partial class SaveInNewNetForm : Form
    {
        MainForm parent;
        public SaveInNewNetForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (netNameBox.Text != string.Empty)
            {
                AuthorisationForm.SendCommand("create-net " + netNameBox.Text);
                parent.newNet = netNameBox.Text;
                Close();
            }
            else
                MessageBox.Show("Enter new net's name!");
        }
    }
}
