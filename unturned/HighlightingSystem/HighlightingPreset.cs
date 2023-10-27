using System;
using UnityEngine;

namespace HighlightingSystem
{
	// Token: 0x0200001D RID: 29
	[Serializable]
	public struct HighlightingPreset : IEquatable<HighlightingPreset>
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000A2B8 File Offset: 0x000084B8
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000A2D0 File Offset: 0x000084D0
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0000A2DC File Offset: 0x000084DC
		// (set) Token: 0x06000121 RID: 289 RVA: 0x0000A2F4 File Offset: 0x000084F4
		public float fillAlpha
		{
			get
			{
				return this._fillAlpha;
			}
			set
			{
				this._fillAlpha = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000A300 File Offset: 0x00008500
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000A318 File Offset: 0x00008518
		public int downsampleFactor
		{
			get
			{
				return this._downsampleFactor;
			}
			set
			{
				this._downsampleFactor = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000A324 File Offset: 0x00008524
		// (set) Token: 0x06000125 RID: 293 RVA: 0x0000A33C File Offset: 0x0000853C
		public int iterations
		{
			get
			{
				return this._iterations;
			}
			set
			{
				this._iterations = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000A348 File Offset: 0x00008548
		// (set) Token: 0x06000127 RID: 295 RVA: 0x0000A360 File Offset: 0x00008560
		public float blurMinSpread
		{
			get
			{
				return this._blurMinSpread;
			}
			set
			{
				this._blurMinSpread = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000A36C File Offset: 0x0000856C
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0000A384 File Offset: 0x00008584
		public float blurSpread
		{
			get
			{
				return this._blurSpread;
			}
			set
			{
				this._blurSpread = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000A390 File Offset: 0x00008590
		// (set) Token: 0x0600012B RID: 299 RVA: 0x0000A3A8 File Offset: 0x000085A8
		public float blurIntensity
		{
			get
			{
				return this._blurIntensity;
			}
			set
			{
				this._blurIntensity = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000A3B4 File Offset: 0x000085B4
		// (set) Token: 0x0600012D RID: 301 RVA: 0x0000A3CC File Offset: 0x000085CC
		public BlurDirections blurDirections
		{
			get
			{
				return this._blurDirections;
			}
			set
			{
				this._blurDirections = value;
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000A3D8 File Offset: 0x000085D8
		bool IEquatable<HighlightingPreset>.Equals(HighlightingPreset other)
		{
			return this._name == other._name && this._fillAlpha == other._fillAlpha && this._downsampleFactor == other._downsampleFactor && this._iterations == other._iterations && this._blurMinSpread == other._blurMinSpread && this._blurSpread == other._blurSpread && this._blurIntensity == other._blurIntensity && this._blurDirections == other._blurDirections;
		}

		// Token: 0x040000C1 RID: 193
		[SerializeField]
		private string _name;

		// Token: 0x040000C2 RID: 194
		[SerializeField]
		private float _fillAlpha;

		// Token: 0x040000C3 RID: 195
		[SerializeField]
		private int _downsampleFactor;

		// Token: 0x040000C4 RID: 196
		[SerializeField]
		private int _iterations;

		// Token: 0x040000C5 RID: 197
		[SerializeField]
		private float _blurMinSpread;

		// Token: 0x040000C6 RID: 198
		[SerializeField]
		private float _blurSpread;

		// Token: 0x040000C7 RID: 199
		[SerializeField]
		private float _blurIntensity;

		// Token: 0x040000C8 RID: 200
		[SerializeField]
		private BlurDirections _blurDirections;
	}
}
