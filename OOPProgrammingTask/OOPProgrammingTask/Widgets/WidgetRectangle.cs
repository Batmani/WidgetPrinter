using System.Threading;
using System.Globalization;
using System;
using OOPProgrammingTask.Helpers;
using OOPProgrammingTask.WidgetsInterfaces;

namespace OOPProgrammingTask.Widgets
{
    //Inheriting - is-a relationship
    //Composition - has-a relationship
    class WidgetRectangle : BaseWidget
    {
        public uint Width { get; set; }
        public uint Height { get; set; }

        public WidgetRectangle(uint xCoordinate, uint yCoordinate, uint width, uint height) : base(Properties.Resources.Rectangle, xCoordinate, yCoordinate)
        {
            Width = width;
            Height = height;
        }

        public override string GetWidgetValues()
        {
            return $"{GetWidgetName()} {WidgetsHelper.FormatCoordinateLayout(XCoordinate, YCoordinate)} {WidgetsHelper.FormatPositionLayout(Width, Height)}";
        }

        public override string GetWidgetName()
        {
            return WidgetType;
        }
    }
}
