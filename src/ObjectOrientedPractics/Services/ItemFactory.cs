using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public static class ItemFactory
    {
        /// <summary>
        /// Создает товар.
        /// </summary>
        /// <returns>Возвращает объект Item</returns>
        public static Item Randomize()
        {
            Item item = new Item();
            item.Name = "Name";
            item.Cost = 1000;
            item.Info = "Info";
            item.Category = Category.Other;
            return item;
        }
    }
}
