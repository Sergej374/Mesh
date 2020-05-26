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
    public partial class InterfaceEditForm : Form
    {
        MainForm parent;

        public InterfaceEditForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            displayNodesBox.Checked = parent.NodesVisible["Node"];
            displaySourcesBox.Checked = parent.NodesVisible["Source"];
            displayTargetsButton.Checked = parent.NodesVisible["Target"];
            displayIDBox.Checked = parent.selectedIDLabel.Visible;
            displayTypeBox.Checked = parent.selectedTypeLabel.Visible;
            displayRadiusValBox.Checked = parent.selectedRadiusLabel.Visible;
        }

        private void displayNodesBox_CheckedChanged(object sender, EventArgs e)
        {
            parent.NodesVisible["Node"] = displayNodesBox.Checked;
            parent.UpdateMesh();
        }

        private void displaySourcesBox_CheckedChanged(object sender, EventArgs e)
        {
            parent.NodesVisible["Source"] = displaySourcesBox.Checked;
            parent.UpdateMesh();
        }

        private void displayTargetsButton_CheckedChanged(object sender, EventArgs e)
        {
            parent.NodesVisible["Target"] = displayTargetsButton.Checked;
            parent.UpdateMesh();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void displayIDBox_CheckedChanged(object sender, EventArgs e)
        {
            parent.selectedIDLabel.Visible = displayIDBox.Checked;
        }

        private void displayTypeBox_CheckedChanged(object sender, EventArgs e)
        {
            parent.selectedTypeLabel.Visible = displayTypeBox.Checked;
        }

        private void displayRadiusValBox_CheckedChanged(object sender, EventArgs e)
        {
            parent.selectedRadiusLabel.Visible = displayRadiusValBox.Checked;
        }
    }
}
