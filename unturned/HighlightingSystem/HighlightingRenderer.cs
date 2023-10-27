using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace HighlightingSystem
{
	// Token: 0x0200001E RID: 30
	[AddComponentMenu("Highlighting System/Highlighting Renderer", 2)]
	public class HighlightingRenderer : HighlightingBase
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000A464 File Offset: 0x00008664
		public ReadOnlyCollection<HighlightingPreset> presets
		{
			get
			{
				bool flag = this._presetsReadonly == null;
				if (flag)
				{
					this._presetsReadonly = this._presets.AsReadOnly();
				}
				return this._presetsReadonly;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000A49C File Offset: 0x0000869C
		public bool GetPreset(string name, out HighlightingPreset preset)
		{
			for (int i = 0; i < this._presets.Count; i++)
			{
				HighlightingPreset highlightingPreset = this._presets[i];
				bool flag = highlightingPreset.name == name;
				if (flag)
				{
					preset = highlightingPreset;
					return true;
				}
			}
			preset = default(HighlightingPreset);
			return false;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000A500 File Offset: 0x00008700
		public bool AddPreset(HighlightingPreset preset, bool overwrite)
		{
			for (int i = 0; i < this._presets.Count; i++)
			{
				bool flag = this._presets[i].name == preset.name;
				if (flag)
				{
					bool result;
					if (overwrite)
					{
						this._presets[i] = preset;
						result = true;
					}
					else
					{
						result = false;
					}
					return result;
				}
			}
			this._presets.Add(preset);
			return true;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000A588 File Offset: 0x00008788
		public bool RemovePreset(string name)
		{
			for (int i = 0; i < this._presets.Count; i++)
			{
				bool flag = this._presets[i].name == name;
				if (flag)
				{
					this._presets.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000A5EC File Offset: 0x000087EC
		public bool LoadPreset(string name)
		{
			HighlightingPreset preset2;
			bool preset = this.GetPreset(name, out preset2);
			if (preset)
			{
				this.ApplyPreset(preset2);
			}
			return false;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000A618 File Offset: 0x00008818
		public void ApplyPreset(HighlightingPreset preset)
		{
			base.downsampleFactor = preset.downsampleFactor;
			base.iterations = preset.iterations;
			base.blurMinSpread = preset.blurMinSpread;
			base.blurSpread = preset.blurSpread;
			base.blurIntensity = preset.blurIntensity;
			base.blurDirections = preset.blurDirections;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000A67A File Offset: 0x0000887A
		public void ClearPresets()
		{
			this._presets.Clear();
		}

		// Token: 0x040000C9 RID: 201
		public static readonly List<HighlightingPreset> defaultPresets = new List<HighlightingPreset>
		{
			new HighlightingPreset
			{
				name = "Default",
				fillAlpha = 0f,
				downsampleFactor = 4,
				iterations = 2,
				blurMinSpread = 0.65f,
				blurSpread = 0.25f,
				blurIntensity = 0.3f,
				blurDirections = BlurDirections.Diagonal
			},
			new HighlightingPreset
			{
				name = "Wide",
				fillAlpha = 0f,
				downsampleFactor = 4,
				iterations = 4,
				blurMinSpread = 0.65f,
				blurSpread = 0.25f,
				blurIntensity = 0.3f,
				blurDirections = BlurDirections.Diagonal
			},
			new HighlightingPreset
			{
				name = "Strong",
				fillAlpha = 0f,
				downsampleFactor = 4,
				iterations = 2,
				blurMinSpread = 0.5f,
				blurSpread = 0.15f,
				blurIntensity = 0.325f,
				blurDirections = BlurDirections.Diagonal
			},
			new HighlightingPreset
			{
				name = "Speed",
				fillAlpha = 0f,
				downsampleFactor = 4,
				iterations = 1,
				blurMinSpread = 0.75f,
				blurSpread = 0f,
				blurIntensity = 0.35f,
				blurDirections = BlurDirections.Diagonal
			},
			new HighlightingPreset
			{
				name = "Quality",
				fillAlpha = 0f,
				downsampleFactor = 2,
				iterations = 3,
				blurMinSpread = 0.5f,
				blurSpread = 0.5f,
				blurIntensity = 0.28f,
				blurDirections = BlurDirections.Diagonal
			},
			new HighlightingPreset
			{
				name = "Solid 1px",
				fillAlpha = 0f,
				downsampleFactor = 1,
				iterations = 1,
				blurMinSpread = 1f,
				blurSpread = 0f,
				blurIntensity = 1f,
				blurDirections = BlurDirections.All
			},
			new HighlightingPreset
			{
				name = "Solid 2px",
				fillAlpha = 0f,
				downsampleFactor = 1,
				iterations = 2,
				blurMinSpread = 1f,
				blurSpread = 0f,
				blurIntensity = 1f,
				blurDirections = BlurDirections.All
			}
		};

		// Token: 0x040000CA RID: 202
		[SerializeField]
		private List<HighlightingPreset> _presets = new List<HighlightingPreset>(HighlightingRenderer.defaultPresets);

		// Token: 0x040000CB RID: 203
		private ReadOnlyCollection<HighlightingPreset> _presetsReadonly;
	}
}
