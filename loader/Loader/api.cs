using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading;

// Token: 0x02000002 RID: 2
public class api
{
	// Token: 0x06000002 RID: 2 RVA: 0x000027B4 File Offset: 0x000009B4
	public api(string name, string ownerid, string secret, string version)
	{
		bool flag = ownerid.Length != 10 || secret.Length != 64;
		if (flag)
		{
			Thread.Sleep(2000);
			api.get_TradeBanStateUnloadPluginget_Name("Application not setup correctly. Please watch the YouTube video for setup.");
			Environment.Exit(0);
		}
		this.name = name;
		this.ownerid = ownerid;
		this.secret = secret;
		this.version = version;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002854 File Offset: 0x00000A54
	public void <.ctor>b__3_0Initializeremove_OnExecuteCommand()
	{
		int num = 0;
		for (;;)
		{
			if (num == 8)
			{
				Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				num = 9;
			}
			bool flag;
			if (num == 20)
			{
				if (!flag)
				{
					break;
				}
				num = 21;
			}
			if (num == 17)
			{
				this.initialized = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
				num = 18;
			}
			if (num != 14)
			{
				goto IL_A1;
			}
			bool newSession;
			if (newSession)
			{
				num = 15;
				goto IL_A1;
			}
			goto IL_209;
			IL_220:
			if (num == 19)
			{
				goto IL_231;
			}
			IL_251:
			string typesFromInterfaceget_DefaultTranslationsReload;
			if (num == 1)
			{
				typesFromInterfaceget_DefaultTranslationsReload = encryption.GetTypesFromInterfaceget_DefaultTranslationsReload();
				num = 2;
			}
			api.response_structure response_structure;
			if (num == 13)
			{
				newSession = response_structure.newSession;
				num = 14;
			}
			if (num == 15)
			{
				Thread.Sleep(<Module>.R2V0R3JvdXBzQnlJZHM=Z2V0X1RyYW5zbGF0aW9ucw==);
				num = 16;
			}
			if (num == 21)
			{
				this.app_data.downloadLink = response_structure.download;
				num = 22;
			}
			bool success;
			if (num == 11)
			{
				success = response_structure.success;
				num = 12;
			}
			if (num == 12)
			{
				if (!success)
				{
					goto IL_231;
				}
				num = 13;
			}
			string text;
			if (num == 4)
			{
				NameValueCollection post_data;
				text = api.get_Clientsset_CommandsGetParentGroups(post_data);
				num = 5;
			}
			if (num == 18)
			{
				break;
			}
			if (num == 5)
			{
				bool flag2 = text == "KeyAuth_Invalid";
				num = 6;
			}
			if (num == 7)
			{
				api.get_TradeBanStateUnloadPluginget_Name("Application not found");
				num = 8;
			}
			if (num == 0)
			{
				num = 1;
			}
			if (num == 22)
			{
				break;
			}
			continue;
			IL_231:
			flag = (response_structure.message == "invalidver");
			num = 20;
			goto IL_251;
			IL_A1:
			if (num == 9)
			{
				goto IL_B4;
			}
			IL_D3:
			if (num == 10)
			{
				this.EnqueueTryInvoke_invoke(response_structure);
				num = 11;
			}
			if (num == 2)
			{
				api.enckey = typesFromInterfaceget_DefaultTranslationsReload + "-" + this.secret;
				num = 3;
			}
			if (num == 3)
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = "init";
				nameValueCollection["ver"] = this.version;
				nameValueCollection["hash"] = api.<Awake>b__8_0set_StateMessageRemovePlayerFromGroup(Process.GetCurrentProcess().MainModule.FileName);
				nameValueCollection["enckey"] = typesFromInterfaceget_DefaultTranslationsReload;
				nameValueCollection["name"] = this.name;
				nameValueCollection["ownerid"] = this.ownerid;
				NameValueCollection post_data = nameValueCollection;
				num = 4;
			}
			if (num == 6)
			{
				bool flag2;
				if (!flag2)
				{
					goto IL_B4;
				}
				num = 7;
			}
			if (num == 16)
			{
				goto IL_209;
			}
			goto IL_220;
			IL_B4:
			response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(text);
			num = 10;
			goto IL_D3;
			IL_209:
			api.sessionid = response_structure.sessionid;
			num = 17;
			goto IL_220;
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002C70 File Offset: 0x00000E70
	public void EnqueueReadget_AvatarFull()
	{
		int num = 0;
		do
		{
			if (num == 4)
			{
				Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				num = 5;
			}
			if (num == 2)
			{
				bool flag;
				if (!flag)
				{
					break;
				}
				num = 3;
			}
			if (num == 3)
			{
				api.get_TradeBanStateUnloadPluginget_Name("You must run the function KeyAuthApp.init(); first");
				num = 4;
			}
			if (num == 1)
			{
				bool flag = (this.initialized ? 1 : 0) == <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 5);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002D60 File Offset: 0x00000F60
	public string checkTimerRestartget_Nameget_AllowedCaller(string Type, int subscription)
	{
		int num = 0;
		string result;
		for (;;)
		{
			DateTime d;
			if (num == 4)
			{
				DateTime dateTime;
				d = dateTime.ToLocalTime();
				num = 5;
			}
			TimeSpan timeSpan;
			if (num == 5)
			{
				timeSpan = d - DateTime.Now;
				num = 6;
			}
			if (num == 13)
			{
				break;
			}
			if (num == 14)
			{
				goto IL_91;
			}
			IL_AC:
			if (num == 15)
			{
				break;
			}
			if (num == 19)
			{
				break;
			}
			if (num == 18)
			{
				goto IL_FB;
			}
			IL_109:
			if (num == 12)
			{
				goto IL_11A;
			}
			IL_13B:
			string text;
			if (num == 6)
			{
				text = Type.ToLower();
				num = 7;
			}
			if (num == 3)
			{
				DateTime dateTime = d.AddSeconds((double)long.Parse(this.user_data.subscriptions[subscription].expiry));
				num = 4;
			}
			string a;
			if (num == 9)
			{
				if (a == "days")
				{
					goto IL_91;
				}
				num = 10;
			}
			if (num == 16)
			{
				goto IL_1E9;
			}
			IL_204:
			if (num == 10)
			{
				if (a == "hours")
				{
					goto IL_1E9;
				}
				num = 11;
			}
			if (num == 8)
			{
				if (a == "months")
				{
					goto IL_11A;
				}
				num = 9;
			}
			if (num == 11)
			{
				goto IL_FB;
			}
			if (num == 7)
			{
				a = text;
				num = 8;
			}
			if (num == 17)
			{
				break;
			}
			if (num == 2)
			{
				d = new DateTime(<Module>.d3JpdGVUb0NvbnNvbGU=Z2V0X0luc3RhbmNl, <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, (DateTimeKind)<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=);
				num = 3;
			}
			if (num == 1)
			{
				this.EnqueueReadget_AvatarFull();
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
			if (num == 20)
			{
				break;
			}
			continue;
			IL_1E9:
			result = Convert.ToString(timeSpan.Hours);
			num = 17;
			goto IL_204;
			IL_11A:
			result = Convert.ToString(timeSpan.Days / <Module>.Z2V0X1N5bnRheA==Z2V0X05hbWU=);
			num = 13;
			goto IL_13B;
			IL_FB:
			result = null;
			num = 19;
			goto IL_109;
			IL_91:
			result = Convert.ToString(timeSpan.Days);
			num = 15;
			goto IL_AC;
		}
		return result;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000030D8 File Offset: 0x000012D8
	public void GetTypesFromParentClassget_HeadlineFixedUpdate(string username, string pass, string key, string email = "")
	{
		int num = 0;
		do
		{
			string json;
			if (num == 4)
			{
				NameValueCollection post_data;
				json = api.get_Clientsset_CommandsGetParentGroups(post_data);
				num = 5;
			}
			if (num == 1)
			{
				this.EnqueueReadget_AvatarFull();
				num = 2;
			}
			api.response_structure response_structure;
			if (num == 6)
			{
				this.EnqueueTryInvoke_invoke(response_structure);
				num = 7;
			}
			if (num == 5)
			{
				response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
				num = 6;
			}
			if (num == 9)
			{
				this.var_dumpset_NameParseUri(response_structure.info);
				num = 10;
			}
			if (num == 3)
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = "register";
				nameValueCollection["username"] = username;
				nameValueCollection["pass"] = pass;
				nameValueCollection["key"] = key;
				nameValueCollection["email"] = email;
				string value;
				nameValueCollection["hwid"] = value;
				nameValueCollection["sessionid"] = api.sessionid;
				nameValueCollection["name"] = this.name;
				nameValueCollection["ownerid"] = this.ownerid;
				NameValueCollection post_data = nameValueCollection;
				num = 4;
			}
			if (num == 2)
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				num = 3;
			}
			if (num == 8)
			{
				bool success;
				if (!success)
				{
					break;
				}
				num = 9;
			}
			if (num == 7)
			{
				bool success = response_structure.success;
				num = 8;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 10);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00003330 File Offset: 0x00001530
	public void checkTimerRestartReloadhandleConnection(string username, string email)
	{
		int num = 0;
		do
		{
			if (num == 5)
			{
				api.response_structure data;
				this.EnqueueTryInvoke_invoke(data);
				num = 6;
			}
			NameValueCollection post_data;
			if (num == 2)
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = "forgot";
				nameValueCollection["username"] = username;
				nameValueCollection["email"] = email;
				nameValueCollection["sessionid"] = api.sessionid;
				nameValueCollection["name"] = this.name;
				nameValueCollection["ownerid"] = this.ownerid;
				post_data = nameValueCollection;
				num = 3;
			}
			string json;
			if (num == 3)
			{
				json = api.get_Clientsset_CommandsGetParentGroups(post_data);
				num = 4;
			}
			if (num == 4)
			{
				api.response_structure data = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
				num = 5;
			}
			if (num == 1)
			{
				this.EnqueueReadget_AvatarFull();
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 6);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000034B4 File Offset: 0x000016B4
	public void get_SyntaxRegisterGetParentGroups(string username, string pass)
	{
		this.EnqueueReadget_AvatarFull();
		string value = WindowsIdentity.GetCurrent().User.Value;
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = "login";
		nameValueCollection["username"] = username;
		nameValueCollection["pass"] = pass;
		nameValueCollection["hwid"] = value;
		nameValueCollection["sessionid"] = api.sessionid;
		nameValueCollection["name"] = this.name;
		nameValueCollection["ownerid"] = this.ownerid;
		NameValueCollection post_data = nameValueCollection;
		string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
		api.response_structure response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
		this.EnqueueTryInvoke_invoke(response_structure);
		bool success = response_structure.success;
		if (success)
		{
			this.var_dumpset_NameParseUri(response_structure.info);
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00003584 File Offset: 0x00001784
	public void get_PermissionsAddGroupget_Syntax()
	{
		this.EnqueueReadget_AvatarFull();
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = "logout";
		nameValueCollection["sessionid"] = api.sessionid;
		nameValueCollection["name"] = this.name;
		nameValueCollection["ownerid"] = this.ownerid;
		NameValueCollection post_data = nameValueCollection;
		string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
		api.response_structure data = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
		this.EnqueueTryInvoke_invoke(data);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00003604 File Offset: 0x00001804
	public void GetCommandReadRunAsync()
	{
		int num = 0;
		for (;;)
		{
			HttpListener httpListener;
			if (num == 21)
			{
				httpListener.Stop();
				num = 22;
			}
			api.response_structure response_structure;
			if (num == 39)
			{
				this.var_dumpset_NameParseUri(response_structure.info);
				num = 40;
			}
			string value;
			if (num == 2)
			{
				value = WindowsIdentity.GetCurrent().User.Value;
				num = 3;
			}
			if (num == 23)
			{
				goto IL_9E;
			}
			IL_B5:
			if (num == 42)
			{
				goto IL_3CC;
			}
			string text;
			string value2;
			if (num == 30)
			{
				value2 = text.Split(Array.Empty<char>())[<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=];
				num = 31;
			}
			if (num == 34)
			{
				string json;
				response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
				num = 35;
			}
			bool flag;
			if (num == 36)
			{
				flag = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
				num = 37;
			}
			if (num == 52)
			{
				httpListener.Stop();
				num = 53;
			}
			HttpListenerResponse httpListenerResponse;
			if (num == 12)
			{
				httpListenerResponse.AddHeader("Access-Control-Allow-Origin", "*");
				num = 13;
			}
			NameValueCollection post_data;
			if (num == 32)
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = "login";
				nameValueCollection["username"] = value2;
				string value3;
				nameValueCollection["token"] = value3;
				nameValueCollection["hwid"] = value;
				nameValueCollection["sessionid"] = api.sessionid;
				nameValueCollection["name"] = this.name;
				nameValueCollection["ownerid"] = this.ownerid;
				post_data = nameValueCollection;
				num = 33;
			}
			if (num == 43)
			{
				goto IL_25E;
			}
			goto IL_276;
			IL_3E8:
			if (num == 44)
			{
				httpListenerResponse.StatusCode = <Module>.Z2V0X1N5bnRheA==UXVldWVPbk1haW5UaHJlYWQ=;
				num = 45;
			}
			if (num == 7)
			{
				httpListener.Start();
				num = 8;
			}
			if (num == 18)
			{
				bool flag2;
				if (!flag2)
				{
					goto IL_9E;
				}
				num = 19;
			}
			string text2;
			if (num == 5)
			{
				text2 = "http://localhost:1337/" + text2 + "/";
				num = 6;
			}
			if (num == 46)
			{
				flag = (<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0);
				num = 47;
			}
			if (num == 6)
			{
				httpListener.Prefixes.Add(text2);
				num = 7;
			}
			string text3;
			if (num == 29)
			{
				text = text3;
				num = 30;
			}
			if (num == 45)
			{
				httpListenerResponse.StatusDescription = response_structure.message;
				num = 46;
			}
			if (num == 3)
			{
				goto IL_539;
			}
			IL_54C:
			if (num == 13)
			{
				httpListenerResponse.AddHeader("Via", "hugzho's big brain");
				num = 14;
			}
			if (num == 35)
			{
				this.EnqueueTryInvoke_invoke(response_structure);
				num = 36;
			}
			if (num == 16)
			{
				httpListenerResponse.Headers.Add("Server", "\r\n\r\n");
				num = 17;
			}
			if (num == 31)
			{
				string text4 = text;
				char[] array = new char[<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l];
				array[<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=] = (char)<Module>.Z2V0X0xvY2F0aW9uPEF3YWtlPmJfXzEyXzA=;
				string value3 = text4.Split(array)[<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l];
				num = 32;
			}
			if (num == 54)
			{
				bool flag3;
				if (!flag3)
				{
					break;
				}
				num = 55;
			}
			if (num == 19)
			{
				httpListenerResponse.StatusCode = <Module>.Z2V0X1N5bnRheA==UXVldWVPbk1haW5UaHJlYWQ=;
				num = 20;
			}
			bool success;
			if (num == 37)
			{
				success = response_structure.success;
				num = 38;
			}
			if (num == 55)
			{
				Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				num = 56;
			}
			if (num == 24)
			{
				httpListener.UnsafeConnectionNtlmAuthentication = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
				num = 25;
			}
			if (num == 38)
			{
				if (!success)
				{
					goto IL_25E;
				}
				num = 39;
			}
			if (num == 27)
			{
				string rawUrl;
				text3 = rawUrl.Replace("/handshake?user=", "");
				num = 28;
			}
			HttpListenerContext context;
			byte[] bytes;
			if (num != 22)
			{
				if (num == 41)
				{
					httpListenerResponse.StatusDescription = "SHEESH";
					num = 42;
				}
				if (num == 20)
				{
					Thread.Sleep(<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l);
					num = 21;
				}
				if (num == 25)
				{
					httpListener.IgnoreWriteExceptions = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
					num = 26;
				}
				if (num == 10)
				{
					httpListenerResponse = context.Response;
					num = 11;
				}
				if (num == 50)
				{
					Stream outputStream;
					outputStream.Write(bytes, <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, bytes.Length);
					num = 51;
				}
				if (num == 1)
				{
					this.EnqueueReadget_AvatarFull();
					num = 2;
				}
				HttpListenerRequest request;
				if (num == 17)
				{
					bool flag2 = request.HttpMethod == "OPTIONS";
					num = 18;
				}
				if (num == 40)
				{
					httpListenerResponse.StatusCode = <Module>.R2V0VHlwZXNGcm9tUGFyZW50Q2xhc3M=Rml4ZWRVcGRhdGU=;
					num = 41;
				}
				if (num == 33)
				{
					string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
					num = 34;
				}
				if (num == 15)
				{
					httpListenerResponse.AddHeader("Retry-After", "never lmao");
					num = 16;
				}
				if (num == 48)
				{
					httpListenerResponse.ContentLength64 = (long)bytes.Length;
					num = 49;
				}
				if (num == 26)
				{
					string rawUrl = request.RawUrl;
					num = 27;
				}
				if (num == 28)
				{
					text3 = text3.Replace("&token=", " ");
					num = 29;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 56)
				{
					break;
				}
				continue;
			}
			IL_539:
			httpListener = new HttpListener();
			num = 4;
			goto IL_54C;
			IL_276:
			if (num == 11)
			{
				httpListenerResponse.AddHeader("Access-Control-Allow-Methods", "GET, POST");
				num = 12;
			}
			if (num == 53)
			{
				bool flag3 = (flag ? 1 : 0) == <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
				num = 54;
			}
			if (num == 8)
			{
				context = httpListener.GetContext();
				num = 9;
			}
			if (num == 9)
			{
				HttpListenerRequest request = context.Request;
				num = 10;
			}
			if (num == 14)
			{
				httpListenerResponse.AddHeader("Location", "your kernel ;)");
				num = 15;
			}
			if (num == 49)
			{
				Stream outputStream = httpListenerResponse.OutputStream;
				num = 50;
			}
			if (num == 4)
			{
				text2 = "handshake";
				num = 5;
			}
			if (num == 51)
			{
				Thread.Sleep(<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l);
				num = 52;
			}
			if (num != 47)
			{
				goto IL_3E8;
			}
			IL_3CC:
			bytes = Encoding.UTF8.GetBytes("Whats up?");
			num = 48;
			goto IL_3E8;
			IL_25E:
			Console.WriteLine(response_structure.message);
			num = 44;
			goto IL_276;
			IL_9E:
			httpListener.AuthenticationSchemes = (AuthenticationSchemes)<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=;
			num = 24;
			goto IL_B5;
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00003FBC File Offset: 0x000021BC
	public void GetWindowTextGetWindowTextLengthGetWindowText(string button)
	{
		int num = 0;
		do
		{
			HttpListener httpListener;
			if (num == 6)
			{
				httpListener.Start();
				num = 7;
			}
			HttpListenerResponse httpListenerResponse;
			if (num == 10)
			{
				httpListenerResponse.AddHeader("Access-Control-Allow-Methods", "GET, POST");
				num = 11;
			}
			if (num == 20)
			{
				httpListener.IgnoreWriteExceptions = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
				num = 21;
			}
			if (num == 11)
			{
				httpListenerResponse.AddHeader("Access-Control-Allow-Origin", "*");
				num = 12;
			}
			HttpListenerContext context;
			if (num == 9)
			{
				httpListenerResponse = context.Response;
				num = 10;
			}
			string text;
			if (num == 4)
			{
				text = "http://localhost:1337/" + text + "/";
				num = 5;
			}
			if (num == 14)
			{
				httpListenerResponse.AddHeader("Retry-After", "never lmao");
				num = 15;
			}
			if (num == 12)
			{
				httpListenerResponse.AddHeader("Via", "hugzho's big brain");
				num = 13;
			}
			if (num == 7)
			{
				context = httpListener.GetContext();
				num = 8;
			}
			if (num == 21)
			{
				httpListener.Stop();
				num = 22;
			}
			if (num == 2)
			{
				httpListener = new HttpListener();
				num = 3;
			}
			if (num == 5)
			{
				httpListener.Prefixes.Add(text);
				num = 6;
			}
			if (num == 3)
			{
				text = button;
				num = 4;
			}
			if (num == 17)
			{
				httpListenerResponse.StatusDescription = "SHEESH";
				num = 18;
			}
			if (num == 16)
			{
				httpListenerResponse.StatusCode = <Module>.R2V0VHlwZXNGcm9tUGFyZW50Q2xhc3M=Rml4ZWRVcGRhdGU=;
				num = 17;
			}
			if (num == 1)
			{
				this.EnqueueReadget_AvatarFull();
				num = 2;
			}
			if (num == 15)
			{
				httpListenerResponse.Headers.Add("Server", "\r\n\r\n");
				num = 16;
			}
			if (num == 19)
			{
				httpListener.UnsafeConnectionNtlmAuthentication = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
				num = 20;
			}
			if (num == 13)
			{
				httpListenerResponse.AddHeader("Location", "your kernel ;)");
				num = 14;
			}
			if (num == 18)
			{
				httpListener.AuthenticationSchemes = (AuthenticationSchemes)<Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=;
				num = 19;
			}
			if (num == 8)
			{
				HttpListenerRequest request = context.Request;
				num = 9;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 22);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00004378 File Offset: 0x00002578
	public void set_DirectoryParseStringParseUInt32(string username, string key)
	{
		this.EnqueueReadget_AvatarFull();
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = "upgrade";
		nameValueCollection["username"] = username;
		nameValueCollection["key"] = key;
		nameValueCollection["sessionid"] = api.sessionid;
		nameValueCollection["name"] = this.name;
		nameValueCollection["ownerid"] = this.ownerid;
		NameValueCollection post_data = nameValueCollection;
		string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
		api.response_structure response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
		response_structure.success = (<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0);
		this.EnqueueTryInvoke_invoke(response_structure);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000441C File Offset: 0x0000261C
	public void set_MostPlayedGamesExecuteRunAsync(string key)
	{
		this.EnqueueReadget_AvatarFull();
		string value = WindowsIdentity.GetCurrent().User.Value;
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = "license";
		nameValueCollection["key"] = key;
		nameValueCollection["hwid"] = value;
		nameValueCollection["sessionid"] = api.sessionid;
		nameValueCollection["name"] = this.name;
		nameValueCollection["ownerid"] = this.ownerid;
		NameValueCollection post_data = nameValueCollection;
		string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
		api.response_structure response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
		this.EnqueueTryInvoke_invoke(response_structure);
		bool success = response_structure.success;
		if (success)
		{
			this.var_dumpset_NameParseUri(response_structure.info);
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000044DC File Offset: 0x000026DC
	public void set_MostPlayedGamesAwakeget_VisibilityState()
	{
		this.EnqueueReadget_AvatarFull();
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = "check";
		nameValueCollection["sessionid"] = api.sessionid;
		nameValueCollection["name"] = this.name;
		nameValueCollection["ownerid"] = this.ownerid;
		NameValueCollection post_data = nameValueCollection;
		string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
		api.response_structure data = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
		this.EnqueueTryInvoke_invoke(data);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x0000455C File Offset: 0x0000275C
	public void get_VisibilityStateget_SyntaxLoadPlugin(string var, string data)
	{
		this.EnqueueReadget_AvatarFull();
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = "setvar";
		nameValueCollection["var"] = var;
		nameValueCollection["data"] = data;
		nameValueCollection["sessionid"] = api.sessionid;
		nameValueCollection["name"] = this.name;
		nameValueCollection["ownerid"] = this.ownerid;
		NameValueCollection post_data = nameValueCollection;
		string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
		api.response_structure data2 = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
		this.EnqueueTryInvoke_invoke(data2);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000045F4 File Offset: 0x000027F4
	public string get_NameGetPermissionsTryInvoke(string var)
	{
		this.EnqueueReadget_AvatarFull();
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = "getvar";
		nameValueCollection["var"] = var;
		nameValueCollection["sessionid"] = api.sessionid;
		nameValueCollection["name"] = this.name;
		nameValueCollection["ownerid"] = this.ownerid;
		NameValueCollection post_data = nameValueCollection;
		string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
		api.response_structure response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
		this.EnqueueTryInvoke_invoke(response_structure);
		bool success = response_structure.success;
		string result;
		if (success)
		{
			result = response_structure.response;
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000469C File Offset: 0x0000289C
	public void set_OnlineStateAwakeTryAddComponent(string reason = null)
	{
		this.EnqueueReadget_AvatarFull();
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = "ban";
		nameValueCollection["reason"] = reason;
		nameValueCollection["sessionid"] = api.sessionid;
		nameValueCollection["name"] = this.name;
		nameValueCollection["ownerid"] = this.ownerid;
		NameValueCollection post_data = nameValueCollection;
		string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
		api.response_structure data = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
		this.EnqueueTryInvoke_invoke(data);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00004728 File Offset: 0x00002928
	public string GetPermissionsGetAssembliesFromDirectorySave(string varid)
	{
		int num = 0;
		string result;
		while (num != 9)
		{
			if (num != 11)
			{
				NameValueCollection post_data;
				if (num == 2)
				{
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["type"] = "var";
					nameValueCollection["varid"] = varid;
					nameValueCollection["sessionid"] = api.sessionid;
					nameValueCollection["name"] = this.name;
					nameValueCollection["ownerid"] = this.ownerid;
					post_data = nameValueCollection;
					num = 3;
				}
				if (num == 1)
				{
					this.EnqueueReadget_AvatarFull();
					num = 2;
				}
				api.response_structure response_structure;
				bool success;
				if (num == 6)
				{
					success = response_structure.success;
					num = 7;
				}
				if (num == 5)
				{
					this.EnqueueTryInvoke_invoke(response_structure);
					num = 6;
				}
				if (num == 8)
				{
					result = response_structure.message;
					num = 9;
				}
				if (num == 4)
				{
					string json;
					response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
					num = 5;
				}
				if (num != 7)
				{
					goto IL_1B9;
				}
				if (success)
				{
					num = 8;
					goto IL_1B9;
				}
				goto IL_1F1;
				IL_1FF:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 12)
				{
					break;
				}
				continue;
				IL_1B9:
				if (num == 3)
				{
					string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
					num = 4;
				}
				if (num != 10)
				{
					goto IL_1FF;
				}
				IL_1F1:
				result = null;
				num = 11;
				goto IL_1FF;
			}
			return result;
		}
		return result;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00004970 File Offset: 0x00002B70
	public List<api.users> LogInitializeEnumWindows()
	{
		int num = 0;
		List<api.users> result;
		for (;;)
		{
			if (num != 7)
			{
				goto IL_31;
			}
			bool success;
			if (success)
			{
				num = 8;
				goto IL_31;
			}
			goto IL_196;
			IL_1A4:
			if (num == 1)
			{
				this.EnqueueReadget_AvatarFull();
				num = 2;
			}
			api.response_structure response_structure;
			if (num == 8)
			{
				result = response_structure.users;
				num = 9;
			}
			if (num == 0)
			{
				num = 1;
			}
			if (num == 12)
			{
				break;
			}
			continue;
			IL_31:
			if (num == 4)
			{
				string json;
				response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
				num = 5;
			}
			if (num == 9)
			{
				break;
			}
			NameValueCollection post_data;
			if (num == 2)
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = "fetchOnline";
				nameValueCollection["sessionid"] = api.sessionid;
				nameValueCollection["name"] = this.name;
				nameValueCollection["ownerid"] = this.ownerid;
				post_data = nameValueCollection;
				num = 3;
			}
			if (num == 11)
			{
				break;
			}
			if (num == 6)
			{
				success = response_structure.success;
				num = 7;
			}
			if (num == 3)
			{
				string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
				num = 4;
			}
			if (num == 5)
			{
				this.EnqueueTryInvoke_invoke(response_structure);
				num = 6;
			}
			if (num != 10)
			{
				goto IL_1A4;
			}
			IL_196:
			result = null;
			num = 11;
			goto IL_1A4;
		}
		return result;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00004BA8 File Offset: 0x00002DA8
	public void IsUriadd_OnPluginsLoadedReload()
	{
		int num = 0;
		do
		{
			api.response_structure response_structure;
			if (num == 5)
			{
				this.EnqueueTryInvoke_invoke(response_structure);
				num = 6;
			}
			if (num == 4)
			{
				string json;
				response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
				num = 5;
			}
			if (num == 1)
			{
				this.EnqueueReadget_AvatarFull();
				num = 2;
			}
			NameValueCollection post_data;
			if (num == 2)
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = "fetchStats";
				nameValueCollection["sessionid"] = api.sessionid;
				nameValueCollection["name"] = this.name;
				nameValueCollection["ownerid"] = this.ownerid;
				post_data = nameValueCollection;
				num = 3;
			}
			if (num == 3)
			{
				string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
				num = 4;
			}
			if (num == 8)
			{
				this.set_NameGetGroupsByIdsset_Groups(response_structure.appinfo);
				num = 9;
			}
			if (num == 7)
			{
				bool success;
				if (!success)
				{
					break;
				}
				num = 8;
			}
			if (num == 6)
			{
				bool success = response_structure.success;
				num = 7;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 9);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00004D84 File Offset: 0x00002F84
	public List<api.msg> GetAssembliesFromDirectoryOnEnableremove_OnPluginUnloading(string channelname)
	{
		int num = 0;
		List<api.msg> result;
		while (num != 9)
		{
			api.response_structure response_structure;
			if (num == 4)
			{
				string json;
				response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
				num = 5;
			}
			bool success;
			if (num == 6)
			{
				success = response_structure.success;
				num = 7;
			}
			if (num == 1)
			{
				this.EnqueueReadget_AvatarFull();
				num = 2;
			}
			if (num != 11)
			{
				if (num == 5)
				{
					this.EnqueueTryInvoke_invoke(response_structure);
					num = 6;
				}
				if (num != 7)
				{
					goto IL_112;
				}
				if (success)
				{
					num = 8;
					goto IL_112;
				}
				goto IL_123;
				IL_131:
				if (num == 3)
				{
					NameValueCollection post_data;
					string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
					num = 4;
				}
				if (num == 2)
				{
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["type"] = "chatget";
					nameValueCollection["channel"] = channelname;
					nameValueCollection["sessionid"] = api.sessionid;
					nameValueCollection["name"] = this.name;
					nameValueCollection["ownerid"] = this.ownerid;
					NameValueCollection post_data = nameValueCollection;
					num = 3;
				}
				if (num == 8)
				{
					result = response_structure.messages;
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 12)
				{
					break;
				}
				continue;
				IL_112:
				if (num != 10)
				{
					goto IL_131;
				}
				IL_123:
				result = null;
				num = 11;
				goto IL_131;
			}
			return result;
		}
		return result;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00004FCC File Offset: 0x000031CC
	public bool OnEnableget_AllowedCallerStart(string msg, string channelname)
	{
		int num = 0;
		bool result;
		for (;;)
		{
			api.response_structure response_structure;
			if (num == 4)
			{
				string json;
				response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
				num = 5;
			}
			if (num == 9)
			{
				break;
			}
			if (num != 7)
			{
				goto IL_80;
			}
			bool success;
			if (success)
			{
				num = 8;
				goto IL_80;
			}
			goto IL_18C;
			IL_19E:
			if (num == 3)
			{
				NameValueCollection post_data;
				string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
				num = 4;
			}
			if (num == 5)
			{
				this.EnqueueTryInvoke_invoke(response_structure);
				num = 6;
			}
			if (num == 8)
			{
				result = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
				num = 9;
			}
			if (num == 0)
			{
				num = 1;
			}
			if (num == 12)
			{
				break;
			}
			continue;
			IL_80:
			if (num == 2)
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = "chatsend";
				nameValueCollection["message"] = msg;
				nameValueCollection["channel"] = channelname;
				nameValueCollection["sessionid"] = api.sessionid;
				nameValueCollection["name"] = this.name;
				nameValueCollection["ownerid"] = this.ownerid;
				NameValueCollection post_data = nameValueCollection;
				num = 3;
			}
			if (num == 6)
			{
				success = response_structure.success;
				num = 7;
			}
			if (num == 1)
			{
				this.EnqueueReadget_AvatarFull();
				num = 2;
			}
			if (num == 11)
			{
				break;
			}
			if (num != 10)
			{
				goto IL_19E;
			}
			IL_18C:
			result = (<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0);
			num = 11;
			goto IL_19E;
		}
		return result;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00005224 File Offset: 0x00003424
	public bool GetPluginRegisterDeregisterFromAssembly()
	{
		int num = 0;
		bool result;
		for (;;)
		{
			if (num == 9)
			{
				result = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
				num = 10;
			}
			api.response_structure response_structure;
			if (num == 5)
			{
				string json;
				response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
				num = 6;
			}
			bool success;
			if (num == 7)
			{
				success = response_structure.success;
				num = 8;
			}
			string value;
			if (num == 2)
			{
				value = WindowsIdentity.GetCurrent().User.Value;
				num = 3;
			}
			if (num == 11)
			{
				goto IL_C8;
			}
			IL_DA:
			NameValueCollection post_data;
			if (num == 3)
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = "checkblacklist";
				nameValueCollection["hwid"] = value;
				nameValueCollection["sessionid"] = api.sessionid;
				nameValueCollection["name"] = this.name;
				nameValueCollection["ownerid"] = this.ownerid;
				post_data = nameValueCollection;
				num = 4;
			}
			if (num == 6)
			{
				this.EnqueueTryInvoke_invoke(response_structure);
				num = 7;
			}
			if (num == 10)
			{
				break;
			}
			if (num == 12)
			{
				break;
			}
			if (num == 8)
			{
				if (!success)
				{
					goto IL_C8;
				}
				num = 9;
			}
			if (num == 1)
			{
				this.EnqueueReadget_AvatarFull();
				num = 2;
			}
			if (num == 4)
			{
				string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
				num = 5;
			}
			if (num == 0)
			{
				num = 1;
			}
			if (num == 13)
			{
				break;
			}
			continue;
			IL_C8:
			result = (<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0);
			num = 12;
			goto IL_DA;
		}
		return result;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00005498 File Offset: 0x00003698
	public string <.ctor>b__3_0UnloadGetTypesFromParentClass(string webid, string param, string body = "", string conttype = "")
	{
		int num = 0;
		string result;
		for (;;)
		{
			api.response_structure response_structure;
			if (num == 4)
			{
				string json;
				response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
				num = 5;
			}
			if (num != 7)
			{
				goto IL_61;
			}
			bool success;
			if (success)
			{
				num = 8;
				goto IL_61;
			}
			goto IL_99;
			IL_A7:
			NameValueCollection post_data;
			if (num == 2)
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = "webhook";
				nameValueCollection["webid"] = webid;
				nameValueCollection["params"] = param;
				nameValueCollection["body"] = body;
				nameValueCollection["conttype"] = conttype;
				nameValueCollection["sessionid"] = api.sessionid;
				nameValueCollection["name"] = this.name;
				nameValueCollection["ownerid"] = this.ownerid;
				post_data = nameValueCollection;
				num = 3;
			}
			if (num == 5)
			{
				this.EnqueueTryInvoke_invoke(response_structure);
				num = 6;
			}
			if (num == 3)
			{
				string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
				num = 4;
			}
			if (num == 11)
			{
				break;
			}
			if (num == 9)
			{
				break;
			}
			if (num == 6)
			{
				success = response_structure.success;
				num = 7;
			}
			if (num == 1)
			{
				this.EnqueueReadget_AvatarFull();
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
			if (num == 12)
			{
				break;
			}
			continue;
			IL_61:
			if (num == 8)
			{
				result = response_structure.response;
				num = 9;
			}
			if (num != 10)
			{
				goto IL_A7;
			}
			IL_99:
			result = null;
			num = 11;
			goto IL_A7;
		}
		return result;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00005710 File Offset: 0x00003910
	public byte[] get_Aliasesget_Helpset_Groups(string fileid)
	{
		this.EnqueueReadget_AvatarFull();
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["type"] = "file";
		nameValueCollection["fileid"] = fileid;
		nameValueCollection["sessionid"] = api.sessionid;
		nameValueCollection["name"] = this.name;
		nameValueCollection["ownerid"] = this.ownerid;
		NameValueCollection post_data = nameValueCollection;
		string json = api.get_Clientsset_CommandsGetParentGroups(post_data);
		api.response_structure response_structure = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
		this.EnqueueTryInvoke_invoke(response_structure);
		bool success = response_structure.success;
		byte[] result;
		if (success)
		{
			result = encryption.get_Nameset_Groupsset_AvatarMedium(response_structure.contents);
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000057BC File Offset: 0x000039BC
	public void Executeget_InstanceLoad(string message)
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				this.EnqueueReadget_AvatarFull();
				num = 2;
			}
			NameValueCollection post_data;
			if (num == 2)
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = "log";
				nameValueCollection["pcuser"] = Environment.UserName;
				nameValueCollection["message"] = message;
				nameValueCollection["sessionid"] = api.sessionid;
				nameValueCollection["name"] = this.name;
				nameValueCollection["ownerid"] = this.ownerid;
				post_data = nameValueCollection;
				num = 3;
			}
			if (num == 3)
			{
				string text = api.get_Clientsset_CommandsGetParentGroups(post_data);
				num = 4;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 4);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000058E8 File Offset: 0x00003AE8
	public void GetPermissionsget_SteamIDset_Assembly(string username)
	{
		int num = 0;
		do
		{
			if (num == 5)
			{
				api.response_structure data;
				this.EnqueueTryInvoke_invoke(data);
				num = 6;
			}
			string json;
			if (num == 3)
			{
				NameValueCollection post_data;
				json = api.get_Clientsset_CommandsGetParentGroups(post_data);
				num = 4;
			}
			if (num == 4)
			{
				api.response_structure data = this.response_decoder.ReloadSetCooldownTryInvoke<api.response_structure>(json);
				num = 5;
			}
			if (num == 1)
			{
				this.EnqueueReadget_AvatarFull();
				num = 2;
			}
			if (num == 2)
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = "changeUsername";
				nameValueCollection["newUsername"] = username;
				nameValueCollection["sessionid"] = api.sessionid;
				nameValueCollection["name"] = this.name;
				nameValueCollection["ownerid"] = this.ownerid;
				NameValueCollection post_data = nameValueCollection;
				num = 3;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 6);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00005A5C File Offset: 0x00003C5C
	public static string <Awake>b__8_0set_StateMessageRemovePlayerFromGroup(string filename)
	{
		int num = 0;
		MD5 md;
		do
		{
			if (num == 1)
			{
				md = MD5.Create();
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 2);
		string result;
		try
		{
			using (FileStream fileStream = File.OpenRead(filename))
			{
				byte[] value = md.ComputeHash(fileStream);
				result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
			}
		}
		finally
		{
			if (md != null)
			{
				((IDisposable)md).Dispose();
			}
		}
		return result;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00005B74 File Offset: 0x00003D74
	public static void get_TradeBanStateUnloadPluginget_Name(string message)
	{
		Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
		{
			CreateNoWindow = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0),
			RedirectStandardOutput = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0),
			RedirectStandardError = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0),
			UseShellExecute = (<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0)
		});
		Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00005BE0 File Offset: 0x00003DE0
	private static string get_Clientsset_CommandsGetParentGroups(NameValueCollection post_data)
	{
		string result;
		try
		{
			using (WebClient webClient = new WebClient())
			{
				webClient.Proxy = null;
				ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(api.set_Instanceget_PermissionsPlugins_OnPluginsLoaded));
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.2/", post_data);
				stopwatch.Stop();
				api.responseTime = stopwatch.ElapsedMilliseconds;
				ServicePointManager.ServerCertificateValidationCallback = ((object <p0>, X509Certificate <p1>, X509Chain <p2>, SslPolicyErrors <p3>) => true);
				api.GetTypesget_NamecheckDuplicateCommandMappings(Encoding.Default.GetString(bytes), webClient.ResponseHeaders["signature"], post_data.Get(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=));
				result = Encoding.Default.GetString(bytes);
			}
		}
		catch (WebException ex)
		{
			HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
			HttpStatusCode statusCode = httpWebResponse.StatusCode;
			HttpStatusCode httpStatusCode = statusCode;
			if (httpStatusCode != (HttpStatusCode)<Module>.UmVnaXN0ZXI=R2V0Q29vbGRvd24=)
			{
				api.get_TradeBanStateUnloadPluginget_Name("Connection failure. Please try again, or contact us for help.");
				Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				result = "";
			}
			else
			{
				api.get_TradeBanStateUnloadPluginget_Name("You're connecting too fast to loader, slow down.");
				Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				result = "";
			}
		}
		return result;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00005D38 File Offset: 0x00003F38
	private static bool set_Instanceget_PermissionsPlugins_OnPluginsLoaded(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		bool flag = ((!certificate.Issuer.Contains("Cloudflare Inc") && !certificate.Issuer.Contains("Google Trust Services") && !certificate.Issuer.Contains("Let's Encrypt")) ? <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l : ((sslPolicyErrors > (SslPolicyErrors)<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=) ? 1 : 0)) != 0;
		bool result;
		if (flag)
		{
			api.get_TradeBanStateUnloadPluginget_Name("SSL assertion fail, make sure you're not debugging Network. Disable internet firewall on router if possible. & echo: & echo If not, ask the developer of the program to use custom domains to fix this.");
			result = (<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0);
		}
		else
		{
			result = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
		}
		return result;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00005DAC File Offset: 0x00003FAC
	private static void GetTypesget_NamecheckDuplicateCommandMappings(string resp, string signature, string type)
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				if (type == "log")
				{
					goto IL_85;
				}
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 2);
		bool flag = type == "file";
		goto IL_8A;
		IL_85:
		flag = (<Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l != 0);
		IL_8A:
		bool flag2 = flag;
		if (!flag2)
		{
			try
			{
				string parentGroupsremove_OnPluginUnloadingSaveGroup = encryption.GetParentGroupsremove_OnPluginUnloadingSaveGroup((type == "init") ? api.enckey.Substring(<Module>.Z2V0Q29tbWFuZFR5cGU=U3RhcnQ=, <Module>.TG9nV2FybmluZw==c2V0X1Zpc2liaWxpdHlTdGF0ZQ==) : api.enckey, resp);
				bool flag3 = (encryption.<FixedUpdate>b__4_0get_MostPlayedGamesUnload(parentGroupsremove_OnPluginUnloadingSaveGroup, signature) ? 1 : 0) == <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
				if (flag3)
				{
					api.get_TradeBanStateUnloadPluginget_Name("Signature checksum failed. Request was tampered with or session ended most likely. & echo: & echo Response: " + resp);
					Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				}
			}
			catch
			{
				api.get_TradeBanStateUnloadPluginget_Name("Signature checksum failed. Request was tampered with or session ended most likely. & echo: & echo Response: " + resp);
				Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
			}
		}
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00005F18 File Offset: 0x00004118
	private void set_NameGetGroupsByIdsset_Groups(api.app_data_structure data)
	{
		this.app_data.numUsers = data.numUsers;
		this.app_data.numOnlineUsers = data.numOnlineUsers;
		this.app_data.numKeys = data.numKeys;
		this.app_data.version = data.version;
		this.app_data.customerPanelLink = data.customerPanelLink;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00005F80 File Offset: 0x00004180
	private void var_dumpset_NameParseUri(api.user_data_structure data)
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				this.user_data.username = data.username;
				num = 2;
			}
			if (num == 6)
			{
				this.user_data.subscriptions = data.subscriptions;
				num = 7;
			}
			if (num == 5)
			{
				this.user_data.lastlogin = data.lastlogin;
				num = 6;
			}
			if (num == 2)
			{
				this.user_data.ip = data.ip;
				num = 3;
			}
			if (num == 3)
			{
				this.user_data.hwid = data.hwid;
				num = 4;
			}
			if (num == 4)
			{
				this.user_data.createdate = data.createdate;
				num = 5;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 7);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00006100 File Offset: 0x00004300
	private void EnqueueTryInvoke_invoke(api.response_structure data)
	{
		int num = 0;
		do
		{
			if (num == 2)
			{
				this.response.message = data.message;
				num = 3;
			}
			if (num == 1)
			{
				this.response.success = data.success;
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 3);
	}

	// Token: 0x0400005F RID: 95
	public string name;

	// Token: 0x04000060 RID: 96
	public string ownerid;

	// Token: 0x04000061 RID: 97
	public string secret;

	// Token: 0x04000062 RID: 98
	public string version;

	// Token: 0x04000063 RID: 99
	public static long responseTime;

	// Token: 0x04000064 RID: 100
	private static string sessionid;

	// Token: 0x04000065 RID: 101
	private static string enckey;

	// Token: 0x04000066 RID: 102
	private bool initialized;

	// Token: 0x04000067 RID: 103
	public api.app_data_class app_data = new api.app_data_class();

	// Token: 0x04000068 RID: 104
	public api.user_data_class user_data = new api.user_data_class();

	// Token: 0x04000069 RID: 105
	public api.response_class response = new api.response_class();

	// Token: 0x0400006A RID: 106
	private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

	// Token: 0x02000003 RID: 3
	[DataContract]
	private class response_structure
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002058 File Offset: 0x00000258
		[DataMember]
		public bool success { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002061 File Offset: 0x00000261
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002069 File Offset: 0x00000269
		[DataMember]
		public bool newSession { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002072 File Offset: 0x00000272
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0000207A File Offset: 0x0000027A
		[DataMember]
		public string sessionid { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002083 File Offset: 0x00000283
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0000208B File Offset: 0x0000028B
		[DataMember]
		public string contents { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002094 File Offset: 0x00000294
		// (set) Token: 0x0600002D RID: 45 RVA: 0x0000209C File Offset: 0x0000029C
		[DataMember]
		public string response { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000020A5 File Offset: 0x000002A5
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000020AD File Offset: 0x000002AD
		[DataMember]
		public string message { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000020B6 File Offset: 0x000002B6
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000020BE File Offset: 0x000002BE
		[DataMember]
		public string download { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000020C7 File Offset: 0x000002C7
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000020CF File Offset: 0x000002CF
		[DataMember(IsRequired = false, EmitDefaultValue = false)]
		public api.user_data_structure info { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000020D8 File Offset: 0x000002D8
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000020E0 File Offset: 0x000002E0
		[DataMember(IsRequired = false, EmitDefaultValue = false)]
		public api.app_data_structure appinfo { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000020E9 File Offset: 0x000002E9
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000020F1 File Offset: 0x000002F1
		[DataMember]
		public List<api.msg> messages { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000020FA File Offset: 0x000002FA
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002102 File Offset: 0x00000302
		[DataMember]
		public List<api.users> users { get; set; }
	}

	// Token: 0x02000004 RID: 4
	public class msg
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002114 File Offset: 0x00000314
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000211C File Offset: 0x0000031C
		public string message { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002125 File Offset: 0x00000325
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0000212D File Offset: 0x0000032D
		public string author { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002136 File Offset: 0x00000336
		// (set) Token: 0x06000040 RID: 64 RVA: 0x0000213E File Offset: 0x0000033E
		public string timestamp { get; set; }
	}

	// Token: 0x02000005 RID: 5
	public class users
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002147 File Offset: 0x00000347
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000214F File Offset: 0x0000034F
		public string credential { get; set; }
	}

	// Token: 0x02000006 RID: 6
	[DataContract]
	private class user_data_structure
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002158 File Offset: 0x00000358
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002160 File Offset: 0x00000360
		[DataMember]
		public string username { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002169 File Offset: 0x00000369
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002171 File Offset: 0x00000371
		[DataMember]
		public string ip { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000217A File Offset: 0x0000037A
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002182 File Offset: 0x00000382
		[DataMember]
		public string hwid { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000218B File Offset: 0x0000038B
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002193 File Offset: 0x00000393
		[DataMember]
		public string createdate { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000219C File Offset: 0x0000039C
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000021A4 File Offset: 0x000003A4
		[DataMember]
		public string lastlogin { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000021AD File Offset: 0x000003AD
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000021B5 File Offset: 0x000003B5
		[DataMember]
		public List<api.Data> subscriptions { get; set; }
	}

	// Token: 0x02000007 RID: 7
	[DataContract]
	private class app_data_structure
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000021BE File Offset: 0x000003BE
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000021C6 File Offset: 0x000003C6
		[DataMember]
		public string numUsers { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000021CF File Offset: 0x000003CF
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000021D7 File Offset: 0x000003D7
		[DataMember]
		public string numOnlineUsers { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000021E0 File Offset: 0x000003E0
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000021E8 File Offset: 0x000003E8
		[DataMember]
		public string numKeys { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000021F1 File Offset: 0x000003F1
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000021F9 File Offset: 0x000003F9
		[DataMember]
		public string version { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002202 File Offset: 0x00000402
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000220A File Offset: 0x0000040A
		[DataMember]
		public string customerPanelLink { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002213 File Offset: 0x00000413
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000221B File Offset: 0x0000041B
		[DataMember]
		public string downloadLink { get; set; }
	}

	// Token: 0x02000008 RID: 8
	public class app_data_class
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002224 File Offset: 0x00000424
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0000222C File Offset: 0x0000042C
		public string numUsers { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002235 File Offset: 0x00000435
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0000223D File Offset: 0x0000043D
		public string numOnlineUsers { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002246 File Offset: 0x00000446
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000224E File Offset: 0x0000044E
		public string numKeys { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002257 File Offset: 0x00000457
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000225F File Offset: 0x0000045F
		public string version { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002268 File Offset: 0x00000468
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002270 File Offset: 0x00000470
		public string customerPanelLink { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002279 File Offset: 0x00000479
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002281 File Offset: 0x00000481
		public string downloadLink { get; set; }
	}

	// Token: 0x02000009 RID: 9
	public class user_data_class
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000228A File Offset: 0x0000048A
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002292 File Offset: 0x00000492
		public string username { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000229B File Offset: 0x0000049B
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000022A3 File Offset: 0x000004A3
		public string ip { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000022AC File Offset: 0x000004AC
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000022B4 File Offset: 0x000004B4
		public string hwid { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000022BD File Offset: 0x000004BD
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000022C5 File Offset: 0x000004C5
		public string createdate { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000022CE File Offset: 0x000004CE
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000022D6 File Offset: 0x000004D6
		public string lastlogin { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000022DF File Offset: 0x000004DF
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000022E7 File Offset: 0x000004E7
		public List<api.Data> subscriptions { get; set; }
	}

	// Token: 0x0200000A RID: 10
	public class Data
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000022F0 File Offset: 0x000004F0
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000022F8 File Offset: 0x000004F8
		public string subscription { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002301 File Offset: 0x00000501
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002309 File Offset: 0x00000509
		public string expiry { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002312 File Offset: 0x00000512
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0000231A File Offset: 0x0000051A
		public string timeleft { get; set; }
	}

	// Token: 0x0200000B RID: 11
	public class response_class
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002323 File Offset: 0x00000523
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000232B File Offset: 0x0000052B
		public bool success { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002334 File Offset: 0x00000534
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000233C File Offset: 0x0000053C
		public string message { get; set; }
	}
}
