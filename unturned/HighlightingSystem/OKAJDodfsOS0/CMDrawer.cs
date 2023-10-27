using System;
using UnityEngine;

namespace OKAJDodfsOS0
{
	// Token: 0x02000005 RID: 5
	internal class CMDrawer
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002443 File Offset: 0x00000643
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000244A File Offset: 0x0000064A
		public static GUIStyle StringStyle { get; set; } = new GUIStyle(GUI.skin.label);

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002454 File Offset: 0x00000654
		// (set) Token: 0x06000010 RID: 16 RVA: 0x0000246B File Offset: 0x0000066B
		public static Color Color
		{
			get
			{
				return GUI.color;
			}
			set
			{
				GUI.color = value;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002478 File Offset: 0x00000678
		public static void DrawString(Vector2 position, string label, Color color, float sizeMultiplier = 1f, bool centered = true, bool bottom = false)
		{
			sizeMultiplier = 1f;
			Color color2 = GUI.color;
			GUI.color = Color.black;
			GUIContent content = new GUIContent(label);
			Vector2 vector = CMDrawer.StringStyle.CalcSize(content) * sizeMultiplier;
			if (bottom)
			{
				position.y += vector.y - 15f;
			}
			Vector2 vector2 = centered ? (position - vector / 2f) : position;
			int fontSize = CMDrawer.StringStyle.fontSize;
			CMDrawer.StringStyle.fontSize = (int)((float)fontSize * sizeMultiplier);
			Vector2 vector3 = vector2;
			GUI.Label(new Rect(vector3 + new Vector2(1f, 1f), vector), content);
			GUI.Label(new Rect(vector3 + new Vector2(-1f, -1f), vector), content);
			GUI.Label(new Rect(vector3 + new Vector2(-1f, 1f), vector), content);
			GUI.Label(new Rect(vector3 + new Vector2(1f, -1f), vector), content);
			GUI.color = color;
			GUI.Label(new Rect(vector3, vector), content);
			CMDrawer.StringStyle.fontSize = fontSize;
			GUI.color = color2;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000025C8 File Offset: 0x000007C8
		public static void DrawLine(Vector2 pointA, Vector2 pointB, float width, Color color)
		{
			Matrix4x4 matrix = GUI.matrix;
			Color color2 = GUI.color;
			GUI.color = color;
			float num = Vector3.Angle(pointB - pointA, Vector2.right);
			bool flag = pointA.y > pointB.y;
			if (flag)
			{
				num = -num;
			}
			GUIUtility.ScaleAroundPivot(new Vector2((pointB - pointA).magnitude, width), new Vector2(pointA.x, pointA.y + 0.5f));
			GUIUtility.RotateAroundPivot(num, pointA);
			GUI.DrawTexture(new Rect(pointA.x, pointA.y, 1f, 1f), CMDrawer.lineTex);
			GUI.matrix = matrix;
			GUI.color = color2;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000268C File Offset: 0x0000088C
		public static void DrawBox(float x, float y, float w, float h, float thickness, Color color)
		{
			CMDrawer.DrawLine(new Vector2(x, y), new Vector2(x + w, y), thickness, color);
			CMDrawer.DrawLine(new Vector2(x, y), new Vector2(x, y + h + 1f), thickness, color);
			CMDrawer.DrawLine(new Vector2(x + w, y), new Vector2(x + w, y + h), thickness, color);
			CMDrawer.DrawLine(new Vector2(x, y + h), new Vector2(x + w, y + h), thickness, color);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002710 File Offset: 0x00000910
		public static void DrawCircle(float FOV, Color color, float thickness = 2f)
		{
			float num = FOV / 90f * ((float)Screen.height / 2f);
			float num2 = (float)Screen.width;
			float num3 = (float)Screen.height;
			Vector2 b = new Vector2(num2 / 2f, num3 / 2f);
			int num4 = 24;
			for (int i = 0; i < num4; i++)
			{
				float f = 0.017453292f * ((float)i * 360f / (float)num4);
				Vector2 pointA = new Vector2(num * Mathf.Cos(f), num * Mathf.Sin(f)) + b;
				f = 0.017453292f * ((float)(i + 1) * 360f / (float)num4);
				Vector2 pointB = new Vector2(num * Mathf.Cos(f), num * Mathf.Sin(f)) + b;
				CMDrawer.DrawLine(pointA, pointB, thickness, color);
			}
		}

		// Token: 0x04000010 RID: 16
		private static Texture2D lineTex = new Texture2D(1, 1);
	}
}
