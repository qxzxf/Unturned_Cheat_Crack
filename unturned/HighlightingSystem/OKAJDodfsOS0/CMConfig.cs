using System;
using UnityEngine;

namespace OKAJDodfsOS0
{
	// Token: 0x02000004 RID: 4
	internal class CMConfig
	{
		// Token: 0x0400000C RID: 12
		public static bool debug = false;

		// Token: 0x0400000D RID: 13
		public static bool enabled = true;

		// Token: 0x0400000E RID: 14
		public static string version = "2.05";

		// Token: 0x02000023 RID: 35
		public static class Windows
		{
			// Token: 0x040000DF RID: 223
			public static bool mainWindow = true;

			// Token: 0x040000E0 RID: 224
			public static bool aimWindow = false;

			// Token: 0x040000E1 RID: 225
			public static bool playersWindow = false;

			// Token: 0x040000E2 RID: 226
			public static bool zombiesWindow = false;

			// Token: 0x040000E3 RID: 227
			public static bool vehiclesWindow = false;

			// Token: 0x040000E4 RID: 228
			public static bool itemsWindow = false;

			// Token: 0x040000E5 RID: 229
			public static bool miscWindow = false;

			// Token: 0x040000E6 RID: 230
			public static bool bindWindow = false;
		}

		// Token: 0x02000024 RID: 36
		public static class Aim
		{
			// Token: 0x040000E7 RID: 231
			public static bool enabled = false;

			// Token: 0x040000E8 RID: 232
			public static float angle = 30f;

			// Token: 0x040000E9 RID: 233
			public static float maxDistance = 512f;
		}

		// Token: 0x02000025 RID: 37
		public static class Players
		{
			// Token: 0x040000EA RID: 234
			public static bool enabled = true;

			// Token: 0x040000EB RID: 235
			public static float maxDistance = 700f;

			// Token: 0x040000EC RID: 236
			public static float refreshInterval = 1f;

			// Token: 0x040000ED RID: 237
			public static bool highlight = false;

			// Token: 0x040000EE RID: 238
			public static Color highlightColor = Color.yellow;

			// Token: 0x040000EF RID: 239
			public static bool espBox = true;

			// Token: 0x040000F0 RID: 240
			public static bool espLine = true;

			// Token: 0x040000F1 RID: 241
			public static bool espInfo = true;

			// Token: 0x040000F2 RID: 242
			public static bool espDistance = true;

			// Token: 0x040000F3 RID: 243
			public static bool espIsBleeding = true;

			// Token: 0x040000F4 RID: 244
			public static bool espIsBrokenLeg = true;

			// Token: 0x040000F5 RID: 245
			public static bool espShowWeapon = true;

			// Token: 0x040000F6 RID: 246
			public static float distanceVisible = 120f;

			// Token: 0x040000F7 RID: 247
			public static float distanceClose = 300f;

			// Token: 0x040000F8 RID: 248
			public static Color defaultEspColor = Color.green;

			// Token: 0x040000F9 RID: 249
			public static float defaultEspThickness = 1f;

			// Token: 0x040000FA RID: 250
			public static Color visibleEspColor = Color.red;

			// Token: 0x040000FB RID: 251
			public static float visibleEspThickness = 1.4f;

			// Token: 0x040000FC RID: 252
			public static Color deadEspColor = Color.black;

			// Token: 0x040000FD RID: 253
			public static float deadEspThickness = 0.5f;

			// Token: 0x040000FE RID: 254
			public static Color distanceColor = Color.gray;

			// Token: 0x040000FF RID: 255
			public static CMConfig.Players.ESPLineStart espLineStart = CMConfig.Players.ESPLineStart.низ;

			// Token: 0x0200003E RID: 62
			public enum ESPLineStart
			{
				// Token: 0x0400013C RID: 316
				верх,
				// Token: 0x0400013D RID: 317
				центр,
				// Token: 0x0400013E RID: 318
				низ
			}
		}

		// Token: 0x02000026 RID: 38
		public static class Vehicles
		{
			// Token: 0x04000100 RID: 256
			public static bool enabled = false;

			// Token: 0x04000101 RID: 257
			public static float maxDistance = 800f;

			// Token: 0x04000102 RID: 258
			public static float refreshInterval = 3f;

			// Token: 0x04000103 RID: 259
			public static bool showStats = true;

			// Token: 0x04000104 RID: 260
			public static bool showDistance = true;

			// Token: 0x04000105 RID: 261
			public static bool notLockedOnly = false;

			// Token: 0x04000106 RID: 262
			public static Color lockedColor = new Color(1f, 0.7f, 0.7f);

			// Token: 0x04000107 RID: 263
			public static Color notLockedColor = new Color(0.7f, 1f, 0.7f);

			// Token: 0x04000108 RID: 264
			public static Color drivenColor = new Color(1f, 1f, 0.7f);

			// Token: 0x04000109 RID: 265
			public static bool noClip = false;

			// Token: 0x0400010A RID: 266
			public static float noClipSpeedMultiplier = 1f;

			// Token: 0x0400010B RID: 267
			public static float xRotAmount = 1.5f;

			// Token: 0x0400010C RID: 268
			public static float yRotAmount = 2f;

			// Token: 0x0400010D RID: 269
			public static float zRotAmount = 1.5f;

			// Token: 0x0400010E RID: 270
			public static float yPosAmount = 0.2f;
		}

		// Token: 0x02000027 RID: 39
		public static class Items
		{
			// Token: 0x0400010F RID: 271
			public static bool enabled = false;

			// Token: 0x04000110 RID: 272
			public static float maxDistance = 120f;

			// Token: 0x04000111 RID: 273
			public static float refreshInterval = 1f;

			// Token: 0x04000112 RID: 274
			public static bool showCategory = true;

			// Token: 0x04000113 RID: 275
			public static bool showDistance = true;

			// Token: 0x04000114 RID: 276
			public static Color espColor = new Color(0.9f, 0.9f, 0.9f);
		}

		// Token: 0x02000028 RID: 40
		public static class Zombies
		{
			// Token: 0x04000115 RID: 277
			public static bool enabled = false;

			// Token: 0x04000116 RID: 278
			public static float maxDistance = 100f;

			// Token: 0x04000117 RID: 279
			public static float refreshInterval = 2f;

			// Token: 0x04000118 RID: 280
			public static bool showDistance = true;

			// Token: 0x04000119 RID: 281
			public static Color espColor = new Color(0.5f, 0.65f, 0.5f);
		}

		// Token: 0x02000029 RID: 41
		public static class Misc
		{
			// Token: 0x0400011A RID: 282
			public static bool noRecoil = false;

			// Token: 0x0400011B RID: 283
			public static bool noSpread = false;

			// Token: 0x0400011C RID: 284
			public static bool onlyHeadshots = false;

			// Token: 0x0400011D RID: 285
			public static bool buildAnywhere = false;

			// Token: 0x0400011E RID: 286
			public static bool crosshair = false;

			// Token: 0x0400011F RID: 287
			public static bool autoKick = true;

			// Token: 0x04000120 RID: 288
			public static bool autoReconnect = true;

			// Token: 0x04000121 RID: 289
			public static bool immediateSalvage = false;
		}
	}
}
