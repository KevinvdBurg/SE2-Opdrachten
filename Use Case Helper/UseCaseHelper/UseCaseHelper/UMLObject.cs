﻿using System;
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
        public string Text { get; set; }

        public UMLObject(string Type, List<Point> Position)
        {

        }
        public UMLObject(string Type, List<Point> Position, string Text)
        {

        }
    }
}
