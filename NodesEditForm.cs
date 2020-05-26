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
    public partial class NodesEditForm : Form
    {
        private MainForm parent;

        public NodesEditForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;

            nodesColorButton.BackColor = parent.Colors["Node"];
            sourcesColorButton.BackColor = parent.Colors["Source"];
            targetsColorButton.BackColor = parent.Colors["Target"];
            radiusesColorButton.BackColor = parent.Colors["Radius"];
            selectedColorButton.BackColor = parent.Colors["Selected"];
            nodesSizeBar.Value = parent.NodesSize;
            linesThicknessBar.Value = parent.LinesThicknessIndex;
        }

        private void sourcesColorButton_Click(object sender, EventArgs e)
        {
            Color color = GetColor();
            if(color != Color.Empty)
            {
                sourcesColorButton.BackColor = color;
                parent.Colors["Source"] = color;
            }
            parent.UpdateMesh();
        }

        private void targetsColorButton_Click(object sender, EventArgs e)
        {
            Color color = GetColor();
            if(color != Color.Empty)
            {
                targetsColorButton.BackColor = color;
                parent.Colors["Target"] = color;
            }
            parent.UpdateMesh();
        }

        private void radiusesColorButton_Click(object sender, EventArgs e)
        {
            Color color = GetColor();
            if(color != Color.Empty)
            {
                radiusesColorButton.BackColor = color;
                parent.Colors["Radius"] = color;
            }
            parent.UpdateMesh();
        }

        private void selectedColorButton_Click(object sender, EventArgs e)
        {
            Color color = GetColor();
            if (color != Color.Empty)
            {
                selectedColorButton.BackColor = color;
                parent.Colors["Selected"] = color;
            }
            parent.UpdateMesh();
        }

        private void nodesColorButton_Click(object sender, EventArgs e)
        {
            Color color = GetColor();
            if(color != Color.Empty)
            {
                nodesColorButton.BackColor = color;
                parent.Colors["Node"] = color;
            }
            parent.UpdateMesh();
        }

        private Color GetColor()
        {
            ColorDialog dialog = new ColorDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
                return dialog.Color;
            else
                return Color.Empty;
        }

        private void nodesSizeBar_Scroll(object sender, EventArgs e)
        {
            parent.NodesSize = nodesSizeBar.Value;
            parent.UpdateMesh();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linesThicknessBar_Scroll(object sender, EventArgs e)
        {
            parent.LinesThicknessIndex = linesThicknessBar.Value;
            parent.UpdateMesh();
        }
    }
}
