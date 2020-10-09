using System;
using System.Collections.Generic;
using System.Text;
using OOPProgrammingTask.WidgetsInterfaces;

namespace OOPProgrammingTask.Printable
{
    public class Print
    {
        public static void PrintWidgets<T>(params T[] widgets) where T : IPrintable
        {
            try
            {
                Console.WriteLine(DASHED_LINE);
                Console.WriteLine(Properties.Resources.BillOfMaterials);
                Console.WriteLine(DASHED_LINE);

                foreach (T widget in widgets)
                {
                    Console.WriteLine(widget.GetWidgetValues());
                }

                Console.WriteLine(DASHED_LINE);
            }
            catch (Exception e)
            {
                Print.OutputErrorCondition();
            }
        }

        private static string DASHED_LINE = "----------------------------------------------------------------";
        private static string ERROR_MESSAGE = "+++++Abort+++++";

        public static void OutputErrorCondition()
        {
            Console.WriteLine(ERROR_MESSAGE);
        }
    }
    
}
