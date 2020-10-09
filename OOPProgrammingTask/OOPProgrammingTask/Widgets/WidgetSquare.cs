using System;
using System.Collections.Generic;
using System.Text;
using OOPProgrammingTask.Helpers;
using OOPProgrammingTask.WidgetsInterfaces;

namespace OOPProgrammingTask.Widgets
{
    class WidgetSquare : BaseWidget
    {
        public uint Size { get; set; }

        public WidgetSquare(uint xCoordinate, uint yCoordinate, uint size) : base(Properties.Resources.Square, xCoordinate, yCoordinate)
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
