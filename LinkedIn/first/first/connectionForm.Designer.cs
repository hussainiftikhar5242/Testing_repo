namespace first
{
    partial class connectionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connectionForm));
            this.emailBox = new System.Windows.Forms.TextBox();
            this.searchConnection = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.connectionGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.backButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.connectionGV)).BeginInit();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(447, 71);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(384, 35);
            this.emailBox.TabIndex = 0;
            // 
            // searchConnection
            // 
            this.searchConnection.BackColor = System.Drawing.Color.Transparent;
            this.searchConnection.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchConnection.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchConnection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchConnection.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchConnection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchConnection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchConnection.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchConnection.Font = new System.Drawing.Font("Traditional Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchConnection.ForeColor = System.Drawing.Color.White;
            this.searchConnection.Location = new System.Drawing.Point(929, 53);
            this.searchConnection.Name = "searchConnection";
            this.searchConnection.Size = new System.Drawing.Size(192, 53);
            this.searchConnection.TabIndex = 1;
            this.searchConnection.Text = "Search Connection ";
            this.searchConnection.Click += new System.EventHandler(this.searchConnection_Click);
            // 
            // connectionGV
            // 
            this.connectionGV.AllowDrop = true;
            this.connectionGV.AllowUserToAddRows = false;
            this.connectionGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.connectionGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.connectionGV.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Traditional Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.connectionGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.connectionGV.ColumnHeadersHeight = 4;
            this.connectionGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Traditional Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.connectionGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.connectionGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.connectionGV.Location = new System.Drawing.Point(388, 200);
            this.connectionGV.Name = "connectionGV";
            this.connectionGV.RowHeadersVisible = false;
            this.connectionGV.RowHeadersWidth = 62;
            this.connectionGV.RowTemplate.Height = 33;
            this.connectionGV.Size = new System.Drawing.Size(830, 372);
            this.connectionGV.TabIndex = 2;
            this.connectionGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.connectionGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.connectionGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.connectionGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.connectionGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.connectionGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.connectionGV.ThemeStyle.BackColor = System.Drawing.SystemColors.Window;
            this.connectionGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.connectionGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.connectionGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.connectionGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Traditional Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectionGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.connectionGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.connectionGV.ThemeStyle.HeaderStyle.Height = 4;
            this.connectionGV.ThemeStyle.ReadOnly = false;
            this.connectionGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.connectionGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.connectionGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Traditional Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectionGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.connectionGV.ThemeStyle.RowsStyle.Height = 33;
            this.connectionGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.connectionGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backButton.FillColor = System.Drawing.Color.Gray;
            this.backButton.Font = new System.Drawing.Font("Traditional Arabic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(1261, 564);
            this.backButton.Name = "backButton";
            this.backButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.backButton.Size = new System.Drawing.Size(239, 65);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back To Main Menu";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(385, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "All Conection Of Your Connection ";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.Color.Red;
            this.namelabel.Font = new System.Drawing.Font("Traditional Arabic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namelabel.ForeColor = System.Drawing.Color.White;
            this.namelabel.Location = new System.Drawing.Point(718, 165);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(345, 31);
            this.namelabel.TabIndex = 6;
            this.namelabel.Text = "Enter The Email Of youe Connection";
            // 
            // connectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1564, 722);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.connectionGV);
            this.Controls.Add(this.searchConnection);
            this.Controls.Add(this.emailBox);
            this.Font = new System.Drawing.Font("Traditional Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "connectionForm";
            this.Text = "connectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.connectionGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox emailBox;
        private Guna.UI2.WinForms.Guna2GradientTileButton searchConnection;
        private Guna.UI2.WinForms.Guna2DataGridView connectionGV;
        private Guna.UI2.WinForms.Guna2CircleButton backButton;
        private Label label2;
        private Label namelabel;
    }
}