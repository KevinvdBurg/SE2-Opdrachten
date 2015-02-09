using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class ScreenUseCaseDraw : Form
    {
        //fields
        private int x;
        private int y;
        List<UMLObject> UMLList = new List<UMLObject>();
        int countClicks = 0;
        bool rbtnLineState = false;
        bool rbtnEclipseState = false;
        bool rbtnTextState = false;
        Point Pos2 = new Point();
        Point Pos1 = new Point();
        
        enum umlType
        {
            Line=0,
            Eclipse,
            Text
        }

        //constructors
        public ScreenUseCaseDraw()
        {
            InitializeComponent();
            ScreenUseCaseTable screenUseCaseTable = new ScreenUseCaseTable();
            screenUseCaseTable.Show();
        }

        //methods
        private void pnlUseCase_MouseClick(object sender, MouseEventArgs e)
        {
            //fields
            List<Point> positionList = new List<Point>();

            UMLObject currentUMLObject;
            string currentType;

            //Line
            if (rbtnLine.Checked)
            {
                rbtnLineState = true;

                if (rbtnEclipseState == true || rbtnTextState == true)
                {
                    countClicks = 0;
                    rbtnEclipseState = false;
                    rbtnTextState = false;
                }

                if (countClicks == 0)
                {
                    Pos1 = new Point();

                    Pos1.X = x;
                    Pos1.Y = y;
                    countClicks++;
                }
                else if (countClicks > 0)
                {
                    Pos2 = new Point();

                    Pos2.X = x;
                    Pos2.Y = y;

                    positionList.Add(Pos1);
                    positionList.Add(Pos2); 
                    currentType = Convert.ToString(umlType.Line);
                    currentUMLObject = new UMLObject(currentType, positionList);
                    UMLList.Add(currentUMLObject);
                    countClicks = 0;
                    ClearPoints();
                }

                Refresh();
            }
            //Eclipse
            else if (rbtnEclipse.Checked)
            {
                currentType = Convert.ToString(umlType.Eclipse);
            }
            //Text
            else if (rbtnText.Checked)
            {
                currentType = Convert.ToString(umlType.Text);
            }
        }

        private void pnlUseCase_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 1);

            if (!Pos1.IsEmpty)
            {
                DrawIncompleteLine(g, Pos1.X, Pos1.Y, x, y);
            }
            
            foreach (UMLObject obj in UMLList)
            {
             
                if (obj.Type == Convert.ToString(umlType.Line))
                {
                    g.DrawLine(p, obj.Position[0].X, obj.Position[0].Y, obj.Position[1].X, obj.Position[1].Y);
                }

                else if (obj.Type == Convert.ToString(umlType.Eclipse))
                {

                }

                else if (obj.Type == Convert.ToString(umlType.Text))
                {

                }
            }
        }

        private void pnlUseCase_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            dyX.Text = Convert.ToString(x);
            dyY.Text = Convert.ToString(y);
        }

        private void DrawIncompleteLine(Graphics g, int pos1x, int pos1y, int pos2x, int pos2y)
        {
            Pen p = new Pen(Color.Black, 1);
            g.DrawLine(p, pos1x, pos1y, pos2x, pos2y);
            Refresh();
        }

        private void ClearPoints()
        {
            Pos1 = new Point();
            Pos2 = new Point();
        }
    }
}
