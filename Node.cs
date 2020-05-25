using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesh
{
    public class Node
    {
        Point position;
        int radius;
        string type;
        int id;

        public Point Position { get => position; set => position = value; }
        public int Radius { get => radius; set => radius = value; }
        public string Type { get => type; set => type = value; }
        public int ID { get => id; private set => id = value; }

        public Node(Point position, int radius, string type, int ID)
        {
            this.Position = position;
            this.Radius = radius;
            this.Type = type;
            this.ID = ID;
        }
    }
}
