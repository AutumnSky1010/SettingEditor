using OkawariBot.Settings;
namespace SettingEditor;
public partial class SettingEditor : Form
{
	private Dictionary<TextBox, Label> _textBoxes;
	private SettingJson _settingJson;
	public SettingEditor()
	{
		InitializeComponent();
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
			this._settingJson = new SettingJson(jsonPath);
			this.SetValue($@"{Path.GetDirectoryName(jsonPath)}\OkawariBot.exe");
		}
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
			MessageBox.Show("ここにボット本体はありません。設定し直してください。");
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