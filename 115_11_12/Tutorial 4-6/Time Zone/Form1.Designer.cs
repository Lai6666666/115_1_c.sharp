namespace Time_Zone
{
    partial class Form1
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.cityListBox = new System.Windows.Forms.ListBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.timeZoneLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.ADDbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(20, 20);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(596, 46);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "選擇城市，我會告訴您所在的時區。";
            // 
            // cityListBox
            // 
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.ItemHeight = 46;
            this.cityListBox.Items.AddRange(new object[] {
            "丹佛",
            "檀香山",
            "明尼阿波利斯",
            "紐約",
            "舊金山"});
            this.cityListBox.Location = new System.Drawing.Point(20, 69);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(470, 234);
            this.cityListBox.TabIndex = 1;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(12, 307);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(128, 46);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "時區：";
            // 
            // timeZoneLabel
            // 
            this.timeZoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeZoneLabel.Location = new System.Drawing.Point(125, 307);
            this.timeZoneLabel.Name = "timeZoneLabel";
            this.timeZoneLabel.Size = new System.Drawing.Size(365, 45);
            this.timeZoneLabel.TabIndex = 3;
            this.timeZoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeZoneLabel.Click += new System.EventHandler(this.timeZoneLabel_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(125, 397);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(150, 50);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "確定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(303, 397);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 50);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(303, 502);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(150, 50);
            this.clearbutton.TabIndex = 6;
            this.clearbutton.Text = "清除";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // ADDbutton
            // 
            this.ADDbutton.Location = new System.Drawing.Point(125, 502);
            this.ADDbutton.Name = "ADDbutton";
            this.ADDbutton.Size = new System.Drawing.Size(150, 50);
            this.ADDbutton.TabIndex = 7;
            this.ADDbutton.Text = "加入";
            this.ADDbutton.UseVisualStyleBackColor = true;
            this.ADDbutton.Click += new System.EventHandler(this.ADDbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 879);
            this.Controls.Add(this.ADDbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.timeZoneLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.cityListBox);
            this.Controls.Add(this.promptLabel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "時區";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.ListBox cityListBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label timeZoneLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button ADDbutton;
    }
}

