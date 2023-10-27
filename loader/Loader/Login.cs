using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

// Token: 0x02000010 RID: 16
public partial class Login : Form
{
	// Token: 0x060000A1 RID: 161 RVA: 0x00008458 File Offset: 0x00006658
	private void ExecuteRunActionGetPermissions(string type)
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				MessageBox.Show(string.Format("It took {0} msg to {1}", api.responseTime, type));
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 2);
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002385 File Offset: 0x00000585
	public Login()
	{
		this.get_AvatarIconget_IsVacBannedLogError();
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002374 File Offset: 0x00000574
	private void set_DirectorygetCommandTypeget_TradeBanState(object sender, EventArgs e)
	{
		Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x000084E4 File Offset: 0x000066E4
	public static bool add_OnPluginLoadingget_PermissionsQueueOnMainThread(string name)
	{
		int num = 0;
		bool result;
		for (;;)
		{
			bool flag;
			if (num == 3)
			{
				flag = Login.KeyAuthApp.user_data.subscriptions.Exists((api.Data x) => x.subscription == CS$<>8__locals1.name);
				num = 4;
			}
			if (num == 7)
			{
				goto IL_61;
			}
			IL_73:
			if (num == 5)
			{
				result = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
				num = 6;
			}
			if (num == 1)
			{
				num = 2;
			}
			if (num == 8)
			{
				break;
			}
			if (num == 4)
			{
				if (!flag)
				{
					goto IL_61;
				}
				num = 5;
			}
			if (num == 6)
			{
				break;
			}
			if (num == 2)
			{
				CS$<>8__locals1.name = name2;
				num = 3;
			}
			if (num == 0)
			{
				num = 1;
			}
			if (num == 9)
			{
				break;
			}
			continue;
			IL_61:
			result = (<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0);
			num = 8;
			goto IL_73;
		}
		return result;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x0000866C File Offset: 0x0000686C
	private void FixedUpdateReloadExecuteDependencyCode(object sender, EventArgs e)
	{
		int num = 0;
		for (;;)
		{
			WebClient webClient;
			string text;
			if (num == 20)
			{
				webClient.DownloadFile(Login.KeyAuthApp.app_data.downloadLink, text);
				num = 21;
			}
			if (num == 10)
			{
				goto IL_503;
			}
			if (num == 13)
			{
				goto IL_74;
			}
			goto IL_92;
			IL_51A:
			if (num == 32)
			{
				MessageBox.Show(Login.KeyAuthApp.response.message);
				num = 33;
			}
			if (num == 33)
			{
				Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				num = 34;
			}
			if (num == 0)
			{
				num = 1;
			}
			if (num == 34)
			{
				break;
			}
			continue;
			IL_2CC:
			DialogResult dialogResult;
			if (num == 7)
			{
				DialogResult dialogResult2;
				dialogResult = dialogResult2;
				num = 8;
			}
			if (num == 30)
			{
				goto IL_301;
			}
			IL_324:
			string str;
			if (num == 18)
			{
				str = Login.set_InstanceIDlogRCONAddPlayerToGroup();
				num = 19;
			}
			if (num == 3)
			{
				bool flag;
				if (!flag)
				{
					goto IL_301;
				}
				num = 4;
			}
			if (num == 25)
			{
				goto IL_37B;
			}
			IL_38F:
			DialogResult dialogResult3;
			if (num == 9)
			{
				if (dialogResult3 == (DialogResult)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X1N0ZWFtSUQ2NA==)
				{
					goto IL_74;
				}
				num = 10;
			}
			if (num == 1)
			{
				Login.KeyAuthApp.<.ctor>b__3_0Initializeremove_OnExecuteCommand();
				num = 2;
			}
			if (num == 6)
			{
				DialogResult dialogResult2 = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", (MessageBoxButtons)<Module>.U2F2ZQ==TG9hZERlZmF1bHRz);
				num = 7;
			}
			if (num == 24)
			{
				goto IL_2B7;
			}
			if (num == 29)
			{
				Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				num = 30;
			}
			if (num == 14)
			{
				Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				num = 15;
			}
			if (num == 23)
			{
				Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				num = 24;
			}
			if (num != 12)
			{
				if (num == 2)
				{
					bool flag = Login.KeyAuthApp.response.message == "invalidver";
					num = 3;
				}
				if (num == 11)
				{
					goto IL_503;
				}
				goto IL_51A;
			}
			IL_37B:
			MessageBox.Show("Invalid option");
			num = 26;
			goto IL_38F;
			IL_301:
			bool flag2 = (Login.KeyAuthApp.response.success ? 1 : 0) == <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
			num = 31;
			goto IL_324;
			IL_21F:
			if (num == 5)
			{
				bool flag3;
				if (!flag3)
				{
					goto IL_2B8;
				}
				num = 6;
			}
			if (num == 21)
			{
				Process.Start(text);
				num = 22;
			}
			if (num == 19)
			{
				text = text.Replace(".exe", "-" + str + ".exe");
				num = 20;
			}
			if (num == 28)
			{
				goto IL_2B7;
			}
			goto IL_2CC;
			IL_92:
			if (num == 31)
			{
				if (!flag2)
				{
					break;
				}
				num = 32;
			}
			if (num == 27)
			{
				goto IL_2B7;
			}
			if (num == 4)
			{
				bool flag3 = (string.IsNullOrEmpty(Login.KeyAuthApp.app_data.downloadLink) ? 1 : 0) == <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
				num = 5;
			}
			if (num == 26)
			{
				Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				num = 27;
			}
			if (num == 17)
			{
				text = Application.ExecutablePath;
				num = 18;
			}
			if (num == 15)
			{
				goto IL_2B7;
			}
			if (num == 8)
			{
				dialogResult3 = dialogResult;
				num = 9;
			}
			if (num == 22)
			{
				Process.Start(new ProcessStartInfo
				{
					Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
					WindowStyle = (ProcessWindowStyle)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l,
					CreateNoWindow = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0),
					FileName = "cmd.exe"
				});
				num = 23;
			}
			if (num == 16)
			{
				goto IL_20D;
			}
			goto IL_21F;
			IL_503:
			if (dialogResult3 != (DialogResult)<Module>.T25FbmFibGU=SGFzUGVybWlzc2lvbnM=)
			{
				num = 12;
				goto IL_51A;
			}
			goto IL_20D;
			IL_2B8:
			MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
			num = 29;
			goto IL_2CC;
			IL_2B7:
			goto IL_2B8;
			IL_20D:
			webClient = new WebClient();
			num = 17;
			goto IL_21F;
			IL_74:
			Process.Start(Login.KeyAuthApp.app_data.downloadLink);
			num = 14;
			goto IL_92;
		}
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00008C20 File Offset: 0x00006E20
	private static string set_InstanceIDlogRCONAddPlayerToGroup()
	{
		string text = null;
		Random random = new Random();
		for (int i = <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=; i < <Module>.d3JpdGVUb0NvbnNvbGU=VHJ5QWRkQ29tcG9uZW50; i += <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l)
		{
			text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
		}
		return text;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x000074DC File Offset: 0x000056DC
	private void ctor>b__3_0Execute(object sender, EventArgs e)
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

	// Token: 0x060000A8 RID: 168 RVA: 0x00008C98 File Offset: 0x00006E98
	private void get_NameGetGroupParseUri(object sender, EventArgs e)
	{
		bool success = Login.KeyAuthApp.response.success;
		if (success)
		{
			Main main = new Main();
			main.Show();
			base.Hide();
		}
		else
		{
			this.status.Text = "Status: " + Login.KeyAuthApp.response.message;
		}
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00002382 File Offset: 0x00000582
	private void get_Permissionsget_Name<Awake>b__12_0(object sender, EventArgs e)
	{
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00008CF8 File Offset: 0x00006EF8
	private void get_AssemblyInitializeunloadPlugins(object sender, EventArgs e)
	{
		Login.KeyAuthApp.set_MostPlayedGamesExecuteRunAsync(this.key.Text);
		bool success = Login.KeyAuthApp.response.success;
		if (success)
		{
			Main main = new Main();
			main.Show();
			base.Hide();
		}
		else
		{
			this.status.Text = "Status: " + Login.KeyAuthApp.response.message;
		}
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00008D6C File Offset: 0x00006F6C
	private void HasPermissionGetMainTypeFromAssemblycheckTimerRestart(object sender, EventArgs e)
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				this.status.Text = "Status: " + Login.KeyAuthApp.response.message;
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 2);
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00002382 File Offset: 0x00000582
	private void set_VisibilityStateProcessLogget_Groups(object sender, EventArgs e)
	{
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002382 File Offset: 0x00000582
	private void set_MostPlayedGamesget_NameAwake(object sender, EventArgs e)
	{
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00008EC0 File Offset: 0x000070C0
	private void get_AvatarIconget_IsVacBannedLogError()
	{
		this.components = new Container();
		this.siticoneDragControl1 = new SiticoneDragControl(this.components);
		this.siticoneControlBox1 = new SiticoneControlBox();
		this.siticoneControlBox2 = new SiticoneControlBox();
		this.label1 = new Label();
		this.label2 = new Label();
		this.key = new SiticoneRoundedTextBox();
		this.LicBtn = new SiticoneRoundedButton();
		this.status = new SiticoneLabel();
		this.siticoneShadowForm = new SiticoneShadowForm(this.components);
		base.SuspendLayout();
		this.siticoneDragControl1.TargetControl = this;
		this.siticoneControlBox1.Anchor = (AnchorStyles)<Module>.c2V0X1RyYWRlQmFuU3RhdGU=T25EaXNhYmxl;
		this.siticoneControlBox1.BorderRadius = <Module>.TG9nc2V0X0xvY2F0aW9u;
		this.siticoneControlBox1.FillColor = Color.FromArgb(<Module>.VW5sb2FkUGx1Z2luRGVsZXRlR3JvdXA=, <Module>.R2V0UGVybWlzc2lvbnM=Z2V0X05hbWU=, <Module>.UmVhZA==SGFzUGVybWlzc2lvbg==);
		this.siticoneControlBox1.HoveredState.FillColor = Color.FromArgb(<Module>.c2V0X1JlYWxOYW1lR2V0VHlwZXM=, <Module>.Z2V0Q29tbWFuZFR5cGU=U3RhcnQ=, <Module>.VW5sb2FkUGx1Z2luRGVsZXRlR3JvdXA=);
		this.siticoneControlBox1.HoveredState.IconColor = Color.White;
		this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
		this.siticoneControlBox1.IconColor = Color.White;
		this.siticoneControlBox1.Location = new Point(<Module>.TG9nV2FybmluZw==VW5sb2FkUGx1Z2lu, <Module>.U2F2ZQ==TG9hZERlZmF1bHRz);
		this.siticoneControlBox1.Name = "siticoneControlBox1";
		this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
		this.siticoneControlBox1.Size = new Size(<Module>.bG9nUkNPTg==TG9n, <Module>.c2V0X0F2YXRhck1lZGl1bQ==Y2hlY2tEdXBsaWNhdGVDb21tYW5kTWFwcGluZ3M=);
		this.siticoneControlBox1.TabIndex = <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l;
		this.siticoneControlBox1.Click += this.set_DirectorygetCommandTypeget_TradeBanState;
		this.siticoneControlBox2.Anchor = (AnchorStyles)<Module>.c2V0X1RyYWRlQmFuU3RhdGU=T25EaXNhYmxl;
		this.siticoneControlBox2.BorderRadius = <Module>.TG9nc2V0X0xvY2F0aW9u;
		this.siticoneControlBox2.ControlBoxType = (ControlBoxType)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
		this.siticoneControlBox2.FillColor = Color.FromArgb(<Module>.VW5sb2FkUGx1Z2luRGVsZXRlR3JvdXA=, <Module>.R2V0UGVybWlzc2lvbnM=Z2V0X05hbWU=, <Module>.UmVhZA==SGFzUGVybWlzc2lvbg==);
		this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
		this.siticoneControlBox2.IconColor = Color.White;
		this.siticoneControlBox2.Location = new Point(<Module>.TG9hZEFzc2VtYmxpZXNGcm9tRGlyZWN0b3J5c2V0X0dyb3Vwcw==, <Module>.U2F2ZQ==TG9hZERlZmF1bHRz);
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
		this.label2.Click += this.set_VisibilityStateProcessLogget_Groups;
		this.key.AllowDrop = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
		this.key.BorderColor = Color.FromArgb(<Module>.T25FbmFibGU=SGFzUGVybWlzc2lvbnM=, <Module>.c2V0X1JlYWxOYW1lRGVsZXRlR3JvdXA=, <Module>.cmVtb3ZlX09uUGx1Z2luVW5sb2FkaW5nR2V0UGx1Z2lucw==);
		this.key.Cursor = Cursors.IBeam;
		this.key.DefaultText = "Key";
		this.key.DisabledState.BorderColor = Color.FromArgb(<Module>.VW5sb2FkR2V0R3JvdXA=, <Module>.VW5sb2FkR2V0R3JvdXA=, <Module>.VW5sb2FkR2V0R3JvdXA=);
		this.key.DisabledState.FillColor = Color.FromArgb(<Module>.Z2V0X0hlYWRsaW5lUGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.Z2V0X0hlYWRsaW5lUGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.Z2V0X0hlYWRsaW5lUGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
		this.key.DisabledState.ForeColor = Color.FromArgb(<Module>.Z2V0X05hbWU=YWRkX09uUGx1Z2luc0xvYWRlZA==, <Module>.Z2V0X05hbWU=YWRkX09uUGx1Z2luc0xvYWRlZA==, <Module>.Z2V0X05hbWU=YWRkX09uUGx1Z2luc0xvYWRlZA==);
		this.key.DisabledState.Parent = this.key;
		this.key.DisabledState.PlaceholderForeColor = Color.FromArgb(<Module>.Z2V0X05hbWU=YWRkX09uUGx1Z2luc0xvYWRlZA==, <Module>.Z2V0X05hbWU=YWRkX09uUGx1Z2luc0xvYWRlZA==, <Module>.Z2V0X05hbWU=YWRkX09uUGx1Z2luc0xvYWRlZA==);
		this.key.FillColor = Color.FromArgb(<Module>.VW5sb2FkUGx1Z2luRGVsZXRlR3JvdXA=, <Module>.R2V0UGVybWlzc2lvbnM=Z2V0X05hbWU=, <Module>.UmVhZA==SGFzUGVybWlzc2lvbg==);
		this.key.FocusedState.BorderColor = Color.FromArgb(<Module>.c2V0X0N1c3RvbVVSTA==UGFyc2VVcmk=, <Module>.Z2V0X1JlYWxOYW1lc2V0X1JlYWxOYW1l, <Module>.QXdha2U=Z2V0X0FsaWFzZXM=);
		this.key.FocusedState.Parent = this.key;
		this.key.HoveredState.BorderColor = Color.FromArgb(<Module>.c2V0X0N1c3RvbVVSTA==UGFyc2VVcmk=, <Module>.Z2V0X1JlYWxOYW1lc2V0X1JlYWxOYW1l, <Module>.QXdha2U=Z2V0X0FsaWFzZXM=);
		this.key.HoveredState.Parent = this.key;
		this.key.Location = new Point(<Module>.TG9nRXhjZXB0aW9uc2V0X0N1c3RvbVVSTA==, <Module>.T25FbmFibGU=Z2V0X0FsbG93ZWRDYWxsZXI=);
		this.key.Margin = new Padding(<Module>.U2F2ZQ==TG9hZERlZmF1bHRz);
		this.key.Name = "key";
		this.key.PasswordChar = (char)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
		this.key.PlaceholderText = "";
		this.key.SelectedText = "";
		this.key.ShadowDecoration.Parent = this.key;
		this.key.Size = new Size(<Module>.VW5sb2FkUGx1Z2luc2V0X1Zpc2liaWxpdHlTdGF0ZQ==, <Module>.Z2V0X1N5bnRheA==Z2V0X05hbWU=);
		this.key.TabIndex = <Module>.RGVsZXRlR3JvdXA=R2V0VHlwZXNGcm9tSW50ZXJmYWNl;
		this.key.TextAlign = (HorizontalAlignment)<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=;
		this.key.TextChanged += this.set_MostPlayedGamesget_NameAwake;
		this.LicBtn.BorderColor = Color.DodgerBlue;
		this.LicBtn.BorderThickness = <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l;
		this.LicBtn.CheckedState.Parent = this.LicBtn;
		this.LicBtn.CustomImages.Parent = this.LicBtn;
		this.LicBtn.FillColor = Color.FromArgb(<Module>.T25FbmFibGU=SGFzUGVybWlzc2lvbnM=, <Module>.c2V0X1JlYWxOYW1lRGVsZXRlR3JvdXA=, <Module>.cmVtb3ZlX09uUGx1Z2luVW5sb2FkaW5nR2V0UGx1Z2lucw==);
		this.LicBtn.Font = new Font("Segoe UI", 9f, (FontStyle)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, (GraphicsUnit)<Module>.R2V0UGVybWlzc2lvbnM=R2V0R3JvdXBzQnlJZHM=, (byte)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
		this.LicBtn.ForeColor = Color.White;
		this.LicBtn.HoveredState.BorderColor = Color.FromArgb(<Module>.TG9nRXJyb3I=Z2V0X05hbWU=, <Module>.Z2V0X1BsdWdpbnM=SGFzUGVybWlzc2lvbg==, <Module>.SXNXaW5kb3dWaXNpYmxlYWRkX09uUGx1Z2luc0xvYWRlZA==);
		this.LicBtn.HoveredState.Parent = this.LicBtn;
		this.LicBtn.Location = new Point(<Module>.Z2V0X05hbWU=Z2V0X0F2YXRhckljb24=, <Module>.TG9nZ2V0X0Nvbm5lY3RlZFRpbWU=);
		this.LicBtn.Name = "LicBtn";
		this.LicBtn.ShadowDecoration.Parent = this.LicBtn;
		this.LicBtn.Size = new Size(<Module>.c2V0X0NvbW1hbmRzZ2V0X0hvdXJzUGxheWVkTGFzdFR3b1dlZWtz, <Module>.aGFuZGxlQ29ubmVjdGlvbg==Z2V0X0lzVmFjQmFubmVk);
		this.LicBtn.TabIndex = <Module>.VHJhbnNsYXRlc2V0X1ByaXZhY3lTdGF0ZQ==;
		this.LicBtn.Text = "License";
		this.LicBtn.Click += this.get_AssemblyInitializeunloadPlugins;
		this.status.AutoSize = (<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0);
		this.status.BackColor = Color.Transparent;
		this.status.Dock = (DockStyle)<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=;
		this.status.Font = new Font("Segoe UI", 12f, (FontStyle)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, (GraphicsUnit)<Module>.R2V0UGVybWlzc2lvbnM=R2V0R3JvdXBzQnlJZHM=, (byte)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
		this.status.ForeColor = SystemColors.ButtonHighlight;
		this.status.Location = new Point(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.UGFyc2VEYXRlVGltZQ==UmVhZA==);
		this.status.Margin = new Padding(<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=);
		this.status.Name = "status";
		this.status.Size = new Size(<Module>.TG9hZFBsdWdpbg==Z2V0X1N5bnRheA==, <Module>.UmVhZA==SGFzUGVybWlzc2lvbg==);
		this.status.TabIndex = <Module>.Z2V0X1ByaXZhY3lTdGF0ZQ==Z2V0X1JlYWxOYW1l;
		this.status.Text = "Status: Awaiting login";
		this.status.TextAlignment = (ContentAlignment)<Module>.Z2V0X0xvY2F0aW9uPEF3YWtlPmJfXzEyXzA=;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = (AutoScaleMode)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l;
		this.AutoValidate = (AutoValidate)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
		this.BackColor = Color.FromArgb(<Module>.VW5sb2FkUGx1Z2luRGVsZXRlR3JvdXA=, <Module>.R2V0UGVybWlzc2lvbnM=Z2V0X05hbWU=, <Module>.UmVhZA==SGFzUGVybWlzc2lvbg==);
		base.ClientSize = new Size(<Module>.TG9hZFBsdWdpbg==Z2V0X1N5bnRheA==, <Module>.R2V0VHlwZXM=VW5sb2FkUGx1Z2lu);
		base.Controls.Add(this.status);
		base.Controls.Add(this.LicBtn);
		base.Controls.Add(this.key);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.siticoneControlBox2);
		base.Controls.Add(this.siticoneControlBox1);
		base.FormBorderStyle = (FormBorderStyle)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
		base.Name = "Login";
		base.StartPosition = (FormStartPosition)<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l;
		this.Text = "Loader";
		base.TransparencyKey = Color.Maroon;
		base.Load += this.FixedUpdateReloadExecuteDependencyCode;
		base.ResumeLayout(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0);
		base.PerformLayout();
	}

	// Token: 0x040000B2 RID: 178
	public static api KeyAuthApp = new api("Hamster2", "Rwv1ehf0hR", "22b911366d4772b1b2773a8fc9ba40508686bfe1bb5cb550b96713b187a4705b", "1.0");

	// Token: 0x040000B4 RID: 180
	private SiticoneDragControl siticoneDragControl1;

	// Token: 0x040000B5 RID: 181
	private SiticoneControlBox siticoneControlBox1;

	// Token: 0x040000B6 RID: 182
	private SiticoneControlBox siticoneControlBox2;

	// Token: 0x040000B7 RID: 183
	private Label label1;

	// Token: 0x040000B8 RID: 184
	private Label label2;

	// Token: 0x040000B9 RID: 185
	private SiticoneShadowForm siticoneShadowForm;

	// Token: 0x040000BA RID: 186
	private SiticoneRoundedTextBox key;

	// Token: 0x040000BB RID: 187
	private SiticoneRoundedButton LicBtn;

	// Token: 0x040000BC RID: 188
	private SiticoneLabel status;
}
