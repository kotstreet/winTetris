using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FigureJ : Figure
{
    public FigureJ(int startColumn)
    {
        Configuration = new Point[4] {
            new Point(1,1),
            new Point(1,0),
            new Point(1,2),
            new Point(0,2)
        };

        Color = Brushes.Red;
        TypeOfCell = TypeOfCell.StaticJ;
        FindStartPosition(startColumn);
    }
}