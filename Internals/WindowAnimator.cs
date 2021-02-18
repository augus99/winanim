using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Winanim {
    public static class WindowAnimator {

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool AnimateWindow(IntPtr hwnd, int time, AnimateWindowFlags flags);

        private enum AnimateWindowFlags : uint {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_BLEND = 0x00080000
        }

        public static void AnimateBlend(this Form form, int milliseconds, WindowAnimatorMode mode) {
            AnimateWindow(form.Handle, 1, (mode == WindowAnimatorMode.Hide ? AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_ACTIVATE : AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE));
            AnimateWindow(form.Handle, milliseconds, (mode == WindowAnimatorMode.Show ? AnimateWindowFlags.AW_ACTIVATE : AnimateWindowFlags.AW_HIDE) | AnimateWindowFlags.AW_BLEND);
        }

        public static void AnimateHorizontal(this Form form, int milliseconds, WindowAnimatorMode mode) {
            AnimateWindow(form.Handle, 1, (mode == WindowAnimatorMode.Hide ? AnimateWindowFlags.AW_HOR_POSITIVE | AnimateWindowFlags.AW_ACTIVATE : AnimateWindowFlags.AW_HOR_NEGATIVE | AnimateWindowFlags.AW_HIDE));
            AnimateWindow(form.Handle, milliseconds, (mode == WindowAnimatorMode.Show ? AnimateWindowFlags.AW_HOR_POSITIVE | AnimateWindowFlags.AW_ACTIVATE : AnimateWindowFlags.AW_HOR_NEGATIVE | AnimateWindowFlags.AW_HIDE));
        }

        public static void AnimateVertical(this Form form, int milliseconds, WindowAnimatorMode mode) {
            AnimateWindow(form.Handle, 1, (mode == WindowAnimatorMode.Hide ? AnimateWindowFlags.AW_VER_POSITIVE | AnimateWindowFlags.AW_ACTIVATE : AnimateWindowFlags.AW_VER_NEGATIVE | AnimateWindowFlags.AW_HIDE));
            AnimateWindow(form.Handle, milliseconds, (mode == WindowAnimatorMode.Show ? AnimateWindowFlags.AW_VER_POSITIVE | AnimateWindowFlags.AW_ACTIVATE : AnimateWindowFlags.AW_VER_NEGATIVE | AnimateWindowFlags.AW_HIDE));
        }

        public static void AnimateCenter(this Form form, int milliseconds, WindowAnimatorMode mode) {
            AnimateWindow(form.Handle, 1, (mode == WindowAnimatorMode.Hide ? AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_ACTIVATE : AnimateWindowFlags.AW_CENTER | AnimateWindowFlags.AW_HIDE));
            AnimateWindow(form.Handle, milliseconds, (mode == WindowAnimatorMode.Show ? AnimateWindowFlags.AW_ACTIVATE : AnimateWindowFlags.AW_HIDE) | AnimateWindowFlags.AW_CENTER);
        }
    }
}