using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            x = MousePosition.X;
            y = MousePosition.Y;

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
                }
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
    }
}
