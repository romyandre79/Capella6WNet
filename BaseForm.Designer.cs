namespace Capella6WNet
{
    partial class BaseForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
      this.CapellaNotifIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.SuspendLayout();
      // 
      // CapellaNotifIcon
      // 
      this.CapellaNotifIcon.Visible = true;
      // 
      // BaseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "BaseForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Activated += new System.EventHandler(this.FormActivated);
      this.Load += new System.EventHandler(this.FormLoad);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon CapellaNotifIcon;
    }
}

