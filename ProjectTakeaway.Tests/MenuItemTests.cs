using Xunit;
using ProjectTakeaway.Web.Data.Entities;

namespace ProjectTakeaway.Tests
{
    /// <summary>
    /// Unit tests for the MenuItem entity.
    /// </summary>
    public class MenuItemTests
    {
        /// <summary>
        /// Tests that a MenuItem can be created and saved to the database.
        /// </summary>
        public void Can_Create_MenuItem()
        {
            var context = TestDbContextFactory.Create();

            var item = new MenuItem
            {
                Name = "Burger",
                Description = "Beef burger",
                Price = 5.99m
            };

            context.MenuItem.Add(item);
            context.SaveChanges();

            Assert.Single(context.MenuItem);
        }

        /// <summary>
        /// Tests that the MenuItem price is stored correctly.
        /// </summary>
        public void MenuItem_Price_Is_Correct()
        {
            var item = new MenuItem
            {
                Name = "Pizza",
                Price = 9.50m
            };

            Assert.Equal(9.50m, item.Price);
        }

        /// <summary>
        /// Tests that a MenuItem can be linked to a MenuCategory.
        /// </summary>
        public void MenuItem_Assigned_To_Category()
        {
            var context = TestDbContextFactory.Create();

            var category = new MenuCategory { Name = "Fast Food" };
            context.MenuCategory.Add(category);
            context.SaveChanges();

            var item = new MenuItem
            {
                Name = "Burger",
                Price = 6,
                MenuCategoryId = category.Id
            };

            context.MenuItem.Add(item);
            context.SaveChanges();

            var saved = context.MenuItem.First();

            Assert.Equal(category.Id, saved.MenuCategoryId);
        }
    }
}