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
    public Host MyHost { get; set; }
    public User MyUser { get; set; }
    public List<MenuAccess> MyMenu { get; set; }
    public List<MenuAccess> MyMenuFav { get; set; }
    public StringBuilder RequestData { get; set; }
    public StringBuilder ResponseData { get; set; }

    public BaseForm()
    {
      InitializeComponent();
      MyHost = new Host();
      MyUser = new User();
      MyMenu = new List<MenuAccess>();
      MyMenuFav = new List<MenuAccess>();
      RequestData = new StringBuilder();
      ResponseData = new StringBuilder();
    }

    protected void FormLoad(object sender, EventArgs e)
    {
      //
    }

    protected void FormActivated(object sender, EventArgs e)
    {
      //
      ApiAccess.GetServerData(MyHost);
    }
  }
}
