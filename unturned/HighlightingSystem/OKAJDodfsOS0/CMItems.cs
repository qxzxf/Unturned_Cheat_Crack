using System;
using SDG.Unturned;
using UnityEngine;

namespace OKAJDodfsOS0
{
	// Token: 0x02000008 RID: 8
	internal class CMItems : MonoBehaviour
	{
		// Token: 0x0600002B RID: 43 RVA: 0x000056E0 File Offset: 0x000038E0
		private void Update()
		{
			bool flag = !CMConfig.Items.enabled || !CMConfig.enabled;
			if (!flag)
			{
				this.lastRefreshTime += Time.deltaTime;
				bool flag2 = this.lastRefreshTime > CMConfig.Items.refreshInterval;
				if (flag2)
				{
					this.UpdateItems();
					this.lastRefreshTime = 0f;
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005740 File Offset: 0x00003940
		private void OnGUI()
		{
			bool flag = !CMConfig.Items.enabled || !CMConfig.enabled;
			if (!flag)
			{
				this.DrawItems();
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005770 File Offset: 0x00003970
		private void DrawItems()
		{
			foreach (InteractableItem item in CMItems.items)
			{
				try
				{
					this.DrawItem(item);
				}
				catch (Exception arg)
				{
					CMLogger.Log(string.Format("Ошибка при отрисовке предмета: {0}", arg));
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000057CC File Offset: 0x000039CC
		private void DrawItem(InteractableItem item)
		{
			bool flag = item == null;
			if (!flag)
			{
				EItemType type = item.asset.type;
				Vector3 position = item.transform.position;
				float num = Vector3.Distance(Camera.main.transform.position, position);
				bool flag2 = num > CMConfig.Items.maxDistance;
				if (!flag2)
				{
					Vector3 vector = Camera.main.WorldToScreenPoint(position);
					bool flag3 = vector.z <= 0f;
					if (!flag3)
					{
						vector.y = (float)Screen.height - vector.y;
						string text = "<size=10>";
						text += item.asset.itemName;
						bool showCategory = CMConfig.Items.showCategory;
						if (showCategory)
						{
							text += string.Format("({0})", type);
						}
						bool showDistance = CMConfig.Items.showDistance;
						if (showDistance)
						{
							text += string.Format("\n{0}m", Mathf.Round(num));
						}
						text += "</size>";
						CMDrawer.DrawString(vector, text, CMConfig.Items.espColor, 1f, true, false);
					}
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000058FF File Offset: 0x00003AFF
		private void UpdateItems()
		{
			CMItems.items = UnityEngine.Object.FindObjectsOfType<InteractableItem>();
		}

		// Token: 0x0400002B RID: 43
		public static InteractableItem[] items;

		// Token: 0x0400002C RID: 44
		private float lastRefreshTime;
	}
}
