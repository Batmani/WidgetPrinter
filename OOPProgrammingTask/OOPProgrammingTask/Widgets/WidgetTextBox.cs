using OOPProgrammingTask.Helpers;
using OOPProgrammingTask.Printable;
using OOPProgrammingTask.WidgetsInterfaces;

namespace OOPProgrammingTask.Widgets
{
    class WidgetTextBox : BaseWidget
    {
        public string TextInBox { get; set; }
        public uint Width { get; set; }
        public uint Height { get; set; }

        public WidgetTextBox(uint xCoordinate, uint yCoordinate, uint width, uint height, string textInBox = "") : base(Properties.Resources.Textbox, xCoordinate, yCoordinate)
        {
            Width = width;
            Height = height;
            TextInBox = textInBox;
        }

        public override string GetWidgetValues()
        {
            return $"{GetWidgetName()} {WidgetsHelper.FormatCoordinateLayout(XCoordinate, YCoordinate)} {WidgetsHelper.FormatPositionLayout(Width, Height)} {WidgetsHelper.FormatTextLayout(TextInBox)}";
        }

        public override string GetWidgetName()
        {
            return WidgetType;
        }
    }
}
