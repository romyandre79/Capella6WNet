using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capella6LNet;

namespace Capella6WNet
{
  public partial class MainForm : Capella6WNet.BaseForm
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void ButtonCloseClick(object sender, EventArgs e)
    {
      Close();
    }

    private void MainFormLoad(object sender, EventArgs e)
    {
      LabelUserName.Text = Utility.GetMessageAPI(MyHost, "username");
      EditUserName.Text = MyUser.UserName;
      LabelPassword.Text = Utility.GetMessageAPI(MyHost, "password");
      EditPassword.Text = MyUser.Password;
      LabelRealName.Text = Utility.GetMessageAPI(MyHost, "realname");
      EditRealName.Text = MyUser.RealName;
      LabelEmail.Text = Utility.GetMessageAPI(MyHost, "email");
      EditEmail.Text = MyUser.Email;
      LabelPhoneNo.Text = Utility.GetMessageAPI(MyHost, "phoneno");
      EditPhoneNo.Text = MyUser.PhoneNo;
      LabelLanguage.Text = Utility.GetMessageAPI(MyHost, "language");

      StringBuilder response = Utility.GetDataAPI(MyHost, "language/listalluser", new StringBuilder());


      LabelTheme.Text = Utility.GetMessageAPI(MyHost, "theme");
    }
  }
}
