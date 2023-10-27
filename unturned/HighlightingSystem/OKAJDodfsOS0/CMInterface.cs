using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

namespace OKAJDodfsOS0
{
	// Token: 0x02000007 RID: 7
	internal class CMInterface : MonoBehaviour
	{
		// Token: 0x0600001B RID: 27 RVA: 0x000029CC File Offset: 0x00000BCC
		private void Awake()
		{
			this.defaultTextColor = new Color(0.129f, 0.588f, 0.953f, 1f);
			this.windowBackground = CMUtils.MakeTex(2, 2, new Color(0.2f, 0.2f, 0.2f, 0.9f));
			this.buttonBackground = CMUtils.MakeTex(2, 2, new Color(0.3f, 0.3f, 0.3f, 0.8f));
			this.buttonHoverBackground = CMUtils.MakeTex(2, 2, new Color(0.35f, 0.35f, 0.4f, 0.8f));
			this.sliderBackground = CMUtils.MakeTex(200, 20, new Color(0.737f, 0.831f, 0.933f, 0.8f));
			this.sliderThumbBackground = CMUtils.MakeTex(20, 10, new Color(0.129f, 0.588f, 0.953f, 1f));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002AC0 File Offset: 0x00000CC0
		private void hideAllWindows()
		{
			try
			{
				Provider.modeConfigData.Gameplay.Timer_Leave_Group = 0U;
				Provider.modeConfigData.Gameplay.Satellite = true;
				Provider.modeConfigData.Gameplay.Timer_Exit = 0U;
				Provider.modeConfigData.Gameplay.Timer_Respawn = 0U;
			}
			catch
			{
			}
			CMConfig.Windows.aimWindow = false;
			CMConfig.Windows.playersWindow = false;
			CMConfig.Windows.zombiesWindow = false;
			CMConfig.Windows.vehiclesWindow = false;
			CMConfig.Windows.itemsWindow = false;
			CMConfig.Windows.miscWindow = false;
			CMConfig.Windows.bindWindow = false;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002B54 File Offset: 0x00000D54
		private void LateUpdate()
		{
			Time.timeScale = this.timeScale;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002B64 File Offset: 0x00000D64
		private void OnGUI()
		{
			this.ApplyGUIStyle();
			bool flag = !CMConfig.enabled;
			if (!flag)
			{
				bool willBeKickedSoon = CMBase.willBeKickedSoon;
				if (willBeKickedSoon)
				{
					GUI.Box(new Rect((float)Screen.width - 210f, 10f, 200f, 20f), "Вы скоро будете кикнуты!");
				}
				bool flag2 = CMConfig.Misc.crosshair && Provider.isConnected;
				if (flag2)
				{
					CMDrawer.DrawLine(new Vector2((float)Screen.width / 2f - 6f, (float)Screen.height / 2f - 1f), new Vector2((float)Screen.width / 2f + 6f, (float)Screen.height / 2f - 1f), 2f, Color.white);
					CMDrawer.DrawLine(new Vector2((float)Screen.width / 2f + 1f, (float)Screen.height / 2f - 6f), new Vector2((float)Screen.width / 2f + 1f, (float)Screen.height / 2f + 6f), 2f, Color.white);
				}
				bool enabled = CMConfig.Aim.enabled;
				if (enabled)
				{
					CMDrawer.DrawCircle(CMConfig.Aim.angle, new Color(1f, 0.1f, 0.2f), 1.5f);
				}
				bool flag3 = !CMConfig.Windows.mainWindow;
				if (flag3)
				{
					this.hideAllWindows();
				}
				bool mainWindow = CMConfig.Windows.mainWindow;
				if (mainWindow)
				{
					this.mainWindowRect = GUI.Window(0, this.mainWindowRect, new GUI.WindowFunction(this.MainWindow), "<b>HamsterHack v" + CMConfig.version + "</b>", CMInterface.windowStyle);
					bool debug = CMConfig.debug;
					if (debug)
					{
						float x = (float)Screen.width - 300f;
						float num = 30f;
						float num2 = 25f;
						GUI.Box(new Rect((float)Screen.width - 305f, 0f, 305f, (float)Screen.height), "Debug");
						bool flag4 = GUI.Button(new Rect(x, num, 140f, 20f), "Enable zoom", CMInterface.buttonStyle);
						if (flag4)
						{
							this.cmPlayers.localPlayer.look.enableZoom(10f);
						}
						num += num2;
						bool flag5 = GUI.Button(new Rect(x, num, 140f, 20f), "Disable zoom", CMInterface.buttonStyle);
						if (flag5)
						{
							this.cmPlayers.localPlayer.look.disableZoom();
						}
						num += num2;
						bool flag6 = GUI.Button(new Rect(x, num, 140f, 20f), "FPS Boost", CMInterface.buttonStyle);
						if (flag6)
						{
							try
							{
								base.gameObject.AddComponent<CMFPSBoost>().ToggleFPSBoost();
							}
							catch (Exception ex)
							{
								CMLogger.Log(ex.ToString());
							}
						}
						num += num2;
						bool flag7 = GUI.Button(new Rect(x, num, 140f, 20f), "Recoil", CMInterface.buttonStyle);
						if (flag7)
						{
							this.cmPlayers.localPlayer.look.recoil(10f, 10f, 10f, 10f);
						}
						num += num2;
						bool flag8 = GUI.Button(new Rect(x, num, 140f, 20f), "Respawn", CMInterface.buttonStyle);
						if (flag8)
						{
							this.cmPlayers.localPlayer.life.ReceiveRespawnRequest(false);
						}
						num += num2;
						bool flag9 = GUI.Button(new Rect(x, num, 140f, 20f), "Life stats", CMInterface.buttonStyle);
						if (flag9)
						{
							this.cmPlayers.localPlayer.life.ReceiveLifeStats(100, 100, 100, 100, 100, false, false);
						}
						num += num2;
						bool flag10 = GUI.Button(new Rect(x, num, 140f, 20f), "Stamina", CMInterface.buttonStyle);
						if (flag10)
						{
							this.cmPlayers.localPlayer.life.ReceiveModifyStamina(100);
						}
						num += num2;
						bool flag11 = GUI.Button(new Rect(x, num, 140f, 20f), "Jump", CMInterface.buttonStyle);
						if (flag11)
						{
							this.cmPlayers.localPlayer.movement.ReceivePluginJumpMultiplier(10f);
						}
						num += num2;
						bool flag12 = GUI.Button(new Rect(x, num, 140f, 20f), "Speed", CMInterface.buttonStyle);
						if (flag12)
						{
							this.cmPlayers.localPlayer.movement.ReceivePluginSpeedMultiplier(10f);
						}
						num += num2;
						bool flag13 = GUI.Button(new Rect(x, num, 140f, 20f), "Gravity", CMInterface.buttonStyle);
						if (flag13)
						{
							this.cmPlayers.localPlayer.movement.ReceivePluginGravityMultiplier(-5f);
						}
						num += num2;
						bool flag14 = GUI.Button(new Rect(x, num, 140f, 20f), "Teleport", CMInterface.buttonStyle);
						if (flag14)
						{
							this.cmPlayers.localPlayer.ReceiveTeleport(new Vector3(0f, 0f, 0f), 90);
						}
						num += num2;
						bool flag15 = GUI.Button(new Rect(x, num, 140f, 20f), string.Format("NoClip {0}", this.testbool), CMInterface.buttonStyle);
						if (flag15)
						{
							this.testbool = !this.testbool;
							bool flag16 = this.testbool;
							if (flag16)
							{
								Player localPlayer = this.cmPlayers.localPlayer;
								localPlayer.movement.enabled = false;
								Rigidbody component = localPlayer.GetComponent<Rigidbody>();
								component.constraints = RigidbodyConstraints.None;
								component.freezeRotation = false;
								component.useGravity = false;
								component.isKinematic = true;
								bool key = Input.GetKey(KeyCode.W);
								if (key)
								{
									component.MovePosition(localPlayer.transform.position + localPlayer.transform.forward * (1f * Time.fixedDeltaTime));
								}
							}
						}
						num += num2;
						bool flag17 = GUI.Button(new Rect(x, num, 140f, 20f), string.Format("timescale ({0}) +", this.timeScale), CMInterface.buttonStyle);
						if (flag17)
						{
							this.timeScale += 0.01f;
							Time.timeScale = this.timeScale;
						}
						num += num2;
						bool flag18 = GUI.Button(new Rect(x, num, 140f, 20f), string.Format("timescale ({0}) -", Time.timeScale), CMInterface.buttonStyle);
						if (flag18)
						{
							this.timeScale -= 0.01f;
							Time.timeScale = this.timeScale;
						}
						num += num2;
						RaycastHit raycastHit;
						bool flag19 = Physics.Raycast(new Ray(MainCamera.instance.transform.position, MainCamera.instance.transform.forward), out raycastHit, 500f, RayMasks.DAMAGE_CLIENT);
						if (flag19)
						{
							GUI.Label(new Rect(x, num, 140f, 20f), raycastHit.transform.gameObject.name);
							num += num2 - 5f;
							GUI.Label(new Rect(x, num, 140f, 20f), raycastHit.transform.gameObject.tag);
							num += num2 - 5f;
							GUI.Label(new Rect(x, num, 140f, 20f), raycastHit.transform.gameObject.layer.ToString());
							num += num2 - 5f;
							GUI.Label(new Rect(x, num, 140f, 20f), raycastHit.transform.position.ToString());
							num += num2 - 5f;
							GUI.Label(new Rect(x, num, 140f, 20f), raycastHit.transform.rotation.ToString());
							num += num2 - 5f;
						}
					}
				}
				bool aimWindow = CMConfig.Windows.aimWindow;
				if (aimWindow)
				{
					this.aimWindowRect = GUI.Window(1, this.aimWindowRect, new GUI.WindowFunction(this.AimWindow), "<b>Aim</b>", CMInterface.windowStyle);
				}
				bool playersWindow = CMConfig.Windows.playersWindow;
				if (playersWindow)
				{
					CMPlayersWindow.playersWindowRect = GUI.Window(2, CMPlayersWindow.playersWindowRect, new GUI.WindowFunction(CMPlayersWindow.Window), "<b>Players</b>", CMInterface.windowStyle);
				}
				bool zombiesWindow = CMConfig.Windows.zombiesWindow;
				if (zombiesWindow)
				{
					this.zombiesWindowRect = GUI.Window(3, this.zombiesWindowRect, new GUI.WindowFunction(this.ZombiesWindow), "<b>Zombie</b>", CMInterface.windowStyle);
				}
				bool vehiclesWindow = CMConfig.Windows.vehiclesWindow;
				if (vehiclesWindow)
				{
					this.vehiclesWindowRect = GUI.Window(4, this.vehiclesWindowRect, new GUI.WindowFunction(this.VehiclesWindow), "<b>Transport</b>", CMInterface.windowStyle);
				}
				bool itemsWindow = CMConfig.Windows.itemsWindow;
				if (itemsWindow)
				{
					this.itemsWindowRect = GUI.Window(5, this.itemsWindowRect, new GUI.WindowFunction(this.ItemsWindow), "<b>Items</b>", CMInterface.windowStyle);
				}
				bool miscWindow = CMConfig.Windows.miscWindow;
				if (miscWindow)
				{
					this.miscWindowRect = GUI.Window(6, this.miscWindowRect, new GUI.WindowFunction(this.MiscWindow), "<b>Other</b>", CMInterface.windowStyle);
				}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003554 File Offset: 0x00001754
		private void MainWindow(int WindowID)
		{
			bool flag = GUI.Button(new Rect(5f, 20f, 150f, 20f), "<b>Aim</b>", CMInterface.buttonStyle);
			if (flag)
			{
				this.SwitchWindow(CMInterface.CMWindow.Aim);
			}
			bool flag2 = GUI.Button(new Rect(5f, 45f, 150f, 20f), "<b>Players</b>", CMInterface.buttonStyle);
			if (flag2)
			{
				this.SwitchWindow(CMInterface.CMWindow.Players);
			}
			bool flag3 = GUI.Button(new Rect(5f, 70f, 150f, 20f), "<b>Zombie</b>", CMInterface.buttonStyle);
			if (flag3)
			{
				this.SwitchWindow(CMInterface.CMWindow.Zombies);
			}
			bool flag4 = GUI.Button(new Rect(5f, 95f, 150f, 20f), "<b>Transport</b>", CMInterface.buttonStyle);
			if (flag4)
			{
				this.SwitchWindow(CMInterface.CMWindow.Vehicles);
			}
			bool flag5 = GUI.Button(new Rect(5f, 120f, 150f, 20f), "<b>Items</b>", CMInterface.buttonStyle);
			if (flag5)
			{
				this.SwitchWindow(CMInterface.CMWindow.Items);
			}
			bool flag6 = GUI.Button(new Rect(5f, 145f, 150f, 20f), "<b>Other</b>", CMInterface.buttonStyle);
			if (flag6)
			{
				this.SwitchWindow(CMInterface.CMWindow.Misc);
			}
			bool flag7 = GUI.Button(new Rect(5f, 170f, 150f, 20f), "<b>Test</b>", CMInterface.buttonStyle);
			if (flag7)
			{
				this.SwitchWindow(CMInterface.CMWindow.Bind);
			}
			bool flag8 = GUI.Button(new Rect(5f, 195f, 75f, 20f), "<size=12>Reconnect</size>", CMInterface.buttonStyle);
			if (flag8)
			{
				CMUtils.Reconnect();
			}
			bool flag9 = GUI.Button(new Rect(80f, 195f, 75f, 20f), "<size=12>Exit</size>", CMInterface.buttonStyle);
			if (flag9)
			{
				CMUtils.Disconnect();
			}
			GUIStyle guistyle = new GUIStyle(GUI.skin.label);
			guistyle.alignment = TextAnchor.MiddleCenter;
			GUI.color = new Color(0.8f, 0.8f, 0.9f);
			GUI.Label(new Rect(5f, 206f, 150f, 25f), "<size=10><b>https://discord.gg/cbRn86CtfD</b></size>", guistyle);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000037A8 File Offset: 0x000019A8
		private void AimWindow(int WindowID)
		{
			float num = 20f;
			float num2 = 25f;
			bool flag = GUI.Button(new Rect(5f, num, 140f, 20f), "norecoil: " + (CMConfig.Misc.noRecoil ? "+" : "-"), CMInterface.buttonStyle);
			if (flag)
			{
				CMConfig.Misc.noRecoil = !CMConfig.Misc.noRecoil;
			}
			num += num2;
			bool flag2 = GUI.Button(new Rect(5f, num, 140f, 20f), "Antisampling: " + (CMConfig.Misc.noSpread ? "+" : "-"), CMInterface.buttonStyle);
			if (flag2)
			{
				CMConfig.Misc.noSpread = !CMConfig.Misc.noSpread;
			}
			num += num2;
			bool flag3 = GUI.Button(new Rect(5f, num, 140f, 20f), "Only head: " + (CMConfig.Misc.onlyHeadshots ? "+" : "-"), CMInterface.buttonStyle);
			if (flag3)
			{
				CMConfig.Misc.onlyHeadshots = !CMConfig.Misc.onlyHeadshots;
			}
			num += num2;
			bool flag4 = GUI.Button(new Rect(5f, num, 140f, 20f), "Included: " + (CMConfig.Aim.enabled ? "+" : "-"), CMInterface.buttonStyle);
			if (flag4)
			{
				CMConfig.Aim.enabled = !CMConfig.Aim.enabled;
			}
			num += num2;
			GUI.Label(new Rect(5f, num, 140f, 20f), "FOV (" + CMConfig.Aim.angle.ToString("0") + "):");
			num += num2 - 5f;
			float num3 = GUI.HorizontalSlider(new Rect(5f, num, 140f, 20f), CMConfig.Aim.angle, 1f, 360f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag5 = num3 != CMConfig.Aim.angle;
			if (flag5)
			{
				CMConfig.Aim.angle = num3;
			}
			num += num2 - 10f;
			GUI.Label(new Rect(5f, num, 140f, 20f), "Max. distance (" + CMConfig.Aim.maxDistance.ToString("0") + "):");
			num += num2 - 5f;
			float num4 = GUI.HorizontalSlider(new Rect(5f, num, 140f, 20f), CMConfig.Aim.maxDistance, 10f, 1024f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag6 = num4 != CMConfig.Aim.maxDistance;
			if (flag6)
			{
				CMConfig.Aim.maxDistance = num4;
			}
			num += num2 - 10f;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003A4C File Offset: 0x00001C4C
		private void ZombiesWindow(int WindowID)
		{
			float num = 20f;
			float num2 = 25f;
			bool flag = GUI.Button(new Rect(5f, num, 140f, 20f), "Included: " + (CMConfig.Zombies.enabled ? "+" : "-"), CMInterface.buttonStyle);
			if (flag)
			{
				CMConfig.Zombies.enabled = !CMConfig.Zombies.enabled;
			}
			num += num2;
			bool flag2 = GUI.Button(new Rect(5f, num, 140f, 20f), "Distance: " + (CMConfig.Zombies.showDistance ? "+" : "-"), CMInterface.buttonStyle);
			if (flag2)
			{
				CMConfig.Zombies.showDistance = !CMConfig.Zombies.showDistance;
			}
			num += num2;
			GUI.Label(new Rect(5f, num, 140f, 20f), "Max. distance (" + CMConfig.Zombies.maxDistance.ToString("0") + "):");
			num += num2 - 5f;
			float num3 = GUI.HorizontalSlider(new Rect(5f, num, 140f, 20f), CMConfig.Zombies.maxDistance, 10f, 500f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag3 = num3 != CMConfig.Zombies.maxDistance;
			if (flag3)
			{
				CMConfig.Zombies.maxDistance = num3;
			}
			num += num2 - 10f;
			GUI.Label(new Rect(5f, num, 140f, 20f), "Update interval (" + CMConfig.Zombies.refreshInterval.ToString("0") + "):");
			num += num2 - 5f;
			float num4 = GUI.HorizontalSlider(new Rect(5f, num, 140f, 20f), CMConfig.Zombies.refreshInterval, 0.1f, 10f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag4 = num4 != CMConfig.Zombies.refreshInterval;
			if (flag4)
			{
				CMConfig.Zombies.refreshInterval = num4;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003C3C File Offset: 0x00001E3C
		private void VehiclesWindow(int WindowID)
		{
			float num = 20f;
			float num2 = 25f;
			GUI.Label(new Rect(5f, num, 140f, 20f), "ESP");
			num += num2 - 5f;
			bool flag = GUI.Button(new Rect(5f, num, 140f, 20f), "Included: " + (CMConfig.Vehicles.enabled ? "+" : "-"), CMInterface.buttonStyle);
			if (flag)
			{
				CMConfig.Vehicles.enabled = !CMConfig.Vehicles.enabled;
			}
			num += num2;
			bool flag2 = GUI.Button(new Rect(5f, num, 140f, 20f), "Information: " + (CMConfig.Vehicles.showStats ? "+" : "-"), CMInterface.buttonStyle);
			if (flag2)
			{
				CMConfig.Vehicles.showStats = !CMConfig.Vehicles.showStats;
			}
			num += num2;
			bool flag3 = GUI.Button(new Rect(5f, num, 140f, 20f), "Distance: " + (CMConfig.Vehicles.showDistance ? "+" : "-"), CMInterface.buttonStyle);
			if (flag3)
			{
				CMConfig.Vehicles.showDistance = !CMConfig.Vehicles.showDistance;
			}
			num += num2;
			bool flag4 = GUI.Button(new Rect(5f, num, 140f, 20f), "Only open: " + (CMConfig.Vehicles.notLockedOnly ? "+" : "-"), CMInterface.buttonStyle);
			if (flag4)
			{
				CMConfig.Vehicles.notLockedOnly = !CMConfig.Vehicles.notLockedOnly;
			}
			num += num2;
			bool flag5 = GUI.Button(new Rect(5f, num, 140f, 20f), "Reset Rotation", CMInterface.buttonStyle);
			if (flag5)
			{
				Player player = Player.player;
				bool flag6 = player == null;
				Component component;
				if (flag6)
				{
					component = null;
				}
				else
				{
					PlayerMovement movement = player.movement;
					component = ((movement != null) ? movement.getVehicle() : null);
				}
				component.transform.localRotation = Quaternion.identity;
			}
			num += num2;
			GUI.Label(new Rect(5f, num, 140f, 20f), "Max. distance (" + CMConfig.Vehicles.maxDistance.ToString("0") + "):");
			num += num2 - 5f;
			float num3 = GUI.HorizontalSlider(new Rect(5f, num, 140f, 20f), CMConfig.Vehicles.maxDistance, 100f, 2000f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag7 = num3 != CMConfig.Vehicles.maxDistance;
			if (flag7)
			{
				CMConfig.Vehicles.maxDistance = num3;
			}
			num += num2 - 10f;
			GUI.Label(new Rect(5f, num, 140f, 20f), "Update interval (" + CMConfig.Vehicles.refreshInterval.ToString("0") + "):");
			num += num2 - 5f;
			float num4 = GUI.HorizontalSlider(new Rect(5f, num, 140f, 20f), CMConfig.Vehicles.refreshInterval, 0.1f, 10f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag8 = num4 != CMConfig.Vehicles.refreshInterval;
			if (flag8)
			{
				CMConfig.Vehicles.refreshInterval = num4;
			}
			num = 20f;
			GUI.Label(new Rect(155f, num, 140f, 20f), "NoClip");
			num += num2 - 5f;
			bool flag9 = GUI.Button(new Rect(155f, num, 140f, 20f), "Included: " + (CMConfig.Vehicles.noClip ? "+" : "-"), CMInterface.buttonStyle);
			if (flag9)
			{
				CMConfig.Vehicles.noClip = !CMConfig.Vehicles.noClip;
			}
			num += num2;
			GUI.Label(new Rect(155f, num, 140f, 20f), "Speed Multiplier [W/S] (" + CMConfig.Vehicles.noClipSpeedMultiplier.ToString("0") + "):");
			num += num2 - 5f;
			float num5 = GUI.HorizontalSlider(new Rect(155f, num, 140f, 20f), CMConfig.Vehicles.noClipSpeedMultiplier, 0.01f, 10f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag10 = num5 != CMConfig.Vehicles.noClipSpeedMultiplier;
			if (flag10)
			{
				CMConfig.Vehicles.noClipSpeedMultiplier = num5;
			}
			num += num2 - 10f;
			GUI.Label(new Rect(155f, num, 140f, 20f), "Y position [shift/space] (" + CMConfig.Vehicles.yPosAmount.ToString("0") + "):");
			num += num2 - 5f;
			float num6 = GUI.HorizontalSlider(new Rect(155f, num, 140f, 20f), CMConfig.Vehicles.yPosAmount, 0.01f, 10f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag11 = num6 != CMConfig.Vehicles.yPosAmount;
			if (flag11)
			{
				CMConfig.Vehicles.yPosAmount = num6;
			}
			num += num2 - 10f;
			GUI.Label(new Rect(155f, num, 140f, 20f), "Y rotation [A/D] (" + CMConfig.Vehicles.yRotAmount.ToString("0") + "):");
			num += num2 - 5f;
			float num7 = GUI.HorizontalSlider(new Rect(155f, num, 140f, 20f), CMConfig.Vehicles.yRotAmount, 0.01f, 10f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag12 = num7 != CMConfig.Vehicles.yRotAmount;
			if (flag12)
			{
				CMConfig.Vehicles.yRotAmount = num7;
			}
			num += num2 - 10f;
			GUI.Label(new Rect(155f, num, 140f, 20f), "X rotation [↑/↓] (" + CMConfig.Vehicles.xRotAmount.ToString("0") + "):");
			num += num2 - 5f;
			float num8 = GUI.HorizontalSlider(new Rect(155f, num, 140f, 20f), CMConfig.Vehicles.xRotAmount, 0.01f, 10f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag13 = num8 != CMConfig.Vehicles.xRotAmount;
			if (flag13)
			{
				CMConfig.Vehicles.xRotAmount = num8;
			}
			num += num2 - 10f;
			GUI.Label(new Rect(155f, num, 140f, 20f), "Z rotation [←/→] (" + CMConfig.Vehicles.zRotAmount.ToString("0") + "):");
			num += num2 - 5f;
			float num9 = GUI.HorizontalSlider(new Rect(155f, num, 140f, 20f), CMConfig.Vehicles.zRotAmount, 0.01f, 10f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag14 = num9 != CMConfig.Vehicles.zRotAmount;
			if (flag14)
			{
				CMConfig.Vehicles.zRotAmount = num9;
			}
			num += num2 - 10f;
			num = 20f;
			GUI.Label(new Rect(305f, num, 140f, 20f), "Other");
			num += num2 - 5f;
			bool flag15 = GUI.Button(new Rect(305f, num, 140f, 20f), "Refuel", CMInterface.buttonStyle);
			if (flag15)
			{
				Player player2 = Player.player;
				bool flag16 = player2 == null;
				InteractableVehicle interactableVehicle;
				if (flag16)
				{
					interactableVehicle = null;
				}
				else
				{
					PlayerMovement movement2 = player2.movement;
					interactableVehicle = ((movement2 != null) ? movement2.getVehicle() : null);
				}
				interactableVehicle.askFillFuel(100);
			}
			num += num2;
			bool flag17 = GUI.Button(new Rect(305f, num, 140f, 20f), "Charge the battery", CMInterface.buttonStyle);
			if (flag17)
			{
				Player player3 = Player.player;
				bool flag18 = player3 == null;
				InteractableVehicle interactableVehicle2;
				if (flag18)
				{
					interactableVehicle2 = null;
				}
				else
				{
					PlayerMovement movement3 = player3.movement;
					interactableVehicle2 = ((movement3 != null) ? movement3.getVehicle() : null);
				}
				interactableVehicle2.askChargeBattery(100);
			}
			num += num2;
			bool flag19 = GUI.Button(new Rect(305f, num, 140f, 20f), "Repair", CMInterface.buttonStyle);
			if (flag19)
			{
				Player player4 = Player.player;
				bool flag20 = player4 == null;
				InteractableVehicle interactableVehicle3;
				if (flag20)
				{
					interactableVehicle3 = null;
				}
				else
				{
					PlayerMovement movement4 = player4.movement;
					interactableVehicle3 = ((movement4 != null) ? movement4.getVehicle() : null);
				}
				interactableVehicle3.askRepair(100);
			}
			num += num2;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000044A8 File Offset: 0x000026A8
		private void ItemsWindow(int WindowID)
		{
			float num = 20f;
			float num2 = 25f;
			bool flag = GUI.Button(new Rect(5f, num, 140f, 20f), "Included: " + (CMConfig.Items.enabled ? "+" : "-"), CMInterface.buttonStyle);
			if (flag)
			{
				CMConfig.Items.enabled = !CMConfig.Items.enabled;
			}
			num += num2;
			bool flag2 = GUI.Button(new Rect(5f, num, 140f, 20f), "Category: " + (CMConfig.Items.showCategory ? "+" : "-"), CMInterface.buttonStyle);
			if (flag2)
			{
				CMConfig.Items.showCategory = !CMConfig.Items.showCategory;
			}
			num += num2;
			bool flag3 = GUI.Button(new Rect(5f, num, 140f, 20f), "Distance: " + (CMConfig.Items.showDistance ? "+" : "-"), CMInterface.buttonStyle);
			if (flag3)
			{
				CMConfig.Items.showDistance = !CMConfig.Items.showDistance;
			}
			num += num2;
			GUI.Label(new Rect(5f, num, 140f, 20f), "Max. distance (" + CMConfig.Items.maxDistance.ToString("0") + "):");
			num += num2 - 5f;
			float num3 = GUI.HorizontalSlider(new Rect(5f, num, 140f, 20f), CMConfig.Items.maxDistance, 10f, 800f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag4 = num3 != CMConfig.Items.maxDistance;
			if (flag4)
			{
				CMConfig.Items.maxDistance = num3;
			}
			num += num2 - 10f;
			GUI.Label(new Rect(5f, num, 140f, 20f), "Update interval (" + CMConfig.Items.refreshInterval.ToString("0") + "):");
			num += num2 - 5f;
			float num4 = GUI.HorizontalSlider(new Rect(5f, num, 140f, 20f), CMConfig.Items.refreshInterval, 0.1f, 10f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag5 = num4 != CMConfig.Items.refreshInterval;
			if (flag5)
			{
				CMConfig.Items.refreshInterval = num4;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000046EC File Offset: 0x000028EC
		private void MiscWindow(int WindowID)
		{
			float num = 20f;
			float num2 = 25f;
			GUI.Label(new Rect(5f, num, 140f, 20f), "Speedhack (" + this.timeScale.ToString("2") + "):");
			num += num2 - 5f;
			float num3 = GUI.HorizontalSlider(new Rect(5f, num, 140f, 20f), this.timeScale, 1f, 1.2f, CMInterface.sliderStyle, CMInterface.sliderThumbStyle);
			bool flag = num3 != this.timeScale;
			if (flag)
			{
				this.timeScale = num3;
			}
			num += num2;
			bool flag2 = GUI.Button(new Rect(5f, num, 140f, 20f), "3rd person: " + ((Provider.cameraMode == ECameraMode.BOTH) ? "+" : "-"), CMInterface.buttonStyle);
			if (flag2)
			{
				Provider.cameraMode = ECameraMode.BOTH;
			}
			num += num2;
			bool flag3 = GUI.Button(new Rect(5f, num, 140f, 20f), "Debag Camera", CMInterface.buttonStyle);
			if (flag3)
			{
				this.cmPlayers.localPlayer.look.ReceiveFreecamAllowed(true);
			}
			num += num2;
			bool flag4 = GUI.Button(new Rect(5f, num, 140f, 20f), "Set the day", CMInterface.buttonStyle);
			if (flag4)
			{
				LightingManager.time = (uint)(LightingManager.cycle * LevelLighting.transition);
			}
			num += num2;
			bool flag5 = GUI.Button(new Rect(5f, num, 140f, 20f), "Set the night", CMInterface.buttonStyle);
			if (flag5)
			{
				LightingManager.time = (uint)(LightingManager.cycle * (LevelLighting.bias + LevelLighting.transition));
			}
			num += num2;
			bool flag6 = GUI.Button(new Rect(5f, num, 140f, 20f), "plus: " + (CMConfig.Misc.crosshair ? "+" : "-"), CMInterface.buttonStyle);
			if (flag6)
			{
				CMConfig.Misc.crosshair = !CMConfig.Misc.crosshair;
			}
			num += num2;
			bool flag7 = GUI.Button(new Rect(5f, num, 140f, 20f), "Reconnecting: " + (CMConfig.Misc.autoReconnect ? "+" : "-"), CMInterface.buttonStyle);
			if (flag7)
			{
				CMConfig.Misc.autoReconnect = !CMConfig.Misc.autoReconnect;
			}
			num += num2;
			bool flag8 = GUI.Button(new Rect(5f, num, 140f, 20f), "FPS Boost", CMInterface.buttonStyle);
			if (flag8)
			{
				bool flag9 = base.GetComponent<CMFPSBoost>();
				if (flag9)
				{
					return;
				}
				base.gameObject.AddComponent<CMFPSBoost>().ToggleFPSBoost();
			}
			num += num2;
			num = 20f;
			GUI.Label(new Rect(155f, num, 140f, 20f), "<b>Objects</b>");
			num += num2;
			bool flag10 = GUI.Button(new Rect(155f, num, 140f, 20f), "Remove", CMInterface.buttonStyle);
			if (flag10)
			{
				Camera main = Camera.main;
				RaycastHit raycastHit;
				bool flag11 = Physics.Raycast(new Ray(main.transform.position, main.transform.forward), out raycastHit);
				if (flag11)
				{
					GameObject gameObject = raycastHit.transform.gameObject;
					gameObject.SetActive(false);
					this.inactiveObjects.Add(gameObject);
				}
			}
			num += num2;
			bool flag12 = GUI.Button(new Rect(155f, num, 140f, 20f), "Add Physics", CMInterface.buttonStyle);
			if (flag12)
			{
				Camera main2 = Camera.main;
				RaycastHit raycastHit2;
				bool flag13 = Physics.Raycast(new Ray(main2.transform.position, main2.transform.forward), out raycastHit2);
				if (flag13)
				{
					GameObject gameObject2 = raycastHit2.transform.gameObject;
					gameObject2.AddComponent<Rigidbody>();
					this.rigidbodyObjects.Add(gameObject2);
				}
			}
			num += num2;
			bool flag14 = GUI.Button(new Rect(155f, num, 140f, 20f), "Remove physics", CMInterface.buttonStyle);
			if (flag14)
			{
				Camera main3 = Camera.main;
				RaycastHit raycastHit3;
				bool flag15 = Physics.Raycast(new Ray(main3.transform.position, main3.transform.forward), out raycastHit3);
				if (flag15)
				{
					UnityEngine.Object.DestroyImmediate(raycastHit3.transform.gameObject.GetComponent<Rigidbody>());
				}
			}
			num += num2;
			bool flag16 = GUI.Button(new Rect(155f, num, 140f, 20f), "TP of the object to me", CMInterface.buttonStyle);
			if (flag16)
			{
				Camera main4 = Camera.main;
				RaycastHit raycastHit4;
				bool flag17 = Physics.Raycast(new Ray(main4.transform.position, main4.transform.forward), out raycastHit4);
				if (flag17)
				{
					raycastHit4.transform.gameObject.transform.position = Camera.main.transform.position;
				}
			}
			num += num2;
			bool flag18 = GUI.Button(new Rect(155f, num, 140f, 20f), "TP to the object", CMInterface.buttonStyle);
			if (flag18)
			{
				Camera main5 = Camera.main;
				RaycastHit raycastHit5;
				bool flag19 = Physics.Raycast(new Ray(main5.transform.position, main5.transform.forward), out raycastHit5);
				if (flag19)
				{
					Vector3 position = raycastHit5.transform.position;
					position.y += 0.5f;
					Player componentInParent = Camera.main.gameObject.GetComponentInParent<Player>();
					componentInParent.teleportToLocationUnsafe(position, main5.transform.rotation.z);
					componentInParent.teleportToLocationUnsafe(position, main5.transform.rotation.z);
					componentInParent.teleportToLocationUnsafe(position, main5.transform.rotation.z);
				}
			}
			num += num2;
			bool flag20 = GUI.Button(new Rect(155f, num, 140f, 20f), "Recover", CMInterface.buttonStyle);
			if (flag20)
			{
				foreach (GameObject gameObject3 in this.inactiveObjects)
				{
					gameObject3.SetActive(true);
				}
				foreach (GameObject gameObject4 in this.rigidbodyObjects)
				{
					UnityEngine.Object.DestroyImmediate(gameObject4.gameObject.GetComponent<Rigidbody>());
				}
			}
			num = 20f;
			GUI.Label(new Rect(305f, num, 140f, 20f), "<b>Players</b>");
			num += num2;
			GUI.Label(new Rect(305f, num, 140f, 20f), string.Format("<size=11>Scale (local player) [{0}]</size>", this.cmPlayers.localPlayerScale));
			num += num2;
			bool flag21 = GUI.Button(new Rect(305f, num, 70f, 20f), "-", CMInterface.buttonStyle);
			if (flag21)
			{
				this.cmPlayers.DecreaseLocalPlayerScale();
			}
			bool flag22 = GUI.Button(new Rect(380f, num, 70f, 20f), "+", CMInterface.buttonStyle);
			if (flag22)
			{
				this.cmPlayers.IncreaseLocalPlayerScale();
			}
			num += num2;
			GUI.Label(new Rect(305f, num, 140f, 20f), string.Format("<size=11>Scale (other players) [{0}]</size>", this.cmPlayers.playersScale));
			num += num2;
			bool flag23 = GUI.Button(new Rect(305f, num, 70f, 20f), "-", CMInterface.buttonStyle);
			if (flag23)
			{
				this.cmPlayers.DecreasePlayersScale();
			}
			bool flag24 = GUI.Button(new Rect(380f, num, 70f, 20f), "+", CMInterface.buttonStyle);
			if (flag24)
			{
				this.cmPlayers.IncreasePlayersScale();
			}
			num = 20f;
			GUI.Label(new Rect(460f, num, 140f, 20f), "<b>Construction</b>");
			num += num2;
			bool flag25 = GUI.Button(new Rect(460f, num, 140f, 20f), "Allow everywhere: " + (CMConfig.Misc.buildAnywhere ? "+" : "-"), CMInterface.buttonStyle);
			if (flag25)
			{
				CMConfig.Misc.buildAnywhere = !CMConfig.Misc.buildAnywhere;
			}
			num += num2;
			bool flag26 = GUI.Button(new Rect(460f, num, 140f, 20f), "<size=12>Instant parsing: " + (CMConfig.Misc.immediateSalvage ? "+" : "-") + "</size>", CMInterface.buttonStyle);
			if (flag26)
			{
				CMConfig.Misc.immediateSalvage = !CMConfig.Misc.immediateSalvage;
				bool immediateSalvage = CMConfig.Misc.immediateSalvage;
				if (immediateSalvage)
				{
					this.cmPlayers.localPlayer.interact.ReceiveSalvageTimeOverride(0f);
				}
				else
				{
					this.cmPlayers.localPlayer.interact.ReceiveSalvageTimeOverride(3f);
				}
			}
			num += num2;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005058 File Offset: 0x00003258
		private void BindWindow(int WindowID)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000505C File Offset: 0x0000325C
		private void ApplyGUIStyle()
		{
			CMInterface.windowStyle = new GUIStyle(GUI.skin.window);
			CMInterface.buttonStyle = new GUIStyle(GUI.skin.button);
			CMInterface.sliderStyle = new GUIStyle(GUI.skin.horizontalSlider);
			CMInterface.sliderThumbStyle = new GUIStyle(GUI.skin.horizontalSliderThumb);
			CMInterface.windowStyle.normal.background = this.windowBackground;
			CMInterface.windowStyle.onNormal.background = CMInterface.windowStyle.normal.background;
			CMInterface.windowStyle.active.background = CMInterface.windowStyle.normal.background;
			CMInterface.windowStyle.onActive.background = CMInterface.windowStyle.normal.background;
			CMInterface.windowStyle.focused.background = CMInterface.windowStyle.normal.background;
			CMInterface.windowStyle.onFocused.background = CMInterface.windowStyle.normal.background;
			CMInterface.windowStyle.normal.textColor = Color.white;
			CMInterface.windowStyle.onNormal.textColor = CMInterface.windowStyle.normal.textColor;
			CMInterface.windowStyle.active.textColor = CMInterface.windowStyle.normal.textColor;
			CMInterface.windowStyle.onActive.textColor = CMInterface.windowStyle.normal.textColor;
			CMInterface.windowStyle.focused.textColor = CMInterface.windowStyle.normal.textColor;
			CMInterface.windowStyle.onFocused.textColor = CMInterface.windowStyle.normal.textColor;
			CMInterface.buttonStyle.normal.background = this.buttonBackground;
			CMInterface.buttonStyle.onNormal.background = CMInterface.buttonStyle.normal.background;
			CMInterface.buttonStyle.active.background = CMInterface.buttonStyle.normal.background;
			CMInterface.buttonStyle.onActive.background = CMInterface.buttonStyle.normal.background;
			CMInterface.buttonStyle.focused.background = CMInterface.buttonStyle.normal.background;
			CMInterface.buttonStyle.onFocused.background = CMInterface.buttonStyle.normal.background;
			CMInterface.buttonStyle.normal.textColor = Color.white;
			CMInterface.buttonStyle.onNormal.textColor = CMInterface.buttonStyle.normal.textColor;
			CMInterface.buttonStyle.active.textColor = CMInterface.buttonStyle.normal.textColor;
			CMInterface.buttonStyle.onActive.textColor = CMInterface.buttonStyle.normal.textColor;
			CMInterface.buttonStyle.focused.textColor = CMInterface.buttonStyle.normal.textColor;
			CMInterface.buttonStyle.onFocused.textColor = CMInterface.buttonStyle.normal.textColor;
			CMInterface.buttonStyle.onHover.background = this.buttonHoverBackground;
			CMInterface.buttonStyle.hover.background = CMInterface.buttonStyle.onHover.background;
			CMInterface.buttonStyle.onHover.textColor = CMInterface.buttonStyle.normal.textColor;
			CMInterface.buttonStyle.hover.textColor = CMInterface.buttonStyle.normal.textColor;
			CMInterface.sliderStyle.normal.background = this.sliderBackground;
			CMInterface.sliderStyle.active.background = CMInterface.sliderStyle.normal.background;
			CMInterface.sliderStyle.hover.background = CMInterface.sliderStyle.normal.background;
			CMInterface.sliderStyle.focused.background = CMInterface.sliderStyle.normal.background;
			CMInterface.sliderThumbStyle.normal.background = this.sliderThumbBackground;
			CMInterface.sliderThumbStyle.active.background = CMInterface.sliderThumbStyle.normal.background;
			CMInterface.sliderThumbStyle.hover.background = CMInterface.sliderThumbStyle.normal.background;
			CMInterface.sliderThumbStyle.focused.background = CMInterface.sliderThumbStyle.normal.background;
			GUI.color = this.defaultTextColor;
			GUI.backgroundColor = new Color(0.16f, 0.15f, 0.16f);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000054FC File Offset: 0x000036FC
		private void SwitchWindow(CMInterface.CMWindow window)
		{
			this.hideAllWindows();
			switch (window)
			{
			case CMInterface.CMWindow.Aim:
				CMConfig.Windows.aimWindow = !CMConfig.Windows.aimWindow;
				break;
			case CMInterface.CMWindow.Players:
				CMConfig.Windows.playersWindow = !CMConfig.Windows.playersWindow;
				break;
			case CMInterface.CMWindow.Zombies:
				CMConfig.Windows.zombiesWindow = !CMConfig.Windows.zombiesWindow;
				break;
			case CMInterface.CMWindow.Vehicles:
				CMConfig.Windows.vehiclesWindow = !CMConfig.Windows.vehiclesWindow;
				break;
			case CMInterface.CMWindow.Items:
				CMConfig.Windows.itemsWindow = !CMConfig.Windows.itemsWindow;
				break;
			case CMInterface.CMWindow.Misc:
				CMConfig.Windows.miscWindow = !CMConfig.Windows.miscWindow;
				break;
			case CMInterface.CMWindow.Bind:
				CMConfig.Windows.bindWindow = !CMConfig.Windows.bindWindow;
				break;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000055A4 File Offset: 0x000037A4
		public void SetModules(CMPlayers cmPlayers)
		{
			this.cmPlayers = cmPlayers;
		}

		// Token: 0x04000012 RID: 18
		public static float xOffset = 185f;

		// Token: 0x04000013 RID: 19
		public static float yOffset = 20f;

		// Token: 0x04000014 RID: 20
		private Rect mainWindowRect = new Rect(20f, 20f, 160f, 225f);

		// Token: 0x04000015 RID: 21
		private Rect aimWindowRect = new Rect(185f, 20f, 150f, 245f);

		// Token: 0x04000016 RID: 22
		private Rect zombiesWindowRect = new Rect(185f, 20f, 150f, 145f);

		// Token: 0x04000017 RID: 23
		private Rect vehiclesWindowRect = new Rect(185f, 20f, 450f, 245f);

		// Token: 0x04000018 RID: 24
		private Rect itemsWindowRect = new Rect(185f, 20f, 150f, 170f);

		// Token: 0x04000019 RID: 25
		private Rect miscWindowRect = new Rect(185f, 20f, 605f, 250f);

		// Token: 0x0400001A RID: 26
		private Rect bindWindowRect = new Rect(185f, 20f, 605f, 250f);

		// Token: 0x0400001B RID: 27
		private List<GameObject> inactiveObjects = new List<GameObject>();

		// Token: 0x0400001C RID: 28
		private List<GameObject> rigidbodyObjects = new List<GameObject>();

		// Token: 0x0400001D RID: 29
		public static GUIStyle windowStyle;

		// Token: 0x0400001E RID: 30
		public static GUIStyle buttonStyle;

		// Token: 0x0400001F RID: 31
		public static GUIStyle sliderStyle;

		// Token: 0x04000020 RID: 32
		public static GUIStyle sliderThumbStyle;

		// Token: 0x04000021 RID: 33
		private Color defaultTextColor;

		// Token: 0x04000022 RID: 34
		private Texture2D windowBackground;

		// Token: 0x04000023 RID: 35
		private Texture2D buttonBackground;

		// Token: 0x04000024 RID: 36
		private Texture2D buttonHoverBackground;

		// Token: 0x04000025 RID: 37
		private Texture2D sliderBackground;

		// Token: 0x04000026 RID: 38
		private Texture2D sliderThumbBackground;

		// Token: 0x04000027 RID: 39
		private CMPlayers cmPlayers;

		// Token: 0x04000028 RID: 40
		public static string debugString = "";

		// Token: 0x04000029 RID: 41
		private bool testbool;

		// Token: 0x0400002A RID: 42
		private float timeScale = 1f;

		// Token: 0x0200002B RID: 43
		private enum CMWindow
		{
			// Token: 0x04000126 RID: 294
			Aim,
			// Token: 0x04000127 RID: 295
			Players,
			// Token: 0x04000128 RID: 296
			Zombies,
			// Token: 0x04000129 RID: 297
			Vehicles,
			// Token: 0x0400012A RID: 298
			Items,
			// Token: 0x0400012B RID: 299
			Misc,
			// Token: 0x0400012C RID: 300
			Bind
		}
	}
}
