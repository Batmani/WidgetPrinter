using System;
using System.Collections.Generic;
using System.Text;
using OOPProgrammingTask.Helpers;
using OOPProgrammingTask.WidgetsInterfaces;

namespace OOPProgrammingTask.Widgets
{
    class WidgetCircle : BaseWidget
    {
        public uint Size { get; set; }

        public WidgetCircle(uint xCoordinate, uint yCoordinate, uint size) : base(Properties.Resources.Circle, xCoordinate, yCoordinate)
        {
            Size = size;
        }

        public override string GetWidgetValues()
        {
            return $"{GetWidgetName()} {WidgetsHelper.FormatCoordinateLayout(XCoordinate, YCoordinate)} {WidgetsHelper.FormatSizeLayout(Size)}";
        }

        public override string GetWidgetName()
        {
            return WidgetType;
        }
    }
}
