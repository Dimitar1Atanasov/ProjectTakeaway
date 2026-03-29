using Xunit;
using ProjectTakeaway.Web.Data.Entities;

namespace ProjectTakeaway.Tests
{
    /// <summary>
    /// Unit tests for the Menu entity.
    /// </summary>
    public class MenuTests
    {
        /// <summary>
        /// Tests that a Menu can be created and saved.
        /// </summary>
        [Fact]
        public void Can_Create_Menu()
        {
            var context = TestDbContextFactory.Create();

            var menu = new Menu
            {
                Name = "Main Menu",
                Description = "All food items"
            };

            context.Menu.Add(menu);
            context.SaveChanges();

            Assert.Single(context.Menu);
        }

        /// <summary>
        /// Tests that the menu name is stored correctly.
        /// </summary>
        [Fact]
        public void Menu_Name_Is_Correct()
        {
            var context = TestDbContextFactory.Create();

            var menu = new Menu { Name = "Lunch Menu" };

            context.Menu.Add(menu);
            context.SaveChanges();

            var saved = context.Menu.First();

            Assert.Equal("Lunch Menu", saved.Name);
        }
    }
}