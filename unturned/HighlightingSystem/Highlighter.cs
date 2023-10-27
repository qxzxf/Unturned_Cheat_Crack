using System;
using System.Collections.Generic;
using UnityEngine;

namespace HighlightingSystem
{
	// Token: 0x02000016 RID: 22
	[AddComponentMenu("Highlighting System/Highlighter", 0)]
	public class Highlighter : HighlighterCore
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00007610 File Offset: 0x00005810
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00007628 File Offset: 0x00005828
		public bool overlay
		{
			get
			{
				return this._overlay;
			}
			set
			{
				this._overlay = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00007634 File Offset: 0x00005834
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000764C File Offset: 0x0000584C
		public bool occluder
		{
			get
			{
				return this._occluder;
			}
			set
			{
				this._occluder = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00007658 File Offset: 0x00005858
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00007670 File Offset: 0x00005870
		public bool tween
		{
			get
			{
				return this._tween;
			}
			set
			{
				this.TweenSet(value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000767C File Offset: 0x0000587C
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00007694 File Offset: 0x00005894
		public Gradient tweenGradient
		{
			get
			{
				return this._tweenGradient;
			}
			set
			{
				this._tweenGradient = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000076A0 File Offset: 0x000058A0
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000076B8 File Offset: 0x000058B8
		public float tweenDuration
		{
			get
			{
				return this._tweenDuration;
			}
			set
			{
				this._tweenDuration = value;
				this.ValidateRanges();
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000076CC File Offset: 0x000058CC
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000076E4 File Offset: 0x000058E4
		public float tweenDelay
		{
			get
			{
				return this._tweenDelay;
			}
			set
			{
				this._tweenDelay = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000076F0 File Offset: 0x000058F0
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00007708 File Offset: 0x00005908
		public bool tweenUseUnscaledTime
		{
			get
			{
				return this._tweenUseUnscaledTime;
			}
			set
			{
				bool flag = this._tweenUseUnscaledTime != value;
				if (flag)
				{
					float num = this.GetTweenTime() - this._tweenStart;
					this._tweenUseUnscaledTime = value;
					this._tweenStart = this.GetTweenTime() - num;
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000774C File Offset: 0x0000594C
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00007764 File Offset: 0x00005964
		public LoopMode tweenLoop
		{
			get
			{
				return this._tweenLoop;
			}
			set
			{
				this._tweenLoop = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00007770 File Offset: 0x00005970
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00007788 File Offset: 0x00005988
		public Easing tweenEasing
		{
			get
			{
				return this._tweenEasing;
			}
			set
			{
				this._tweenEasing = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00007794 File Offset: 0x00005994
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000077AC File Offset: 0x000059AC
		public bool tweenReverse
		{
			get
			{
				return this._tweenReverse;
			}
			set
			{
				this._tweenReverse = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000077B8 File Offset: 0x000059B8
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000077D0 File Offset: 0x000059D0
		public int tweenRepeatCount
		{
			get
			{
				return this._tweenRepeatCount;
			}
			set
			{
				this._tweenRepeatCount = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000077DC File Offset: 0x000059DC
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000077F4 File Offset: 0x000059F4
		public bool constant
		{
			get
			{
				return this._constant;
			}
			set
			{
				this.ConstantSet(value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00007800 File Offset: 0x00005A00
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00007818 File Offset: 0x00005A18
		public Color constantColor
		{
			get
			{
				return this._constantColor;
			}
			set
			{
				this._constantColor = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00007822 File Offset: 0x00005A22
		public float constantFadeTime
		{
			set
			{
				this._constantFadeInTime = value;
				this._constantFadeOutTime = value;
				this.ValidateRanges();
				this.ConstantSet();
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00007844 File Offset: 0x00005A44
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000785C File Offset: 0x00005A5C
		public float constantFadeInTime
		{
			get
			{
				return this._constantFadeInTime;
			}
			set
			{
				this._constantFadeInTime = value;
				this.ValidateRanges();
				bool constant = this._constant;
				if (constant)
				{
					this.ConstantSet();
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000788C File Offset: 0x00005A8C
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000078A4 File Offset: 0x00005AA4
		public float constantFadeOutTime
		{
			get
			{
				return this._constantFadeOutTime;
			}
			set
			{
				this._constantFadeOutTime = value;
				this.ValidateRanges();
				bool flag = !this._constant;
				if (flag)
				{
					this.ConstantSet();
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000078D8 File Offset: 0x00005AD8
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000078F0 File Offset: 0x00005AF0
		public bool constantUseUnscaledTime
		{
			get
			{
				return this._constantUseUnscaledTime;
			}
			set
			{
				bool flag = this._constantUseUnscaledTime != value;
				if (flag)
				{
					float num = this.GetConstantTime() - this._constantStart;
					this._constantUseUnscaledTime = value;
					this._constantStart = this.GetConstantTime() - num;
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00007934 File Offset: 0x00005B34
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000794C File Offset: 0x00005B4C
		public Easing constantEasing
		{
			get
			{
				return this._constantEasing;
			}
			set
			{
				this._constantEasing = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00007958 File Offset: 0x00005B58
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00007970 File Offset: 0x00005B70
		public RendererFilterMode filterMode
		{
			get
			{
				return this._filterMode;
			}
			set
			{
				bool flag = this._filterMode != value;
				if (flag)
				{
					this._filterMode = value;
					base.SetDirty();
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000079A0 File Offset: 0x00005BA0
		public List<Transform> filterList
		{
			get
			{
				return this._filterList;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000079B8 File Offset: 0x00005BB8
		protected override HighlighterCore.RendererFilter rendererFilterToUse
		{
			get
			{
				bool flag = base.rendererFilter != null;
				HighlighterCore.RendererFilter result;
				if (flag)
				{
					result = base.rendererFilter;
				}
				else
				{
					bool flag2 = this._filterMode == RendererFilterMode.None;
					if (flag2)
					{
						bool flag3 = HighlighterCore.globalRendererFilter == null;
						if (flag3)
						{
							result = new HighlighterCore.RendererFilter(HighlighterCore.DefaultRendererFilter);
						}
						else
						{
							result = HighlighterCore.globalRendererFilter;
						}
					}
					else
					{
						bool flag4 = this._filterMode == RendererFilterMode.Include;
						if (flag4)
						{
							result = new HighlighterCore.RendererFilter(this.TransformFilterInclude);
						}
						else
						{
							bool flag5 = this._filterMode == RendererFilterMode.Exclude;
							if (flag5)
							{
								result = new HighlighterCore.RendererFilter(this.TransformFilterExclude);
							}
							else
							{
								result = new HighlighterCore.RendererFilter(HighlighterCore.DefaultRendererFilter);
							}
						}
					}
				}
				return result;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00007A64 File Offset: 0x00005C64
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00007A83 File Offset: 0x00005C83
		protected bool hover
		{
			get
			{
				return this._hoverFrame == Time.frameCount;
			}
			set
			{
				this._hoverFrame = (value ? Time.frameCount : -1);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00007A98 File Offset: 0x00005C98
		protected float constantValue
		{
			get
			{
				bool flag = this._constantDuration <= 0f;
				float result;
				if (flag)
				{
					result = 1f;
				}
				else
				{
					result = Mathf.Clamp01((this.GetConstantTime() - this._constantStart) / this._constantDuration);
				}
				return result;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00007AE0 File Offset: 0x00005CE0
		protected virtual void OnDidApplyAnimationProperties()
		{
			this.ValidateAll();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00007AE0 File Offset: 0x00005CE0
		protected override void OnEnableSafe()
		{
			this.ValidateAll();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00007AEA File Offset: 0x00005CEA
		protected override void OnDisableSafe()
		{
			this._tweenEnabled = false;
			this._constantEnabled = false;
			this._constantStart = this.GetConstantTime() - this._constantDuration;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00007B0E File Offset: 0x00005D0E
		protected void ValidateAll()
		{
			this.ValidateRanges();
			this.TweenSet();
			this.ConstantSet();
			base.SetDirty();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00007B30 File Offset: 0x00005D30
		protected void ValidateRanges()
		{
			bool flag = this._tweenDuration < 0f;
			if (flag)
			{
				this._tweenDuration = 0f;
			}
			bool flag2 = this._constantFadeInTime < 0f;
			if (flag2)
			{
				this._constantFadeInTime = 0f;
			}
			bool flag3 = this._constantFadeOutTime < 0f;
			if (flag3)
			{
				this._constantFadeInTime = 0f;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007B98 File Offset: 0x00005D98
		public void Hover(Color color)
		{
			this._hoverColor = color;
			this.hover = true;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007BAA File Offset: 0x00005DAA
		public void ConstantOn(float fadeTime = 0.25f)
		{
			this.ConstantSet(fadeTime, true);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007BB6 File Offset: 0x00005DB6
		public void ConstantOn(Color color, float fadeTime = 0.25f)
		{
			this._constantColor = color;
			this.ConstantSet(fadeTime, true);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00007BC9 File Offset: 0x00005DC9
		public void ConstantOff(float fadeTime = 0.25f)
		{
			this.ConstantSet(fadeTime, false);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00007BD5 File Offset: 0x00005DD5
		public void ConstantSwitch(float fadeTime = 0.25f)
		{
			this.ConstantSet(fadeTime, !this._constant);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00007BE9 File Offset: 0x00005DE9
		public void ConstantOnImmediate()
		{
			this.ConstantSet(0f, true);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00007BF9 File Offset: 0x00005DF9
		public void ConstantOnImmediate(Color color)
		{
			this._constantColor = color;
			this.ConstantSet(0f, true);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00007C10 File Offset: 0x00005E10
		public void ConstantOffImmediate()
		{
			this.ConstantSet(0f, false);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00007C20 File Offset: 0x00005E20
		public void ConstantSwitchImmediate()
		{
			this.ConstantSet(0f, !this._constant);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00007C38 File Offset: 0x00005E38
		public void Off()
		{
			this.hover = false;
			this.TweenSet(false);
			this.ConstantSet(0f, false);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00007C58 File Offset: 0x00005E58
		public void TweenStart()
		{
			this.TweenSet(true);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00007C63 File Offset: 0x00005E63
		public void TweenStop()
		{
			this.TweenSet(false);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00007C70 File Offset: 0x00005E70
		public void TweenSet(bool value)
		{
			this._tween = value;
			bool flag = this._tweenEnabled != this._tween;
			if (flag)
			{
				this._tweenEnabled = this._tween;
				this._tweenStart = this.GetTweenTime();
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00007CB4 File Offset: 0x00005EB4
		public void ConstantSet(float fadeTime, bool value)
		{
			bool flag = fadeTime < 0f;
			if (flag)
			{
				fadeTime = 0f;
			}
			bool flag2 = this._constantDuration != fadeTime;
			if (flag2)
			{
				float constantTime = this.GetConstantTime();
				this._constantStart = ((this._constantDuration > 0f) ? (constantTime - fadeTime / this._constantDuration * (constantTime - this._constantStart)) : (constantTime - fadeTime));
				this._constantDuration = fadeTime;
			}
			this._constant = value;
			bool flag3 = this._constantEnabled != this._constant;
			if (flag3)
			{
				this._constantEnabled = this._constant;
				this._constantStart = this.GetConstantTime() - this._constantDuration * (1f - this.constantValue);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00007D6C File Offset: 0x00005F6C
		protected void TweenSet()
		{
			this.TweenSet(this._tween);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00007D7C File Offset: 0x00005F7C
		protected void ConstantSet()
		{
			this.ConstantSet(this._constant);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00007D8C File Offset: 0x00005F8C
		protected void ConstantSet(bool value)
		{
			this.ConstantSet(value ? this.constantFadeInTime : this._constantFadeOutTime, value);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00007DA8 File Offset: 0x00005FA8
		protected override void UpdateHighlighting()
		{
			bool hover = this.hover;
			if (hover)
			{
				this.color = this._hoverColor;
				this.mode = (this._overlay ? HighlighterMode.Overlay : HighlighterMode.Default);
			}
			else
			{
				bool tweenEnabled = this._tweenEnabled;
				if (tweenEnabled)
				{
					float num = this.GetTweenTime() - (this._tweenStart + this._tweenDelay);
					bool flag = num >= 0f;
					if (flag)
					{
						float num2 = (this._tweenDuration > 0f) ? (num / this._tweenDuration) : 0f;
						num2 = this.Loop(num2, this._tweenLoop, this._tweenReverse, this._tweenRepeatCount);
						bool flag2 = num2 >= 0f;
						if (flag2)
						{
							num2 = this.Ease(num2, this._tweenEasing);
							this.color = this._tweenGradient.Evaluate(num2);
							this.mode = (this._overlay ? HighlighterMode.Overlay : HighlighterMode.Default);
							return;
						}
					}
				}
				float num3 = this._constantEnabled ? this.constantValue : (1f - this.constantValue);
				bool flag3 = num3 > 0f;
				if (flag3)
				{
					num3 = this.Ease(num3, this._constantEasing);
					this.color = this._constantColor;
					this.color.a = this.color.a * num3;
					this.mode = (this._overlay ? HighlighterMode.Overlay : HighlighterMode.Default);
				}
				else
				{
					bool occluder = this._occluder;
					if (occluder)
					{
						this.mode = HighlighterMode.Occluder;
					}
					else
					{
						this.mode = HighlighterMode.Disabled;
					}
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00007F34 File Offset: 0x00006134
		protected bool TransformFilterInclude(Renderer renderer, List<int> submeshIndices)
		{
			Transform transform = renderer.transform;
			for (int i = 0; i < this._filterList.Count; i++)
			{
				Transform transform2 = this._filterList[i];
				bool flag = !(transform2 == null) && transform.IsChildOf(transform2);
				if (flag)
				{
					submeshIndices.Add(-1);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00007FA0 File Offset: 0x000061A0
		protected bool TransformFilterExclude(Renderer renderer, List<int> submeshIndices)
		{
			Transform transform = renderer.transform;
			for (int i = 0; i < this._filterList.Count; i++)
			{
				Transform transform2 = this._filterList[i];
				bool flag = !(transform2 == null) && transform.IsChildOf(transform2);
				if (flag)
				{
					return false;
				}
			}
			submeshIndices.Add(-1);
			return true;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000800C File Offset: 0x0000620C
		protected float Loop(float x, LoopMode loop, bool reverse = false, int repeatCount = -1)
		{
			float num = -1f;
			switch (loop)
			{
			case LoopMode.Loop:
			{
				int num2 = Mathf.FloorToInt(x);
				bool flag = repeatCount < 0 || num2 < repeatCount;
				if (flag)
				{
					num = x - (float)num2;
				}
				break;
			}
			case LoopMode.PingPong:
			{
				int num3 = Mathf.FloorToInt(x * 0.5f);
				bool flag2 = repeatCount < 0 || num3 < repeatCount;
				if (flag2)
				{
					num = 1f - Mathf.Abs(x - (float)num3 * 2f - 1f);
				}
				break;
			}
			case LoopMode.ClampForever:
				num = Mathf.Clamp01(x);
				break;
			default:
			{
				bool flag3 = x >= 0f && x <= 1f;
				if (flag3)
				{
					num = x;
				}
				break;
			}
			}
			bool flag4 = num >= 0f && reverse;
			if (flag4)
			{
				num = 1f - num;
			}
			return num;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000080F4 File Offset: 0x000062F4
		protected float Ease(float x, Easing easing)
		{
			x = Mathf.Clamp01(x);
			float result;
			switch (easing)
			{
			case Easing.QuadIn:
				result = x * x;
				break;
			case Easing.QuadOut:
				result = -x * (x - 2f);
				break;
			case Easing.QuadInOut:
				result = ((x < 0.5f) ? (2f * x * x) : (2f * x * (2f - x) - 1f));
				break;
			case Easing.CubicIn:
				result = x * x * x;
				break;
			case Easing.CubicOut:
				x -= 1f;
				result = x * x * x + 1f;
				break;
			case Easing.CubicInOut:
			{
				bool flag = x < 0.5f;
				if (flag)
				{
					result = 4f * x * x * x;
				}
				else
				{
					x = 2f * x - 2f;
					result = 0.5f * (x * x * x + 2f);
				}
				break;
			}
			case Easing.SineIn:
				result = 1f - Mathf.Cos(x * 1.5707964f);
				break;
			case Easing.SineOut:
				result = Mathf.Sin(x * 1.5707964f);
				break;
			case Easing.SineInOut:
				result = -0.5f * (Mathf.Cos(x * 3.1415927f) - 1f);
				break;
			default:
				result = x;
				break;
			}
			return result;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00008238 File Offset: 0x00006438
		protected float GetTweenTime()
		{
			bool flag = !this._tweenUseUnscaledTime;
			float result;
			if (flag)
			{
				result = Time.time;
			}
			else
			{
				result = Time.unscaledTime;
			}
			return result;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00008268 File Offset: 0x00006468
		protected float GetConstantTime()
		{
			bool flag = !this._constantUseUnscaledTime;
			float result;
			if (flag)
			{
				result = Time.time;
			}
			else
			{
				result = Time.unscaledTime;
			}
			return result;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00008298 File Offset: 0x00006498
		public static Color HSVToRGB(float hue, float saturation, float value)
		{
			float num = 6f * Mathf.Clamp01(hue);
			saturation = Mathf.Clamp01(saturation);
			value = Mathf.Clamp01(value);
			return new Color(value * (1f + (Mathf.Clamp01(Mathf.Max(2f - num, num - 4f)) - 1f) * saturation), value * (1f + (Mathf.Clamp01(Mathf.Min(num, 4f - num)) - 1f) * saturation), value * (1f + (Mathf.Clamp01(Mathf.Min(num - 2f, 6f - num)) - 1f) * saturation));
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000833E File Offset: 0x0000653E
		[Obsolete]
		public void On()
		{
			this.hover = true;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00008349 File Offset: 0x00006549
		[Obsolete]
		public void On(Color color)
		{
			this.Hover(color);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00008354 File Offset: 0x00006554
		[Obsolete]
		public void OnParams(Color color)
		{
			this._hoverColor = color;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00007818 File Offset: 0x00005A18
		[Obsolete]
		public void ConstantParams(Color color)
		{
			this._constantColor = color;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00008360 File Offset: 0x00006560
		[Obsolete]
		public void FlashingParams(Color color1, Color color2, float freq)
		{
			this.flashingColorKeys[0].color = color1;
			this.flashingColorKeys[1].color = color2;
			this._tweenGradient.SetKeys(this.flashingColorKeys, this.flashingAlphaKeys);
			this._tweenDuration = 1f / freq;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00007C58 File Offset: 0x00005E58
		[Obsolete]
		public void FlashingOn()
		{
			this.TweenSet(true);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000083B8 File Offset: 0x000065B8
		[Obsolete]
		public void FlashingOn(Color color1, Color color2)
		{
			this.flashingColorKeys[0].color = color1;
			this.flashingColorKeys[1].color = color2;
			this._tweenGradient.SetKeys(this.flashingColorKeys, this.flashingAlphaKeys);
			this.TweenSet(true);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000840C File Offset: 0x0000660C
		[Obsolete]
		public void FlashingOn(Color color1, Color color2, float freq)
		{
			this.flashingColorKeys[0].color = color1;
			this.flashingColorKeys[1].color = color2;
			this._tweenGradient.SetKeys(this.flashingColorKeys, this.flashingAlphaKeys);
			this._tweenDuration = 1f / freq;
			this.TweenSet(true);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000846B File Offset: 0x0000666B
		[Obsolete]
		public void FlashingOn(float freq)
		{
			this._tweenDuration = 1f / freq;
			this.TweenSet(true);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00007C63 File Offset: 0x00005E63
		[Obsolete]
		public void FlashingOff()
		{
			this.TweenSet(false);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00008483 File Offset: 0x00006683
		[Obsolete]
		public void FlashingSwitch()
		{
			this.tween = !this.tween;
		}

		// Token: 0x04000058 RID: 88
		protected const float HALFPI = 1.5707964f;

		// Token: 0x04000059 RID: 89
		[SerializeField]
		protected bool _overlay;

		// Token: 0x0400005A RID: 90
		[SerializeField]
		protected bool _occluder;

		// Token: 0x0400005B RID: 91
		protected Color _hoverColor = Color.red;

		// Token: 0x0400005C RID: 92
		protected int _hoverFrame = -1;

		// Token: 0x0400005D RID: 93
		[SerializeField]
		protected bool _tween;

		// Token: 0x0400005E RID: 94
		[SerializeField]
		protected Gradient _tweenGradient = new Gradient
		{
			colorKeys = new GradientColorKey[]
			{
				new GradientColorKey(new Color(0f, 1f, 1f, 1f), 0f),
				new GradientColorKey(new Color(0f, 1f, 1f, 1f), 1f)
			},
			alphaKeys = new GradientAlphaKey[]
			{
				new GradientAlphaKey(0f, 0f),
				new GradientAlphaKey(1f, 1f)
			}
		};

		// Token: 0x0400005F RID: 95
		[SerializeField]
		protected float _tweenDuration = 1f;

		// Token: 0x04000060 RID: 96
		[SerializeField]
		protected bool _tweenReverse;

		// Token: 0x04000061 RID: 97
		[SerializeField]
		protected LoopMode _tweenLoop = LoopMode.PingPong;

		// Token: 0x04000062 RID: 98
		[SerializeField]
		protected Easing _tweenEasing;

		// Token: 0x04000063 RID: 99
		[SerializeField]
		protected float _tweenDelay;

		// Token: 0x04000064 RID: 100
		[SerializeField]
		protected int _tweenRepeatCount = -1;

		// Token: 0x04000065 RID: 101
		[SerializeField]
		protected bool _tweenUseUnscaledTime;

		// Token: 0x04000066 RID: 102
		[SerializeField]
		protected bool _constant;

		// Token: 0x04000067 RID: 103
		[SerializeField]
		protected Color _constantColor = Color.yellow;

		// Token: 0x04000068 RID: 104
		[SerializeField]
		protected float _constantFadeInTime = 0.1f;

		// Token: 0x04000069 RID: 105
		[SerializeField]
		protected float _constantFadeOutTime = 0.25f;

		// Token: 0x0400006A RID: 106
		[SerializeField]
		protected Easing _constantEasing;

		// Token: 0x0400006B RID: 107
		[SerializeField]
		protected bool _constantUseUnscaledTime;

		// Token: 0x0400006C RID: 108
		[SerializeField]
		protected RendererFilterMode _filterMode;

		// Token: 0x0400006D RID: 109
		[SerializeField]
		protected List<Transform> _filterList = new List<Transform>();

		// Token: 0x0400006E RID: 110
		protected bool _tweenEnabled;

		// Token: 0x0400006F RID: 111
		protected float _tweenStart;

		// Token: 0x04000070 RID: 112
		protected bool _constantEnabled;

		// Token: 0x04000071 RID: 113
		protected float _constantStart;

		// Token: 0x04000072 RID: 114
		protected float _constantDuration;

		// Token: 0x04000073 RID: 115
		private GradientColorKey[] flashingColorKeys = new GradientColorKey[]
		{
			new GradientColorKey(new Color(0f, 1f, 1f, 0f), 0f),
			new GradientColorKey(new Color(0f, 1f, 1f, 1f), 1f)
		};

		// Token: 0x04000074 RID: 116
		private GradientAlphaKey[] flashingAlphaKeys = new GradientAlphaKey[]
		{
			new GradientAlphaKey(1f, 0f),
			new GradientAlphaKey(1f, 1f)
		};
	}
}
