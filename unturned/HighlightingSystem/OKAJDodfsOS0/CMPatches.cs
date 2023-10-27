using System;
using System.Reflection;
using HarmonyLib;
using SDG.Unturned;
using UnityEngine;

namespace OKAJDodfsOS0
{
	// Token: 0x0200000A RID: 10
	internal class CMPatches : MonoBehaviour
	{
		// Token: 0x06000034 RID: 52 RVA: 0x000059A0 File Offset: 0x00003BA0
		public void Init()
		{
			CMLogger.Log("Инициализирую Harmony...");
			try
			{
				Harmony.DEBUG = CMConfig.debug;
				FileLog.Reset();
				new Harmony(CMUtils.GenerateRandomString(24)).PatchAll();
			}
			catch (Exception arg)
			{
				CMLogger.Log(string.Format("Ошибка инициализации Harmony: {0}", arg));
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005A08 File Offset: 0x00003C08
		private static void writeinfo(RaycastInfo info)
		{
			string text = (info.player != null) ? info.player.name.ToString() : "null";
			string text2 = (info.collider != null) ? info.collider.ToString() : "null";
			Vector3 point = info.point;
			string text3 = info.point.ToString();
			Vector3 normal = info.normal;
			string text4 = info.normal.ToString();
			string text5 = info.section.ToString();
			string text6 = info.limb.ToString();
			Vector3 direction = info.direction;
			string text7 = info.direction.ToString();
			string text8 = (info.transform != null) ? info.transform.position.ToString() : "null";
			string text9 = info.distance.ToString();
			CMLogger.Log(string.Concat(new string[]
			{
				text,
				" ",
				text2,
				" ",
				text3,
				" ",
				text4,
				" ",
				text5,
				" ",
				text6,
				" ",
				text7,
				" ",
				text8,
				" ",
				text9
			}));
		}

		// Token: 0x0400002D RID: 45
		private Harmony harmony;

		// Token: 0x0400002E RID: 46
		private static int counter;

		// Token: 0x0200002C RID: 44
		[HarmonyPatch(typeof(UseableGun))]
		[HarmonyPatch("fire")]
		private class UseableGun_shootPatch
		{
			// Token: 0x06000148 RID: 328 RVA: 0x0000AD94 File Offset: 0x00008F94
			private unsafe static void Prefix(UseableGun __instance)
			{
				bool flag = !CMConfig.enabled;
				if (!flag)
				{
					bool noSpread = CMConfig.Misc.noSpread;
					if (noSpread)
					{
						*CMPatches.UseableGun_shootPatch.aimAccuracy(__instance) = 10000;
						*CMPatches.UseableGun_shootPatch.maxAimingAccuracy(__instance) = 10000;
						*CMPatches.UseableGun_shootPatch.steadyAccuracy(__instance) = 10000U;
						*CMPatches.UseableGun_shootPatch.swayTime(__instance) = 0f;
					}
				}
			}

			// Token: 0x0400012D RID: 301
			private static AccessTools.FieldRef<UseableGun, int> aimAccuracy = AccessTools.FieldRefAccess<UseableGun, int>("aimAccuracy");

			// Token: 0x0400012E RID: 302
			private static AccessTools.FieldRef<UseableGun, int> maxAimingAccuracy = AccessTools.FieldRefAccess<UseableGun, int>("maxAimingAccuracy");

			// Token: 0x0400012F RID: 303
			private static AccessTools.FieldRef<UseableGun, uint> steadyAccuracy = AccessTools.FieldRefAccess<UseableGun, uint>("steadyAccuracy");

			// Token: 0x04000130 RID: 304
			private static AccessTools.FieldRef<UseableGun, float> swayTime = AccessTools.FieldRefAccess<UseableGun, float>("swayTime");
		}

		// Token: 0x0200002D RID: 45
		[HarmonyPatch(typeof(Player))]
		[HarmonyPatch("sendScreenshot")]
		private class Player_sendScreenshot
		{
			// Token: 0x0600014B RID: 331 RVA: 0x0000AE40 File Offset: 0x00009040
			private static void Prefix(Player __instance)
			{
				bool enabled = CMConfig.enabled;
				if (enabled)
				{
					CMConfig.enabled = false;
					CMLogger.Log("SPY!");
				}
			}
		}

		// Token: 0x0200002E RID: 46
		[HarmonyPatch(typeof(Player))]
		[HarmonyPatch("takeScreenshot")]
		private class Player_sendScreensho
		{
			// Token: 0x0600014D RID: 333 RVA: 0x0000AE6C File Offset: 0x0000906C
			private static void Prefix(Player __instance)
			{
				bool enabled = CMConfig.enabled;
				if (enabled)
				{
					CMConfig.enabled = false;
					CMLogger.Log("SPY!");
				}
			}
		}

		// Token: 0x0200002F RID: 47
		[HarmonyPatch(typeof(Player))]
		[HarmonyPatch("askScreenshot")]
		private class Player_askScreenshot
		{
			// Token: 0x0600014F RID: 335 RVA: 0x0000AE98 File Offset: 0x00009098
			private static void Prefix(Player __instance)
			{
				bool enabled = CMConfig.enabled;
				if (enabled)
				{
					CMConfig.enabled = false;
					CMLogger.Log("SPY!");
				}
			}
		}

		// Token: 0x02000030 RID: 48
		[HarmonyPatch(typeof(PlayerLook))]
		[HarmonyPatch("recoil")]
		private class PlayerLook_recoil
		{
			// Token: 0x06000151 RID: 337 RVA: 0x0000AEC4 File Offset: 0x000090C4
			private static bool Prefix(PlayerLook __instance)
			{
				return !CMConfig.enabled || !CMConfig.Misc.noRecoil;
			}
		}

		// Token: 0x02000031 RID: 49
		[HarmonyPatch(typeof(UseableBarricade))]
		[HarmonyPatch("check")]
		private class UseableBarricade_check
		{
			// Token: 0x06000153 RID: 339 RVA: 0x0000AEE8 File Offset: 0x000090E8
			private static bool Prefix(ref bool __result)
			{
				bool flag = !CMConfig.enabled;
				bool result;
				if (flag)
				{
					result = true;
				}
				else
				{
					bool buildAnywhere = CMConfig.Misc.buildAnywhere;
					if (buildAnywhere)
					{
						__result = true;
						result = false;
					}
					else
					{
						result = true;
					}
				}
				return result;
			}
		}

		// Token: 0x02000032 RID: 50
		public static class InteractThroughWallsPatch
		{
			// Token: 0x0200003F RID: 63
			[HarmonyPatch(typeof(PlayerInteract))]
			[HarmonyPatch("Update")]
			internal class PlayerInteract_Update_Patch
			{
				// Token: 0x06000170 RID: 368 RVA: 0x0000B2CC File Offset: 0x000094CC
				private static void Prefix(PlayerInteract __instance)
				{
					bool flag = __instance == null || !__instance.gameObject.CompareTag("Player");
					if (!flag)
					{
						int num = RayMasks.PLAYER_INTERACT;
						bool flag2 = __instance.player.stance.stance == EPlayerStance.CLIMB;
						if (flag2)
						{
							num &= -33554433;
						}
						bool isCam = __instance.player.look.isCam;
						RaycastHit raycastHit;
						if (isCam)
						{
							Physics.Raycast(new Ray(__instance.player.look.aim.position, __instance.player.look.aim.forward), out raycastHit, 50f, num);
						}
						else
						{
							Physics.Raycast(new Ray(MainCamera.instance.transform.position, MainCamera.instance.transform.forward), out raycastHit, (float)((__instance.player.look.perspective == EPlayerPerspective.THIRD) ? 50 : 50), num);
						}
						CMPatches.InteractThroughWallsPatch.PlayerInteract_Update_Patch.hitField.SetValue(__instance, raycastHit);
					}
				}

				// Token: 0x0400013F RID: 319
				private static FieldInfo hitField = AccessTools.Field(typeof(PlayerInteract), "hit");
			}
		}

		// Token: 0x02000033 RID: 51
		[HarmonyPatch("Provider", "battlEyeClientSendPacket", MethodType.Normal)]
		private class Provider_battlEyeClientSendPacket
		{
			// Token: 0x06000155 RID: 341 RVA: 0x0000AF20 File Offset: 0x00009120
			private static bool Prefix(IntPtr packetHandle, int length)
			{
				bool flag = !CMConfig.Misc.autoKick;
				bool result;
				if (flag)
				{
					result = true;
				}
				else
				{
					bool flag2 = length == 525;
					if (flag2)
					{
						CMPatches.counter++;
						bool flag3 = CMPatches.counter == 75;
						if (flag3)
						{
							CMBase.willBeKickedSoon = true;
						}
						bool flag4 = CMPatches.counter == 77;
						if (flag4)
						{
							CMBase.hasToLeave = true;
							CMPatches.counter = 0;
						}
						result = false;
					}
					else
					{
						result = true;
					}
				}
				return result;
			}
		}

		// Token: 0x02000034 RID: 52
		[HarmonyPatch("Provider", "disconnect", MethodType.Normal)]
		private class Provider_disconnect
		{
			// Token: 0x06000157 RID: 343 RVA: 0x0000AF93 File Offset: 0x00009193
			private static void Prefix()
			{
				CMPatches.counter = 0;
			}
		}

		// Token: 0x02000035 RID: 53
		[HarmonyPatch("NetMessages", "SendMessageToServer", MethodType.Normal)]
		private class dfgsgf
		{
			// Token: 0x06000159 RID: 345 RVA: 0x0000AF9C File Offset: 0x0000919C
			private static bool Prefix(EServerMessage index)
			{
				return true;
			}
		}

		// Token: 0x02000036 RID: 54
		[HarmonyPatch(typeof(DamageTool))]
		[HarmonyPatch("getLimb")]
		private class DamageTool_getLimb
		{
			// Token: 0x0600015B RID: 347 RVA: 0x0000AFB0 File Offset: 0x000091B0
			private static bool Prefix(ref ELimb __result)
			{
				bool flag = !CMConfig.enabled;
				bool result;
				if (flag)
				{
					result = true;
				}
				else
				{
					bool onlyHeadshots = CMConfig.Misc.onlyHeadshots;
					if (onlyHeadshots)
					{
						__result = ELimb.SKULL;
						result = false;
					}
					else
					{
						result = true;
					}
				}
				return result;
			}
		}

		// Token: 0x02000037 RID: 55
		[HarmonyPatch(typeof(DamageTool))]
		[HarmonyPatch("isPlayerAllowedToDamagePlayer")]
		private class DamageTool_isPlayerAllowedToDamagePlayer
		{
			// Token: 0x0600015D RID: 349 RVA: 0x0000AFE8 File Offset: 0x000091E8
			private static bool Prefix(ref bool __result)
			{
				bool flag = !CMConfig.enabled;
				bool result;
				if (flag)
				{
					result = true;
				}
				else
				{
					__result = true;
					result = false;
				}
				return result;
			}
		}

		// Token: 0x02000038 RID: 56
		[HarmonyPatch(typeof(PlayerInput))]
		[HarmonyPatch("sendRaycast")]
		private class PlayerInput_sendRaycast
		{
			// Token: 0x0600015F RID: 351 RVA: 0x0000B010 File Offset: 0x00009210
			private static bool Prefix(ref RaycastInfo info, ERaycastInfoUsage usage)
			{
				bool flag = !CMConfig.enabled || !CMConfig.Aim.enabled || (usage != ERaycastInfoUsage.Punch && usage != ERaycastInfoUsage.Melee);
				bool result;
				if (flag)
				{
					result = true;
				}
				else
				{
					CMPatches.writeinfo(info);
					bool flag2 = usage == ERaycastInfoUsage.Melee || usage == ERaycastInfoUsage.Punch;
					if (flag2)
					{
						try
						{
							foreach (Player player in UnityEngine.Object.FindObjectsOfType<Player>())
							{
								float num = Vector3.Distance(MainCamera.instance.transform.position, player.transform.position);
								bool flag3 = player != null && !player.channel.isOwner && num <= 10f;
								if (flag3)
								{
									Vector3 vector = player.transform.position - MainCamera.instance.transform.position;
									info.collider = player.gameObject.GetComponentInChildren<BoxCollider>();
									info.point = info.collider.transform.position;
									info.transform = info.collider.transform;
									info.player = player;
									info.direction = vector.normalized;
									info.distance = 3f;
									info.limb = ELimb.SKULL;
									break;
								}
							}
							CMPatches.writeinfo(info);
							return true;
						}
						catch (Exception ex)
						{
							CMLogger.Log(ex.ToString());
							return true;
						}
					}
					result = true;
				}
				return result;
			}
		}
	}
}
