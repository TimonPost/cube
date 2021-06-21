using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CubeAssignment.Gui
{
    /// <summary>
    /// Winapi hook for getting keyboard state. 
    /// </summary>
    public static class Keyboard
    {
        [Flags]
        private enum KeyStates
        {
            None = 0,
            Down = 1,
            Toggled = 2
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern short GetKeyState(int keyCode);

        /// <summary>
        /// Get the keystate for the given key. 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static KeyStates GetKeyState(Keys key)
        {
            var state = KeyStates.None;

            var retVal = GetKeyState((int) key);

            //If the high-order bit is 1, the key is down
            //otherwise, it is up.
            if ((retVal & 0x8000) == 0x8000)
            {
                state |= KeyStates.Down;
            }

            //If the low-order bit is 1, the key is toggled.
            if ((retVal & 1) == 1)
            {
                state |= KeyStates.Toggled;
            }

            return state;
        }

        /// <summary>
        /// Check if key is down.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool IsKeyDown(Keys key)
        {
            if (Form.ActiveForm == MainForm.Instance)
            {
                return KeyStates.Down == (GetKeyState(key) & KeyStates.Down);
            }
            return false;
        }
    }
}