using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotaUtility.ScreenWorkers
{
    internal class Screener
    {
        public static void MakeScreenshot(string currentTime)
        {
           
            Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(printscreen as Image);

            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
            
            printscreen.Save($@"printscreen{currentTime}.jpg", ImageFormat.Jpeg);
            
        }
    }
}
