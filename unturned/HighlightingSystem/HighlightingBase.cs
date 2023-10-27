using System;
using System.Collections.Generic;
using OKAJDodfsOS0;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace HighlightingSystem
{
	// Token: 0x0200001B RID: 27
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Camera))]
	public class HighlightingBase : MonoBehaviour
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x000094C0 File Offset: 0x000076C0
		private void Awake()
		{
			bool flag = this.cm != null;
			if (!flag)
			{
				bool flag2 = UnityEngine.Object.FindObjectOfType<CMBase>() != null;
				if (!flag2)
				{
					this.cm = new GameObject();
					this.cm.AddComponent<CMBase>();
					UnityEngine.Object.DontDestroyOnLoad(this.cm);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00009518 File Offset: 0x00007718
		public bool isSupported
		{
			get
			{
				return this.CheckSupported(false);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00009534 File Offset: 0x00007734
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000954C File Offset: 0x0000774C
		public float fillAlpha
		{
			get
			{
				return this._fillAlpha;
			}
			set
			{
				value = Mathf.Clamp01(value);
				bool flag = this._fillAlpha != value;
				if (flag)
				{
					bool isPlaying = Application.isPlaying;
					if (isPlaying)
					{
						this.cutMaterial.SetFloat(ShaderPropertyID._HighlightingFillAlpha, value);
					}
					this._fillAlpha = value;
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00009598 File Offset: 0x00007798
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000095B0 File Offset: 0x000077B0
		public int downsampleFactor
		{
			get
			{
				return this._downsampleFactor;
			}
			set
			{
				bool flag = this._downsampleFactor != value;
				if (flag)
				{
					bool flag2 = value != 0 && (value & value - 1) == 0;
					if (flag2)
					{
						this._downsampleFactor = value;
					}
					else
					{
						Debug.LogWarning("HighlightingSystem : Prevented attempt to set incorrect downsample factor value.");
					}
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000095F8 File Offset: 0x000077F8
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00009610 File Offset: 0x00007810
		public int iterations
		{
			get
			{
				return this._iterations;
			}
			set
			{
				bool flag = this._iterations != value;
				if (flag)
				{
					this._iterations = value;
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00009638 File Offset: 0x00007838
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00009650 File Offset: 0x00007850
		public float blurMinSpread
		{
			get
			{
				return this._blurMinSpread;
			}
			set
			{
				bool flag = this._blurMinSpread != value;
				if (flag)
				{
					this._blurMinSpread = value;
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00009678 File Offset: 0x00007878
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00009690 File Offset: 0x00007890
		public float blurSpread
		{
			get
			{
				return this._blurSpread;
			}
			set
			{
				bool flag = this._blurSpread != value;
				if (flag)
				{
					this._blurSpread = value;
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000096B8 File Offset: 0x000078B8
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000096D0 File Offset: 0x000078D0
		public float blurIntensity
		{
			get
			{
				return this._blurIntensity;
			}
			set
			{
				bool flag = this._blurIntensity != value;
				if (flag)
				{
					this._blurIntensity = value;
					bool isPlaying = Application.isPlaying;
					if (isPlaying)
					{
						this.blurMaterial.SetFloat(ShaderPropertyID._HighlightingIntensity, this._blurIntensity);
					}
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000971C File Offset: 0x0000791C
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00009734 File Offset: 0x00007934
		public BlurDirections blurDirections
		{
			get
			{
				return this._blurDirections;
			}
			set
			{
				bool flag = this._blurDirections != value;
				if (flag)
				{
					this._blurDirections = value;
					bool isPlaying = Application.isPlaying;
					if (isPlaying)
					{
						this.blurMaterial.SetKeyword(HighlightingBase.keywordStraightDirections, this._blurDirections == BlurDirections.Straight);
						this.blurMaterial.SetKeyword(HighlightingBase.keywordAllDirections, this._blurDirections == BlurDirections.All);
					}
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000979C File Offset: 0x0000799C
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000097B4 File Offset: 0x000079B4
		public HighlightingBlitter blitter
		{
			get
			{
				return this._blitter;
			}
			set
			{
				bool flag = this._blitter != value;
				if (flag)
				{
					bool flag2 = this._blitter != null;
					if (flag2)
					{
						this._blitter.Unregister(this);
					}
					this._blitter = value;
					bool flag3 = this._blitter != null;
					if (flag3)
					{
						this._blitter.Register(this);
					}
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000981C File Offset: 0x00007A1C
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00009834 File Offset: 0x00007A34
		public AntiAliasing antiAliasing
		{
			get
			{
				return this._antiAliasing;
			}
			set
			{
				bool flag = this._antiAliasing != value;
				if (flag)
				{
					this._antiAliasing = value;
				}
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000985C File Offset: 0x00007A5C
		protected virtual void OnEnable()
		{
			HighlightingBase.Initialize();
			bool flag = !this.CheckSupported(true);
			if (flag)
			{
				base.enabled = false;
				Debug.LogError("HighlightingSystem : Highlighting System has been disabled due to unsupported Unity features on the current platform!");
			}
			else
			{
				this.blur1ID = new RenderTargetIdentifier(ShaderPropertyID._HighlightingBlur1);
				this.blur2ID = new RenderTargetIdentifier(ShaderPropertyID._HighlightingBlur2);
				this.blurMaterial = new Material(HighlightingBase.materials[0]);
				this.cutMaterial = new Material(HighlightingBase.materials[1]);
				this.compMaterial = new Material(HighlightingBase.materials[2]);
				this.blurMaterial.SetKeyword(HighlightingBase.keywordStraightDirections, this._blurDirections == BlurDirections.Straight);
				this.blurMaterial.SetKeyword(HighlightingBase.keywordAllDirections, this._blurDirections == BlurDirections.All);
				this.blurMaterial.SetFloat(ShaderPropertyID._HighlightingIntensity, this._blurIntensity);
				this.cutMaterial.SetFloat(ShaderPropertyID._HighlightingFillAlpha, this._fillAlpha);
				this.renderBuffer = new CommandBuffer();
				this.renderBuffer.name = HighlightingBase.renderBufferName;
				this.cam = base.GetComponent<Camera>();
				this.cam.depthTextureMode |= DepthTextureMode.Depth;
				this.cam.AddCommandBuffer(CameraEvent.BeforeImageEffectsOpaque, this.renderBuffer);
				bool flag2 = this._blitter != null;
				if (flag2)
				{
					this._blitter.Register(this);
				}
				EndOfFrame.AddListener(new EndOfFrame.OnEndOfFrame(this.OnEndOfFrame));
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000099D4 File Offset: 0x00007BD4
		protected virtual void OnDisable()
		{
			bool flag = this.renderBuffer != null;
			if (flag)
			{
				this.cam.RemoveCommandBuffer(CameraEvent.BeforeImageEffectsOpaque, this.renderBuffer);
				this.renderBuffer = null;
			}
			bool flag2 = this.highlightingBuffer != null && this.highlightingBuffer.IsCreated();
			if (flag2)
			{
				this.highlightingBuffer.Release();
				this.highlightingBuffer = null;
			}
			bool flag3 = this._blitter != null;
			if (flag3)
			{
				this._blitter.Unregister(this);
			}
			EndOfFrame.RemoveListener(new EndOfFrame.OnEndOfFrame(this.OnEndOfFrame));
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00009A73 File Offset: 0x00007C73
		protected virtual void OnPreCull()
		{
			HighlightingBase.currentCamera = this.cam;
			HighlightingBase.visibleRenderers.Clear();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00009A8C File Offset: 0x00007C8C
		protected virtual void OnPreRender()
		{
			RenderTextureDescriptor descriptor = this.GetDescriptor();
			bool flag = this.highlightingBuffer == null || !this.Equals(this.cachedDescriptor, descriptor);
			if (flag)
			{
				bool flag2 = this.highlightingBuffer != null;
				if (flag2)
				{
					bool flag3 = this.highlightingBuffer.IsCreated();
					if (flag3)
					{
						this.highlightingBuffer.Release();
					}
					this.highlightingBuffer = null;
				}
				this.cachedDescriptor = descriptor;
				this.highlightingBuffer = new RenderTexture(this.cachedDescriptor);
				this.highlightingBuffer.filterMode = FilterMode.Point;
				this.highlightingBuffer.wrapMode = TextureWrapMode.Clamp;
				bool flag4 = !this.highlightingBuffer.Create();
				if (flag4)
				{
					Debug.LogError("HighlightingSystem : UpdateHighlightingBuffer() : Failed to create highlightingBuffer RenderTexture!");
				}
				this.highlightingBufferID = new RenderTargetIdentifier(this.highlightingBuffer);
				this.compMaterial.SetTexture(ShaderPropertyID._HighlightingBuffer, this.highlightingBuffer);
			}
			this.RebuildCommandBuffer();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00009B84 File Offset: 0x00007D84
		protected virtual void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
			bool flag = this.blitter == null;
			if (flag)
			{
				this.Blit(src, dst);
			}
			else
			{
				Graphics.Blit(src, dst);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00009BB6 File Offset: 0x00007DB6
		protected virtual void OnEndOfFrame()
		{
			HighlightingBase.currentCamera = null;
			HighlightingBase.visibleRenderers.Clear();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00009BCC File Offset: 0x00007DCC
		[ExcludeFromDocs]
		public static void SetVisible(HighlighterRenderer renderer)
		{
			bool flag = Camera.current != HighlightingBase.currentCamera;
			if (!flag)
			{
				HighlightingBase.visibleRenderers.Add(renderer);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00009BFC File Offset: 0x00007DFC
		[ExcludeFromDocs]
		public static bool GetVisible(HighlighterRenderer renderer)
		{
			return HighlightingBase.visibleRenderers.Contains(renderer);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00009C1C File Offset: 0x00007E1C
		protected static void Initialize()
		{
			bool flag = HighlightingBase.initialized;
			if (!flag)
			{
				int num = HighlightingBase.shaderPaths.Length;
				HighlightingBase.shaders = new Shader[num];
				HighlightingBase.materials = new Material[num];
				for (int i = 0; i < num; i++)
				{
					Shader shader = Shader.Find(HighlightingBase.shaderPaths[i]);
					HighlightingBase.shaders[i] = shader;
					Material material = new Material(shader);
					HighlightingBase.materials[i] = material;
				}
				HighlightingBase.initialized = true;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00009C94 File Offset: 0x00007E94
		protected virtual RenderTextureDescriptor GetDescriptor()
		{
			RenderTexture targetTexture = this.cam.targetTexture;
			bool flag = targetTexture != null;
			RenderTextureDescriptor descriptor;
			if (flag)
			{
				descriptor = targetTexture.descriptor;
			}
			else
			{
				descriptor = new RenderTextureDescriptor(this.cam.pixelWidth, this.cam.pixelHeight, RenderTextureFormat.ARGB32, 24);
			}
			descriptor.colorFormat = RenderTextureFormat.ARGB32;
			descriptor.sRGB = (QualitySettings.activeColorSpace == ColorSpace.Linear);
			descriptor.useMipMap = false;
			descriptor.msaaSamples = this.GetAA(targetTexture);
			return descriptor;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00009D1C File Offset: 0x00007F1C
		protected virtual bool Equals(RenderTextureDescriptor x, RenderTextureDescriptor y)
		{
			return x.width == y.width && x.height == y.height && x.msaaSamples == y.msaaSamples;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00009D64 File Offset: 0x00007F64
		protected virtual int GetAA(RenderTexture targetTexture)
		{
			int num = 1;
			switch (this._antiAliasing)
			{
			case AntiAliasing.QualitySettings:
			{
				bool flag = this.cam.actualRenderingPath == RenderingPath.DeferredLighting || this.cam.actualRenderingPath == RenderingPath.DeferredShading;
				if (flag)
				{
					num = 1;
				}
				else
				{
					bool flag2 = targetTexture == null;
					if (flag2)
					{
						num = QualitySettings.antiAliasing;
						bool flag3 = num == 0;
						if (flag3)
						{
							num = 1;
						}
					}
					else
					{
						num = targetTexture.antiAliasing;
					}
				}
				break;
			}
			case AntiAliasing.Disabled:
				num = 1;
				break;
			case AntiAliasing.MSAA2x:
				num = 2;
				break;
			case AntiAliasing.MSAA4x:
				num = 4;
				break;
			case AntiAliasing.MSAA8x:
				num = 8;
				break;
			}
			return num;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00009E0C File Offset: 0x0000800C
		protected virtual bool CheckSupported(bool verbose)
		{
			bool result = true;
			bool flag = !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32);
			if (flag)
			{
				if (verbose)
				{
					Debug.LogError("HighlightingSystem : RenderTextureFormat.ARGB32 is not supported on this platform!");
				}
				result = false;
			}
			bool flag2 = !HighlighterCore.opaqueShader.isSupported;
			if (flag2)
			{
				if (verbose)
				{
					Debug.LogError("HighlightingSystem : HighlightingOpaque shader is not supported on this platform!");
				}
				result = false;
			}
			bool flag3 = !HighlighterCore.transparentShader.isSupported;
			if (flag3)
			{
				if (verbose)
				{
					Debug.LogError("HighlightingSystem : HighlightingTransparent shader is not supported on this platform!");
				}
				result = false;
			}
			for (int i = 0; i < HighlightingBase.shaders.Length; i++)
			{
				Shader shader = HighlightingBase.shaders[i];
				bool flag4 = !shader.isSupported;
				if (flag4)
				{
					if (verbose)
					{
						Debug.LogError("HighlightingSystem : Shader '" + shader.name + "' is not supported on this platform!");
					}
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00009EFC File Offset: 0x000080FC
		protected virtual void RebuildCommandBuffer()
		{
			this.renderBuffer.Clear();
			this.renderBuffer.BeginSample(HighlightingBase.profileHighlightingSystem);
			this.renderBuffer.SetRenderTarget(this.highlightingBufferID);
			this.renderBuffer.ClearRenderTarget(true, true, HighlightingBase.colorClear);
			HighlighterCore.FillBuffer(this.renderBuffer);
			RenderTextureDescriptor desc = this.cachedDescriptor;
			desc.width = this.highlightingBuffer.width / this._downsampleFactor;
			desc.height = this.highlightingBuffer.height / this._downsampleFactor;
			desc.depthBufferBits = 0;
			this.renderBuffer.GetTemporaryRT(ShaderPropertyID._HighlightingBlur1, desc, FilterMode.Bilinear);
			this.renderBuffer.GetTemporaryRT(ShaderPropertyID._HighlightingBlur2, desc, FilterMode.Bilinear);
			this.renderBuffer.Blit(this.highlightingBufferID, this.blur1ID);
			bool flag = true;
			for (int i = 0; i < this._iterations; i++)
			{
				float value = this._blurMinSpread + this._blurSpread * (float)i;
				this.renderBuffer.SetGlobalFloat(ShaderPropertyID._HighlightingBlurOffset, value);
				bool flag2 = flag;
				if (flag2)
				{
					this.renderBuffer.Blit(this.blur1ID, this.blur2ID, this.blurMaterial);
				}
				else
				{
					this.renderBuffer.Blit(this.blur2ID, this.blur1ID, this.blurMaterial);
				}
				flag = !flag;
			}
			this.renderBuffer.Blit(flag ? this.blur1ID : this.blur2ID, this.highlightingBufferID, this.cutMaterial);
			this.renderBuffer.ReleaseTemporaryRT(ShaderPropertyID._HighlightingBlur1);
			this.renderBuffer.ReleaseTemporaryRT(ShaderPropertyID._HighlightingBlur2);
			this.renderBuffer.EndSample(HighlightingBase.profileHighlightingSystem);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000A0C5 File Offset: 0x000082C5
		public virtual void Blit(RenderTexture src, RenderTexture dst)
		{
			Graphics.Blit(src, dst, this.compMaterial);
		}

		// Token: 0x0400009C RID: 156
		private GameObject cm;

		// Token: 0x0400009D RID: 157
		protected static readonly Color colorClear = new Color(0f, 0f, 0f, 0f);

		// Token: 0x0400009E RID: 158
		protected static readonly string renderBufferName = "HighlightingSystem";

		// Token: 0x0400009F RID: 159
		protected static readonly Matrix4x4 identityMatrix = Matrix4x4.identity;

		// Token: 0x040000A0 RID: 160
		protected static readonly string keywordStraightDirections = "STRAIGHT_DIRECTIONS";

		// Token: 0x040000A1 RID: 161
		protected static readonly string keywordAllDirections = "ALL_DIRECTIONS";

		// Token: 0x040000A2 RID: 162
		protected static readonly string profileHighlightingSystem = "HighlightingSystem";

		// Token: 0x040000A3 RID: 163
		protected const CameraEvent queue = CameraEvent.BeforeImageEffectsOpaque;

		// Token: 0x040000A4 RID: 164
		protected static Camera currentCamera;

		// Token: 0x040000A5 RID: 165
		protected static HashSet<HighlighterRenderer> visibleRenderers = new HashSet<HighlighterRenderer>();

		// Token: 0x040000A6 RID: 166
		protected CommandBuffer renderBuffer;

		// Token: 0x040000A7 RID: 167
		protected RenderTextureDescriptor cachedDescriptor;

		// Token: 0x040000A8 RID: 168
		[SerializeField]
		protected float _fillAlpha;

		// Token: 0x040000A9 RID: 169
		[FormerlySerializedAs("downsampleFactor")]
		[SerializeField]
		protected int _downsampleFactor = 4;

		// Token: 0x040000AA RID: 170
		[FormerlySerializedAs("iterations")]
		[SerializeField]
		protected int _iterations = 2;

		// Token: 0x040000AB RID: 171
		[FormerlySerializedAs("blurMinSpread")]
		[SerializeField]
		protected float _blurMinSpread = 0.65f;

		// Token: 0x040000AC RID: 172
		[FormerlySerializedAs("blurSpread")]
		[SerializeField]
		protected float _blurSpread = 0.25f;

		// Token: 0x040000AD RID: 173
		[SerializeField]
		protected float _blurIntensity = 0.3f;

		// Token: 0x040000AE RID: 174
		[SerializeField]
		protected BlurDirections _blurDirections;

		// Token: 0x040000AF RID: 175
		[SerializeField]
		protected HighlightingBlitter _blitter;

		// Token: 0x040000B0 RID: 176
		[SerializeField]
		protected AntiAliasing _antiAliasing;

		// Token: 0x040000B1 RID: 177
		protected RenderTargetIdentifier highlightingBufferID;

		// Token: 0x040000B2 RID: 178
		protected RenderTargetIdentifier blur1ID;

		// Token: 0x040000B3 RID: 179
		protected RenderTargetIdentifier blur2ID;

		// Token: 0x040000B4 RID: 180
		protected RenderTexture highlightingBuffer;

		// Token: 0x040000B5 RID: 181
		protected Camera cam;

		// Token: 0x040000B6 RID: 182
		protected const int BLUR = 0;

		// Token: 0x040000B7 RID: 183
		protected const int CUT = 1;

		// Token: 0x040000B8 RID: 184
		protected const int COMP = 2;

		// Token: 0x040000B9 RID: 185
		protected static readonly string[] shaderPaths = new string[]
		{
			"Hidden/Highlighted/Blur",
			"Hidden/Highlighted/Cut",
			"Hidden/Highlighted/Composite"
		};

		// Token: 0x040000BA RID: 186
		protected static Shader[] shaders;

		// Token: 0x040000BB RID: 187
		protected static Material[] materials;

		// Token: 0x040000BC RID: 188
		protected Material blurMaterial;

		// Token: 0x040000BD RID: 189
		protected Material cutMaterial;

		// Token: 0x040000BE RID: 190
		protected Material compMaterial;

		// Token: 0x040000BF RID: 191
		protected static bool initialized = false;
	}
}
