namespace OOPProgrammingTask.Helpers
{
    public class WidgetsHelper
    {
        public static string FormatCoordinateLayout(uint xCoordinate, uint yCoordinate)
        {
            return $"({xCoordinate},{yCoordinate})";
        }

        public static string FormatPositionLayout(uint width, uint height)
        {
            return $"{Properties.Resources.Width}={width} {Properties.Resources.Height}={height}";
        }

        public static string FormatSizeLayout(uint size)
        {
            return $"{Properties.Resources.Size}={size}";
        }

        public static string FormatTextLayout(string text)
        {
            return $"{Properties.Resources.Text}=\"{text}\"";
        }

        public static string FormatDiameterLayout(uint diameterH, uint diameterV)
        {
            return $"{Properties.Resources.diameterH} = {diameterH} {Properties.Resources.diameterV} = {diameterV}";
        }

    }
}
