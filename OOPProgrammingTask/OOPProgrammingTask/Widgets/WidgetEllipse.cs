using System;
using System.Collections.Generic;
using System.Text;
using OOPProgrammingTask.Helpers;
using OOPProgrammingTask.WidgetsInterfaces;

namespace OOPProgrammingTask.Widgets
{
    class WidgetEllipse : BaseWidget
    {
        public uint DiameterH { get; set; }
        public uint DiameterV { get; set; }

        public WidgetEllipse(uint xCoordinate, uint yCoordinate, uint diameterH, uint diameterV) : base(Properties.Resources.Ellipse, xCoordinate, yCoordinate)
        {
            DiameterH = diameterH;
            DiameterV = diameterV;
        }

        public override string GetWidgetValues()
        {
            return $"{GetWidgetName()} {WidgetsHelper.FormatCoordinateLayout(XCoordinate, YCoordinate)} {WidgetsHelper.FormatDiameterLayout(DiameterH, DiameterH)}";
        }

        public override string GetWidgetName()
        {
            return WidgetType;
        }
    }
}
