using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace snaprint_try4
{
    internal static class EjectPendriveManager
    {
        const int OPEN_EXISTING = 3;
        const uint GENERIC_READ = 0x80000000;
        const uint GENERIC_WRITE = 0x40000000;
        const uint IOCTL_STORAGE_EJECT_MEDIA = 0x2D4808;

        [DllImport("kernel32")]
        private static extern int CloseHandle(IntPtr handle);
        [DllImport("kernel32")]
        private static extern int DeviceIoControl(IntPtr deviceHandle, uint ioControlCode, IntPtr inBuffer, int inBufferSize, IntPtr outBuffer, int outBufferSize, ref int bytesReturned, IntPtr overlapped);
        [DllImport("kernel32")]
        private static extern IntPtr CreateFile(string filename, uint desiredAccess, uint shareMode, IntPtr securityAttributes, int creationDisposition, int flagsAndAttributes, IntPtr templateFile);

        public static bool EjectPenDrive(char driveLetterCharacter)
        {
            string pathfordrive = "\\\\.\\" + driveLetterCharacter + ":";
            IntPtr handle = CreateFile(pathfordrive, GENERIC_READ | GENERIC_WRITE, 0, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);
            if ((long)handle == -1)
            {
                MessageBox.Show("Unable to open drive " + driveLetterCharacter, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int dummy = 0;
            if (DeviceIoControl(handle, IOCTL_STORAGE_EJECT_MEDIA, IntPtr.Zero, 0, IntPtr.Zero, 0, ref dummy, IntPtr.Zero) == 0)
            {
                MessageBox.Show("Failed to eject the flash drive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseHandle(handle);
                return false;
            }

            CloseHandle(handle);
            MessageBox.Show("Flash drive removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }
}
