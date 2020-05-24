using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FigureT : Figure
{
    public FigureT(int startColumn)
    {
        Configuration = new Point[4] {
            new Point(1,1),
            new Point(0,1),
            new Point(1,0),
            new Point(2,1)
        };

        Color = Brushes.Gray;
        TypeOfCell = TypeOfCell.StaticT;
        FindStartPosition(startColumn);
    }
}
