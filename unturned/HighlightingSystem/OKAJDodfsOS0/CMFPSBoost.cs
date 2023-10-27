using System;
using System.Collections;
using UnityEngine;

namespace OKAJDodfsOS0
{
	// Token: 0x02000006 RID: 6
	public class CMFPSBoost : MonoBehaviour
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002810 File Offset: 0x00000A10
		public void ToggleFPSBoost()
		{
			this.enableFPSBoost = !this.enableFPSBoost;
			Terrain activeTerrain = Terrain.activeTerrain;
			QualitySettings.shadows = (this.enableFPSBoost ? ShadowQuality.Disable : ShadowQuality.All);
			QualitySettings.masterTextureLimit = (this.enableFPSBoost ? 1 : 0);
			QualitySettings.antiAliasing = (this.enableFPSBoost ? 0 : 2);
			QualitySettings.pixelLightCount = (this.enableFPSBoost ? 0 : 4);
			QualitySettings.shadowResolution = (this.enableFPSBoost ? ShadowResolution.Low : ShadowResolution.High);
			QualitySettings.realtimeReflectionProbes = !this.enableFPSBoost;
			bool flag = this.enableFPSBoost;
			if (flag)
			{
				activeTerrain.detailObjectDensity = 0f;
				activeTerrain.heightmapPixelError = 20f;
				activeTerrain.terrainData.heightmapResolution = 4;
				activeTerrain.terrainData.SetDetailResolution(4, activeTerrain.terrainData.detailResolutionPerPatch);
				RenderSettings.skybox = null;
				RenderSettings.fog = false;
				RenderSettings.reflectionIntensity = 0f;
				RenderSettings.sun = null;
				base.StartCoroutine(this.ReplaceMaterialsEvery3Seconds());
			}
			else
			{
				base.StopCoroutine(this.ReplaceMaterialsEvery3Seconds());
			}
			ParticleSystem[] array = UnityEngine.Object.FindObjectsOfType<ParticleSystem>();
			for (int i = 0; i < array.Length; i++)
			{
				ParticleSystem.MainModule main = array[i].main;
				main.maxParticles = (this.enableFPSBoost ? (main.maxParticles / 2) : (main.maxParticles * 2));
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000296D File Offset: 0x00000B6D
		private IEnumerator ReplaceMaterialsEvery3Seconds()
		{
			while (this.enableFPSBoost)
			{
				this.ReplaceAllMaterials();
				yield return new WaitForSeconds(3f);
			}
			yield break;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000297C File Offset: 0x00000B7C
		private void ReplaceAllMaterials()
		{
			Material material = new Material(Shader.Find("Standard"));
			material.color = Color.white;
			MeshRenderer[] array = UnityEngine.Object.FindObjectsOfType<MeshRenderer>();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].material = material;
			}
		}

		// Token: 0x04000011 RID: 17
		public bool enableFPSBoost;
	}
}
