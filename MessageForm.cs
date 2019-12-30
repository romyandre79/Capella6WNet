using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capella6WNet
{
  public partial class MessageForm : Form
  {
    private static MessageForm DialogMessage;
    public MessageBoxIcon IconMessageBox { get; set; }
    public MessageForm()
    {
      InitializeComponent();
    }

    public static void ShowForm(string MessageCaption,MessageBoxIcon IconMessageBox)
    {
      DialogMessage = new MessageForm();
      DialogMessage.IconMessageBox = IconMessageBox;
      DialogMessage.LabelMessage.Text = MessageCaption;
      DialogMessage.ShowDialog();
    }

    private void ButtonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void MessageFormLoad(object sender, EventArgs e)
    {
      if (IconMessageBox == MessageBoxIcon.Error)
      {
        PictureBoxMessageForm.Image = Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\error.png");
      } else 
        if (IconMessageBox == MessageBoxIcon.Information)
      {
        PictureBoxMessageForm.Image = Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\info.png");
      }
    }
  }
}
