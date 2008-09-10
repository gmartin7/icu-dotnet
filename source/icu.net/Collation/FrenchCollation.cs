namespace Icu.Collation
{

	/// <summary>
	/// Attribute for direction of secondary weights - used in French.
	/// </summary>
	public enum FrenchCollation
	{
		Default = -1,
		/// <summary>
		/// treats secondary weights in the order they appear
		/// </summary>
		Off = 16,
		/// <summary>
		/// secondary weights are considered backwards
		/// </summary>
		On = 17
	}
}