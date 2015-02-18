using System;
using System.Diagnostics;

namespace Dummy_Launcher
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Process.Start(@"C:\Program Files\AutoHotkey\AutoHotkeyU64.exe", @"C:\Users\ath\Desktop\Scripts\Caffine.ahk");
    }
  }
}
