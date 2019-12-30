namespace Capella6WNet
{
  partial class MessageForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
      this.PictureBoxMessageForm = new System.Windows.Forms.PictureBox();
      this.LabelMessage = new System.Windows.Forms.Label();
      this.ButtonClose = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMessageForm)).BeginInit();
      this.SuspendLayout();
      // 
      // PictureBoxMessageForm
      // 
      this.PictureBoxMessageForm.BackColor = System.Drawing.Color.Transparent;
      this.PictureBoxMessageForm.Location = new System.Drawing.Point(12, 12);
      this.PictureBoxMessageForm.Name = "PictureBoxMessageForm";
      this.PictureBoxMessageForm.Size = new System.Drawing.Size(169, 277);
      this.PictureBoxMessageForm.TabIndex = 0;
      this.PictureBoxMessageForm.TabStop = false;
      // 
      // LabelMessage
      // 
      this.LabelMessage.BackColor = System.Drawing.Color.Transparent;
      this.LabelMessage.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LabelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.LabelMessage.Location = new System.Drawing.Point(207, 13);
      this.LabelMessage.Name = "LabelMessage";
      this.LabelMessage.Size = new System.Drawing.Size(673, 276);
      this.LabelMessage.TabIndex = 1;
      this.LabelMessage.Text = "label1";
      // 
      // ButtonClose
      // 
      this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
      this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ButtonClose.FlatAppearance.BorderSize = 0;
      this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("ButtonClose.Image")));
      this.ButtonClose.Location = new System.Drawing.Point(772, 292);
      this.ButtonClose.Name = "ButtonClose";
      this.ButtonClose.Size = new System.Drawing.Size(108, 53);
      this.ButtonClose.TabIndex = 2;
      this.ButtonClose.UseVisualStyleBackColor = false;
      this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
      // 
      // MessageForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.BackgroundImage = global::Capella6WNet.Properties.Resources.Andromeda_Galaxy;
      this.ClientSize = new System.Drawing.Size(892, 357);
      this.Controls.Add(this.ButtonClose);
      this.Controls.Add(this.LabelMessage);
      this.Controls.Add(this.PictureBoxMessageForm);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MessageForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MessageForm";
      this.Load += new System.EventHandler(this.MessageFormLoad);
      ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMessageForm)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxMessageForm;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Button ButtonClose;
    }
}