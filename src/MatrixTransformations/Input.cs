using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MatrixTransformations
{
    public class Input
    {
        private const int KeyDownState = 0x8000;

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern short GetKeyState(int keyCode);

        public static bool IsKeyDown(Keys key)
        {
            return (GetKeyState((int) key) & 0x8000) == KeyDownState;
        }
    }
}