using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotaUtility.ScreenWorkers;
using DotaUtility.Timers;

namespace DotaUtility.HotKeys
{
    internal class Hooks
    {
        public static void Screenshot(object sender, KeyPressedEventArgs e)
        {
            string currentTime = DateTime.Now.ToString("Hhmmss",
                CultureInfo.InvariantCulture);
            Screener.MakeScreenshot(currentTime);
        }

        public static void Timer(object sender, KeyPressedEventArgs e)
        {
            RoshanTimer.Start();
        }
    }
}
