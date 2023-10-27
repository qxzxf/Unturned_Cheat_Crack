using System;
using System.Diagnostics;
using OKAJDodfsOS0;

// Token: 0x02000002 RID: 2
internal class SystemInfoHelper
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	private static string GetUserName()
	{
		return Environment.UserName;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
	private static string GetHWID()
	{
		Process process = new Process();
		process.StartInfo.FileName = "wmic";
		process.StartInfo.Arguments = "csproduct get uuid";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		string text = process.StandardOutput.ReadToEnd();
		process.WaitForExit();
		return text.Trim().Replace("\r", "").Split(new char[]
		{
			'\n'
		})[1].Trim();
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002110 File Offset: 0x00000310
	public static string GetUniqueIdentifier()
	{
		string result;
		try
		{
			string userName = SystemInfoHelper.GetUserName();
			string hwid = SystemInfoHelper.GetHWID();
			result = userName + ":" + hwid;
		}
		catch (Exception ex)
		{
			CMLogger.Log(ex.ToString());
			result = "";
		}
		return result;
	}
}
