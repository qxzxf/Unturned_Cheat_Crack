using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Internal;

namespace HighlightingSystem
{
	// Token: 0x0200001C RID: 28
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Highlighting System/Highlighting Blitter", 3)]
	public class HighlightingBlitter : MonoBehaviour
	{
		// Token: 0x0600011A RID: 282 RVA: 0x0000A1A0 File Offset: 0x000083A0
		protected virtual void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
			bool flag = true;
			for (int i = 0; i < this.renderers.Count; i++)
			{
				HighlightingBase highlightingBase = this.renderers[i];
				bool flag2 = flag;
				if (flag2)
				{
					highlightingBase.Blit(src, dst);
				}
				else
				{
					highlightingBase.Blit(dst, src);
				}
				flag = !flag;
			}
			bool flag3 = flag;
			if (flag3)
			{
				Graphics.Blit(src, dst);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000A210 File Offset: 0x00008410
		[ExcludeFromDocs]
		public virtual void Register(HighlightingBase renderer)
		{
			bool flag = !this.renderers.Contains(renderer);
			if (flag)
			{
				this.renderers.Add(renderer);
			}
			base.enabled = (this.renderers.Count > 0);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000A258 File Offset: 0x00008458
		[ExcludeFromDocs]
		public virtual void Unregister(HighlightingBase renderer)
		{
			int num = this.renderers.IndexOf(renderer);
			bool flag = num != -1;
			if (flag)
			{
				this.renderers.RemoveAt(num);
			}
			base.enabled = (this.renderers.Count > 0);
		}

		// Token: 0x040000C0 RID: 192
		protected List<HighlightingBase> renderers = new List<HighlightingBase>();
	}
}
