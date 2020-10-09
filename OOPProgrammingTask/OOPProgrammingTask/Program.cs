using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using OOPProgrammingTask.Printable;
using OOPProgrammingTask.Widgets;
using OOPProgrammingTask.WidgetsInterfaces;

namespace OOPProgrammingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            WidgetRectangle printRectangle = new WidgetRectangle(10, 10, 30, 40);
            WidgetSquare printSquare = new WidgetSquare(15,30, 35);
            WidgetCircle circle = new WidgetCircle(1,1,300);
            WidgetTextBox textBox = new WidgetTextBox(5, 5, 200, 100, "sample text");
            WidgetEllipse ellipse = new WidgetEllipse(100,150, 300, 200);
            Print.PrintWidgets<IPrintable>(printRectangle, textBox, printSquare, ellipse, circle);
        }
    }
}
