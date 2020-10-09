using OOPProgrammingTask.Printable;
using OOPProgrammingTask.WidgetsInterfaces;

namespace OOPProgrammingTask.Helpers
{
    public abstract class BaseWidget : IPrintable
    {
        public string WidgetType { get; }

        private uint _xCoordinate;
        private uint _yCoordinate;

        public uint XCoordinate
        {
            get
            {
                return _xCoordinate;
            }
            set
            {
                if (value > 1000)
                {
                    Print.OutputErrorCondition();
                }
                else
                {
                    _xCoordinate = value;
                }
            }
        }

        public uint YCoordinate
        {
            get
            {
                return _yCoordinate;
            }
            set
            {
                if (value > 1000)
                {
                    Print.OutputErrorCondition();
                }
                else
                {
                    _yCoordinate = value;
                }
            }
        }

        public abstract string GetWidgetName();
        public abstract string GetWidgetValues();

        protected BaseWidget(string widgetType, uint xCoordinate, uint yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            WidgetType = widgetType;
        }
    }
}
