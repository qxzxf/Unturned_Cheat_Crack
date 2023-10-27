using System;
using System.IO;

namespace OKAJDodfsOS0
{
	// Token: 0x02000009 RID: 9
	internal class CMLogger
	{
		// Token: 0x06000031 RID: 49 RVA: 0x0000590C File Offset: 0x00003B0C
		public static void Log(string message)
		{
			bool flag = !CMConfig.debug;
			if (!flag)
			{
				using (StreamWriter streamWriter = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "log.txt"), true))
				{
					streamWriter.WriteLine(message);
				}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005968 File Offset: 0x00003B68
		public static void Reset()
		{
			bool flag = !CMConfig.debug;
			if (!flag)
			{
				File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "log.txt"), string.Empty);
			}
		}
	}
}
