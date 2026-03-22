namespace ProjectTakeaway.Web.Data.Entities
{
    /// <summary>
    /// Represents a single item that can be ordered from a menu category.
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// Gets or sets the unique identifier of the menu item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the menu item.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description of the menu item.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the image URL representing the menu item.
        /// </summary>
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the price of the menu item.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the category this item belongs to.
        /// </summary>
        public int MenuCategoryId { get; set; }

        /// <summary>
        /// Navigation property to the category that this menu item belongs to.
        /// </summary>
        public MenuCategory? MenuCategory { get; set; }
    }
}