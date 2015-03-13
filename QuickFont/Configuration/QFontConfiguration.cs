namespace QuickFont
{
	public class QFontConfiguration
	{
		public QFontKerningConfiguration KerningConfig = new QFontKerningConfiguration();
		public QFontShadowConfiguration ShadowConfig = null;
		/// <summary>
		/// Render the font pixel-prefectly at a size in units of the current orthogonal projection, independent of the viewport pixel size.
		/// </summary>
		public bool TransformToCurrentOrthogProjection = false;
	}
}
