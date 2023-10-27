using System;
using HighlightingSystem;
using SDG.Unturned;
using UnityEngine;

namespace OKAJDodfsOS0
{
	// Token: 0x0200000B RID: 11
	internal class CMPlayers : MonoBehaviour
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00005B90 File Offset: 0x00003D90
		public void IncreaseLocalPlayerScale()
		{
			this.scaleChanged = true;
			bool flag = this.playersScale > 0f;
			if (flag)
			{
				this.localPlayerScale += 1f;
				this.UpdatePlayers();
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005BD4 File Offset: 0x00003DD4
		public void DecreaseLocalPlayerScale()
		{
			this.scaleChanged = true;
			bool flag = this.playersScale > 0f;
			if (flag)
			{
				this.localPlayerScale -= 1f;
				this.UpdatePlayers();
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005C15 File Offset: 0x00003E15
		public void ResetPlayersScale()
		{
			this.localPlayerScale = 1f;
			this.playersScale = 1f;
			this.UpdatePlayers();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005C38 File Offset: 0x00003E38
		public void IncreasePlayersScale()
		{
			this.scaleChanged = true;
			bool flag = this.playersScale > 0f;
			if (flag)
			{
				this.playersScale += 1f;
				this.UpdatePlayers();
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005C7C File Offset: 0x00003E7C
		public void DecreasePlayersScale()
		{
			this.scaleChanged = true;
			bool flag = this.playersScale > 1f;
			if (flag)
			{
				this.playersScale -= 1f;
				this.UpdatePlayers();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005CC0 File Offset: 0x00003EC0
		private void Update()
		{
			bool flag = !CMConfig.enabled;
			if (!flag)
			{
				this.lastRefreshTime += Time.deltaTime;
				bool flag2 = this.lastRefreshTime > CMConfig.Players.refreshInterval;
				if (flag2)
				{
					this.UpdatePlayers();
					this.lastRefreshTime = 0f;
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005D14 File Offset: 0x00003F14
		private void OnGUI()
		{
			bool flag = !CMConfig.Players.enabled || !CMConfig.enabled;
			if (!flag)
			{
				this.DrawPlayers();
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005D44 File Offset: 0x00003F44
		private void DrawPlayers()
		{
			foreach (Player player in this.players)
			{
				try
				{
					this.DrawPlayer(player);
				}
				catch (Exception arg)
				{
					CMLogger.Log(string.Format("Ошибка при отрисовке игрока: {0}", arg));
				}
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005DA0 File Offset: 0x00003FA0
		private void DrawPlayer(Player player)
		{
			bool flag = player == this.localPlayer || player == null;
			if (!flag)
			{
				Vector3 position = player.transform.position;
				float num = Vector3.Distance(Camera.main.transform.position, position);
				bool flag2 = num > CMConfig.Players.maxDistance;
				if (!flag2)
				{
					Vector3 position2 = new Vector3(position.x, position.y, position.z);
					Vector3 position3 = new Vector3(position.x, position.y + 2f, position.z);
					Vector3 vector = Camera.main.WorldToScreenPoint(position2);
					Vector3 vector2 = Camera.main.WorldToScreenPoint(position3);
					bool flag3 = vector.z <= 0f;
					if (!flag3)
					{
						float num2 = vector2.y - vector.y;
						float num3 = num2 / 1.8f;
						Vector2 vector3 = vector;
						Vector2 vector4 = vector2;
						vector3.x = vector.x - num3 / 2f;
						vector4.x = vector2.x - num3 / 2f;
						vector3.y = (float)Screen.height - vector3.y;
						vector4.y = (float)Screen.height - vector4.y;
						Vector2 vector5 = new Vector2((float)Screen.width / 2f, (float)Screen.height);
						Vector2.Lerp(vector5, vector3, 0.8f);
						Color color = CMConfig.Players.defaultEspColor;
						float num4 = CMConfig.Players.defaultEspThickness;
						bool flag4 = CMConfig.Players.distanceVisible >= num;
						if (flag4)
						{
							color = CMConfig.Players.visibleEspColor;
							num4 = CMConfig.Players.visibleEspThickness;
						}
						bool isDead = player.life.isDead;
						if (isDead)
						{
							color = CMConfig.Players.deadEspColor;
							num4 = CMConfig.Players.deadEspThickness;
						}
						bool highlight = CMConfig.Players.highlight;
						if (highlight)
						{
							this.HighlightPlayer(player, CMConfig.Players.highlightColor);
						}
						else
						{
							this.UnhighlightPlayer(player);
						}
						bool espBox = CMConfig.Players.espBox;
						if (espBox)
						{
							CMDrawer.DrawBox(vector4.x, vector4.y, num3, num2, num4, color);
							bool flag5 = CMConfig.Players.espInfo && CMConfig.Players.espDistance && !CMConfig.Players.espLine;
							if (flag5)
							{
								this.DrawPlayerInfo(player, vector3, num, color, true);
							}
							else
							{
								bool flag6 = (CMConfig.Players.espInfo && !CMConfig.Players.espDistance) || CMConfig.Players.espLine;
								if (flag6)
								{
									this.DrawPlayerInfo(player, vector3, num, color, false);
								}
							}
							bool espLine = CMConfig.Players.espLine;
							if (espLine)
							{
								Vector2 vector6;
								switch (CMConfig.Players.espLineStart)
								{
								case CMConfig.Players.ESPLineStart.верх:
									vector6 = new Vector2((float)Screen.width / 2f, 0f);
									break;
								case CMConfig.Players.ESPLineStart.центр:
									vector6 = new Vector2((float)Screen.width / 2f, (float)Screen.height / 2f);
									break;
								case CMConfig.Players.ESPLineStart.низ:
									vector6 = vector5;
									break;
								default:
									vector6 = vector5;
									break;
								}
								this.DrawLine(vector6, new Vector2(vector.x, vector3.y), num4, color);
								bool espDistance = CMConfig.Players.espDistance;
								if (espDistance)
								{
									CMDrawer.DrawString(Vector2.Lerp(vector6, vector3, 0.7f), string.Format("{0}m", Mathf.Round(num)), CMConfig.Players.distanceColor, 1f, true, false);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000060FC File Offset: 0x000042FC
		private void DrawLine(Vector2 startPos, Vector2 playerFootPos, float espThickness, Color espColor)
		{
			CMDrawer.DrawLine(startPos, playerFootPos, espThickness, espColor);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000610C File Offset: 0x0000430C
		private void DrawPlayerInfo(Player player, Vector2 screenFootPos, float distanceToPlayer, Color color, bool showDistance = false)
		{
			string text = "<size=10>";
			text += player.channel.owner.playerID.characterName;
			bool isDead = player.life.isDead;
			if (isDead)
			{
				text += "\nМёртв";
			}
			bool flag = CMConfig.Players.espIsBleeding && player.life.isBleeding && !player.life.isDead;
			if (flag)
			{
				text += "\nКровотёк";
			}
			bool flag2 = CMConfig.Players.espIsBrokenLeg && player.life.isBroken;
			if (flag2)
			{
				text += "\nСломана нога";
			}
			bool flag3 = CMConfig.Players.espShowWeapon && player.equipment.asset != null;
			if (flag3)
			{
				text = text + "\n[" + player.equipment.asset.itemName + "]";
			}
			if (showDistance)
			{
				text += string.Format("\n{0}m", Mathf.Round(distanceToPlayer));
			}
			text += "</size>";
			float num = 120f;
			bool flag4 = distanceToPlayer > num;
			float num3;
			if (flag4)
			{
				float maxDistance = CMConfig.Players.maxDistance;
				float num2 = 0.5f;
				num3 = Mathf.Lerp(1f, num2, (distanceToPlayer - num) / (maxDistance - num));
				num3 = Mathf.Clamp(num3, num2, 1f);
			}
			else
			{
				num3 = 1f;
			}
			CMDrawer.DrawString(new Vector2(screenFootPos.x, screenFootPos.y), text, color, num3, true, true);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006298 File Offset: 0x00004498
		private void HighlightPlayer(Player player, Color color)
		{
			player.gameObject.GetComponent<Highlighter>().ConstantOnImmediate(color);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000062B0 File Offset: 0x000044B0
		private void UnhighlightPlayer(Player player)
		{
			try
			{
				player.GetComponent<Highlighter>().ConstantOffImmediate();
			}
			catch
			{
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000062E4 File Offset: 0x000044E4
		private void UpdatePlayers()
		{
			Player[] array = UnityEngine.Object.FindObjectsOfType<Player>();
			foreach (Player player in array)
			{
				bool flag = player.GetComponent<Highlighter>() == null;
				if (flag)
				{
					player.gameObject.AddComponent<Highlighter>();
				}
				bool flag2 = this.scaleChanged;
				if (flag2)
				{
					bool flag3 = player == this.localPlayer;
					if (flag3)
					{
						player.gameObject.transform.localScale = new Vector3(this.localPlayerScale, this.localPlayerScale, this.localPlayerScale);
					}
					else
					{
						player.gameObject.transform.localScale = new Vector3(this.playersScale, this.playersScale, this.playersScale);
					}
				}
			}
			bool flag4 = this.localPlayer == null;
			if (flag4)
			{
				this.localPlayer = this.GetLocalPlayer();
			}
			this.players = array;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000063D4 File Offset: 0x000045D4
		private Player GetLocalPlayer()
		{
			return Camera.main.GetComponentInParent<Player>();
		}

		// Token: 0x0400002F RID: 47
		public Player localPlayer;

		// Token: 0x04000030 RID: 48
		public Player[] players;

		// Token: 0x04000031 RID: 49
		public float playersScale = 1f;

		// Token: 0x04000032 RID: 50
		public float localPlayerScale = 1f;

		// Token: 0x04000033 RID: 51
		private bool scaleChanged;

		// Token: 0x04000034 RID: 52
		private float lastRefreshTime;
	}
}
