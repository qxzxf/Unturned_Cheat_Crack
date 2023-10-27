using System;
using SDG.Unturned;
using UnityEngine;

namespace OKAJDodfsOS0
{
	// Token: 0x02000010 RID: 16
	internal class CMZombies : MonoBehaviour
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00007230 File Offset: 0x00005430
		private void Update()
		{
			bool flag = !CMConfig.Zombies.enabled || !CMConfig.enabled;
			if (!flag)
			{
				this.lastRefreshTime += Time.deltaTime;
				bool flag2 = this.lastRefreshTime > CMConfig.Zombies.refreshInterval;
				if (flag2)
				{
					this.UpdateZombies();
					this.lastRefreshTime = 0f;
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007290 File Offset: 0x00005490
		private void OnGUI()
		{
			bool flag = !CMConfig.Zombies.enabled || !CMConfig.enabled;
			if (!flag)
			{
				this.DrawZombies();
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000072C0 File Offset: 0x000054C0
		private void DrawZombies()
		{
			foreach (Zombie zombie in CMZombies.zombies)
			{
				try
				{
					this.DrawZombie(zombie);
				}
				catch (Exception arg)
				{
					CMLogger.Log(string.Format("Ошибка при отрисовке зомби: {0}", arg));
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000731C File Offset: 0x0000551C
		private void DrawZombie(Zombie zombie)
		{
			bool flag = zombie.isDead || zombie == null;
			if (!flag)
			{
				Vector3 position = zombie.transform.position;
				float num = Vector3.Distance(Camera.main.transform.position, position);
				bool flag2 = num > CMConfig.Zombies.maxDistance;
				if (!flag2)
				{
					Vector3 vector = Camera.main.WorldToScreenPoint(position);
					bool flag3 = vector.z <= 0f;
					if (!flag3)
					{
						vector.y = (float)Screen.height - vector.y;
						string text = zombie.name;
						bool showDistance = CMConfig.Zombies.showDistance;
						if (showDistance)
						{
							text += string.Format("\n{0}m", Mathf.Round(num));
						}
						CMDrawer.DrawString(vector, text, CMConfig.Zombies.espColor, 1f, true, false);
					}
				}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007400 File Offset: 0x00005600
		private void UpdateZombies()
		{
			CMZombies.zombies = UnityEngine.Object.FindObjectsOfType<Zombie>();
		}

		// Token: 0x04000038 RID: 56
		public static Zombie[] zombies;

		// Token: 0x04000039 RID: 57
		private float lastRefreshTime;
	}
}
