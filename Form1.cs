using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private Graphics drawer, panelDrawer;
        private Pen[] pens = new Pen[] { new Pen(Color.Blue, 3), new Pen(Color.DeepPink, 3), new Pen(Color.Green, 3), new Pen(Color.Black), new Pen(Color.DarkOrange, 3) };
        private int nodesSize = 50;
        private Bitmap picture;
        private bool mouseIsDown = false;
        private bool draggingRadius = false;
        private int dragAccuracy = 25;

        public List<Node> Nodes { get; set; } = new List<Node>();

        public int SelectedNodeID
        {
            get => selectedNodeID;
            set
            {
                selectedNodeID = value;
                if (selectedNodeID != -1)
                    typeChooseButton.Enabled = true;
                else
                    typeChooseButton.Enabled = false;
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
                if (node.ID != SelectedNodeID)
                {
                    if (node.Type == "Node")
                        drawer.DrawEllipse(pens[0], new Rectangle(node.Position.X - nodesSize / 2, node.Position.Y - nodesSize / 2, nodesSize, nodesSize));
                    else if (node.Type == "Source")
                        drawer.DrawEllipse(pens[4], new Rectangle(node.Position.X - nodesSize / 2, node.Position.Y - nodesSize / 2, nodesSize, nodesSize));
                    else
                        drawer.DrawEllipse(pens[1], new Rectangle(node.Position.X - nodesSize / 2, node.Position.Y - nodesSize / 2, nodesSize, nodesSize));
                }
                else
                {
                    drawer.DrawEllipse(pens[2], new Rectangle(node.Position.X - nodesSize / 2, node.Position.Y - nodesSize / 2, nodesSize, nodesSize));
                    drawer.DrawEllipse(pens[3], new Rectangle(node.Position.X - node.Radius, node.Position.Y - node.Radius, node.Radius * 2, node.Radius * 2));
                }
            }
            workPanel.Invalidate();
        }

        private void workPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
            for (int i = 0; i < Nodes.Count; i++)
            {
                double distanceToMouse = Math.Sqrt(Math.Pow(e.X - Nodes[i].Position.X, 2) + Math.Pow(e.Y - Nodes[i].Position.Y, 2));
                if (distanceToMouse <= dragAccuracy)
                {
                    SelectedNodeID = Nodes[i].ID;
                    selectedIDLabel.Text = "ID: " + SelectedNodeID;
                    typeChooseButton.Text = Nodes.Find(Node => Node.ID == selectedNodeID).Type;
                    typeChooseButton.Enabled = true;
                    UpdateMesh();
                    return;
                }
                else if (Math.Abs(distanceToMouse - Nodes[i].Radius) < 2)
                {
                    draggingRadius = true;
                    Nodes[i].Radius = Convert.ToInt32(distanceToMouse);
                    UpdateMesh();
                    return;
                }
            }

            if (SelectedNodeID != -1 && !draggingRadius)
            {
                SelectedNodeID = -1;
                selectedIDLabel.Text = "";
                typeChooseButton.Enabled = false;
                UpdateMesh();
                return;
            }

            Point mousePos = e.Location;
            if (SelectedNodeID == -1)
                AddNode(mousePos, 100, "Node");

            workPanel.Invalidate();
        }

        private void workPanel_MouseUp(object sender, MouseEventArgs e)
        {
            draggingRadius = false;
            mouseIsDown = false;
            workPanel.Invalidate();
        }

        private void workPanel_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                double distanceToMouse = Math.Sqrt(Math.Pow(e.X - Nodes[i].Position.X, 2) + Math.Pow(e.Y - Nodes[i].Position.Y, 2));

                if (distanceToMouse <= nodesSize / 2)
                {
                    Cursor.Current = Cursors.SizeAll;
                }
                else if (Nodes[i].ID == selectedNodeID && Math.Abs(distanceToMouse - Convert.ToDouble(Nodes[i].Radius)) < 2)
                {
                    Cursor.Current = Cursors.Cross;
                }
            }


            if (mouseIsDown && SelectedNodeID != -1)
            {
                if (Cursor.Position.X < Left)
                    Cursor.Position = new Point(Left, Cursor.Position.Y);
                if (Cursor.Position.X > Right)
                    Cursor.Position = new Point(Right, Cursor.Position.Y);
                if (Cursor.Position.Y < Top + workPanel.Top + toolStrip1.Height)
                    Cursor.Position = new Point(Cursor.Position.X, Top + workPanel.Top + toolStrip1.Height);
                if (Cursor.Position.Y > Top + workPanel.Bottom)
                    Cursor.Position = new Point(Cursor.Position.X, Top + workPanel.Bottom);

                Node nod = Nodes.Find(Node => Node.ID == SelectedNodeID);
                double distanceToMouse = Math.Sqrt(Math.Pow(e.X - nod.Position.X, 2) + Math.Pow(e.Y - nod.Position.Y, 2));
                if (draggingRadius)
                {
                    if (distanceToMouse >= nodesSize / 2)
                        Nodes.Find(Node => Node.ID == SelectedNodeID).Radius = Convert.ToInt32(distanceToMouse);
                }
                else
                {
                    Nodes.Find(Node => Node.ID == SelectedNodeID).Position = e.Location;
                }

                UpdateMesh();
            }


        }

        private void workPanel_SizeChanged(object sender, EventArgs e)
        {
            Bitmap bitmap = picture;
            picture = new Bitmap(workPanel.Width, workPanel.Height);
            drawer = Graphics.FromImage(picture);
            panelDrawer = workPanel.CreateGraphics();
            drawer.DrawImage(bitmap, 0, 0);
            workPanel.Invalidate();
        }

        private void nodeTypeButton_Click(object sender, EventArgs e)
        {
            Nodes.Find(Node => Node.ID == selectedNodeID).Type = "Node";
            typeChooseButton.Text = "Node";
            UpdateMesh();
        }

        private void sourceTypeButton_Click(object sender, EventArgs e)
        {
            Nodes.Find(Node => Node.ID == selectedNodeID).Type = "Source";
            typeChooseButton.Text = "Source";
            UpdateMesh();
        }

        private void targetTypeButton_Click(object sender, EventArgs e)
        {
            Nodes.Find(Node => Node.ID == selectedNodeID).Type = "Target";
            typeChooseButton.Text = "Target";
            UpdateMesh();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string output = "";
            output += ID + "\n";
            foreach (Node node in Nodes)
            {
                output += node.Position.X + " " + node.Position.Y + " " + node.Radius + " ";
                switch (node.Type)
                {
                    case "Node":
                        output += 1;
                        break;
                    case "Source":
                        output += 2;
                        break;
                    case "Target":
                        output += 3;
                        break;
                }
                output += " " + node.ID + "\n";
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "txt|.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, output);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            string[] input = new string[2];
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Nodes.Clear();
                input = File.ReadAllLines(dialog.FileName);

                for (int i = 1; i < input.Length; i++)
                {
                    string[] nums = input[i].Split(new char[] { ' ' });
                    Nodes.Add(new Node(new Point(Convert.ToInt32(nums[0]), Convert.ToInt32(nums[1])), Convert.ToInt32(nums[2]), "type", Convert.ToInt32(nums[4])));
                    switch (nums[3])
                    {
                        case "1":
                            Nodes[Nodes.Count - 1].Type = "Node";
                            break;
                        case "2":
                            Nodes[Nodes.Count - 1].Type = "Source";
                            break;
                        case "3":
                            Nodes[Nodes.Count - 1].Type = "Target";
                            break;
                    }
                }
                ID = Convert.ToInt32(input[0]);
            }
            UpdateMesh();
        }

        private void workPanel_Paint(object sender, PaintEventArgs e)
        {
            panelDrawer.DrawImage(picture, 0, 0);
        }
    }
}
