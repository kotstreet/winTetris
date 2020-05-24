using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FigureL : Figure
{
    public FigureL(int startColumn)
    {
        Configuration = new Point[4] {
            new Point(1,1),
            new Point(1,0),
            new Point(1,2),
            new Point(2,2)
        };

        Color = Brushes.Blue;
        TypeOfCell = TypeOfCell.StaticL;
        FindStartPosition(startColumn);
    }
}