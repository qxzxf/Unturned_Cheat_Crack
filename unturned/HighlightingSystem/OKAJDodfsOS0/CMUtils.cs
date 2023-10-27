using System;
using SDG.Unturned;
using UnityEngine;

namespace OKAJDodfsOS0
{
	// Token: 0x0200000E RID: 14
	internal class CMUtils : MonoBehaviour
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00006B4C File Offset: 0x00004D4C
		public static string GenerateRandomString(int length)
		{
			System.Random random = new System.Random();
			char[] array = new char[length];
			for (int i = 0; i < length; i++)
			{
				array[i] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"[random.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Length)];
			}
			return new string(array);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006BA4 File Offset: 0x00004DA4
		public static void Reconnect()
		{
			SteamServerInfo currentServerInfo = Provider.currentServerInfo;
			Provider.disconnect();
			MenuPlayConnectUI.connect(new SteamConnectionInfo(currentServerInfo.ip, currentServerInfo.queryPort, ""), true);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006BDC File Offset: 0x00004DDC
		public static void Disconnect()
		{
			bool isConnected = Provider.isConnected;
			if (isConnected)
			{
				Provider.disconnect();
				CMBase.willBeKickedSoon = false;
				CMBase.hasToLeave = false;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006C08 File Offset: 0x00004E08
		public static Texture2D MakeTex(int width, int height, Color color)
		{
			Color[] array = new Color[width * height];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = color;
			}
			Texture2D texture2D = new Texture2D(width, height);
			texture2D.SetPixels(array);
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006C5C File Offset: 0x00004E5C
		public static Color ColorFromHEX(string hex)
		{
			Color color;
			bool flag = ColorUtility.TryParseHtmlString(hex, out color);
			Color result;
			if (flag)
			{
				result = color;
			}
			else
			{
				result = Color.gray;
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006C84 File Offset: 0x00004E84
		public static string HEXFromColor(Color color)
		{
			return ColorUtility.ToHtmlStringRGBA(color);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006C9C File Offset: 0x00004E9C
		public static bool IsPlayerInFOV(Vector3 cameraPosition, Vector3 cameraForward, Vector3 playerPosition)
		{
			Vector3 to = playerPosition - cameraPosition;
			return Vector3.Angle(cameraForward, to) <= CMConfig.Aim.angle;
		}
	}
}
