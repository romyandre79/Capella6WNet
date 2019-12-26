namespace Capella6WNet
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.LabelText = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.ButtonClose = new System.Windows.Forms.Button();
      this.MainFormTreeView = new System.Windows.Forms.TreeView();
      this.MainFormTabControl = new System.Windows.Forms.TabControl();
      this.TabPageHome = new System.Windows.Forms.TabPage();
      this.ButtonSubmit = new System.Windows.Forms.Button();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.LabelTheme = new System.Windows.Forms.Label();
      this.EditLanguage = new System.Windows.Forms.ComboBox();
      this.LabelLanguage = new System.Windows.Forms.Label();
      this.EditPhoneNo = new System.Windows.Forms.TextBox();
      this.LabelPhoneNo = new System.Windows.Forms.Label();
      this.EditEmail = new System.Windows.Forms.TextBox();
      this.LabelEmail = new System.Windows.Forms.Label();
      this.EditRealName = new System.Windows.Forms.TextBox();
      this.LabelRealName = new System.Windows.Forms.Label();
      this.EditPassword = new System.Windows.Forms.TextBox();
      this.LabelPassword = new System.Windows.Forms.Label();
      this.EditUserName = new System.Windows.Forms.TextBox();
      this.LabelUserName = new System.Windows.Forms.Label();
      this.ImageListButton = new System.Windows.Forms.ImageList(this.components);
      this.ImageListMenu = new System.Windows.Forms.ImageList(this.components);
      this.panel1.SuspendLayout();
      this.MainFormTabControl.SuspendLayout();
      this.TabPageHome.SuspendLayout();
      this.SuspendLayout();
      // 
      // LabelText
      // 
      this.LabelText.Dock = System.Windows.Forms.DockStyle.Top;
      this.LabelText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.LabelText.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LabelText.Location = new System.Drawing.Point(0, 0);
      this.LabelText.Name = "LabelText";
      this.LabelText.Size = new System.Drawing.Size(996, 52);
      this.LabelText.TabIndex = 1;
      this.LabelText.Text = "Capella ERP Indonesia";
      this.LabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ButtonClose);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 52);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(996, 58);
      this.panel1.TabIndex = 2;
      // 
      // ButtonClose
      // 
      this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonClose.Location = new System.Drawing.Point(12, 3);
      this.ButtonClose.Name = "ButtonClose";
      this.ButtonClose.Size = new System.Drawing.Size(105, 49);
      this.ButtonClose.TabIndex = 7;
      this.ButtonClose.Text = "&Close";
      this.ButtonClose.UseVisualStyleBackColor = true;
      this.ButtonClose.Click += new System.EventHandler(this.ButtonCloseClick);
      // 
      // MainFormTreeView
      // 
      this.MainFormTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.MainFormTreeView.Dock = System.Windows.Forms.DockStyle.Left;
      this.MainFormTreeView.Location = new System.Drawing.Point(0, 110);
      this.MainFormTreeView.Name = "MainFormTreeView";
      this.MainFormTreeView.Size = new System.Drawing.Size(278, 436);
      this.MainFormTreeView.TabIndex = 3;
      // 
      // MainFormTabControl
      // 
      this.MainFormTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
      this.MainFormTabControl.Controls.Add(this.TabPageHome);
      this.MainFormTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainFormTabControl.Location = new System.Drawing.Point(278, 110);
      this.MainFormTabControl.Multiline = true;
      this.MainFormTabControl.Name = "MainFormTabControl";
      this.MainFormTabControl.SelectedIndex = 0;
      this.MainFormTabControl.Size = new System.Drawing.Size(718, 436);
      this.MainFormTabControl.TabIndex = 4;
      // 
      // TabPageHome
      // 
      this.TabPageHome.BackColor = System.Drawing.Color.White;
      this.TabPageHome.Controls.Add(this.ButtonSubmit);
      this.TabPageHome.Controls.Add(this.comboBox1);
      this.TabPageHome.Controls.Add(this.LabelTheme);
      this.TabPageHome.Controls.Add(this.EditLanguage);
      this.TabPageHome.Controls.Add(this.LabelLanguage);
      this.TabPageHome.Controls.Add(this.EditPhoneNo);
      this.TabPageHome.Controls.Add(this.LabelPhoneNo);
      this.TabPageHome.Controls.Add(this.EditEmail);
      this.TabPageHome.Controls.Add(this.LabelEmail);
      this.TabPageHome.Controls.Add(this.EditRealName);
      this.TabPageHome.Controls.Add(this.LabelRealName);
      this.TabPageHome.Controls.Add(this.EditPassword);
      this.TabPageHome.Controls.Add(this.LabelPassword);
      this.TabPageHome.Controls.Add(this.EditUserName);
      this.TabPageHome.Controls.Add(this.LabelUserName);
      this.TabPageHome.Location = new System.Drawing.Point(4, 25);
      this.TabPageHome.Name = "TabPageHome";
      this.TabPageHome.Padding = new System.Windows.Forms.Padding(3);
      this.TabPageHome.Size = new System.Drawing.Size(710, 407);
      this.TabPageHome.TabIndex = 0;
      this.TabPageHome.Text = "Home";
      // 
      // ButtonSubmit
      // 
      this.ButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonSubmit.Location = new System.Drawing.Point(271, 279);
      this.ButtonSubmit.Name = "ButtonSubmit";
      this.ButtonSubmit.Size = new System.Drawing.Size(105, 49);
      this.ButtonSubmit.TabIndex = 17;
      this.ButtonSubmit.Text = "&Submit";
      this.ButtonSubmit.UseVisualStyleBackColor = true;
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(140, 231);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(236, 27);
      this.comboBox1.TabIndex = 16;
      // 
      // LabelTheme
      // 
      this.LabelTheme.AutoSize = true;
      this.LabelTheme.Location = new System.Drawing.Point(37, 234);
      this.LabelTheme.Name = "LabelTheme";
      this.LabelTheme.Size = new System.Drawing.Size(35, 13);
      this.LabelTheme.TabIndex = 15;
      this.LabelTheme.Text = "label1";
      // 
      // EditLanguage
      // 
      this.EditLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.EditLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.EditLanguage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditLanguage.FormattingEnabled = true;
      this.EditLanguage.Location = new System.Drawing.Point(140, 198);
      this.EditLanguage.Name = "EditLanguage";
      this.EditLanguage.Size = new System.Drawing.Size(236, 27);
      this.EditLanguage.TabIndex = 14;
      // 
      // LabelLanguage
      // 
      this.LabelLanguage.AutoSize = true;
      this.LabelLanguage.Location = new System.Drawing.Point(37, 201);
      this.LabelLanguage.Name = "LabelLanguage";
      this.LabelLanguage.Size = new System.Drawing.Size(35, 13);
      this.LabelLanguage.TabIndex = 13;
      this.LabelLanguage.Text = "label1";
      // 
      // EditPhoneNo
      // 
      this.EditPhoneNo.AcceptsTab = true;
      this.EditPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditPhoneNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditPhoneNo.Location = new System.Drawing.Point(140, 157);
      this.EditPhoneNo.Name = "EditPhoneNo";
      this.EditPhoneNo.PasswordChar = 'X';
      this.EditPhoneNo.Size = new System.Drawing.Size(236, 27);
      this.EditPhoneNo.TabIndex = 12;
      // 
      // LabelPhoneNo
      // 
      this.LabelPhoneNo.AutoSize = true;
      this.LabelPhoneNo.Location = new System.Drawing.Point(37, 164);
      this.LabelPhoneNo.Name = "LabelPhoneNo";
      this.LabelPhoneNo.Size = new System.Drawing.Size(35, 13);
      this.LabelPhoneNo.TabIndex = 11;
      this.LabelPhoneNo.Text = "label1";
      // 
      // EditEmail
      // 
      this.EditEmail.AcceptsTab = true;
      this.EditEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditEmail.Location = new System.Drawing.Point(140, 124);
      this.EditEmail.Name = "EditEmail";
      this.EditEmail.PasswordChar = 'X';
      this.EditEmail.Size = new System.Drawing.Size(236, 27);
      this.EditEmail.TabIndex = 10;
      // 
      // LabelEmail
      // 
      this.LabelEmail.AutoSize = true;
      this.LabelEmail.Location = new System.Drawing.Point(37, 131);
      this.LabelEmail.Name = "LabelEmail";
      this.LabelEmail.Size = new System.Drawing.Size(35, 13);
      this.LabelEmail.TabIndex = 9;
      this.LabelEmail.Text = "label1";
      // 
      // EditRealName
      // 
      this.EditRealName.AcceptsTab = true;
      this.EditRealName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditRealName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditRealName.Location = new System.Drawing.Point(140, 91);
      this.EditRealName.Name = "EditRealName";
      this.EditRealName.PasswordChar = 'X';
      this.EditRealName.Size = new System.Drawing.Size(236, 27);
      this.EditRealName.TabIndex = 8;
      // 
      // LabelRealName
      // 
      this.LabelRealName.AutoSize = true;
      this.LabelRealName.Location = new System.Drawing.Point(37, 98);
      this.LabelRealName.Name = "LabelRealName";
      this.LabelRealName.Size = new System.Drawing.Size(35, 13);
      this.LabelRealName.TabIndex = 7;
      this.LabelRealName.Text = "label1";
      // 
      // EditPassword
      // 
      this.EditPassword.AcceptsTab = true;
      this.EditPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditPassword.Location = new System.Drawing.Point(140, 58);
      this.EditPassword.Name = "EditPassword";
      this.EditPassword.PasswordChar = 'X';
      this.EditPassword.Size = new System.Drawing.Size(236, 27);
      this.EditPassword.TabIndex = 6;
      // 
      // LabelPassword
      // 
      this.LabelPassword.AutoSize = true;
      this.LabelPassword.Location = new System.Drawing.Point(37, 65);
      this.LabelPassword.Name = "LabelPassword";
      this.LabelPassword.Size = new System.Drawing.Size(35, 13);
      this.LabelPassword.TabIndex = 5;
      this.LabelPassword.Text = "label1";
      // 
      // EditUserName
      // 
      this.EditUserName.AcceptsTab = true;
      this.EditUserName.BackColor = System.Drawing.Color.White;
      this.EditUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditUserName.Location = new System.Drawing.Point(140, 25);
      this.EditUserName.Name = "EditUserName";
      this.EditUserName.ReadOnly = true;
      this.EditUserName.Size = new System.Drawing.Size(236, 27);
      this.EditUserName.TabIndex = 4;
      // 
      // LabelUserName
      // 
      this.LabelUserName.AutoSize = true;
      this.LabelUserName.Location = new System.Drawing.Point(37, 32);
      this.LabelUserName.Name = "LabelUserName";
      this.LabelUserName.Size = new System.Drawing.Size(35, 13);
      this.LabelUserName.TabIndex = 0;
      this.LabelUserName.Text = "label1";
      // 
      // ImageListButton
      // 
      this.ImageListButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.ImageListButton.ImageSize = new System.Drawing.Size(16, 16);
      this.ImageListButton.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // ImageListMenu
      // 
      this.ImageListMenu.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
      this.ImageListMenu.ImageSize = new System.Drawing.Size(16, 16);
      this.ImageListMenu.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(996, 546);
      this.ControlBox = false;
      this.Controls.Add(this.MainFormTabControl);
      this.Controls.Add(this.MainFormTreeView);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.LabelText);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.MainFormLoad);
      this.panel1.ResumeLayout(false);
      this.MainFormTabControl.ResumeLayout(false);
      this.TabPageHome.ResumeLayout(false);
      this.TabPageHome.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.TreeView MainFormTreeView;
        private System.Windows.Forms.TabControl MainFormTabControl;
        private System.Windows.Forms.TabPage TabPageHome;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.TextBox EditUserName;
        private System.Windows.Forms.TextBox EditPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox EditPhoneNo;
        private System.Windows.Forms.Label LabelPhoneNo;
        private System.Windows.Forms.TextBox EditEmail;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox EditRealName;
        private System.Windows.Forms.Label LabelRealName;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelTheme;
        private System.Windows.Forms.ComboBox EditLanguage;
        private System.Windows.Forms.Label LabelLanguage;
        private System.Windows.Forms.ImageList ImageListButton;
        private System.Windows.Forms.ImageList ImageListMenu;
    }
}
