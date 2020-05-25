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
    public partial class Form1 : Form
    {
        static int ID = 1;
        int selectedNodeID = -1;
        List<Node> nodes = new List<Node>();
        private Graphics drawer, panelDrawer;
        private Pen[] pens = new Pen[] { new Pen(Color.Blue), new Pen(Color.DeepPink), new Pen(Color.Green), new Pen(Color.Black) };
        private int nodesSize = 50;
        private Bitmap picture;
        private bool mouseIsDown = false;
        private int dragAccuracy = 50;

        public List<Node> Nodes
        {
            get => nodes;
            set
            {
                nodes = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            picture = new Bitmap(workPanel.Width, workPanel.Height);
            drawer = Graphics.FromImage(picture);
            panelDrawer = workPanel.CreateGraphics();
        }

        private void AddNode(Point pos, int rad, string typ)
        {
            Nodes.Add(new Node(pos, rad, typ, ID));
            ID++;

            UpdateMesh();
        }

        private void UpdateMesh()
        {
            drawer.Clear(Color.Empty);

            foreach (Node node in Nodes)
            {
                if (node.ID != selectedNodeID)
                {
                    if (node.Type != "Target")
                        drawer.DrawEllipse(pens[0], new Rectangle(node.Position.X - nodesSize / 2, node.Position.Y - nodesSize / 2, nodesSize, nodesSize));
                    else
                        drawer.DrawEllipse(pens[1], new Rectangle(node.Position.X - nodesSize / 2, node.Position.Y - nodesSize / 2, nodesSize, nodesSize));
                }
                else
                {
                    drawer.DrawEllipse(pens[1], new Rectangle(node.Position.X - nodesSize / 2, node.Position.Y - nodesSize / 2, nodesSize, nodesSize));
                    drawer.DrawEllipse(pens[3], new Rectangle(node.Position.X - node.Radius / 2, node.Position.Y - node.Radius / 2, node.Radius, node.Radius));
                }
            }
            workPanel.Invalidate();
        }

        private void workPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
            for (int i = 0; i < Nodes.Count; i++)
            {
                double distanceToMouse = Math.Sqrt(Math.Pow(e.X - nodes[i].Position.X, 2) + Math.Pow(e.Y - nodes[i].Position.Y, 2));
                if (distanceToMouse <= dragAccuracy)
                {
                    selectedNodeID = nodes[i].ID;
                    UpdateMesh();
                    return;
                }
            }
            selectedNodeID = -1;

            Point mousePos = e.Location;
            if (selectedNodeID == -1)
                AddNode(mousePos, 100, "Node");

            workPanel.Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = MousePosition.ToString();

            if (mouseIsDown)
            {
                nodes.Find(Node => Node.ID == selectedNodeID).Position = e.Location;
                workPanel.Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void workPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
            workPanel.Invalidate();
        }

        private void workPanel_Paint(object sender, PaintEventArgs e)
        {
            panelDrawer.DrawImage(picture, 0, 0);
        }
    }
}
