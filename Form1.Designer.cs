namespace SettingEditor
{
	partial class SettingEditor
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingEditor));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.openFileButton = new System.Windows.Forms.Button();
			this.botPathLabel = new System.Windows.Forms.Label();
			this.botPathBox = new System.Windows.Forms.TextBox();
			this.guildIdBox = new System.Windows.Forms.NumericUpDown();
			this.tokenBox = new System.Windows.Forms.TextBox();
			this.guildIdLabel = new System.Windows.Forms.Label();
			this.tokenLabel = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.notificationLabel = new System.Windows.Forms.Label();
			this.notificationSecondBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.isAutomaticExtensionButton = new System.Windows.Forms.CheckBox();
			this.setButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.automaticExtensionSecondBox = new System.Windows.Forms.NumericUpDown();
			this.automaticExtensionMinuteBox = new System.Windows.Forms.NumericUpDown();
			this.automaticExtensionTimeLabel = new System.Windows.Forms.Label();
			this.gotiEmojiIdBox = new System.Windows.Forms.TextBox();
			this.gotiEmojiIdLabel = new System.Windows.Forms.Label();
			this.timeOutMessageBox = new System.Windows.Forms.TextBox();
			this.okawariEmojiIdBox = new System.Windows.Forms.TextBox();
			this.votingTimeLimitSecondBox = new System.Windows.Forms.NumericUpDown();
			this.votingTimeLimitSecondLabel = new System.Windows.Forms.Label();
			this.okawariEmojiIdLabel = new System.Windows.Forms.Label();
			this.timeOutMessageLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guildIdBox)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.automaticExtensionSecondBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.automaticExtensionMinuteBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.votingTimeLimitSecondBox)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Controls.Add(this.openFileButton);
			this.groupBox1.Controls.Add(this.botPathLabel);
			this.groupBox1.Controls.Add(this.botPathBox);
			this.groupBox1.Controls.Add(this.guildIdBox);
			this.groupBox1.Controls.Add(this.tokenBox);
			this.groupBox1.Controls.Add(this.guildIdLabel);
			this.groupBox1.Controls.Add(this.tokenLabel);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// openFileButton
			// 
			resources.ApplyResources(this.openFileButton, "openFileButton");
			this.openFileButton.Name = "openFileButton";
			this.openFileButton.UseVisualStyleBackColor = true;
			this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
			// 
			// botPathLabel
			// 
			resources.ApplyResources(this.botPathLabel, "botPathLabel");
			this.botPathLabel.Name = "botPathLabel";
			// 
			// botPathBox
			// 
			resources.ApplyResources(this.botPathBox, "botPathBox");
			this.botPathBox.Name = "botPathBox";
			// 
			// guildIdBox
			// 
			resources.ApplyResources(this.guildIdBox, "guildIdBox");
			this.guildIdBox.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
			this.guildIdBox.Name = "guildIdBox";
			// 
			// tokenBox
			// 
			resources.ApplyResources(this.tokenBox, "tokenBox");
			this.tokenBox.Name = "tokenBox";
			// 
			// guildIdLabel
			// 
			resources.ApplyResources(this.guildIdLabel, "guildIdLabel");
			this.guildIdLabel.Name = "guildIdLabel";
			// 
			// tokenLabel
			// 
			resources.ApplyResources(this.tokenLabel, "tokenLabel");
			this.tokenLabel.Name = "tokenLabel";
			// 
			// groupBox2
			// 
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.notificationLabel);
			this.groupBox2.Controls.Add(this.notificationSecondBox);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.isAutomaticExtensionButton);
			this.groupBox2.Controls.Add(this.setButton);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.automaticExtensionSecondBox);
			this.groupBox2.Controls.Add(this.automaticExtensionMinuteBox);
			this.groupBox2.Controls.Add(this.automaticExtensionTimeLabel);
			this.groupBox2.Controls.Add(this.gotiEmojiIdBox);
			this.groupBox2.Controls.Add(this.gotiEmojiIdLabel);
			this.groupBox2.Controls.Add(this.timeOutMessageBox);
			this.groupBox2.Controls.Add(this.okawariEmojiIdBox);
			this.groupBox2.Controls.Add(this.votingTimeLimitSecondBox);
			this.groupBox2.Controls.Add(this.votingTimeLimitSecondLabel);
			this.groupBox2.Controls.Add(this.okawariEmojiIdLabel);
			this.groupBox2.Controls.Add(this.timeOutMessageLabel);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// notificationLabel
			// 
			resources.ApplyResources(this.notificationLabel, "notificationLabel");
			this.notificationLabel.Name = "notificationLabel";
			// 
			// notificationSecondBox
			// 
			resources.ApplyResources(this.notificationSecondBox, "notificationSecondBox");
			this.notificationSecondBox.Name = "notificationSecondBox";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// isAutomaticExtensionButton
			// 
			resources.ApplyResources(this.isAutomaticExtensionButton, "isAutomaticExtensionButton");
			this.isAutomaticExtensionButton.Name = "isAutomaticExtensionButton";
			this.isAutomaticExtensionButton.UseVisualStyleBackColor = true;
			// 
			// setButton
			// 
			resources.ApplyResources(this.setButton, "setButton");
			this.setButton.Name = "setButton";
			this.setButton.UseVisualStyleBackColor = true;
			this.setButton.Click += new System.EventHandler(this.setButton_Click);
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// automaticExtensionSecondBox
			// 
			resources.ApplyResources(this.automaticExtensionSecondBox, "automaticExtensionSecondBox");
			this.automaticExtensionSecondBox.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.automaticExtensionSecondBox.Name = "automaticExtensionSecondBox";
			// 
			// automaticExtensionMinuteBox
			// 
			resources.ApplyResources(this.automaticExtensionMinuteBox, "automaticExtensionMinuteBox");
			this.automaticExtensionMinuteBox.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
			this.automaticExtensionMinuteBox.Name = "automaticExtensionMinuteBox";
			this.automaticExtensionMinuteBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// automaticExtensionTimeLabel
			// 
			resources.ApplyResources(this.automaticExtensionTimeLabel, "automaticExtensionTimeLabel");
			this.automaticExtensionTimeLabel.Name = "automaticExtensionTimeLabel";
			// 
			// gotiEmojiIdBox
			// 
			resources.ApplyResources(this.gotiEmojiIdBox, "gotiEmojiIdBox");
			this.gotiEmojiIdBox.Name = "gotiEmojiIdBox";
			// 
			// gotiEmojiIdLabel
			// 
			resources.ApplyResources(this.gotiEmojiIdLabel, "gotiEmojiIdLabel");
			this.gotiEmojiIdLabel.Name = "gotiEmojiIdLabel";
			// 
			// timeOutMessageBox
			// 
			resources.ApplyResources(this.timeOutMessageBox, "timeOutMessageBox");
			this.timeOutMessageBox.Name = "timeOutMessageBox";
			// 
			// okawariEmojiIdBox
			// 
			resources.ApplyResources(this.okawariEmojiIdBox, "okawariEmojiIdBox");
			this.okawariEmojiIdBox.Name = "okawariEmojiIdBox";
			// 
			// votingTimeLimitSecondBox
			// 
			resources.ApplyResources(this.votingTimeLimitSecondBox, "votingTimeLimitSecondBox");
			this.votingTimeLimitSecondBox.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
			this.votingTimeLimitSecondBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.votingTimeLimitSecondBox.Name = "votingTimeLimitSecondBox";
			this.votingTimeLimitSecondBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// votingTimeLimitSecondLabel
			// 
			resources.ApplyResources(this.votingTimeLimitSecondLabel, "votingTimeLimitSecondLabel");
			this.votingTimeLimitSecondLabel.Name = "votingTimeLimitSecondLabel";
			// 
			// okawariEmojiIdLabel
			// 
			resources.ApplyResources(this.okawariEmojiIdLabel, "okawariEmojiIdLabel");
			this.okawariEmojiIdLabel.Name = "okawariEmojiIdLabel";
			// 
			// timeOutMessageLabel
			// 
			resources.ApplyResources(this.timeOutMessageLabel, "timeOutMessageLabel");
			this.timeOutMessageLabel.Name = "timeOutMessageLabel";
			// 
			// SettingEditor
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingEditor";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guildIdBox)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.automaticExtensionSecondBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.automaticExtensionMinuteBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.votingTimeLimitSecondBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupBox1;
		private Label guildIdLabel;
		private Label tokenLabel;
		private GroupBox groupBox2;
		private Label okawariEmojiIdLabel;
		private Label timeOutMessageLabel;
		private Label votingTimeLimitSecondLabel;
		private NumericUpDown votingTimeLimitSecondBox;
		private NumericUpDown guildIdBox;
		private TextBox tokenBox;
		private Label label4;
		private Label label3;
		private NumericUpDown automaticExtensionSecondBox;
		private NumericUpDown automaticExtensionMinuteBox;
		private Label automaticExtensionTimeLabel;
		private TextBox gotiEmojiIdBox;
		private Label gotiEmojiIdLabel;
		private TextBox timeOutMessageBox;
		private TextBox okawariEmojiIdBox;
		private Button setButton;
		private CheckBox isAutomaticExtensionButton;
		private Button openFileButton;
		private Label botPathLabel;
		private TextBox botPathBox;
		private Label label1;
		private Label notificationLabel;
		private TextBox notificationSecondBox;
		private Label label5;
	}
}