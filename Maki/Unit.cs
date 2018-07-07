namespace Maki
{
    /// <summary>
    /// Represents a unit type.
    /// </summary>
    public sealed class Unit
    {
        /// <summary>
        /// Unique instance.
        /// </summary>
        public static readonly Unit Value = new Unit();

        private Unit()
        { }
    }
}
