using Xunit;
using ProjectTakeaway.Web.Data.Entities;

namespace ProjectTakeaway.Tests
{
    /// <summary>
    /// Unit tests for the MenuCategory entity.
    /// </summary>
    public class MenuCategoryTests
    {
        /// <summary>
        /// Tests that a MenuCategory can be created and saved to the database.
        /// </summary>
        [Fact]
        public void Can_Create_Category()
        {
            var context = TestDbContextFactory.Create();

            var category = new MenuCategory
            {
                Name = "Pizza",
                Description = "All pizza items"
            };

            context.MenuCategory.Add(category);
            context.SaveChanges();

            Assert.Single(context.MenuCategory);
        }

        /// <summary>
        /// Tests that a MenuCategory can be deleted from the database.
        /// </summary>
        [Fact]
        public void Can_Delete_Category()
        {
            var context = TestDbContextFactory.Create();

            var category = new MenuCategory { Name = "Drinks" };

            context.MenuCategory.Add(category);
            context.SaveChanges();

            context.MenuCategory.Remove(category);
            context.SaveChanges();

            Assert.Empty(context.MenuCategory);
        }

        /// <summary>
        /// Tests that the category name is stored correctly.
        /// </summary>
        [Fact]
        public void Category_Name_Is_Stored_Correctly()
        {
            var context = TestDbContextFactory.Create();

            var category = new MenuCategory { Name = "Desserts" };

            context.MenuCategory.Add(category);
            context.SaveChanges();

            var saved = context.MenuCategory.First();

            Assert.Equal("Desserts", saved.Name);
        }
    }
}