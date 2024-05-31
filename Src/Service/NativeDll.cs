using System.Runtime.InteropServices;

namespace Service
{
    public static class NativeDll
    {
        [DllImport("Utility.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetNumber();
    }
}
