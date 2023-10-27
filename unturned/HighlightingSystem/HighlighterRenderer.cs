using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace HighlightingSystem
{
	// Token: 0x0200001A RID: 26
	[DisallowMultipleComponent]
	[AddComponentMenu("")]
	[ExcludeFromDocs]
	public class HighlighterRenderer : MonoBehaviour
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00009063 File Offset: 0x00007263
		private void Awake()
		{
			base.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000906F File Offset: 0x0000726F
		private void OnEnable()
		{
			EndOfFrame.AddListener(new EndOfFrame.OnEndOfFrame(this.OnEndOfFrame));
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00009084 File Offset: 0x00007284
		private void OnDisable()
		{
			EndOfFrame.RemoveListener(new EndOfFrame.OnEndOfFrame(this.OnEndOfFrame));
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00009099 File Offset: 0x00007299
		private void OnWillRenderObject()
		{
			HighlightingBase.SetVisible(this);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000090A4 File Offset: 0x000072A4
		private void OnDestroy()
		{
			bool flag = this.data == null;
			if (!flag)
			{
				int i = 0;
				int count = this.data.Count;
				while (i < count)
				{
					HighlighterRenderer.Data data = this.data[i];
					bool transparent = data.transparent;
					if (transparent)
					{
						UnityEngine.Object.Destroy(data.material);
					}
					i++;
				}
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000910C File Offset: 0x0000730C
		public void Initialize(Material sharedOpaqueMaterial, Shader transparentShader, List<int> submeshIndices)
		{
			this.data.Clear();
			this.r = base.GetComponent<Renderer>();
			Material[] sharedMaterials = this.r.sharedMaterials;
			int num = sharedMaterials.Length;
			bool flag = sharedMaterials == null || num == 0;
			if (!flag)
			{
				bool flag2 = submeshIndices.Count == 1 && submeshIndices[0] == -1;
				if (flag2)
				{
					submeshIndices.Clear();
					for (int i = 0; i < num; i++)
					{
						submeshIndices.Add(i);
					}
				}
				int j = 0;
				int count = submeshIndices.Count;
				while (j < count)
				{
					int num2 = submeshIndices[j];
					bool flag3 = num2 < num;
					if (flag3)
					{
						Material material = sharedMaterials[num2];
						bool flag4 = !(material == null);
						if (flag4)
						{
							HighlighterRenderer.Data item = default(HighlighterRenderer.Data);
							string tag = material.GetTag(HighlighterRenderer.sRenderType, true, HighlighterRenderer.sOpaque);
							bool flag5 = tag == HighlighterRenderer.sTransparent || tag == HighlighterRenderer.sTransparentCutout;
							if (flag5)
							{
								Material material2 = new Material(transparentShader);
								bool flag6 = this.r is SpriteRenderer;
								if (flag6)
								{
									material2.SetInt(ShaderPropertyID._HighlightingCull, 0);
								}
								bool flag7 = material.HasProperty(ShaderPropertyID._MainTex);
								if (flag7)
								{
									material2.SetTexture(ShaderPropertyID._MainTex, material.mainTexture);
									material2.SetTextureOffset(HighlighterRenderer.sMainTex, material.mainTextureOffset);
									material2.SetTextureScale(HighlighterRenderer.sMainTex, material.mainTextureScale);
								}
								int cutoff = ShaderPropertyID._Cutoff;
								material2.SetFloat(cutoff, material.HasProperty(cutoff) ? material.GetFloat(cutoff) : HighlighterRenderer.transparentCutoff);
								item.material = material2;
								item.transparent = true;
							}
							else
							{
								item.material = sharedOpaqueMaterial;
								item.transparent = false;
							}
							item.submeshIndex = num2;
							this.data.Add(item);
						}
					}
					j++;
				}
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000931C File Offset: 0x0000751C
		public void SetOverlay(bool overlay)
		{
			int i = 0;
			int count = this.data.Count;
			while (i < count)
			{
				HighlighterRenderer.Data data = this.data[i];
				bool transparent = data.transparent;
				if (transparent)
				{
					data.material.SetKeyword("HIGHLIGHTING_OVERLAY", overlay);
				}
				i++;
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00009378 File Offset: 0x00007578
		public void SetColor(Color clr)
		{
			int i = 0;
			int count = this.data.Count;
			while (i < count)
			{
				HighlighterRenderer.Data data = this.data[i];
				bool transparent = data.transparent;
				if (transparent)
				{
					data.material.SetColor(ShaderPropertyID._HighlightingColor, clr);
				}
				i++;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000093D4 File Offset: 0x000075D4
		public void FillBuffer(CommandBuffer buffer)
		{
			int i = 0;
			int count = this.data.Count;
			while (i < count)
			{
				HighlighterRenderer.Data data = this.data[i];
				buffer.DrawRenderer(this.r, data.material, data.submeshIndex);
				i++;
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00009428 File Offset: 0x00007628
		public bool IsValid()
		{
			return this.r != null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00009448 File Offset: 0x00007648
		private void OnEndOfFrame()
		{
			bool flag = !this.isAlive;
			if (flag)
			{
				UnityEngine.Object.Destroy(this);
			}
		}

		// Token: 0x04000091 RID: 145
		private static float transparentCutoff = 0.5f;

		// Token: 0x04000092 RID: 146
		private const HideFlags flags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;

		// Token: 0x04000093 RID: 147
		private const int cullOff = 0;

		// Token: 0x04000094 RID: 148
		private static readonly string sRenderType = "RenderType";

		// Token: 0x04000095 RID: 149
		private static readonly string sOpaque = "Opaque";

		// Token: 0x04000096 RID: 150
		private static readonly string sTransparent = "Transparent";

		// Token: 0x04000097 RID: 151
		private static readonly string sTransparentCutout = "TransparentCutout";

		// Token: 0x04000098 RID: 152
		private static readonly string sMainTex = "_MainTex";

		// Token: 0x04000099 RID: 153
		public bool isAlive;

		// Token: 0x0400009A RID: 154
		private Renderer r;

		// Token: 0x0400009B RID: 155
		private List<HighlighterRenderer.Data> data = new List<HighlighterRenderer.Data>();

		// Token: 0x0200003D RID: 61
		[ExcludeFromDocs]
		private struct Data
		{
			// Token: 0x04000138 RID: 312
			public Material material;

			// Token: 0x04000139 RID: 313
			public int submeshIndex;

			// Token: 0x0400013A RID: 314
			public bool transparent;
		}
	}
}
