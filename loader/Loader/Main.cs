using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

// Token: 0x0200000F RID: 15
public partial class Main : Form
{
	// Token: 0x06000091 RID: 145 RVA: 0x00002351 File Offset: 0x00000551
	public Main()
	{
		this.set_HeadlineStartTranslate();
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002374 File Offset: 0x00000574
	private void get_Nameget_TradeBanStatecheckCommandMappings(object sender, EventArgs e)
	{
		Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
	}

	// Token: 0x06000093 RID: 147 RVA: 0x000069F0 File Offset: 0x00004BF0
	private void get_ClientsGetGroupget_Name(object sender, EventArgs e)
	{
		this.expiry.Text = "Expiry: " + this.ProcessInternalLogget_AllowedCallerAwake(long.Parse(Login.KeyAuthApp.user_data.subscriptions[<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=].expiry)).ToString();
		this.hwid.Text = "HWID: " + Login.KeyAuthApp.user_data.hwid;
		this.createDate.Text = "Creation date: " + this.ProcessInternalLogget_AllowedCallerAwake(long.Parse(Login.KeyAuthApp.user_data.createdate)).ToString();
		this.lastLogin.Text = "Last login: " + this.ProcessInternalLogget_AllowedCallerAwake(long.Parse(Login.KeyAuthApp.user_data.lastlogin)).ToString();
		this.subscriptionDaysLabel.Text = "Expiry in Days: " + this.<LoadPlugin>b__4_0GetWebRequestset_Assembly();
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00006AF8 File Offset: 0x00004CF8
	public static bool set_LocationLogErrorProcessLog(string name, int len)
	{
		for (int i = <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=; i < len; i += <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l)
		{
			bool flag = Login.KeyAuthApp.user_data.subscriptions[i].subscription == name;
			if (flag)
			{
				return <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0;
			}
		}
		return <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00006B58 File Offset: 0x00004D58
	public string <LoadPlugin>b__4_0GetWebRequestset_Assembly()
	{
		int num = 0;
		string result;
		do
		{
			DateTime d;
			if (num == 3)
			{
				DateTime dateTime;
				d = dateTime.ToLocalTime();
				num = 4;
			}
			TimeSpan timeSpan;
			if (num == 6)
			{
				int num2;
				string str = num2.ToString();
				string str2 = " Days ";
				num2 = timeSpan.Hours;
				result = Convert.ToString(str + str2 + num2.ToString() + " Hours Left");
				num = 7;
			}
			if (num == 2)
			{
				DateTime dateTime = d.AddSeconds((double)long.Parse(Login.KeyAuthApp.user_data.subscriptions[<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=].expiry));
				num = 3;
			}
			if (num == 7)
			{
				break;
			}
			if (num == 1)
			{
				d = new DateTime(<Module>.d3JpdGVUb0NvbnNvbGU=Z2V0X0luc3RhbmNl, <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, (DateTimeKind)<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=);
				num = 2;
			}
			if (num == 4)
			{
				timeSpan = d - DateTime.Now;
				num = 5;
			}
			if (num == 5)
			{
				int num2 = timeSpan.Days;
				num = 6;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 8);
		return result;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00006D30 File Offset: 0x00004F30
	public DateTime ProcessInternalLogget_AllowedCallerAwake(long unixtime)
	{
		int num = 0;
		DateTime result;
		do
		{
			if (num == 1)
			{
				result = new DateTime(<Module>.d3JpdGVUb0NvbnNvbGU=Z2V0X0luc3RhbmNl, <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, (DateTimeKind)<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=);
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 2);
		try
		{
			result = result.AddSeconds((double)unixtime).ToLocalTime();
		}
		catch
		{
			result = DateTime.MaxValue;
		}
		return result;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00006E28 File Offset: 0x00005028
	private void IsValidCSteamIDgetCommandTypeset_PrivacyState(object sender, EventArgs e)
	{
		int num = 0;
		WebClient webClient;
		for (;;)
		{
			if (num == 5)
			{
				Process.Start(this.openFileDialog1.FileName);
				num = 6;
			}
			bool flag;
			if (num == 1)
			{
				flag = string.IsNullOrEmpty(this.TextBox1.Text);
				num = 2;
			}
			if (num == 6)
			{
				webClient = new WebClient();
				num = 7;
			}
			if (num != 2)
			{
				goto IL_B6;
			}
			if (flag)
			{
				num = 3;
				goto IL_B6;
			}
			goto IL_EC;
			IL_11B:
			if (num == 0)
			{
				num = 1;
			}
			if (num == 7)
			{
				break;
			}
			continue;
			IL_B6:
			if (num == 3)
			{
				Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				num = 4;
			}
			if (num != 4)
			{
				goto IL_11B;
			}
			IL_EC:
			this.openFileDialog1.FileName = this.TextBox1.Text + "\\Unturned_BE.exe";
			num = 5;
			goto IL_11B;
		}
		try
		{
			webClient.DownloadFile(new Uri("https://cdn.discordapp.com/attachments/1134788916642336910/1141629854886920242/HighlightingSystem.dll"), this.TextBox1.Text + "\\Unturned_Data\\Managed\\HighlightingSystem.dll");
			webClient.DownloadFile(new Uri("https://cdn.discordapp.com/attachments/1134788916642336910/1141619957046718504/0Harmony.dll"), this.TextBox1.Text + "\\Unturned_Data\\Managed\\0Harmony.dll");
			webClient.DownloadFile(new Uri("https://cdn.discordapp.com/attachments/1134788916642336910/1134951901331464423/HighlightingSystem.dll"), this.TextBox1.Text + "\\Sandbox\\HighlightingSystem.dll");
			string text = this.TextBox1.Text + "\\Sandbox\\HighlightingSystem.dll";
			string text2 = this.TextBox1.Text + "\\Unturned_Data\\Managed\\HighlightingSystem.dll";
			Main.hui1 = text;
			Main.hui2 = text2;
		}
		finally
		{
			if (webClient != null)
			{
				((IDisposable)webClient).Dispose();
			}
		}
		Thread thread = new Thread(new ThreadStart(this.checkTimerRestartLogAwake));
		thread.Start();
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000070A4 File Offset: 0x000052A4
	private void checkTimerRestartLogAwake()
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				Thread.Sleep(<Module>.X2ludm9rZQ==QXdha2U=);
				num = 2;
			}
			if (num == 4)
			{
				Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				num = 5;
			}
			if (num == 2)
			{
				File.Copy(Main.hui1, Main.hui2, <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
				num = 3;
			}
			if (num == 3)
			{
				File.Delete(Main.hui1);
				num = 4;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 5);
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00007194 File Offset: 0x00005394
	private void AddPlayerToGroupget_DirectoryReload(object sender, EventArgs e)
	{
		int num = 0;
		for (;;)
		{
			if (num == 8)
			{
				goto IL_1F;
			}
			IL_37:
			bool flag;
			if (num == 2)
			{
				flag = ((string.IsNullOrEmpty(this.chatchannel) ? 1 : 0) == <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				num = 3;
			}
			if (num == 1)
			{
				this.timer1.Interval = <Module>.Z2V0X0luc3RhbmNlSUQ=YWRkX09uUGx1Z2luc0xvYWRlZA==;
				num = 2;
			}
			if (num == 6)
			{
				bool flag2;
				if (!flag2)
				{
					goto IL_1F;
				}
				num = 7;
			}
			if (num == 7)
			{
				break;
			}
			List<api.msg> assembliesFromDirectoryOnEnableremove_OnPluginUnloading;
			if (num == 4)
			{
				assembliesFromDirectoryOnEnableremove_OnPluginUnloading = Login.KeyAuthApp.GetAssembliesFromDirectoryOnEnableremove_OnPluginUnloading(this.chatchannel);
				num = 5;
			}
			if (num == 3)
			{
				if (!flag)
				{
					goto IL_1CC;
				}
				num = 4;
			}
			if (num == 5)
			{
				bool flag2 = assembliesFromDirectoryOnEnableremove_OnPluginUnloading == null;
				num = 6;
			}
			if (num == 0)
			{
				num = 1;
			}
			if (num == 9)
			{
				goto Block_11;
			}
			continue;
			IL_1F:
			List<api.msg>.Enumerator enumerator = assembliesFromDirectoryOnEnableremove_OnPluginUnloading.GetEnumerator();
			num = 9;
			goto IL_37;
		}
		goto IL_1C6;
		Block_11:
		try
		{
			List<api.msg>.Enumerator enumerator;
			while (enumerator.MoveNext())
			{
				api.msg msg = enumerator.Current;
			}
		}
		finally
		{
			List<api.msg>.Enumerator enumerator;
			((IDisposable)enumerator).Dispose();
		}
		IL_1C6:
		return;
		IL_1CC:
		this.timer1.Stop();
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002382 File Offset: 0x00000582
	private void set_GroupsInvokeAwake(object sender, CancelEventArgs e)
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00007390 File Offset: 0x00005590
	private void getCommandIdentityReloadLoadPlugin(object sender, EventArgs e)
	{
		int num = 0;
		do
		{
			FolderBrowserDialog folderBrowserDialog;
			bool flag;
			if (num == 4)
			{
				flag = (folderBrowserDialog.ShowDialog() == (DialogResult)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l);
				num = 5;
			}
			if (num == 1)
			{
				folderBrowserDialog = new FolderBrowserDialog();
				num = 2;
			}
			if (num == 2)
			{
				folderBrowserDialog.RootFolder = (Environment.SpecialFolder)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
				num = 3;
			}
			if (num == 3)
			{
				folderBrowserDialog.ShowNewFolderButton = (<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0);
				num = 4;
			}
			if (num == 6)
			{
				this.TextBox1.Text = folderBrowserDialog.SelectedPath;
				num = 7;
			}
			if (num == 5)
			{
				if (!flag)
				{
					break;
				}
				num = 6;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 7);
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002382 File Offset: 0x00000582
	private void get_AvatarFullGetShellWindowParseUInt32(object sender, EventArgs e)
	{
	}

	// Token: 0x0600009D RID: 157 RVA: 0x000074DC File Offset: 0x000056DC
	private void Executeget_Configurationget_Timeout(object sender, CancelEventArgs e)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
	}

	// Token: 0x0600009E RID: 158 RVA: 0x000074DC File Offset: 0x000056DC
	private void GetTypesFromParentClassset_Assemblyget_StateMessage(object sender, CancelEventArgs e)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x000075F0 File Offset: 0x000057F0
	private void set_HeadlineStartTranslate()
	{
		this.components = new Container();
		this.siticoneDragControl1 = new SiticoneDragControl(this.components);
		this.siticoneControlBox1 = new SiticoneControlBox();
		this.siticoneControlBox2 = new SiticoneControlBox();
		this.label1 = new Label();
		this.label2 = new Label();
		this.expiry = new SiticoneLabel();
		this.Game = new SiticoneRoundedButton();
		this.lastLogin = new SiticoneLabel();
		this.subscriptionDaysLabel = new SiticoneLabel();
		this.siticoneShadowForm = new SiticoneShadowForm(this.components);
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.createDate = new SiticoneLabel();
		this.hwid = new SiticoneLabel();
		this.TextBox1 = new RichTextBox();
		this.button1 = new Button();
		this.openFileDialog1 = new OpenFileDialog();
		this.label3 = new Label();
		this.timer2 = new System.Windows.Forms.Timer(this.components);
		base.SuspendLayout();
		this.siticoneDragControl1.TargetControl = this;
		this.siticoneControlBox1.Anchor = (AnchorStyles)<Module>.c2V0X1RyYWRlQmFuU3RhdGU=T25EaXNhYmxl;
		this.siticoneControlBox1.BorderRadius = <Module>.TG9nc2V0X0xvY2F0aW9u;
		this.siticoneControlBox1.FillColor = Color.FromArgb(<Module>.VW5sb2FkUGx1Z2luRGVsZXRlR3JvdXA=, <Module>.R2V0UGVybWlzc2lvbnM=Z2V0X05hbWU=, <Module>.UmVhZA==SGFzUGVybWlzc2lvbg==);
		this.siticoneControlBox1.HoveredState.FillColor = Color.FromArgb(<Module>.c2V0X1JlYWxOYW1lR2V0VHlwZXM=, <Module>.Z2V0Q29tbWFuZFR5cGU=U3RhcnQ=, <Module>.VW5sb2FkUGx1Z2luRGVsZXRlR3JvdXA=);
		this.siticoneControlBox1.HoveredState.IconColor = Color.White;
		this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
		this.siticoneControlBox1.IconColor = Color.White;
		this.siticoneControlBox1.Location = new Point(<Module>.VW5sb2FkUXVldWVPbk1haW5UaHJlYWQ=, <Module>.U2F2ZQ==TG9hZERlZmF1bHRz);
		this.siticoneControlBox1.Name = "siticoneControlBox1";
		this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
		this.siticoneControlBox1.Size = new Size(<Module>.bG9nUkNPTg==TG9n, <Module>.c2V0X0F2YXRhck1lZGl1bQ==Y2hlY2tEdXBsaWNhdGVDb21tYW5kTWFwcGluZ3M=);
		this.siticoneControlBox1.TabIndex = <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l;
		this.siticoneControlBox1.Click += this.get_Nameget_TradeBanStatecheckCommandMappings;
		this.siticoneControlBox2.Anchor = (AnchorStyles)<Module>.c2V0X1RyYWRlQmFuU3RhdGU=T25EaXNhYmxl;
		this.siticoneControlBox2.BorderRadius = <Module>.TG9nc2V0X0xvY2F0aW9u;
		this.siticoneControlBox2.ControlBoxType = (ControlBoxType)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
		this.siticoneControlBox2.FillColor = Color.FromArgb(<Module>.VW5sb2FkUGx1Z2luRGVsZXRlR3JvdXA=, <Module>.R2V0UGVybWlzc2lvbnM=Z2V0X05hbWU=, <Module>.UmVhZA==SGFzUGVybWlzc2lvbg==);
		this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
		this.siticoneControlBox2.IconColor = Color.White;
		this.siticoneControlBox2.Location = new Point(<Module>.Z2V0X0NvbmZpZ3VyYXRpb24=R2V0T3BlbldpbmRvd3M=, <Module>.U2F2ZQ==TG9hZERlZmF1bHRz);
		this.siticoneControlBox2.Name = "siticoneControlBox2";
		this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
		this.siticoneControlBox2.Size = new Size(<Module>.bG9nUkNPTg==TG9n, <Module>.c2V0X0F2YXRhck1lZGl1bQ==Y2hlY2tEdXBsaWNhdGVDb21tYW5kTWFwcGluZ3M=);
		this.siticoneControlBox2.TabIndex = <Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=;
		this.label1.AutoSize = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
		this.label1.Font = new Font("Segoe UI Light", 10f);
		this.label1.ForeColor = Color.White;
		this.label1.Location = new Point(<Module>.R2V0UGVybWlzc2lvbnM=Z2V0X1N5bnRheA==, <Module>.UmVsb2FkQWRkR3JvdXA=);
		this.label1.Name = "label1";
		this.label1.Size = new Size(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.SGFzUGVybWlzc2lvbg==c2V0X0luc3RhbmNlSUQ=);
		this.label1.TabIndex = <Module>.c2V0X1Zpc2liaWxpdHlTdGF0ZQ==R2V0V2luZG93VGV4dA==;
		this.label2.AutoSize = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
		this.label2.Font = new Font("Segoe UI Semibold", 10.2f, (FontStyle)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, (GraphicsUnit)<Module>.R2V0UGVybWlzc2lvbnM=R2V0R3JvdXBzQnlJZHM=, (byte)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
		this.label2.ForeColor = Color.FromArgb(<Module>.Z2V0X0Nvbm5lY3RlZFRpbWU=R2V0R3JvdXA=, <Module>.Z2V0X0Nvbm5lY3RlZFRpbWU=R2V0R3JvdXA=, <Module>.QXdha2U=Z2V0X0FsaWFzZXM=);
		this.label2.Location = new Point(<Module>.TG9nc2V0X0xvY2F0aW9u, <Module>.QnJvYWRjYXN0RGVsZXRlR3JvdXA=);
		this.label2.Margin = new Padding(<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
		this.label2.Name = "label2";
		this.label2.Size = new Size(<Module>.R2V0UGVybWlzc2lvbnM=RGVsZXRlR3JvdXA=, <Module>.SGFzUGVybWlzc2lvbg==c2V0X0luc3RhbmNlSUQ=);
		this.label2.TabIndex = <Module>.aGFuZGxlQ29ubmVjdGlvbg==Z2V0X0lzVmFjQmFubmVk;
		this.label2.Text = "HamsterHack";
		this.expiry.BackColor = Color.Transparent;
		this.expiry.Font = new Font("Segoe UI", 7.8f, (FontStyle)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, (GraphicsUnit)<Module>.R2V0UGVybWlzc2lvbnM=R2V0R3JvdXBzQnlJZHM=, (byte)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
		this.expiry.ForeColor = SystemColors.ButtonHighlight;
		this.expiry.Location = new Point(<Module>.Z2V0X1N5bnRheA==UXVldWVPbk1haW5UaHJlYWQ=, <Module>.Z2V0X1RpbWVvdXQ=Z2V0X0F2YXRhck1lZGl1bQ==);
		this.expiry.Margin = new Padding(<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=);
		this.expiry.Name = "expiry";
		this.expiry.Size = new Size(<Module>.U2F2ZUdyb3VwR2V0Q29tbWFuZA==, <Module>.R2V0UGVybWlzc2lvbnM=Z2V0X0N1c3RvbVVSTA==);
		this.expiry.TabIndex = <Module>.Z2V0X1ByaXZhY3lTdGF0ZQ==Z2V0X1JlYWxOYW1l;
		this.expiry.Text = "expiryLabel";
		this.Game.BorderColor = Color.DodgerBlue;
		this.Game.BorderThickness = <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l;
		this.Game.CheckedState.Parent = this.Game;
		this.Game.CustomImages.Parent = this.Game;
		this.Game.FillColor = Color.FromArgb(<Module>.T25FbmFibGU=SGFzUGVybWlzc2lvbnM=, <Module>.c2V0X1JlYWxOYW1lRGVsZXRlR3JvdXA=, <Module>.cmVtb3ZlX09uUGx1Z2luVW5sb2FkaW5nR2V0UGx1Z2lucw==);
		this.Game.Font = new Font("Segoe UI", 9f, (FontStyle)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, (GraphicsUnit)<Module>.R2V0UGVybWlzc2lvbnM=R2V0R3JvdXBzQnlJZHM=, (byte)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
		this.Game.ForeColor = Color.White;
		this.Game.HoveredState.BorderColor = Color.FromArgb(<Module>.TG9nRXJyb3I=Z2V0X05hbWU=, <Module>.Z2V0X1BsdWdpbnM=SGFzUGVybWlzc2lvbg==, <Module>.SXNXaW5kb3dWaXNpYmxlYWRkX09uUGx1Z2luc0xvYWRlZA==);
		this.Game.HoveredState.Parent = this.Game;
		this.Game.Location = new Point(<Module>.Rml4ZWRVcGRhdGU=c2V0X0RpcmVjdG9yeQ==, <Module>.TG9nV2FybmluZw==SXNEZXBlbmRlbmN5TG9hZGVk);
		this.Game.Name = "Game";
		this.Game.ShadowDecoration.Parent = this.Game;
		this.Game.Size = new Size(<Module>.R2V0VHlwZXNGcm9tSW50ZXJmYWNlR2V0UGVybWlzc2lvbnM=, <Module>.aGFuZGxlQ29ubmVjdGlvbg==Z2V0X0lzVmFjQmFubmVk);
		this.Game.TabIndex = <Module>.UmVhZA==SGFzUGVybWlzc2lvbg==;
		this.Game.Text = "START GAME";
		this.Game.Click += this.IsValidCSteamIDgetCommandTypeset_PrivacyState;
		this.lastLogin.BackColor = Color.Transparent;
		this.lastLogin.Font = new Font("Segoe UI", 7.8f, (FontStyle)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, (GraphicsUnit)<Module>.R2V0UGVybWlzc2lvbnM=R2V0R3JvdXBzQnlJZHM=, (byte)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
		this.lastLogin.ForeColor = SystemColors.ButtonHighlight;
		this.lastLogin.Location = new Point(<Module>.Z2V0X1N5bnRheA==UXVldWVPbk1haW5UaHJlYWQ=, <Module>.Z2V0X0N1c3RvbVVSTA==UmVsb2Fk);
		this.lastLogin.Margin = new Padding(<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=);
		this.lastLogin.Name = "lastLogin";
		this.lastLogin.Size = new Size(<Module>.UmVnaXN0ZXI=c2V0X0xvY2F0aW9u, <Module>.R2V0UGVybWlzc2lvbnM=Z2V0X0N1c3RvbVVSTA==);
		this.lastLogin.TabIndex = <Module>.Z2V0X0F2YXRhckZ1bGw=c2V0X0hvdXJzUGxheWVkTGFzdFR3b1dlZWtz;
		this.lastLogin.Text = "lastLoginLabel";
		this.subscriptionDaysLabel.BackColor = Color.Transparent;
		this.subscriptionDaysLabel.Font = new Font("Segoe UI", 7.8f, (FontStyle)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, (GraphicsUnit)<Module>.R2V0UGVybWlzc2lvbnM=R2V0R3JvdXBzQnlJZHM=, (byte)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
		this.subscriptionDaysLabel.ForeColor = SystemColors.ButtonHighlight;
		this.subscriptionDaysLabel.Location = new Point(<Module>.Z2V0X1N5bnRheA==UXVldWVPbk1haW5UaHJlYWQ=, <Module>.cmVtb3ZlX09uUGx1Z2luVW5sb2FkaW5nc2V0X09ubGluZVN0YXRl);
		this.subscriptionDaysLabel.Margin = new Padding(<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=);
		this.subscriptionDaysLabel.Name = "subscriptionDaysLabel";
		this.subscriptionDaysLabel.Size = new Size(<Module>.c2V0X0lzVmFjQmFubmVkZ2V0X1RyYWRlQmFuU3RhdGU=, <Module>.R2V0UGVybWlzc2lvbnM=Z2V0X0N1c3RvbVVSTA==);
		this.subscriptionDaysLabel.TabIndex = <Module>.R2V0UGx1Z2luZ2V0X0FsaWFzZXM=;
		this.subscriptionDaysLabel.Text = "subscriptionDaysLabel";
		this.timer1.Enabled = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
		this.timer1.Interval = <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l;
		this.timer1.Tick += this.AddPlayerToGroupget_DirectoryReload;
		this.createDate.BackColor = Color.Transparent;
		this.createDate.Font = new Font("Segoe UI", 7.8f, (FontStyle)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, (GraphicsUnit)<Module>.R2V0UGVybWlzc2lvbnM=R2V0R3JvdXBzQnlJZHM=, (byte)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
		this.createDate.ForeColor = SystemColors.ButtonHighlight;
		this.createDate.Location = new Point(<Module>.Z2V0X1N5bnRheA==UXVldWVPbk1haW5UaHJlYWQ=, <Module>.VHJ5UmVtb3ZlQ29tcG9uZW50c2V0X1ByaXZhY3lTdGF0ZQ==);
		this.createDate.Margin = new Padding(<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=);
		this.createDate.Name = "createDate";
		this.createDate.Size = new Size(<Module>.cmVtb3ZlX09uUGx1Z2luTG9hZGluZw==c2V0X0F2YXRhckZ1bGw=, <Module>.R2V0UGVybWlzc2lvbnM=Z2V0X0N1c3RvbVVSTA==);
		this.createDate.TabIndex = <Module>.Z2V0X1RpbWVvdXQ=Z2V0X0F2YXRhck1lZGl1bQ==;
		this.createDate.Text = "createDateLabel";
		this.hwid.BackColor = Color.Transparent;
		this.hwid.Font = new Font("Segoe UI", 7.8f, (FontStyle)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, (GraphicsUnit)<Module>.R2V0UGVybWlzc2lvbnM=R2V0R3JvdXBzQnlJZHM=, (byte)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
		this.hwid.ForeColor = SystemColors.ButtonHighlight;
		this.hwid.Location = new Point(<Module>.Z2V0X1N5bnRheA==UXVldWVPbk1haW5UaHJlYWQ=, <Module>.Y2hlY2tUaW1lclJlc3RhcnQ=RXhlY3V0ZQ==);
		this.hwid.Margin = new Padding(<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=);
		this.hwid.Name = "hwid";
		this.hwid.Size = new Size(<Module>.R2V0UGx1Z2lucw==UGFyc2VVcmk=, <Module>.R2V0UGVybWlzc2lvbnM=Z2V0X0N1c3RvbVVSTA==);
		this.hwid.TabIndex = <Module>.bG9nUkNPTg==TG9n;
		this.hwid.Text = "hwidLabel";
		this.TextBox1.BackColor = Color.FromArgb(<Module>.VW5sb2FkUGx1Z2luRGVsZXRlR3JvdXA=, <Module>.R2V0UGVybWlzc2lvbnM=Z2V0X05hbWU=, <Module>.UmVhZA==SGFzUGVybWlzc2lvbg==);
		this.TextBox1.ForeColor = Color.FromArgb(<Module>.QXdha2U=Z2V0X0FsaWFzZXM=, <Module>.QXdha2U=Z2V0X0FsaWFzZXM=, <Module>.RXhlY3V0ZQ==R2V0UGx1Z2lu);
		this.TextBox1.Location = new Point(<Module>.TG9nRXhjZXB0aW9uc2V0X0N1c3RvbVVSTA==, <Module>.c2V0X1N0ZWFtSUQ2NA==U2F2ZUdyb3Vw);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new Size(<Module>.U2F2ZUdyb3VwUmVnaXN0ZXI=, <Module>.U2F2ZUdyb3VwT25EZXN0cm95);
		this.TextBox1.TabIndex = <Module>.aGFuZGxlQ29ubmVjdGlvbg==Y2hlY2tEdXBsaWNhdGVDb21tYW5kTWFwcGluZ3M=;
		this.TextBox1.Text = "";
		this.TextBox1.TextChanged += this.get_AvatarFullGetShellWindowParseUInt32;
		this.button1.Location = new Point(<Module>.T25EZXN0cm95Z2V0X05hbWU=, <Module>.Z2V0X05hbWU=VHJ5UmVtb3ZlQ29tcG9uZW50);
		this.button1.Name = "button1";
		this.button1.Size = new Size(<Module>.QXdha2U=cmVtb3ZlX09uUGx1Z2luVW5sb2FkaW5n, <Module>.c2V0X0F2YXRhck1lZGl1bQ==Y2hlY2tEdXBsaWNhdGVDb21tYW5kTWFwcGluZ3M=);
		this.button1.TabIndex = <Module>.RXhlY3V0ZURlcGVuZGVuY3lDb2RlQXdha2U=;
		this.button1.Text = "...";
		this.button1.UseVisualStyleBackColor = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
		this.button1.Click += this.getCommandIdentityReloadLoadPlugin;
		this.openFileDialog1.FileName = "openFileDialog1";
		this.openFileDialog1.FileOk += this.GetTypesFromParentClassset_Assemblyget_StateMessage;
		this.label3.AutoSize = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
		this.label3.Font = new Font("Segoe UI Semibold", 10.2f, (FontStyle)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, (GraphicsUnit)<Module>.R2V0UGVybWlzc2lvbnM=R2V0R3JvdXBzQnlJZHM=, (byte)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
		this.label3.ForeColor = Color.Gainsboro;
		this.label3.Location = new Point(<Module>.TG9hZA==QnJvYWRjYXN0, <Module>.Z2V0X1ByaXZhY3lTdGF0ZQ==Z2V0X1RyYW5zbGF0aW9ucw==);
		this.label3.Margin = new Padding(<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
		this.label3.Name = "label3";
		this.label3.Size = new Size(<Module>.UHJvY2Vzc0xvZw==Z2V0X0hlbHA=, <Module>.SGFzUGVybWlzc2lvbg==c2V0X0luc3RhbmNlSUQ=);
		this.label3.TabIndex = <Module>.QWRkUGxheWVyVG9Hcm91cA==Z2V0X0luc3RhbmNlSUQ=;
		this.label3.Text = "The way to the game";
		this.timer2.Tick += this.IsValidCSteamIDgetCommandTypeset_PrivacyState;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = (AutoScaleMode)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l;
		this.AutoValidate = (AutoValidate)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
		this.BackColor = Color.FromArgb(<Module>.VW5sb2FkUGx1Z2luRGVsZXRlR3JvdXA=, <Module>.R2V0UGVybWlzc2lvbnM=Z2V0X05hbWU=, <Module>.UmVhZA==SGFzUGVybWlzc2lvbg==);
		base.ClientSize = new Size(<Module>.c2V0X0luc3RhbmNlZ2V0X0lzVmFjQmFubmVk, <Module>.PEdldEdyb3Vwcz5iX18xMV8zPEF3YWtlPmJfXzhfMA==);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.subscriptionDaysLabel);
		base.Controls.Add(this.lastLogin);
		base.Controls.Add(this.createDate);
		base.Controls.Add(this.hwid);
		base.Controls.Add(this.Game);
		base.Controls.Add(this.expiry);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.siticoneControlBox2);
		base.Controls.Add(this.siticoneControlBox1);
		base.FormBorderStyle = (FormBorderStyle)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
		base.Name = "Main";
		base.StartPosition = (FormStartPosition)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l;
		this.Text = "Loader";
		base.TransparencyKey = Color.Maroon;
		base.Load += this.get_ClientsGetGroupget_Name;
		base.ResumeLayout(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0);
		base.PerformLayout();
	}

	// Token: 0x0400009B RID: 155
	public static System.Timers.Timer timer;

	// Token: 0x0400009C RID: 156
	private string chatchannel = "";

	// Token: 0x0400009D RID: 157
	public static string hui1;

	// Token: 0x0400009E RID: 158
	public static string hui2;

	// Token: 0x040000A0 RID: 160
	private SiticoneDragControl siticoneDragControl1;

	// Token: 0x040000A1 RID: 161
	private SiticoneControlBox siticoneControlBox1;

	// Token: 0x040000A2 RID: 162
	private SiticoneControlBox siticoneControlBox2;

	// Token: 0x040000A3 RID: 163
	private Label label1;

	// Token: 0x040000A4 RID: 164
	private Label label2;

	// Token: 0x040000A5 RID: 165
	private SiticoneShadowForm siticoneShadowForm;

	// Token: 0x040000A6 RID: 166
	private SiticoneLabel expiry;

	// Token: 0x040000A7 RID: 167
	private SiticoneRoundedButton Game;

	// Token: 0x040000A8 RID: 168
	private System.Windows.Forms.Timer timer1;

	// Token: 0x040000A9 RID: 169
	private SiticoneLabel lastLogin;

	// Token: 0x040000AA RID: 170
	private SiticoneLabel subscriptionDaysLabel;

	// Token: 0x040000AB RID: 171
	private SiticoneLabel createDate;

	// Token: 0x040000AC RID: 172
	private SiticoneLabel hwid;

	// Token: 0x040000AD RID: 173
	private Button button1;

	// Token: 0x040000AE RID: 174
	private RichTextBox TextBox1;

	// Token: 0x040000AF RID: 175
	private OpenFileDialog openFileDialog1;

	// Token: 0x040000B0 RID: 176
	private Label label3;

	// Token: 0x040000B1 RID: 177
	private System.Windows.Forms.Timer timer2;
}
