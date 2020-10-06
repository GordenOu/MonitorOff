using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace MonitorOff
{
    public class Program
    {
        [DllImport("user32.dll")]
        private static extern int PostMessage(int hWnd, int wMsg, int wParam, int lParam);

        [STAThread]
        static void Main()
        {
            Task.Delay(1000).Wait();
            PostMessage(0xFFFF, 0x0112, 0xF170, 2);
        }
    }
}
