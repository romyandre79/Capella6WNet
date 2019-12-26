namespace Capella6WNet
{
  partial class LoginForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
      this.LabelText = new System.Windows.Forms.Label();
      this.LabelUserName = new System.Windows.Forms.Label();
      this.EditUserName = new System.Windows.Forms.TextBox();
      this.EditPassword = new System.Windows.Forms.TextBox();
      this.LabelPassword = new System.Windows.Forms.Label();
      this.ButtonLogin = new System.Windows.Forms.Button();
      this.ButtonClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // LabelText
      // 
      this.LabelText.Dock = System.Windows.Forms.DockStyle.Top;
      this.LabelText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.LabelText.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LabelText.Location = new System.Drawing.Point(0, 0);
      this.LabelText.Name = "LabelText";
      this.LabelText.Size = new System.Drawing.Size(993, 52);
      this.LabelText.TabIndex = 0;
      this.LabelText.Text = "Capella ERP Indonesia";
      this.LabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // LabelUserName
      // 
      this.LabelUserName.AutoSize = true;
      this.LabelUserName.BackColor = System.Drawing.Color.Transparent;
      this.LabelUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LabelUserName.Location = new System.Drawing.Point(488, 267);
      this.LabelUserName.Name = "LabelUserName";
      this.LabelUserName.Size = new System.Drawing.Size(51, 19);
      this.LabelUserName.TabIndex = 2;
      this.LabelUserName.Text = "label1";
      // 
      // EditUserName
      // 
      this.EditUserName.AcceptsTab = true;
      this.EditUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditUserName.Location = new System.Drawing.Point(617, 265);
      this.EditUserName.Name = "EditUserName";
      this.EditUserName.Size = new System.Drawing.Size(236, 27);
      this.EditUserName.TabIndex = 3;
      this.EditUserName.Text = "admin";
      // 
      // EditPassword
      // 
      this.EditPassword.AcceptsTab = true;
      this.EditPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EditPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditPassword.Location = new System.Drawing.Point(617, 298);
      this.EditPassword.Name = "EditPassword";
      this.EditPassword.PasswordChar = 'X';
      this.EditPassword.Size = new System.Drawing.Size(236, 27);
      this.EditPassword.TabIndex = 5;
      this.EditPassword.Text = "123456";
      // 
      // LabelPassword
      // 
      this.LabelPassword.AutoSize = true;
      this.LabelPassword.BackColor = System.Drawing.Color.Transparent;
      this.LabelPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LabelPassword.Location = new System.Drawing.Point(488, 300);
      this.LabelPassword.Name = "LabelPassword";
      this.LabelPassword.Size = new System.Drawing.Size(51, 19);
      this.LabelPassword.TabIndex = 4;
      this.LabelPassword.Text = "label1";
      // 
      // ButtonLogin
      // 
      this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonLogin.Location = new System.Drawing.Point(617, 349);
      this.ButtonLogin.Name = "ButtonLogin";
      this.ButtonLogin.Size = new System.Drawing.Size(107, 51);
      this.ButtonLogin.TabIndex = 6;
      this.ButtonLogin.Text = "&Login";
      this.ButtonLogin.UseVisualStyleBackColor = true;
      this.ButtonLogin.Click += new System.EventHandler(this.ButtonLoginClick);
      // 
      // ButtonClose
      // 
      this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonClose.Location = new System.Drawing.Point(746, 349);
      this.ButtonClose.Name = "ButtonClose";
      this.ButtonClose.Size = new System.Drawing.Size(107, 51);
      this.ButtonClose.TabIndex = 7;
      this.ButtonClose.Text = "&Close";
      this.ButtonClose.UseVisualStyleBackColor = true;
      this.ButtonClose.Click += new System.EventHandler(this.ButtonCloseClick);
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.BackColor = System.Drawing.Color.White;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(993, 524);
      this.Controls.Add(this.ButtonClose);
      this.Controls.Add(this.ButtonLogin);
      this.Controls.Add(this.EditPassword);
      this.Controls.Add(this.LabelPassword);
      this.Controls.Add(this.EditUserName);
      this.Controls.Add(this.LabelUserName);
      this.Controls.Add(this.LabelText);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "LoginForm";
      this.ShowInTaskbar = true;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Capella ERP - Login";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.LoginFormLoad);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.TextBox EditUserName;
        private System.Windows.Forms.TextBox EditPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonClose;
    }
}
