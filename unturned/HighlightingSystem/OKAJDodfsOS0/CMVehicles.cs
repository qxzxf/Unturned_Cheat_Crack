using System;
using SDG.Unturned;
using UnityEngine;

namespace OKAJDodfsOS0
{
	// Token: 0x0200000F RID: 15
	internal class CMVehicles : MonoBehaviour
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00006CC8 File Offset: 0x00004EC8
		private void Update()
		{
			try
			{
				bool flag = CMConfig.Vehicles.enabled && CMConfig.enabled;
				if (flag)
				{
					this.lastRefreshTime += Time.deltaTime;
					bool flag2 = this.lastRefreshTime > CMConfig.Vehicles.refreshInterval;
					if (flag2)
					{
						this.UpdateVehicles();
						this.lastRefreshTime = 0f;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006D3C File Offset: 0x00004F3C
		private void FixedUpdate()
		{
			bool flag = !CMConfig.Vehicles.noClip;
			if (!flag)
			{
				Player player = Player.player;
				bool flag2 = player == null;
				InteractableVehicle interactableVehicle;
				if (flag2)
				{
					interactableVehicle = null;
				}
				else
				{
					PlayerMovement movement = player.movement;
					interactableVehicle = ((movement != null) ? movement.getVehicle() : null);
				}
				InteractableVehicle interactableVehicle2 = interactableVehicle;
				bool flag3 = interactableVehicle2 != null && interactableVehicle2 && Provider.isConnected && !Provider.isLoading;
				if (flag3)
				{
					Rigidbody component = interactableVehicle2.GetComponent<Rigidbody>();
					component.constraints = RigidbodyConstraints.None;
					component.freezeRotation = false;
					component.useGravity = false;
					component.isKinematic = true;
					Transform transform = interactableVehicle2.transform;
					bool key = Input.GetKey(KeyCode.W);
					if (key)
					{
						component.MovePosition(transform.position + transform.forward * (interactableVehicle2.asset.speedMax * CMConfig.Vehicles.noClipSpeedMultiplier * Time.fixedDeltaTime));
					}
					bool key2 = Input.GetKey(KeyCode.S);
					if (key2)
					{
						component.MovePosition(transform.position - transform.forward * (interactableVehicle2.asset.speedMax * CMConfig.Vehicles.noClipSpeedMultiplier * Time.fixedDeltaTime));
					}
					bool key3 = Input.GetKey(KeyCode.A);
					if (key3)
					{
						transform.Rotate(0f, -CMConfig.Vehicles.yRotAmount, 0f);
					}
					bool key4 = Input.GetKey(KeyCode.D);
					if (key4)
					{
						transform.Rotate(0f, CMConfig.Vehicles.yRotAmount, 0f);
					}
					bool key5 = Input.GetKey(KeyCode.UpArrow);
					if (key5)
					{
						transform.Rotate(CMConfig.Vehicles.xRotAmount, 0f, 0f);
					}
					bool key6 = Input.GetKey(KeyCode.DownArrow);
					if (key6)
					{
						transform.Rotate(-CMConfig.Vehicles.xRotAmount, 0f, 0f);
					}
					bool key7 = Input.GetKey(KeyCode.LeftArrow);
					if (key7)
					{
						transform.Rotate(0f, 0f, CMConfig.Vehicles.zRotAmount);
					}
					bool key8 = Input.GetKey(KeyCode.RightArrow);
					if (key8)
					{
						transform.Rotate(0f, 0f, -CMConfig.Vehicles.zRotAmount);
					}
					bool key9 = Input.GetKey(KeyCode.Space);
					if (key9)
					{
						transform.position += new Vector3(0f, CMConfig.Vehicles.yPosAmount, 0f);
					}
					bool key10 = Input.GetKey(KeyCode.LeftShift);
					if (key10)
					{
						transform.position -= new Vector3(0f, CMConfig.Vehicles.yPosAmount, 0f);
					}
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006FE8 File Offset: 0x000051E8
		private void OnGUI()
		{
			bool flag = !CMConfig.Vehicles.enabled || !CMConfig.enabled;
			if (!flag)
			{
				this.DrawVehicles();
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00007018 File Offset: 0x00005218
		private void DrawVehicles()
		{
			foreach (InteractableVehicle vehicle in this.vehicles)
			{
				try
				{
					this.DrawVehicle(vehicle);
				}
				catch (Exception arg)
				{
					CMLogger.Log(string.Format("Ошибка при отрисовке авто: {0}", arg));
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007074 File Offset: 0x00005274
		private void DrawVehicle(InteractableVehicle vehicle)
		{
			bool flag = (vehicle.isLocked && CMConfig.Vehicles.notLockedOnly) || vehicle == null;
			if (!flag)
			{
				Vector3 position = vehicle.transform.position;
				float num = Vector3.Distance(Camera.main.transform.position, position);
				bool flag2 = num > CMConfig.Vehicles.maxDistance;
				if (!flag2)
				{
					Vector3 vector = Camera.main.WorldToScreenPoint(position);
					bool flag3 = vector.z <= 0f;
					if (!flag3)
					{
						vector.y = (float)Screen.height - vector.y;
						Color color = Color.white;
						bool isLocked = vehicle.isLocked;
						if (isLocked)
						{
							color = CMConfig.Vehicles.lockedColor;
						}
						else
						{
							color = CMConfig.Vehicles.notLockedColor;
						}
						bool isDriven = vehicle.isDriven;
						if (isDriven)
						{
							color = CMConfig.Vehicles.drivenColor;
						}
						string text = "<size=10>";
						text += vehicle.asset.name;
						bool showStats = CMConfig.Vehicles.showStats;
						if (showStats)
						{
							text += string.Format("\nH:{0:.0} F:{1:.0} C:{2:.0}", (int)(vehicle.health / 6), (int)(vehicle.fuel / 10), (int)(vehicle.batteryCharge / 100));
						}
						bool showDistance = CMConfig.Vehicles.showDistance;
						if (showDistance)
						{
							text += string.Format("\n{0}m", Mathf.Round(num));
						}
						text += "</size>";
						CMDrawer.DrawString(vector, text, color, 1f, true, false);
					}
				}
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007204 File Offset: 0x00005404
		private void UpdateVehicles()
		{
			InteractableVehicle[] array = UnityEngine.Object.FindObjectsOfType<InteractableVehicle>();
			bool flag = array != null && array.Length != 0;
			if (flag)
			{
				this.vehicles = array;
			}
		}

		// Token: 0x04000036 RID: 54
		public InteractableVehicle[] vehicles;

		// Token: 0x04000037 RID: 55
		private float lastRefreshTime;
	}
}
