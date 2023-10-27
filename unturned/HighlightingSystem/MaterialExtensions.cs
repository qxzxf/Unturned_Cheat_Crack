using System;
using UnityEngine;
using UnityEngine.Internal;

namespace HighlightingSystem
{
	// Token: 0x02000020 RID: 32
	[ExcludeFromDocs]
	public static class MaterialExtensions
	{
		// Token: 0x06000138 RID: 312 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		public static void SetKeyword(this Material material, string keyword, bool state)
		{
			if (state)
			{
				material.EnableKeyword(keyword);
			}
			else
			{
				material.DisableKeyword(keyword);
			}
		}
	}
}
