using System;
using UnityEngine;

namespace OKAJDodfsOS0
{
	// Token: 0x02000011 RID: 17
	internal class UILayoutManager
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000740D File Offset: 0x0000560D
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00007415 File Offset: 0x00005615
		public float X { get; private set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000741E File Offset: 0x0000561E
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00007426 File Offset: 0x00005626
		public float Y { get; private set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000742F File Offset: 0x0000562F
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00007437 File Offset: 0x00005637
		public float Width { get; private set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00007440 File Offset: 0x00005640
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00007448 File Offset: 0x00005648
		public float Height { get; private set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00007451 File Offset: 0x00005651
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00007459 File Offset: 0x00005659
		public float Spacing { get; private set; }

		// Token: 0x0600006B RID: 107 RVA: 0x00007462 File Offset: 0x00005662
		public UILayoutManager(float x, float y, float width, float height, float spacing)
		{
			this.X = x;
			this.Y = y;
			this.Width = width;
			this.Height = height;
			this.Spacing = spacing;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007498 File Offset: 0x00005698
		public Rect Next()
		{
			Rect result = new Rect(this.X, this.Y, this.Width, this.Height);
			this.Y += this.Height + this.Spacing;
			return result;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000074E5 File Offset: 0x000056E5
		public void Reset()
		{
			this.Y = 20f;
		}
	}
}
