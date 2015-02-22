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
        private List<UMLObject> umlList = new List<UMLObject>();
        private List<Actor> actorList = new List<Actor>();
        private int countClicks = 0;
        private bool rbtnLineState = false;
        private bool rbtnEclipseState = false;
        private bool rbtnTextState = false;
        private bool rbtnPointerState = false;
        private Point Pos2 = new Point();
        private Point Pos1 = new Point();
        private int txtboxCount = 0;


        enum umlType
        {
            Line = 0,
            Eclipse,
            Text
        }

        //constructors
        public ScreenUseCaseDraw()
        {
            InitializeComponent();
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
                    umlList.Add(currentUMLObject);
                    countClicks = 0;

                    ClearPoints();
                }

                Refresh();
            }

            //Eclipse
            else if (rbtnEclipse.Checked)
            {

                Pos1.X = x;
                Pos1.Y = y;

                positionList.Add(Pos1);
                currentType = Convert.ToString(umlType.Eclipse);
                currentUMLObject = new UMLObject(currentType, positionList);
                umlList.Add(currentUMLObject);

                ClearPoints();

                Refresh();
            }
            //Text
            else if (rbtnText.Checked)
            {
                string txtCount = "dyTextbox" + txtboxCount++;
                Pos1.X = x;
                Pos1.Y = y;
                TextBox txt = new TextBox();
                txt.Name = txtCount;
                txt.Text = txtCount;
                txt.Location = Pos1;
                txt.Click += new EventHandler(clickTextbox);

                this.pnlDraw.Controls.Add(txt);
                ClearPoints();
            }

        }

        private void pnlUseCase_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            Pen p = new Pen(Color.Black, 1);

            if (!Pos1.IsEmpty)
            {
                DrawIncompleteLine(g, Pos1.X, Pos1.Y, x, y);
            }

            foreach (Actor actor in actorList)
            {
                int x = actor.X;
                int y = actor.Y;

                g.DrawEllipse(p, x + 10, y, 40, 40);

                g.DrawLine(p, 30, y + 40, x + 30, y + 120);

                g.DrawLine(p, x, y + 50, x + 60, y + 50);

                g.DrawLine(p, x + 30, y + 120, x, y + 160);

                g.DrawLine(p, x + 30, y + 120, x + 60, y + 160);
            }

            foreach (UMLObject obj in umlList)
            {

                if (obj.Type == Convert.ToString(umlType.Line))
                {
                    g.DrawLine(p, obj.Position[0].X, obj.Position[0].Y, obj.Position[1].X, obj.Position[1].Y);
                }

                else if (obj.Type == Convert.ToString(umlType.Eclipse))
                {
                    g.DrawEllipse(p, obj.Position[0].X - 75, obj.Position[0].Y - 50, 150, 100);
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

            if (!Pos1.IsEmpty)
            {
                Refresh();
            }

        }

        private void DrawIncompleteLine(Graphics g, int pos1x, int pos1y, int pos2x, int pos2y)
        {
            Pen p = new Pen(Color.Black, 1);
            g.DrawLine(p, pos1x, pos1y, pos2x, pos2y);
        }

        private void ClearPoints()
        {
            Pos1 = new Point();
            Pos2 = new Point();
        }

        private void rbtnEclipse_CheckedChanged(object sender, EventArgs e)
        {
            rbtnEclipseState = true;

            if (rbtnLineState == true || rbtnTextState == true || rbtnPointerState == true)
            {
                countClicks = 0;
                rbtnLineState = false;
                rbtnTextState = false;
                rbtnPointerState = false;
                ClearPoints();
                Refresh();
            }
        }

        private void rbtnLine_CheckedChanged(object sender, EventArgs e)
        {
            rbtnLineState = true;

            if (rbtnEclipseState == true || rbtnTextState == true || rbtnPointerState == true)
            {
                countClicks = 0;
                rbtnEclipseState = false;
                rbtnTextState = false;
                rbtnPointerState = false;
                ClearPoints();
                Refresh();
            }
        }

        private void rbtnText_CheckedChanged(object sender, EventArgs e)
        {
            rbtnTextState = true;

            if (rbtnLineState == true || rbtnEclipseState == true || rbtnPointerState == true)
            {
                countClicks = 0;
                rbtnLineState = false;
                rbtnEclipseState = false;
                rbtnPointerState = false;
                ClearPoints();
                Refresh();
            }
        }

        private void btnPointer_CheckedChanged(object sender, EventArgs e)
        {
            rbtnPointerState = true;

            if (rbtnLineState == true || rbtnEclipseState == true || rbtnTextState == true)
            {
                countClicks = 0;
                rbtnLineState = false;
                rbtnEclipseState = false;
                rbtnTextState = false;
                ClearPoints();
                Refresh();
            }
        }

        private void pnlUseCase_Click(object sender, EventArgs e)
        {
            MouseEventArgs m = (MouseEventArgs)e;
            if (rbtnPointerState == true)
            {
                if (m.X < 100)
                {
                    int actorHeight = (pnlDraw.Height / 3);

                    if (m.Y >= 0 && m.Y <= actorHeight)
                    {
                        Actor actor1 = new Actor(0, 0);
                        actorList.Add(actor1);

                    }
                    if (m.Y >= actorHeight && m.Y <= actorHeight * 2)
                    {
                        Actor actor2 = new Actor(0, actorHeight);
                        actorList.Add(actor2);
                    }
                    if (m.Y >= actorHeight * 2 && m.Y <= actorHeight * 3)
                    {
                        Actor actor3 = new Actor(0, actorHeight * 2);
                        actorList.Add(actor3);
                    }
                    Refresh();
                }
            }
        }

        private void clickTextbox(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScreenUseCaseTable screenUseCaseTable = new ScreenUseCaseTable();
            screenUseCaseTable.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            foreach (Control tempCtrl in pnlDraw.Controls)
            {
                /*string name = tempCtrl.Name;
                string namebox = "dyTextbox" + name.Substring(9);
                if (name == namebox)
                {*/
                    pnlDraw.Controls.Remove(tempCtrl);
                /*}
                else
                {
                    Console.WriteLine("Substring:" + name.Substring(8));
                    Console.WriteLine("ControlName: " +tempCtrl.Name);
                    Console.WriteLine("Namebox: " + namebox);
                }*/
            }

            actorList.Clear();
            umlList.Clear();
            Refresh();
        }
    }
}
