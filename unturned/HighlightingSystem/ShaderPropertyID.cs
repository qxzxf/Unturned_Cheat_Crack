using System;
using UnityEngine;
using UnityEngine.Internal;

namespace HighlightingSystem
{
	// Token: 0x02000022 RID: 34
	[ExcludeFromDocs]
	public class ShaderPropertyID
	{
		// Token: 0x040000D5 RID: 213
		public static readonly int _MainTex = Shader.PropertyToID("_MainTex");

		// Token: 0x040000D6 RID: 214
		public static readonly int _Cutoff = Shader.PropertyToID("_Cutoff");

		// Token: 0x040000D7 RID: 215
		public static readonly int _HighlightingIntensity = Shader.PropertyToID("_HighlightingIntensity");

		// Token: 0x040000D8 RID: 216
		public static readonly int _HighlightingCull = Shader.PropertyToID("_HighlightingCull");

		// Token: 0x040000D9 RID: 217
		public static readonly int _HighlightingColor = Shader.PropertyToID("_HighlightingColor");

		// Token: 0x040000DA RID: 218
		public static readonly int _HighlightingBlurOffset = Shader.PropertyToID("_HighlightingBlurOffset");

		// Token: 0x040000DB RID: 219
		public static readonly int _HighlightingFillAlpha = Shader.PropertyToID("_HighlightingFillAlpha");

		// Token: 0x040000DC RID: 220
		public static readonly int _HighlightingBuffer = Shader.PropertyToID("_HighlightingBuffer");

		// Token: 0x040000DD RID: 221
		public static readonly int _HighlightingBlur1 = Shader.PropertyToID("_HighlightingBlur1");

		// Token: 0x040000DE RID: 222
		public static readonly int _HighlightingBlur2 = Shader.PropertyToID("_HighlightingBlur2");
	}
}
