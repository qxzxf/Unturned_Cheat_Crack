using System;
using SDG.Unturned;
using UnityEngine;

namespace OKAJDodfsOS0
{
	// Token: 0x02000003 RID: 3
	internal class CMBase : MonoBehaviour
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002178 File Offset: 0x00000378
		private void Awake()
		{
			try
			{
				this.AddComponents();
			}
			catch (Exception arg)
			{
				CMLogger.Log(string.Format("Ошибка при добавлении компонентов: {0}", arg));
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021B8 File Offset: 0x000003B8
		private void Update()
		{
			this.timer += Time.deltaTime;
			bool flag = this.timer >= 120f;
			if (flag)
			{
				this.timer = 0f;
			}
			bool flag2 = !Provider.isConnected;
			if (flag2)
			{
				CMBase.hasToLeave = false;
			}
			CMBase.willBeKickedSoon = false;
			bool flag3 = CMBase.hasToLeave;
			if (flag3)
			{
				bool autoReconnect = CMConfig.Misc.autoReconnect;
				if (autoReconnect)
				{
					CMUtils.Reconnect();
				}
				else
				{
					CMUtils.Disconnect();
				}
			}
			bool keyDown = Input.GetKeyDown(KeyCode.Delete);
			if (keyDown)
			{
				CMConfig.enabled = !CMConfig.enabled;
			}
			bool flag4 = !CMConfig.enabled;
			if (flag4)
			{
				CMConfig.Windows.mainWindow = false;
				CMConfig.Windows.aimWindow = false;
				CMConfig.Windows.zombiesWindow = false;
				CMConfig.Windows.playersWindow = false;
				CMConfig.Windows.itemsWindow = false;
				CMConfig.Windows.vehiclesWindow = false;
				CMConfig.Windows.miscWindow = false;
			}
			else
			{
				bool key = Input.GetKey(KeyCode.LeftShift);
				if (!key)
				{
					bool keyDown2 = Input.GetKeyDown(KeyCode.F1);
					if (keyDown2)
					{
						CMConfig.Windows.mainWindow = !CMConfig.Windows.mainWindow;
					}
					bool keyDown3 = Input.GetKeyDown(KeyCode.F2);
					if (keyDown3)
					{
						CMConfig.Players.enabled = !CMConfig.Players.enabled;
					}
					bool keyDown4 = Input.GetKeyDown(KeyCode.F3);
					if (keyDown4)
					{
						CMConfig.Zombies.enabled = !CMConfig.Zombies.enabled;
					}
					bool keyDown5 = Input.GetKeyDown(KeyCode.F4);
					if (keyDown5)
					{
						CMConfig.Vehicles.enabled = !CMConfig.Vehicles.enabled;
					}
					bool keyDown6 = Input.GetKeyDown(KeyCode.F5);
					if (keyDown6)
					{
						CMConfig.Items.enabled = !CMConfig.Items.enabled;
					}
				}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002344 File Offset: 0x00000544
		private void AddComponents()
		{
			this.cmPatches = base.gameObject.AddComponent<CMPatches>();
			this.cmPatches.Init();
			this.cmPlayers = base.gameObject.AddComponent<CMPlayers>();
			this.cmZombies = base.gameObject.AddComponent<CMZombies>();
			this.cmVehicles = base.gameObject.AddComponent<CMVehicles>();
			this.cmItems = base.gameObject.AddComponent<CMItems>();
			this.cmInterface = base.gameObject.AddComponent<CMInterface>();
			this.cmInterface.SetModules(this.cmPlayers);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000023D8 File Offset: 0x000005D8
		public static void chipsi()
		{
			for (;;)
			{
				GameObject[] array = UnityEngine.Object.FindObjectsOfType<GameObject>();
				foreach (GameObject gameObject in array)
				{
					CMBase.chipsiki = array;
				}
			}
		}

		// Token: 0x04000001 RID: 1
		private CMPatches cmPatches;

		// Token: 0x04000002 RID: 2
		private CMPlayers cmPlayers;

		// Token: 0x04000003 RID: 3
		private CMVehicles cmVehicles;

		// Token: 0x04000004 RID: 4
		private CMItems cmItems;

		// Token: 0x04000005 RID: 5
		private CMZombies cmZombies;

		// Token: 0x04000006 RID: 6
		private CMInterface cmInterface;

		// Token: 0x04000007 RID: 7
		private float timer;

		// Token: 0x04000008 RID: 8
		public static bool hasToLeave = false;

		// Token: 0x04000009 RID: 9
		public static bool willBeKickedSoon = false;

		// Token: 0x0400000A RID: 10
		public static bool chips = true;

		// Token: 0x0400000B RID: 11
		public static GameObject[] chipsiki;
	}
}
