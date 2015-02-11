using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    class UMLObject
    {
        public string Type { get; set; }
        public List<Point> Position { get; set; }
        public int Count { get; set; }

        public UMLObject(string type, List<Point> position)
        {
            this.Type = type;
            this.Position = position;
        }
        public UMLObject(string type, List<Point> position, int count)
        {
            this.Type = type;
            this.Position = position;
            this.Count = count;
        }
    }
}
