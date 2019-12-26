using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Capella6LNet;

namespace Capella6WNet
{
  public partial class LoginForm : Capella6WNet.BaseForm
  {
    public LoginForm()
    {
      InitializeComponent();
    }

    private void ButtonCloseClick(object sender, EventArgs e)
    {
      Close();
    }

    private void LoginFormLoad(object sender, EventArgs e)
    {
      base.FormLoad(sender, e);
      this.BackgroundImage = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\wallpaper\\"+MyHost.Wallpaper);
      LabelUserName.Text = Utility.GetMessageAPI(MyHost, "username");
      LabelPassword.Text = Utility.GetMessageAPI(MyHost,"password");
    }

    private void ButtonLoginClick(object sender, EventArgs e)
    {
      bool s = Utility.Login(MyHost, EditUserName.Text, EditPassword.Text, MyUser);
      if (s == false)
        MessageBox.Show(Utility.GetMessageAPI(MyHost,"youarenotauthorized"), MyHost.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
      else
      {
        this.Hide();
        MainForm mainForm = new MainForm();
        mainForm.MyUser = this.MyUser;
        mainForm.MyHost = this.MyHost;
        if (mainForm.ShowDialog() == DialogResult.Cancel)
        {
          this.Show();
        }
      }
    }
  }
}
