using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capella6LNet;
using Newtonsoft.Json;

namespace Capella6WNet
{
  public partial class BaseForm : Form
  {
    public Host MyHost = new Host();
    public User MyUser = new User();
    public List<MenuAccess> MyMenu = new List<MenuAccess>();
    public List<MenuAccess> MyMenuFav = new List<MenuAccess>();
    public StringBuilder RequestData = new StringBuilder();
    public StringBuilder ResponseData = new StringBuilder();

    public BaseForm()
    {
      InitializeComponent();
    }

    protected void FormLoad(object sender, EventArgs e)
    {
      //
    }

    protected void FormActivated(object sender, EventArgs e)
    {
      //
      Utility.GetServerData(MyHost);
    }
  }
}
