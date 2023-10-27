using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Internal;

namespace HighlightingSystem
{
	// Token: 0x02000015 RID: 21
	[ExcludeFromDocs]
	public class EndOfFrame : MonoBehaviour
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000074F4 File Offset: 0x000056F4
		private static EndOfFrame singleton
		{
			get
			{
				bool flag = EndOfFrame._singleton == null;
				if (flag)
				{
					EndOfFrame._singleton = new GameObject("EndOfFrameHelper")
					{
						hideFlags = HideFlags.HideAndDontSave
					}.AddComponent<EndOfFrame>();
				}
				return EndOfFrame._singleton;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00007539 File Offset: 0x00005739
		private void OnEnable()
		{
			this.coroutine = base.StartCoroutine(this.EndOfFrameRoutine());
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00007550 File Offset: 0x00005750
		private void OnDisable()
		{
			bool flag = this.coroutine != null;
			if (flag)
			{
				base.StopCoroutine(this.coroutine);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000757C File Offset: 0x0000577C
		public static void AddListener(EndOfFrame.OnEndOfFrame listener)
		{
			bool flag = listener == null;
			if (!flag)
			{
				EndOfFrame.singleton.listeners.Add(listener);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000075A8 File Offset: 0x000057A8
		public static void RemoveListener(EndOfFrame.OnEndOfFrame listener)
		{
			bool flag = listener == null || EndOfFrame._singleton == null;
			if (!flag)
			{
				EndOfFrame.singleton.listeners.Remove(listener);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000075DF File Offset: 0x000057DF
		private IEnumerator EndOfFrameRoutine()
		{
			for (;;)
			{
				yield return this.waitForEndOfFrame;
				int num;
				for (int i = this.listeners.Count - 1; i >= 0; i = num - 1)
				{
					EndOfFrame.OnEndOfFrame onEndOfFrame = this.listeners[i];
					bool flag = onEndOfFrame != null;
					if (flag)
					{
						onEndOfFrame();
					}
					else
					{
						this.listeners.RemoveAt(i);
					}
					onEndOfFrame = null;
					num = i;
				}
			}
			yield break;
		}

		// Token: 0x04000054 RID: 84
		private static EndOfFrame _singleton;

		// Token: 0x04000055 RID: 85
		private WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();

		// Token: 0x04000056 RID: 86
		private Coroutine coroutine;

		// Token: 0x04000057 RID: 87
		private List<EndOfFrame.OnEndOfFrame> listeners = new List<EndOfFrame.OnEndOfFrame>();

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000162 RID: 354
		[ExcludeFromDocs]
		public delegate void OnEndOfFrame();
	}
}
