using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class FigureGenerator
{
    /// <summary>
    /// Generate random figure
    /// </summary>
    /// <param name="startColumn">x coordinate of start figure position in game field</param>
    /// <returns>generated figure</returns>
    public static Figure Generate(int startColumn)
    {
        var random = new Random();
        var generatedValue = random.Next(1, 8);

        switch (generatedValue)
        {
            case Constants.GeneratedValueForS:
                return new FigureS(startColumn);
            case Constants.GeneratedValueForZ:
                return new FigureZ(startColumn);
            case Constants.GeneratedValueForT:
                return new FigureT(startColumn);
            case Constants.GeneratedValueForO:
                return new FigureO(startColumn);
            case Constants.GeneratedValueForL:
                return new FigureL(startColumn);
            case Constants.GeneratedValueForJ:
                return new FigureJ(startColumn);
            default:
                return new FigureI(startColumn);
        }
    }
}
