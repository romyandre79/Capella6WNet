using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capella6LNet;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace Capella6WNet
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      SkinManager.LoadAssembly(typeof(Office2016Theme).Assembly);
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new LoginForm());
    }
  }
}
