using System;
using System.Collections.Generic;
using System.Text;

public class Circle
{
    public double Radius { get; set; }

    public double Area
    {
        get { return 3.14 * Radius * Radius; }
        private set { }
    }
}