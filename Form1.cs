using OkawariBot.Settings;
namespace SettingEditor;
public partial class SettingEditor : Form
{
	private Dictionary<TextBox, Label> _textBoxes;
	private SettingJson _settingJson;
	public SettingEditor()
	{
		this.InitializeComponent();
		this._textBoxes = new Dictionary<TextBox, Label>()
		{
			{ this.tokenBox, this.tokenLabel },
			{ this.timeOutMessageBox, this.timeOutMessageLabel },
			{ this.okawariEmojiIdBox, this.okawariEmojiIdLabel },
			{ this.gotiEmojiIdBox, this.gotiEmojiIdLabel },
			{ this.botPathBox, this.botPathLabel }
		};
		if (File.Exists("jsonPath.data"))
		{
			string jsonPath = File.ReadAllText("jsonPath.data");
			if (!File.Exists(jsonPath))
			{
				jsonPath = this.ResetJsonPath();
				if (string.IsNullOrEmpty(jsonPath)) { this.Close(); }
				return;
			}
			this._settingJson = new SettingJson(jsonPath);
			this.SetValue($@"{Path.GetDirectoryName(jsonPath)}\OkawariBot.exe");
		}
	}
	private string ResetJsonPath()
	{
		MessageBox.Show("おかわりbotの設定ファイルが見つかりませんでした。\n設定ファイルを選択してください。");
		var dialog = new OpenFileDialog() { Filter = "設定ファイル|settings.json" };
		DialogResult result = dialog.ShowDialog();
		if (!(result == DialogResult.OK))
		{
			return "";
		}
		if (!File.Exists(dialog.FileName))
		{
			this.ResetJsonPath();
		}
		return dialog.FileName;
	}
	private void SetValue(string botPath)
	{
		BotSetting botSetting = this._settingJson.Deserialize();
		this.tokenBox.Text = botSetting.Token;
		this.timeOutMessageBox.Text = botSetting.TimeOutMessage;
		this.okawariEmojiIdBox.Text = botSetting.okawariEmojiId;
		this.gotiEmojiIdBox.Text = botSetting.gotiEmojiId;
		this.guildIdBox.Value = botSetting.GuildId;
		this.votingTimeLimitSecondBox.Value = botSetting.VotingTimeLimitSecond;
		this.isAutomaticExtensionButton.Checked = botSetting.IsAutomaticExtension;
		this.automaticExtensionMinuteBox.Value = botSetting.AutomaticExtensionSecond / 60;
		this.automaticExtensionSecondBox.Value = botSetting.AutomaticExtensionSecond % 60;
		this.botPathBox.Text = botPath;
		if (botSetting.NotificationTimes.Count == 0)
		{
			this.notificationSecondBox.Text = "";
			return;
		}
		this.notificationSecondBox.Text = string.Join(',', botSetting.NotificationTimes);
	}
	private void setButton_Click(object sender, EventArgs e)
	{
		if ( !this.CanSave() ) { return; }

		this.Save();
		MessageBox.Show("設定しました。");
	}
	private bool CanSave()
	{
		foreach (KeyValuePair<TextBox, Label> pair in _textBoxes)
		{
			if (string.IsNullOrEmpty(pair.Key.Text))
			{
				MessageBox.Show($"設定されていない項目があります。場所：{pair.Value.Text}", "設定出来ません");
				return false;
			}
		}
		if (!File.Exists(this.botPathBox.Text))
		{
			MessageBox.Show("ここにbot本体はありません。設定し直してください。");
			return false;
		}
		if (!CSVSecond.IsAllInNumber(this.notificationSecondBox.Text) && this.notificationSecondBox.Text != "")
		{
			MessageBox.Show("通知する時間の書き方が違います。「秒,秒」のように通知したい時間の秒数をカンマ区切りで入力してください。");
			return false;
		}
		if (this.automaticExtensionSecondBox.Value + this.automaticExtensionMinuteBox.Value * 60 <= 0)
		{
			MessageBox.Show("自動延長の時間は一秒以上の値を指定してください。");
			return false;
		}
		return true;
	}
	private void Save()
	{
		var setting = new BotSetting()
		{
			Token = this.tokenBox.Text,
			TimeOutMessage = this.timeOutMessageBox.Text,
			AutomaticExtensionSecond = (int)(this.automaticExtensionMinuteBox.Value * 60 + this.automaticExtensionSecondBox.Value),
			IsAutomaticExtension = this.isAutomaticExtensionButton.Checked,
			GuildId = (ulong)this.guildIdBox.Value,
			gotiEmojiId = this.gotiEmojiIdBox.Text,
			okawariEmojiId = this.okawariEmojiIdBox.Text,
			VotingTimeLimitSecond = (int)this.votingTimeLimitSecondBox.Value,
		};
		if (this.notificationSecondBox.Text != "")
		{
			setting.NotificationTimes = CSVSecond.Parse(this.notificationSecondBox.Text);
		}
		string jsonPath = $@"{Path.GetDirectoryName(this.botPathBox.Text)}\settings.json";
		if (!File.Exists(jsonPath))
		{
			var file = File.Create(jsonPath);
			file.Close();
			file.Dispose();
		}
		this._settingJson = new SettingJson(jsonPath);
		this._settingJson.Serialize(setting);
		this.SaveJsonPath();
	}
	private void SaveJsonPath()
	{
		string? name = Path.GetDirectoryName(this.botPathBox.Text);
		File.WriteAllText("jsonPath.data", @$"{name}\settings.json");
	}

	private void openFileButton_Click(object sender, EventArgs e)
	{
		var dialog = new OpenFileDialog()
		{
			Filter = "OkawariBot.exe|OkawariBot.exe"
		};
		var result = dialog.ShowDialog();
		if (result == DialogResult.OK)
		{
			this.botPathBox.Text = dialog.FileName;
		}
	}
}