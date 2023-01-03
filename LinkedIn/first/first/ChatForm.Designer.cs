namespace first
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.messageWriteBox = new System.Windows.Forms.TextBox();
            this.sendButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.messageShowBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.enterButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chatlabel = new System.Windows.Forms.Label();
            this.chatlabel1 = new System.Windows.Forms.Label();
            this.backButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // messageWriteBox
            // 
            this.messageWriteBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageWriteBox.Location = new System.Drawing.Point(167, 118);
            this.messageWriteBox.Multiline = true;
            this.messageWriteBox.Name = "messageWriteBox";
            this.messageWriteBox.Size = new System.Drawing.Size(957, 46);
            this.messageWriteBox.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sendButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sendButton.Font = new System.Drawing.Font("Traditional Arabic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendButton.ForeColor = System.Drawing.Color.Black;
            this.sendButton.Location = new System.Drawing.Point(976, 221);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(219, 53);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send Message";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageShowBox
            // 
            this.messageShowBox.AllowDrop = true;
            this.messageShowBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageShowBox.Location = new System.Drawing.Point(157, 328);
            this.messageShowBox.Multiline = true;
            this.messageShowBox.Name = "messageShowBox";
            this.messageShowBox.ReadOnly = true;
            this.messageShowBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageShowBox.Size = new System.Drawing.Size(967, 290);
            this.messageShowBox.TabIndex = 2;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(157, 26);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(376, 31);
            this.emailBox.TabIndex = 3;
            // 
            // enterButton
            // 
            this.enterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.enterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.enterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.enterButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.enterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.enterButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.enterButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.enterButton.Font = new System.Drawing.Font("Traditional Arabic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterButton.ForeColor = System.Drawing.Color.Black;
            this.enterButton.Location = new System.Drawing.Point(629, 14);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(185, 43);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter";
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // chatlabel
            // 
            this.chatlabel.AutoSize = true;
            this.chatlabel.BackColor = System.Drawing.Color.Transparent;
            this.chatlabel.Font = new System.Drawing.Font("Traditional Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chatlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chatlabel.Location = new System.Drawing.Point(157, 291);
            this.chatlabel.Name = "chatlabel";
            this.chatlabel.Size = new System.Drawing.Size(228, 34);
            this.chatlabel.TabIndex = 5;
            this.chatlabel.Text = "You are chatting with";
            // 
            // chatlabel1
            // 
            this.chatlabel1.AutoSize = true;
            this.chatlabel1.BackColor = System.Drawing.Color.Transparent;
            this.chatlabel1.Font = new System.Drawing.Font("Traditional Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chatlabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chatlabel1.Location = new System.Drawing.Point(391, 291);
            this.chatlabel1.Name = "chatlabel1";
            this.chatlabel1.Size = new System.Drawing.Size(344, 34);
            this.chatlabel1.TabIndex = 6;
            this.chatlabel1.Text = "Please Enter Email of your Friend";
            // 
            // backButton
            // 
            this.backButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backButton.Font = new System.Drawing.Font("Traditional Arabic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(1130, 575);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(185, 43);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back To Profile";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1327, 635);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.chatlabel1);
            this.Controls.Add(this.chatlabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.messageShowBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageWriteBox);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox messageWriteBox;
        private Guna.UI2.WinForms.Guna2GradientButton sendButton;
        private TextBox messageShowBox;
        private TextBox emailBox;
        private Guna.UI2.WinForms.Guna2GradientButton enterButton;
        private Label chatlabel;
        private Label chatlabel1;
        private Guna.UI2.WinForms.Guna2GradientButton backButton;
    }
}