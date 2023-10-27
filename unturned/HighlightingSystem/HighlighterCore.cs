using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace HighlightingSystem
{
	// Token: 0x02000018 RID: 24
	[DisallowMultipleComponent]
	public class HighlighterCore : MonoBehaviour
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00008644 File Offset: 0x00006844
		public static ReadOnlyCollection<HighlighterCore> highlighters
		{
			get
			{
				bool flag = HighlighterCore.sHighlightersReadonly == null;
				if (flag)
				{
					HighlighterCore.sHighlightersReadonly = HighlighterCore.sHighlighters.AsReadOnly();
				}
				return HighlighterCore.sHighlightersReadonly;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00008678 File Offset: 0x00006878
		[ExcludeFromDocs]
		public static Shader opaqueShader
		{
			get
			{
				bool flag = HighlighterCore._opaqueShader == null;
				if (flag)
				{
					HighlighterCore._opaqueShader = Shader.Find("Hidden/Highlighted/Opaque");
				}
				return HighlighterCore._opaqueShader;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000086B0 File Offset: 0x000068B0
		[ExcludeFromDocs]
		public static Shader transparentShader
		{
			get
			{
				bool flag = HighlighterCore._transparentShader == null;
				if (flag)
				{
					HighlighterCore._transparentShader = Shader.Find("Hidden/Highlighted/Transparent");
				}
				return HighlighterCore._transparentShader;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000086E8 File Offset: 0x000068E8
		private Material opaqueMaterial
		{
			get
			{
				bool flag = this._opaqueMaterial == null;
				if (flag)
				{
					this._opaqueMaterial = new Material(HighlighterCore.opaqueShader);
					this._opaqueMaterial.SetKeyword("HIGHLIGHTING_OVERLAY", this.cachedOverlay);
					this._opaqueMaterial.SetColor(ShaderPropertyID._HighlightingColor, this.cachedColor);
				}
				return this._opaqueMaterial;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00008750 File Offset: 0x00006950
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00008768 File Offset: 0x00006968
		public static HighlighterCore.RendererFilter globalRendererFilter
		{
			get
			{
				return HighlighterCore._globalRendererFilter;
			}
			set
			{
				bool flag = HighlighterCore._globalRendererFilter != value;
				if (flag)
				{
					HighlighterCore._globalRendererFilter = value;
					for (int i = HighlighterCore.sHighlighters.Count - 1; i >= 0; i--)
					{
						HighlighterCore highlighterCore = HighlighterCore.sHighlighters[i];
						bool flag2 = highlighterCore == null;
						if (flag2)
						{
							HighlighterCore.sHighlighters.RemoveAt(i);
						}
						else
						{
							bool flag3 = highlighterCore.rendererFilter == null;
							if (flag3)
							{
								highlighterCore.SetDirty();
							}
						}
					}
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000087F0 File Offset: 0x000069F0
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00008808 File Offset: 0x00006A08
		public HighlighterCore.RendererFilter rendererFilter
		{
			get
			{
				return this._rendererFilter;
			}
			set
			{
				bool flag = this._rendererFilter != value;
				if (flag)
				{
					this._rendererFilter = value;
					this.SetDirty();
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00008838 File Offset: 0x00006A38
		protected virtual HighlighterCore.RendererFilter rendererFilterToUse
		{
			get
			{
				bool flag = this._rendererFilter != null;
				HighlighterCore.RendererFilter result;
				if (flag)
				{
					result = this._rendererFilter;
				}
				else
				{
					bool flag2 = HighlighterCore._globalRendererFilter != null;
					if (flag2)
					{
						result = HighlighterCore._globalRendererFilter;
					}
					else
					{
						result = new HighlighterCore.RendererFilter(HighlighterCore.DefaultRendererFilter);
					}
				}
				return result;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00008884 File Offset: 0x00006A84
		public static bool DefaultRendererFilter(Renderer renderer, List<int> submeshIndices)
		{
			bool flag = renderer.GetComponentInParent<HighlighterBlocker>() != null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = false;
				bool flag3 = renderer is MeshRenderer;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = renderer is SkinnedMeshRenderer;
					if (flag4)
					{
						flag2 = true;
					}
					else
					{
						bool flag5 = renderer is SpriteRenderer;
						if (flag5)
						{
							flag2 = true;
						}
						else
						{
							bool flag6 = renderer is ParticleSystemRenderer;
							if (flag6)
							{
								flag2 = true;
							}
						}
					}
				}
				bool flag7 = flag2;
				if (flag7)
				{
					submeshIndices.Add(-1);
				}
				result = flag2;
			}
			return result;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000890F File Offset: 0x00006B0F
		private void Awake()
		{
			this.tr = base.GetComponent<Transform>();
			this.AwakeSafe();
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00008928 File Offset: 0x00006B28
		private void OnEnable()
		{
			bool flag = !HighlighterCore.sHighlighters.Contains(this);
			if (flag)
			{
				HighlighterCore.sHighlighters.Add(this);
			}
			this.OnEnableSafe();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000895D File Offset: 0x00006B5D
		private void OnDisable()
		{
			HighlighterCore.sHighlighters.Remove(this);
			this.ClearRenderers();
			this.isDirty = true;
			this.OnDisableSafe();
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00008984 File Offset: 0x00006B84
		private void OnDestroy()
		{
			bool flag = this._opaqueMaterial != null;
			if (flag)
			{
				UnityEngine.Object.Destroy(this._opaqueMaterial);
			}
			this.OnDestroySafe();
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005058 File Offset: 0x00003258
		protected virtual void AwakeSafe()
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005058 File Offset: 0x00003258
		protected virtual void OnEnableSafe()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005058 File Offset: 0x00003258
		protected virtual void OnDisableSafe()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005058 File Offset: 0x00003258
		protected virtual void OnDestroySafe()
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000089B7 File Offset: 0x00006BB7
		public void SetDirty()
		{
			this.isDirty = true;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00005058 File Offset: 0x00003258
		protected virtual void UpdateHighlighting()
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000089C4 File Offset: 0x00006BC4
		private void ClearRenderers()
		{
			for (int i = this.highlightableRenderers.Count - 1; i >= 0; i--)
			{
				this.highlightableRenderers[i].isAlive = false;
			}
			this.highlightableRenderers.Clear();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00008A14 File Offset: 0x00006C14
		private void UpdateRenderers()
		{
			bool flag = this.isDirty;
			if (flag)
			{
				this.isDirty = false;
				this.ClearRenderers();
				this.GrabRenderers(this.tr);
				int i = 0;
				int count = HighlighterCore.sRendererData.Count;
				while (i < count)
				{
					HighlighterCore.RendererData rendererData = HighlighterCore.sRendererData[i];
					GameObject gameObject = rendererData.renderer.gameObject;
					HighlighterRenderer highlighterRenderer = gameObject.GetComponent<HighlighterRenderer>();
					bool flag2 = highlighterRenderer == null;
					if (flag2)
					{
						highlighterRenderer = gameObject.AddComponent<HighlighterRenderer>();
					}
					highlighterRenderer.isAlive = true;
					highlighterRenderer.Initialize(this.opaqueMaterial, HighlighterCore.transparentShader, rendererData.submeshIndices);
					highlighterRenderer.SetOverlay(this.cachedOverlay);
					highlighterRenderer.SetColor(this.cachedColor);
					this.highlightableRenderers.Add(highlighterRenderer);
					i++;
				}
				for (int j = 0; j < HighlighterCore.sRendererData.Count; j++)
				{
					HighlighterCore.ReleaseRendererDataInstance(HighlighterCore.sRendererData[j]);
				}
				HighlighterCore.sRendererData.Clear();
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00008B38 File Offset: 0x00006D38
		private void GrabRenderers(Transform t)
		{
			t.gameObject.GetComponents<Renderer>(HighlighterCore.sRenderers);
			int i = 0;
			int count = HighlighterCore.sRenderers.Count;
			while (i < count)
			{
				Renderer renderer = HighlighterCore.sRenderers[i];
				bool flag = this.rendererFilterToUse(renderer, HighlighterCore.sSubmeshIndices);
				if (flag)
				{
					HighlighterCore.RendererData rendererDataInstance = HighlighterCore.GetRendererDataInstance();
					rendererDataInstance.renderer = renderer;
					List<int> submeshIndices = rendererDataInstance.submeshIndices;
					submeshIndices.Clear();
					submeshIndices.AddRange(HighlighterCore.sSubmeshIndices);
					HighlighterCore.sRendererData.Add(rendererDataInstance);
				}
				HighlighterCore.sSubmeshIndices.Clear();
				i++;
			}
			HighlighterCore.sRenderers.Clear();
			int childCount = t.childCount;
			bool flag2 = childCount == 0;
			if (!flag2)
			{
				for (int j = 0; j < childCount; j++)
				{
					Transform child = t.GetChild(j);
					bool flag3 = !(child.GetComponent<HighlighterCore>() != null);
					if (flag3)
					{
						this.GrabRenderers(child);
					}
				}
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00008C44 File Offset: 0x00006E44
		private void FillBufferInternal(CommandBuffer buffer)
		{
			bool flag = this.mode == HighlighterMode.Overlay || this.mode == HighlighterMode.Occluder;
			bool flag2 = this.cachedOverlay != flag;
			if (flag2)
			{
				this.cachedOverlay = flag;
				this.opaqueMaterial.SetKeyword("HIGHLIGHTING_OVERLAY", this.cachedOverlay);
				for (int i = 0; i < this.highlightableRenderers.Count; i++)
				{
					this.highlightableRenderers[i].SetOverlay(this.cachedOverlay);
				}
			}
			Color rhs = (this.mode != HighlighterMode.Occluder) ? this.color : this.occluderColor;
			bool flag3 = this.cachedColor != rhs;
			if (flag3)
			{
				this.cachedColor = rhs;
				this.opaqueMaterial.SetColor(ShaderPropertyID._HighlightingColor, this.cachedColor);
				for (int j = 0; j < this.highlightableRenderers.Count; j++)
				{
					this.highlightableRenderers[j].SetColor(this.cachedColor);
				}
			}
			for (int k = this.highlightableRenderers.Count - 1; k >= 0; k--)
			{
				HighlighterRenderer highlighterRenderer = this.highlightableRenderers[k];
				bool flag4 = highlighterRenderer == null;
				if (flag4)
				{
					this.highlightableRenderers.RemoveAt(k);
				}
				else
				{
					bool flag5 = !highlighterRenderer.IsValid();
					if (flag5)
					{
						this.highlightableRenderers.RemoveAt(k);
						highlighterRenderer.isAlive = false;
					}
					else
					{
						bool flag6 = HighlightingBase.GetVisible(highlighterRenderer) || this.forceRender;
						if (flag6)
						{
							highlighterRenderer.FillBuffer(buffer);
						}
					}
				}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00008DFC File Offset: 0x00006FFC
		private static void ExpandRendererDataPool(int count)
		{
			for (int i = 0; i < count; i++)
			{
				HighlighterCore.RendererData item = new HighlighterCore.RendererData();
				HighlighterCore.sRendererDataPool.Push(item);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00008E30 File Offset: 0x00007030
		private static HighlighterCore.RendererData GetRendererDataInstance()
		{
			bool flag = HighlighterCore.sRendererDataPool.Count == 0;
			if (flag)
			{
				HighlighterCore.ExpandRendererDataPool(4);
			}
			return HighlighterCore.sRendererDataPool.Pop();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00008E68 File Offset: 0x00007068
		private static void ReleaseRendererDataInstance(HighlighterCore.RendererData instance)
		{
			bool flag = instance == null || HighlighterCore.sRendererDataPool.Contains(instance);
			if (!flag)
			{
				instance.renderer = null;
				instance.submeshIndices.Clear();
				HighlighterCore.sRendererDataPool.Push(instance);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00008EB0 File Offset: 0x000070B0
		[ExcludeFromDocs]
		public static void FillBuffer(CommandBuffer buffer)
		{
			for (int i = HighlighterCore.sHighlighters.Count - 1; i >= 0; i--)
			{
				HighlighterCore highlighterCore = HighlighterCore.sHighlighters[i];
				bool flag = highlighterCore == null;
				if (flag)
				{
					HighlighterCore.sHighlighters.RemoveAt(i);
				}
				else
				{
					highlighterCore.UpdateHighlighting();
					bool flag2 = highlighterCore == null;
					if (flag2)
					{
						HighlighterCore.sHighlighters.RemoveAt(i);
					}
					else
					{
						highlighterCore.UpdateRenderers();
					}
				}
			}
			for (int j = 0; j < HighlighterCore.renderingOrder.Length; j++)
			{
				HighlighterMode highlighterMode = HighlighterCore.renderingOrder[j];
				for (int k = HighlighterCore.sHighlighters.Count - 1; k >= 0; k--)
				{
					HighlighterCore highlighterCore2 = HighlighterCore.sHighlighters[k];
					bool flag3 = highlighterCore2.mode == highlighterMode;
					if (flag3)
					{
						highlighterCore2.FillBufferInternal(buffer);
					}
				}
			}
		}

		// Token: 0x04000075 RID: 117
		[ExcludeFromDocs]
		public const string keywordOverlay = "HIGHLIGHTING_OVERLAY";

		// Token: 0x04000076 RID: 118
		private readonly Color occluderColor = new Color(0f, 0f, 0f, 0f);

		// Token: 0x04000077 RID: 119
		private static readonly HighlighterMode[] renderingOrder = new HighlighterMode[]
		{
			HighlighterMode.Default,
			HighlighterMode.Overlay,
			HighlighterMode.Occluder
		};

		// Token: 0x04000078 RID: 120
		private const int poolChunkSize = 4;

		// Token: 0x04000079 RID: 121
		private static readonly List<Renderer> sRenderers = new List<Renderer>(4);

		// Token: 0x0400007A RID: 122
		private static readonly Stack<HighlighterCore.RendererData> sRendererDataPool = new Stack<HighlighterCore.RendererData>();

		// Token: 0x0400007B RID: 123
		private static readonly List<HighlighterCore.RendererData> sRendererData = new List<HighlighterCore.RendererData>(4);

		// Token: 0x0400007C RID: 124
		private static readonly List<int> sSubmeshIndices = new List<int>(4);

		// Token: 0x0400007D RID: 125
		private static readonly List<HighlighterCore> sHighlighters = new List<HighlighterCore>();

		// Token: 0x0400007E RID: 126
		private static ReadOnlyCollection<HighlighterCore> sHighlightersReadonly;

		// Token: 0x0400007F RID: 127
		public HighlighterMode mode;

		// Token: 0x04000080 RID: 128
		public bool forceRender;

		// Token: 0x04000081 RID: 129
		public Color color = Color.white;

		// Token: 0x04000082 RID: 130
		private Transform tr;

		// Token: 0x04000083 RID: 131
		private List<HighlighterRenderer> highlightableRenderers = new List<HighlighterRenderer>();

		// Token: 0x04000084 RID: 132
		private bool isDirty = true;

		// Token: 0x04000085 RID: 133
		private bool cachedOverlay;

		// Token: 0x04000086 RID: 134
		private Color cachedColor = Color.clear;

		// Token: 0x04000087 RID: 135
		private static Shader _opaqueShader;

		// Token: 0x04000088 RID: 136
		private static Shader _transparentShader;

		// Token: 0x04000089 RID: 137
		private Material _opaqueMaterial;

		// Token: 0x0400008A RID: 138
		private static HighlighterCore.RendererFilter _globalRendererFilter = null;

		// Token: 0x0400008B RID: 139
		private HighlighterCore.RendererFilter _rendererFilter;

		// Token: 0x0200003B RID: 59
		[ExcludeFromDocs]
		private class RendererData
		{
			// Token: 0x04000136 RID: 310
			public Renderer renderer;

			// Token: 0x04000137 RID: 311
			public List<int> submeshIndices = new List<int>();
		}

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x0600016D RID: 365
		public delegate bool RendererFilter(Renderer renderer, List<int> submeshIndices);
	}
}
