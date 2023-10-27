using System;
using UnityEngine;

namespace OKAJDodfsOS0
{
	// Token: 0x0200000C RID: 12
	internal class CMPlayersWindow
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00006410 File Offset: 0x00004610
		public static void Window(int WindowID)
		{
			float num = 5f;
			float num2 = 20f;
			float num3 = 140f;
			float height = 20f;
			float num4 = 10f;
			float num5 = 25f;
			float num6 = num;
			float num7 = num2;
			GUI.Label(new Rect(num6, num7, num3, height), "<b>ESP</b>");
			num7 += num5 - 5f;
			bool flag = GUI.Button(new Rect(num6, num7, num3, height), "Included: " + (CMConfig.Players.enabled ? "+" : "-"), CMInterface.buttonStyle);
			if (flag)
			{
				CMConfig.Players.enabled = !CMConfig.Players.enabled;
			}
			num7 += num5;
			bool flag2 = GUI.Button(new Rect(num6, num7, num3, height), "Box: " + (CMConfig.Players.espBox ? "+" : "-"), CMInterface.buttonStyle);
			if (flag2)
			{
				CMConfig.Players.espBox = !CMConfig.Players.espBox;
			}
			num7 += num5;
			bool flag3 = GUI.Button(new Rect(num6, num7, num3, height), "Line: " + (CMConfig.Players.espLine ? "+" : "-"), CMInterface.buttonStyle);
			if (flag3)
			{
				CMConfig.Players.espLine = !CMConfig.Players.espLine;
			}
			num7 += num5;
			bool flag4 = GUI.Button(new Rect(num6, num7, num3, height), string.Format("Line from: {0}", CMConfig.Players.espLineStart), CMInterface.buttonStyle);
			if (flag4)
			{
				switch (CMConfig.Players.espLineStart)
				{
				case CMConfig.Players.ESPLineStart.верх:
					CMConfig.Players.espLineStart = CMConfig.Players.ESPLineStart.центр;
					break;
				case CMConfig.Players.ESPLineStart.центр:
					CMConfig.Players.espLineStart = CMConfig.Players.ESPLineStart.низ;
					break;
				case CMConfig.Players.ESPLineStart.низ:
					CMConfig.Players.espLineStart = CMConfig.Players.ESPLineStart.верх;
					break;
				}
			}
			num7 += num5;
			bool flag5 = GUI.Button(new Rect(num6, num7, num3, height), "Information: " + (CMConfig.Players.espInfo ? "+" : "-"), CMInterface.buttonStyle);
			if (flag5)
			{
				CMConfig.Players.espInfo = !CMConfig.Players.espInfo;
			}
			num7 += num5;
			bool flag6 = GUI.Button(new Rect(num6, num7, num3, height), "Distance: " + (CMConfig.Players.espDistance ? "+" : "-"), CMInterface.buttonStyle);
			if (flag6)
			{
				CMConfig.Players.espDistance = !CMConfig.Players.espDistance;
			}
			num7 += num5;
			bool flag7 = GUI.Button(new Rect(num6, num7, num3, height), "Weapons in hand: " + (CMConfig.Players.espShowWeapon ? "+" : "-"), CMInterface.buttonStyle);
			if (flag7)
			{
				CMConfig.Players.espShowWeapon = !CMConfig.Players.espShowWeapon;
			}
			num7 += num5;
			bool flag8 = GUI.Button(new Rect(num6, num7, num3, height), "Contour (glow): " + (CMConfig.Players.highlight ? "+" : "-"), CMInterface.buttonStyle);
			if (flag8)
			{
				CMConfig.Players.highlight = !CMConfig.Players.highlight;
			}
			num7 += num5;
			GUI.Label(new Rect(num6, num7, num3, height), "<size=11>Max. distance (" + CMConfig.Players.maxDistance.ToString("0") + "):</size>");
			num7 += num5 - 5f;
			float num8 = GUI.HorizontalSlider(new Rect(num6, num7, num3, height), CMConfig.Players.maxDistance, 100f, 2000f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag9 = num8 != CMConfig.Players.maxDistance;
			if (flag9)
			{
				CMConfig.Players.maxDistance = num8;
			}
			num7 += num5 - 10f;
			GUI.Label(new Rect(num6, num7, num3, height), "<size=11>Update interval (" + CMConfig.Players.refreshInterval.ToString("0") + "):</size>");
			num7 += num5 - 5f;
			float num9 = GUI.HorizontalSlider(new Rect(num6, num7, num3, height), CMConfig.Players.refreshInterval, 0.1f, 10f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag10 = num9 != CMConfig.Players.refreshInterval;
			if (flag10)
			{
				CMConfig.Players.refreshInterval = num9;
			}
			num7 = num2;
			num6 += num3 + num4;
			GUI.Label(new Rect(num6, num7, num3, height), "<b>ESP Customization [RGB]</b>");
			num7 += num5 - 5f;
			GUI.Label(new Rect(num6, num7, num3, height), "Contour (glow)");
			num7 += num5 - 5f;
			float r = GUI.HorizontalSlider(new Rect(num6, num7, num3, height), CMConfig.Players.highlightColor.r, 0f, 1f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			num7 += num5 - 5f;
			float g = GUI.HorizontalSlider(new Rect(num6, num7, num3, height), CMConfig.Players.highlightColor.g, 0f, 1f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			num7 += num5 - 5f;
			float b = GUI.HorizontalSlider(new Rect(num6, num7, num3, height), CMConfig.Players.highlightColor.b, 0f, 1f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			Color color = new Color(r, g, b);
			bool flag11 = color != CMConfig.Players.highlightColor;
			if (flag11)
			{
				CMConfig.Players.highlightColor = color;
			}
			num7 += num5;
			GUI.Label(new Rect(num6, num7, num3, height), "Box (by default)");
			num7 += num5 - 5f;
			float r2 = GUI.HorizontalSlider(new Rect(num6, num7, num3, height), CMConfig.Players.defaultEspColor.r, 0f, 1f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			num7 += num5 - 5f;
			float g2 = GUI.HorizontalSlider(new Rect(num6, num7, num3, height), CMConfig.Players.defaultEspColor.g, 0f, 1f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			num7 += num5 - 5f;
			float b2 = GUI.HorizontalSlider(new Rect(num6, num7, num3, height), CMConfig.Players.defaultEspColor.b, 0f, 1f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			Color color2 = new Color(r2, g2, b2);
			bool flag12 = color2 != CMConfig.Players.defaultEspColor;
			if (flag12)
			{
				CMConfig.Players.defaultEspColor = color2;
			}
			num7 += num5;
			GUI.Label(new Rect(num6, num7, num3, height), "Box (<120m)");
			num7 += num5 - 5f;
			float r3 = GUI.HorizontalSlider(new Rect(num6, num7, num3, height), CMConfig.Players.visibleEspColor.r, 0f, 1f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			num7 += num5 - 5f;
			float g3 = GUI.HorizontalSlider(new Rect(num6, num7, num3, height), CMConfig.Players.visibleEspColor.g, 0f, 1f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			num7 += num5 - 5f;
			float b3 = GUI.HorizontalSlider(new Rect(num6, num7, num3, height), CMConfig.Players.visibleEspColor.b, 0f, 1f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			Color color3 = new Color(r3, g3, b3);
			bool flag13 = color3 != CMConfig.Players.visibleEspColor;
			if (flag13)
			{
				CMConfig.Players.visibleEspColor = color3;
			}
		}

		// Token: 0x04000035 RID: 53
		public static Rect playersWindowRect = new Rect(CMInterface.xOffset, CMInterface.yOffset, 300f, 315f);
	}
}
