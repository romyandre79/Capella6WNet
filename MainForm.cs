using Capella6LNet;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

      ResponseData = Utility.GetDataAPI(MyHost, "language/listalluser", new StringBuilder());
      LanguageListResponse languageListResponse = JsonConvert.DeserializeObject<LanguageListResponse>(ResponseData.ToString());
      if (languageListResponse.IsError == 0)
      {
        EditLanguage.Items.Clear();
        int i = 0;
        foreach (Language language in languageListResponse.Rows)
        {
          EditLanguage.Items.Insert(i, language.languagename);
          i++;
        }
      }
      EditLanguage.Text = MyUser.LanguageName;

      ResponseData = Utility.GetDataAPI(MyHost, "theme/listalluser", new StringBuilder());
      ThemeListResponse themeListResponse = JsonConvert.DeserializeObject<ThemeListResponse>(ResponseData.ToString());
      if (languageListResponse.IsError == 0)
      {
        EditTheme.Items.Clear();
        int i = 0;
        foreach (Theme theme in themeListResponse.Rows)
        {
          EditTheme.Items.Insert(i,theme.themename);
          i++;
        }
      }
      EditTheme.Text = MyUser.ThemeName;
      LabelTheme.Text = Utility.GetMessageAPI(MyHost, "theme");

      ButtonClose.Image = Image.FromFile("icons/close.png");
      ButtonSubmit.Image = Image.FromFile("icons/save.png");
    }

    private void ButtonSubmit_Click(object sender, EventArgs e)
    {
      RequestData = new StringBuilder();
      RequestData.Append("token=" + MyUser.AuthKey);
      RequestData.Append("&useraccessid=" + MyUser.UserAccessId);
      RequestData.Append("&username=" + MyUser.UserName);
      RequestData.Append("&realname=" + EditRealName.Text);
      RequestData.Append("&password=" + EditPassword.Text);
      RequestData.Append("&email=" + EditEmail.Text);
      RequestData.Append("&phoneno=" + EditPhoneNo.Text);
      int i = EditLanguage.SelectedIndex + 1;
      RequestData.Append("&languageid=" + i.ToString());
      i = EditTheme.SelectedIndex + 1;
      RequestData.Append("&themeid=" + i.ToString());
      RequestData.Append("&datauser=" + Utility.GetDataUser(MyHost, MyUser));
      ResponseData = Utility.GetDataAPI(MyHost, "useraccess/saveprofile", RequestData);
      string s = ResponseData.ToString();
      if (s.Contains("Error") == true)
      {
        MessageBox.Show(s, MyHost.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        BaseResponse baseResponse = JsonConvert.DeserializeObject<BaseResponse>(ResponseData.ToString());
        MessageBox.Show(baseResponse.Msg, MyHost.Title, MessageBoxButtons.OK, ((baseResponse.IsError == 0) ? MessageBoxIcon.Information : MessageBoxIcon.Error));
      }
    }
  }
}
