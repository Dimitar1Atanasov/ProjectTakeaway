namespace ProjectTakeaway.Web.Data.Entities
{
    /// <summary>
    /// Represents a category within a menu that groups related menu items.
    /// </summary>
    public class MenuCategory
    {
        /// <summary>
        /// Gets or sets the unique identifier of the menu category.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the menu category.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the menu category.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the collection of menu items that belong to this category.
        /// </summary>
        public ICollection<MenuItem>? MenuItems = new List<MenuItem>();
    }
}