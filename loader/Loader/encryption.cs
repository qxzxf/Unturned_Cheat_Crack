using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200000D RID: 13
public static class encryption
{
	// Token: 0x06000088 RID: 136 RVA: 0x000061CC File Offset: 0x000043CC
	public static string GetParentGroupsremove_OnPluginUnloadingSaveGroup(string enckey, string resp)
	{
		int num = 0;
		string result;
		do
		{
			byte[] bytes;
			if (num == 1)
			{
				bytes = Encoding.ASCII.GetBytes(enckey);
				num = 2;
			}
			HMACSHA256 hmacsha;
			if (num == 3)
			{
				hmacsha = new HMACSHA256(bytes);
				num = 4;
			}
			if (num == 4)
			{
				byte[] bytes2;
				result = encryption.<FixedUpdate>b__4_0DeleteGroupLoadDefaults(hmacsha.ComputeHash(bytes2));
				num = 5;
			}
			if (num == 2)
			{
				byte[] bytes2 = Encoding.ASCII.GetBytes(resp);
				num = 3;
			}
			if (num == 5)
			{
				break;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 6);
		return result;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x000062F0 File Offset: 0x000044F0
	public static string <FixedUpdate>b__4_0DeleteGroupLoadDefaults(byte[] ba)
	{
		int num = 0;
		string result;
		for (;;)
		{
			if (num == 4)
			{
				goto IL_B2;
			}
			if (num == 2)
			{
				num = 3;
			}
			StringBuilder stringBuilder;
			byte b;
			if (num == 6)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
				num = 7;
			}
			if (num == 10)
			{
				break;
			}
			if (num == 8)
			{
				goto IL_B2;
			}
			goto IL_CA;
			IL_163:
			if (num == 1)
			{
				stringBuilder = new StringBuilder(ba.Length * <Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=);
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
			if (num == 11)
			{
				break;
			}
			continue;
			IL_CA:
			if (num == 9)
			{
				result = stringBuilder.ToString();
				num = 10;
			}
			int num2;
			if (num == 3)
			{
				num2 = <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
				num = 4;
			}
			if (num == 7)
			{
				num2 += <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l;
				num = 8;
			}
			if (num != 5)
			{
				goto IL_163;
			}
			IL_14D:
			b = ba[num2];
			num = 6;
			goto IL_163;
			IL_B2:
			if (num2 >= ba.Length)
			{
				num = 9;
				goto IL_CA;
			}
			goto IL_14D;
		}
		return result;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000064CC File Offset: 0x000046CC
	public static byte[] get_Nameset_Groupsset_AvatarMedium(string hex)
	{
		byte[] result;
		try
		{
			int length = hex.Length;
			byte[] array = new byte[length / <Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=];
			for (int i = <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=; i < length; i += <Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=)
			{
				array[i / <Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=] = Convert.ToByte(hex.Substring(i, <Module>.SW52b2tlR2V0R3JvdXBzQnlJZHM=), <Module>.TG9hZA==QnJvYWRjYXN0);
			}
			result = array;
		}
		catch
		{
			api.get_TradeBanStateUnloadPluginget_Name("The session has ended, open program again.");
			Environment.Exit(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
			result = null;
		}
		return result;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x0000655C File Offset: 0x0000475C
	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public static bool <FixedUpdate>b__4_0get_MostPlayedGamesUnload(string str1, string str2)
	{
		int num = 0;
		bool result;
		for (;;)
		{
			if (num != 11)
			{
				goto IL_31;
			}
			bool flag;
			if (!flag)
			{
				num = 12;
				goto IL_31;
			}
			goto IL_1E5;
			IL_213:
			if (num == 0)
			{
				num = 1;
			}
			if (num == 14)
			{
				break;
			}
			continue;
			IL_31:
			if (num == 7)
			{
				goto IL_84;
			}
			int num2;
			if (num == 6)
			{
				num2 = <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
				num = 7;
			}
			if (num == 10)
			{
				goto IL_84;
			}
			IL_A0:
			if (num == 9)
			{
				num2 += <Module>.R2V0UGVybWlzc2lvbnM=c2V0X0hlYWRsaW5l;
				num = 10;
			}
			if (num != 2)
			{
				goto IL_EC;
			}
			bool flag2;
			if (flag2)
			{
				num = 3;
				goto IL_EC;
			}
			goto IL_169;
			IL_17B:
			if (num == 13)
			{
				break;
			}
			if (num == 1)
			{
				flag2 = (((str1.Length == str2.Length) ? 1 : 0) == <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				num = 2;
			}
			if (num == 8)
			{
				goto IL_1E5;
			}
			goto IL_213;
			IL_EC:
			if (num == 4)
			{
				break;
			}
			int num3;
			if (num == 12)
			{
				result = (num3 == <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=);
				num = 13;
			}
			if (num == 3)
			{
				result = (<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ= != 0);
				num = 4;
			}
			if (num != 5)
			{
				goto IL_17B;
			}
			IL_169:
			num3 = <Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=;
			num = 6;
			goto IL_17B;
			IL_84:
			flag = (num2 < str1.Length);
			num = 11;
			goto IL_A0;
			IL_1E5:
			num3 |= (int)(str1[num2] ^ str2[num2]);
			num = 9;
			goto IL_213;
		}
		return result;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x000067B8 File Offset: 0x000049B8
	public static string GetTypesFromInterfaceget_DefaultTranslationsReload()
	{
		int num = 0;
		Guid guid;
		do
		{
			if (num == 1)
			{
				guid = Guid.NewGuid();
				num = 2;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 2);
		return guid.ToString().Substring(<Module>.c2V0X0Fzc2VtYmx5UGx1Z2luc19PblBsdWdpbnNMb2FkZWQ=, <Module>.TG9hZA==QnJvYWRjYXN0);
	}
}
