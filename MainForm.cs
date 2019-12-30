using Capella6LNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace Capella6WNet
{
  public partial class MainForm : Capella6WNet.BaseForm
  {
    private Control ReturnControl = null;
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
      this.SkinManagerMainForm.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2016White;
      LabelUserName.Text = ApiAccess.GetMessageAPI(MyHost, "username");
      EditUserName.Text = MyUser.UserName;
      LabelPassword.Text = ApiAccess.GetMessageAPI(MyHost, "password");
      EditPassword.Text = MyUser.Password;
      LabelRealName.Text = ApiAccess.GetMessageAPI(MyHost, "realname");
      EditRealName.Text = MyUser.RealName;
      LabelEmail.Text = ApiAccess.GetMessageAPI(MyHost, "email");
      EditEmail.Text = MyUser.Email;
      LabelPhoneNo.Text = ApiAccess.GetMessageAPI(MyHost, "phoneno");
      EditPhoneNo.Text = MyUser.PhoneNo;

      LabelLanguage.Text = ApiAccess.GetMessageAPI(MyHost, "language");
      ResponseData = ApiAccess.GetDataAPI(MyHost, "language/listalluser", new StringBuilder());
      LanguageListResponse languageListResponse = JsonConvert.DeserializeObject<LanguageListResponse>(ResponseData.ToString());
      List<Language> DataLanguage = new List<Language>();
      if (languageListResponse.IsError == 0)
      {
        int i = 0;
        foreach (Language language in languageListResponse.Rows)
        {
          DataLanguage.Add(language);
          i++;
        }
      }
      EditLanguage.DataSource = DataLanguage;
      EditLanguage.DisplayMember = "languagename";
      EditLanguage.ValueMember = "languageid";
      EditLanguage.Text = MyUser.LanguageName;

      ResponseData = ApiAccess.GetDataAPI(MyHost, "theme/listalluser", new StringBuilder());
      ThemeListResponse themeListResponse = JsonConvert.DeserializeObject<ThemeListResponse>(ResponseData.ToString());
      List<Capella6LNet.Theme> DataTheme = new List<Capella6LNet.Theme>();
      if (themeListResponse.IsError == 0)
      {
        int i = 0;
        foreach (Capella6LNet.Theme theme in themeListResponse.Rows)
        {
          DataTheme.Add(theme);
          i++;
        }
      }
      EditTheme.DataSource = DataTheme;
      EditTheme.DisplayMember = "themename";
      EditTheme.ValueMember = "themeid";
      EditTheme.Text = MyUser.ThemeName;
      LabelTheme.Text = ApiAccess.GetMessageAPI(MyHost, "theme");

      ButtonClose.Image = Image.FromFile("icons/close.png");
      ButtonSubmit.Image = Image.FromFile("icons/save.png");

      ResponseData = ApiAccess.GetDataAPI(MyHost, "sysadm/getallmenus", new StringBuilder("token=" + MyUser.AuthKey));
      MenuAccessListResponse response = JsonConvert.DeserializeObject<MenuAccessListResponse>(ResponseData.ToString());
      ImageListMenu.Images.Clear();
      if (response.IsError == 0)
      {
        MyUser.MenuItems = new System.Collections.Generic.List<MenuAccess>();
        foreach (MenuAccess menuAccess in response.Rows)
        {
          if (menuAccess.ParentId == null)
          {
            ImageListMenu.Images.Add(menuAccess.MenuAccessId, Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\folder.png"));
            TreeMenuItem ParentTree = new TreeMenuItem();
            MainFormTreeView.Items.Add(ParentTree);
            ParentTree.Name = "menu" + menuAccess.MenuAccessId;
            ParentTree.Text = menuAccess.MenuLabel;
            //ParentTree.LeftImageIndices = new int[] { ImageListMenu.Images.Count - 1 };
            foreach (MenuAccess submenuAccess in response.Rows)
            {
              if (submenuAccess.ParentId == menuAccess.MenuAccessId)
              {
                TreeMenuItem SubMenuTree = new TreeMenuItem();
                ParentTree.Items.Add(SubMenuTree);
                SubMenuTree.Name = "menu" + submenuAccess.MenuAccessId;
                SubMenuTree.Text = submenuAccess.MenuLabel;
                //SubMenuTree.LeftImageIndices = new int[] { ImageListMenu.Images.Count - 1 };
              }
            }
          }
          MyUser.MenuItems.Add(menuAccess);
        }
      } else
      {
        MessageForm.ShowForm(response.Msg, MessageBoxIcon.Error);
      }

      ResponseData = ApiAccess.GetDataAPI(MyHost, "sysadm/getuserfavs", new StringBuilder("token=" + MyUser.AuthKey));
      response = JsonConvert.DeserializeObject<MenuAccessListResponse>(ResponseData.ToString());
      PanelOtherFav.Controls.Clear();
      if (response.IsError == 0)
      {
        MyUser.UserFavs = new System.Collections.Generic.List<MenuAccess>();
        foreach (MenuAccess menuAccess in response.Rows)
        {
          ButtonAdv button = new ButtonAdv();
          button.FlatStyle = FlatStyle.Flat;
          button.FlatAppearance.BorderSize = 0;
          button.Text = "";
          button.Name = "buttonfav" + menuAccess.MenuAccessId;
          button.Image = Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\" + menuAccess.MenuIcon);
          button.Width = 51;
          button.Height = 51;
          ToolTipButton.SetToolTip(button, menuAccess.MenuLabel);
          if (PanelOtherFav.Controls.Count == 0)
          {
            button.Left = 0;
          }
          else
          {
            Control lastControl = PanelOtherFav.Controls[PanelOtherFav.Controls.Count - 1];
            button.Left = lastControl.Location.X + lastControl.Width + 10;
          }
          button.Top = 0;
          PanelOtherFav.Controls.Add(button);
          MyUser.UserFavs.Add(menuAccess);
        }
      }
      else
      {
        MessageForm.ShowForm(response.Msg, MessageBoxIcon.Error);
      }
    }

    private void ButtonSubmitClick(object sender, EventArgs e)
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
      RequestData.Append("&datauser=" + ApiAccess.GetDataUser(MyHost, MyUser));
      ResponseData = ApiAccess.GetDataAPI(MyHost, "useraccess/saveprofile", RequestData);
      string s = ResponseData.ToString();
      if (s.Contains("Error") == true)
      {
        MessageForm.ShowForm(s, MessageBoxIcon.Error);
      }
      else
      {
        BaseResponse baseResponse = JsonConvert.DeserializeObject<BaseResponse>(ResponseData.ToString());
        MessageForm.ShowForm(baseResponse.Msg, ((baseResponse.IsError == 0) ? MessageBoxIcon.Information : MessageBoxIcon.Error));
      }
    }

    private void TextBoxKeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        string idtab = System.Text.RegularExpressions.Regex.Match(((TextBox)sender).Name, @"\d+").Value;
        ReturnControl = null;
        GetControl(MainFormTabControl, "buttonsearch" + idtab);
        if (ReturnControl != null)
        {
          ((Button)ReturnControl).PerformClick();
        }
      }
    }

    private void DataGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
    {
      var grid = sender as DataGridView;
      var rowIdx = (e.RowIndex + 1).ToString();

      var centerFormat = new StringFormat()
      {
        // right alignment might actually make more sense for numbers
        Alignment = StringAlignment.Center,
        LineAlignment = StringAlignment.Center
      };

      var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
      e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
    }

    private void GetControl(Control ParentControl, string ControlName)
    {
      if (ReturnControl == null)
      {
        foreach (Control subcontrol in ParentControl.Controls)
        {
          if (subcontrol.Name == ControlName)
          {
            ReturnControl = subcontrol;
          }
          else
          if (subcontrol.Controls.Count > 0)
          {
           GetControl(subcontrol, ControlName);
          }
        }
      } 
    }

    private void FillGrid(DataTable dataTable, MenuCodeResponse menuCodeResponse, StringBuilder SearchData,  int Page, int Rows)
    {
      ResponseData = ApiAccess.GetDataAPI(MyHost, menuCodeResponse.ListUrl, RequestData);
      dynamic RootObject = JObject.Parse(ResponseData.ToString());
      dataTable.Rows.Clear();
      for (int i=0;i < RootObject.rows.Count;i++)
      {
        string s = RootObject.rows[i].ToString();
        string[] array1 = s.Split(',');
        string[] values = new string[dataTable.Columns.Count];
        int l = 0;
        for (int j = 0; j < array1.Length; j++)
        {
          string[] array2 = (array1[j].Trim().Replace("{", "").Replace("}", "").Replace("\r\n", "").Replace("\"", "")).Split(':');
          for (int k = 0; k < array2.Length; k++)
          {
            if (dataTable.Columns.Contains(array2[k].Trim()) == true) {
              values[l] = array2[k + 1];
              k+=2;
              l++;
            }
          }
        }
        dataTable.Rows.Add(values);
        dataTable.AcceptChanges();
      }
    }

    private void ButtonSearchClick(object sender, EventArgs e)
    {
      string idtab = System.Text.RegularExpressions.Regex.Match(((Button)sender).Name,@"\d+").Value;
      MenuAccess mymenu = MyUser.MenuItems.Find(menuku => menuku.MenuAccessId == idtab);
      MenuCodeResponse menuCodeResponse = JsonConvert.DeserializeObject<MenuCodeResponse>(mymenu.MenuCode);
      RequestData = new StringBuilder();
      RequestData.Append("token=" + MyUser.AuthKey);
      ReturnControl = null;
      GetControl(MainFormTabControl, "panelsearch" + idtab);
      if (ReturnControl != null)
      {
        foreach (Control control in ReturnControl.Controls)
        {
          if (control.Name.Contains("searchbox"))
          {
            RequestData.Append("&"+control.Name.Replace("searchbox", "").Replace(idtab, "") + "=" + control.Text);
          }
        }
      }
      ReturnControl = null;
      GetControl(MainFormTabControl, "grid" + idtab);
      DataGridView GridData = (DataGridView)ReturnControl ;
      DataTable dataTable = (DataTable) GridData.DataSource;
      FillGrid(dataTable, menuCodeResponse, RequestData, 1, 10);
    }

    private void TreeViewAdvMainFormSelectionChanged(TreeNavigator sender, SelectionStateChangedEventArgs e)
    {
      //MessageBox.Show(e.SelectedItem.Text);
      string idtab = MainFormTreeView.SelectedItem.Name.Remove(0, 4);
      TabPageAdv tabPageAdv = null;
      for (int i = 0; i < MainFormTabControl.TabPages.Count; i++)
      {
        if (MainFormTabControl.TabPages[i].Name == "tab" + idtab)
        {
          tabPageAdv = MainFormTabControl.TabPages[i];
          break;
        }
      }
      if (tabPageAdv == null)
      {
        MenuAccess mymenu = MyUser.MenuItems.Find(menuku => menuku.MenuAccessId == idtab);
        if (mymenu.ParentId != "")
        {
          try
          {
            MenuCodeResponse menuCodeResponse = JsonConvert.DeserializeObject<MenuCodeResponse>(mymenu.MenuCode);

            tabPageAdv = new TabPageAdv();
            tabPageAdv.Name = "tab" + idtab;
            tabPageAdv.BackColor = Color.White;
            tabPageAdv.Text = MainFormTreeView.SelectedItem.Text;
            tabPageAdv.TabVisible = true;
            tabPageAdv.ThemesEnabled = true;
            tabPageAdv.ShowCloseButton = true;
            tabPageAdv.Image = Image.FromFile("icons\\" + mymenu.MenuIcon);

            char[] separator = new char[] { ',' };

            DataTable dataTable = new DataTable();
            DataGridView dataGrid = new DataGridView();
            dataGrid.Name = "grid" + idtab;
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.GridColor = Color.Black;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGrid.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dataGrid.RowPostPaint += DataGrid_RowPostPaint;
            List<GridData> grids = menuCodeResponse.Grid;

            if (mymenu.IsWrite == "0")
            {
              dataGrid.ReadOnly = true;
            }
            else
            {
              dataGrid.ReadOnly = false;
            }

            dataGrid.Dock = DockStyle.Fill;
            foreach (GridData gridData in grids)
            {
              DataGridViewColumn dataGridViewColumn;
              if (gridData.fieldtype == "checkbox")
              {
                dataGridViewColumn = new DataGridViewCheckBoxColumn();
              }
              else
              if (gridData.fieldtype == "string")
              {
                dataGridViewColumn = new DataGridViewTextBoxColumn();
              }
              else
              {
                dataGridViewColumn = new DataGridViewTextBoxColumn();
              }
              dataGridViewColumn.DataPropertyName = gridData.fieldname;
              dataGridViewColumn.HeaderText = ApiAccess.GetMessageAPI(MyHost, gridData.fieldname);
              if (gridData.fieldkey == "true")
              {
                dataGridViewColumn.Visible = false;
              }
              dataGridViewColumn.Width = Convert.ToInt32(gridData.width);
              dataGrid.Columns.Add(dataGridViewColumn);
            }

            foreach (GridData gridData in grids)
            {
              DataColumn dataColumn = new DataColumn();
              dataColumn.ColumnName = gridData.fieldname;
              dataColumn.Caption = ApiAccess.GetMessageAPI(MyHost, gridData.fieldname);
              if (gridData.fieldkey == "true")
              {
                dataColumn.ReadOnly = true;
              }
              if (gridData.fieldtype == "integer")
              {
                dataColumn.DataType = System.Type.GetType("System.Int32");
              }
              else
              if (gridData.fieldtype == "string")
              {
                dataColumn.DataType = System.Type.GetType("System.String");
                dataColumn.MaxLength = Convert.ToInt32(gridData.fieldsize);
              }
              else
              if (gridData.fieldtype == "checkbox")
              {
                dataColumn.DataType = System.Type.GetType("System.Byte");
              }
              if (gridData.required == "true")
              {
                dataColumn.AllowDBNull = false;
              }
              else
              {
                dataColumn.AllowDBNull = true;
              }
              if (gridData.unique == "true")
              {
                dataColumn.Unique = true;
              }
              else
              {
                dataColumn.Unique = false;
              }
              dataTable.Columns.Add(dataColumn);
            }

            dataGrid.DataSource = dataTable;
            tabPageAdv.Controls.Add(dataGrid);

            GradientPanel panelSearch = new GradientPanel();
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new System.Drawing.Point(0, 0);
            panelSearch.AutoSize = true;
            panelSearch.BorderStyle = BorderStyle.None;
            panelSearch.Visible = true;
            panelSearch.Name = "panelsearch" + idtab;

            string[] searchField = menuCodeResponse.Search.Split(separator);
            int x = 0; int y = 0; int z = 0;
            for (int i = 0; i < searchField.Length; i++)
            {
              if (z == 0)
              {
                x = 0; y = 0;
              }
              else
              if (z == 1)
              {
                x += 250;
                z = 0;
                y = 0;
              }
              Label label = new Label();
              label.Text = ApiAccess.GetMessageAPI(MyHost, searchField[i]);
              label.AutoSize = true;
              label.Name = "searchlabel" + searchField[i] + idtab;
              if (panelSearch.Controls.Count == 0)
              {
                label.Location = new System.Drawing.Point(0, 0);
              }
              else
              {
                Control lastControl = panelSearch.Controls[panelSearch.Controls.Count - 1];
                label.Location = new System.Drawing.Point(x, y);
              }
              panelSearch.Controls.Add(label);

              TextBox textBox = new TextBox();
              textBox.Text = "";
              textBox.Name = "searchbox" + searchField[i] + idtab;
              textBox.Size = new Size(100, 20);
              if (panelSearch.Controls.Count == 0)
              {
                textBox.Location = new Point(0, 0);
              }
              else
              {
                Control lastControl = panelSearch.Controls[panelSearch.Controls.Count - 1];
                textBox.Location = new System.Drawing.Point(lastControl.Location.X + lastControl.Width + 50, y);
              }
              textBox.KeyDown += TextBoxKeyDown;
              panelSearch.Controls.Add(textBox);

              y += 10;
              z++;
            }

            tabPageAdv.Controls.Add(panelSearch);

            GradientPanel panelMenu = new GradientPanel();
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new System.Drawing.Point(0, 0);
            panelMenu.Size = new System.Drawing.Size(718, 60);
            panelMenu.BorderStyle = BorderStyle.None;
            panelMenu.Visible = true;
            panelMenu.Name = "panelbutton" + idtab;

            string[] menubuttons = menuCodeResponse.Button.Split(separator);
            for (int i = 0; i < menubuttons.Length; i++)
            {
              if (mymenu.IsWrite == "1")
              {
                if (menubuttons[i] == "new")
                {
                  Button buttonNew = new Button();
                  buttonNew.FlatStyle = FlatStyle.Flat;
                  buttonNew.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\add.png");
                  buttonNew.Size = new System.Drawing.Size(51, 51);
                  buttonNew.FlatAppearance.BorderSize = 0;
                  buttonNew.Name = "buttonnew" + idtab;
                  if (panelMenu.Controls.Count == 0)
                  {
                    buttonNew.Location = new System.Drawing.Point(0, 0);
                  }
                  else
                  {
                    Control lastControl = panelMenu.Controls[panelMenu.Controls.Count - 1];
                    buttonNew.Left = lastControl.Location.X + lastControl.Width + 10;
                  }
                  panelMenu.Controls.Add(buttonNew);
                }
                if (menubuttons[i] == "edit")
                {
                  Button buttonEdit = new Button();
                  buttonEdit.FlatStyle = FlatStyle.Flat;
                  buttonEdit.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\edit.png");
                  buttonEdit.Size = new System.Drawing.Size(51, 51);
                  buttonEdit.FlatAppearance.BorderSize = 0;
                  buttonEdit.Name = "buttonedit" + idtab;
                  if (panelMenu.Controls.Count == 0)
                  {
                    buttonEdit.Location = new System.Drawing.Point(0, 0);
                  }
                  else
                  {
                    Control lastControl = panelMenu.Controls[panelMenu.Controls.Count - 1];
                    buttonEdit.Left = lastControl.Location.X + lastControl.Width + 10;
                  }
                  panelMenu.Controls.Add(buttonEdit);
                }
                if (menubuttons[i] == "copy")
                {
                  Button buttonCopy = new Button();
                  buttonCopy.FlatStyle = FlatStyle.Flat;
                  buttonCopy.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\copy.png");
                  buttonCopy.Size = new System.Drawing.Size(51, 51);
                  buttonCopy.FlatAppearance.BorderSize = 0;
                  buttonCopy.Name = "buttoncopy" + idtab;
                  if (panelMenu.Controls.Count == 0)
                  {
                    buttonCopy.Location = new System.Drawing.Point(0, 0);
                  }
                  else
                  {
                    Control lastControl = panelMenu.Controls[panelMenu.Controls.Count - 1];
                    buttonCopy.Left = lastControl.Location.X + lastControl.Width + 10;
                  }
                  panelMenu.Controls.Add(buttonCopy);
                }
                if (menubuttons[i] == "undo")
                {
                  Button buttonUndo = new Button();
                  buttonUndo.FlatStyle = FlatStyle.Flat;
                  buttonUndo.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\undo.png");
                  buttonUndo.Size = new System.Drawing.Size(51, 51);
                  buttonUndo.FlatAppearance.BorderSize = 0;
                  buttonUndo.Name = "buttonundo" + idtab;
                  if (panelMenu.Controls.Count == 0)
                  {
                    buttonUndo.Location = new System.Drawing.Point(0, 0);
                  }
                  else
                  {
                    Control lastControl = panelMenu.Controls[panelMenu.Controls.Count - 1];
                    buttonUndo.Left = lastControl.Location.X + lastControl.Width + 10;
                  }
                  panelMenu.Controls.Add(buttonUndo);
                }
                if (menubuttons[i] == "save")
                {
                  Button buttonSave = new Button();
                  buttonSave.FlatStyle = FlatStyle.Flat;
                  buttonSave.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\save.png");
                  buttonSave.Size = new System.Drawing.Size(51, 51);
                  buttonSave.FlatAppearance.BorderSize = 0;
                  buttonSave.Name = "buttonsave" + idtab;
                  if (panelMenu.Controls.Count == 0)
                  {
                    buttonSave.Location = new System.Drawing.Point(0, 0);
                  }
                  else
                  {
                    Control lastControl = panelMenu.Controls[panelMenu.Controls.Count - 1];
                    buttonSave.Left = lastControl.Location.X + lastControl.Width + 10;
                  }
                  panelMenu.Controls.Add(buttonSave);
                }
                if (menubuttons[i] == "upload")
                {
                  Button buttonUpload = new Button();
                  buttonUpload.FlatStyle = FlatStyle.Flat;
                  buttonUpload.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\upload.png");
                  buttonUpload.Size = new System.Drawing.Size(51, 51);
                  buttonUpload.FlatAppearance.BorderSize = 0;
                  buttonUpload.Name = "buttonupload" + idtab;
                  if (panelMenu.Controls.Count == 0)
                  {
                    buttonUpload.Location = new System.Drawing.Point(0, 0);
                  }
                  else
                  {
                    Control lastControl = panelMenu.Controls[panelMenu.Controls.Count - 1];
                    buttonUpload.Left = lastControl.Location.X + lastControl.Width + 10;
                  }
                  panelMenu.Controls.Add(buttonUpload);
                }
              }
              if (mymenu.IsDownload == "1")
              {
                if (menubuttons[i] == "pdf")
                {
                  Button buttonPdf = new Button();
                  buttonPdf.FlatStyle = FlatStyle.Flat;
                  buttonPdf.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\pdf.png");
                  buttonPdf.Size = new System.Drawing.Size(51, 51);
                  buttonPdf.FlatAppearance.BorderSize = 0;
                  buttonPdf.Name = "buttonpdf" + idtab;
                  if (panelMenu.Controls.Count == 0)
                  {
                    buttonPdf.Location = new System.Drawing.Point(0, 0);
                  }
                  else
                  {
                    Control lastControl = panelMenu.Controls[panelMenu.Controls.Count - 1];
                    buttonPdf.Left = lastControl.Location.X + lastControl.Width + 10;
                  }
                  panelMenu.Controls.Add(buttonPdf);
                }
                if (menubuttons[i] == "xls")
                {
                  Button buttonXls = new Button();
                  buttonXls.FlatStyle = FlatStyle.Flat;
                  buttonXls.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\xls.png");
                  buttonXls.Size = new System.Drawing.Size(51, 51);
                  buttonXls.FlatAppearance.BorderSize = 0;
                  buttonXls.Name = "buttonxls" + idtab;
                  if (panelMenu.Controls.Count == 0)
                  {
                    buttonXls.Location = new System.Drawing.Point(0, 0);
                  }
                  else
                  {
                    Control lastControl = panelMenu.Controls[panelMenu.Controls.Count - 1];
                    buttonXls.Left = lastControl.Location.X + lastControl.Width + 10;
                  }
                  panelMenu.Controls.Add(buttonXls);
                }
              }
              if (mymenu.IsRead == "1")
              {
                if (menubuttons[i] == "search")
                {
                  Button buttonSearch = new Button();
                  buttonSearch.FlatStyle = FlatStyle.Flat;
                  buttonSearch.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\search.png");
                  buttonSearch.Size = new System.Drawing.Size(51, 51);
                  buttonSearch.FlatAppearance.BorderSize = 0;
                  buttonSearch.Name = "buttonsearch" + idtab;
                  buttonSearch.Click += new EventHandler(this.ButtonSearchClick);
                  if (panelMenu.Controls.Count == 0)
                  {
                    buttonSearch.Location = new System.Drawing.Point(0, 0);
                  }
                  else
                  {
                    Control lastControl = panelMenu.Controls[panelMenu.Controls.Count - 1];
                    buttonSearch.Left = lastControl.Location.X + lastControl.Width + 10;
                  }
                  panelMenu.Controls.Add(buttonSearch);
                }
              }
              if (mymenu.IsPurge == "1")
              {
                if (menubuttons[i] == "purge")
                {
                  Button buttonPurge = new Button();
                  buttonPurge.FlatStyle = FlatStyle.Flat;
                  buttonPurge.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\purge.png");
                  buttonPurge.Size = new System.Drawing.Size(51, 51);
                  buttonPurge.FlatAppearance.BorderSize = 0;
                  buttonPurge.Name = "buttonpurge" + idtab;
                  if (panelMenu.Controls.Count == 0)
                  {
                    buttonPurge.Location = new System.Drawing.Point(0, 0);
                  }
                  else
                  {
                    Control lastControl = panelMenu.Controls[panelMenu.Controls.Count - 1];
                    buttonPurge.Left = lastControl.Location.X + lastControl.Width + 10;
                  }
                  panelMenu.Controls.Add(buttonPurge);
                }
                if (menubuttons[i] == "history")
                {
                  Button buttonHistory = new Button();
                  buttonHistory.FlatStyle = FlatStyle.Flat;
                  buttonHistory.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\history.png");
                  buttonHistory.Size = new System.Drawing.Size(51, 51);
                  buttonHistory.FlatAppearance.BorderSize = 0;
                  buttonHistory.Name = "buttonhistory" + idtab;
                  if (panelMenu.Controls.Count == 0)
                  {
                    buttonHistory.Location = new System.Drawing.Point(0, 0);
                  }
                  else
                  {
                    Control lastControl = panelMenu.Controls[panelMenu.Controls.Count - 1];
                    buttonHistory.Left = lastControl.Location.X + lastControl.Width + 10;
                  }
                  panelMenu.Controls.Add(buttonHistory);
                }
              }
            }

            tabPageAdv.Controls.Add(panelMenu);

            GradientPanel panelPager = new GradientPanel();
            panelPager.Dock = DockStyle.Bottom;
            panelPager.Name = "panelpager" + idtab;
            panelPager.Size = new Size(718, 60);
            tabPageAdv.Controls.Add(panelPager);

            Button buttonLast = new Button();
            buttonLast.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\last.png");
            buttonLast.Location = new Point(0, 0);
            buttonLast.Dock = DockStyle.Left;
            buttonLast.Size = new Size(50, 50);
            buttonLast.FlatStyle = FlatStyle.Flat;
            buttonLast.FlatAppearance.BorderSize = 0;
            buttonLast.Name = "buttonlast" + idtab;
            panelPager.Controls.Add(buttonLast);

            Button buttonNext = new Button();
            buttonNext.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\next.png");
            buttonNext.Location = new Point(0, 0);
            buttonNext.Dock = DockStyle.Left;
            buttonNext.Size = new Size(50, 50);
            buttonNext.FlatStyle = FlatStyle.Flat;
            buttonNext.FlatAppearance.BorderSize = 0;
            buttonNext.Name = "buttonnext" + idtab;
            panelPager.Controls.Add(buttonNext);

            Button buttonPrev = new Button();
            buttonPrev.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\previous.png");
            buttonPrev.Dock = DockStyle.Left;
            buttonPrev.Size = new Size(50, 50);
            buttonPrev.FlatStyle = FlatStyle.Flat;
            buttonPrev.FlatAppearance.BorderSize = 0;
            buttonPrev.Name = "buttonprev" + idtab;
            panelPager.Controls.Add(buttonPrev);

            Button buttonFirst = new Button();
            buttonFirst.Image = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icons\\first.png");
            buttonFirst.Location = new Point(0, 0);
            buttonFirst.Dock = DockStyle.Left;
            buttonFirst.Size = new Size(50, 50);
            buttonFirst.FlatStyle = FlatStyle.Flat;
            buttonFirst.FlatAppearance.BorderSize = 0;
            buttonFirst.Name = "buttonfirst" + idtab;
            panelPager.Controls.Add(buttonFirst);

            MainFormTabControl.TabPages.Add(tabPageAdv);

            RequestData.Clear();
            RequestData.Append("token=" + MyUser.AuthKey);
            FillGrid(dataTable, menuCodeResponse, new StringBuilder(), 1, 10);
          }
          catch (Exception ex)
          {
            MessageForm.ShowForm("Error: " + ex.Message, MessageBoxIcon.Error);
          }
          MainFormTabControl.SelectedTab = tabPageAdv;
        }
      }
    }
  }
}
