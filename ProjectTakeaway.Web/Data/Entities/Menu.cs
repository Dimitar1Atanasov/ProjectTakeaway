namespace ProjectTakeaway.Web.Data.Entities
{
    /// <summary>
    /// Represents a menu that groups multiple menu categories.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Gets or sets the unique identifier of the menu.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the menu.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the menu.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the image URL representing the menu.
        /// </summary>
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the collection of categories that belong to this menu.
        /// </summary>
        public ICollection<MenuCategory>? MenuCategories = new List<MenuCategory>();
    }
}