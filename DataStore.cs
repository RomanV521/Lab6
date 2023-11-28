using System;

namespace Lab6
{
    class DataStore
    {
        Random random = new Random();

        private string[] productName = { "Хлеб", "Морковь", "Молоко", "Яйца", "Яблоки", "Рис", "Гречка", "Творог", "Масло", "Курица", "Лук", "Помидоры", "Огурцы", "Бананы", "Сахар", "Соль", "Перец", "Сыр", "Картошка", "Паста" };
        private const int minCost = 10;
        private const int maxCost = 20;
        private const int minDiscount = 10;
        private const int maxDiscount = 99;

        /// <summary>
        /// Создание новой случайной записи класса Product
        /// </summary>
        /// <returns>Новый объект класса Product</returns>
        public Product CreateProductRecord()
        {
            return new Product(productName[random.Next(0, productName.Length)], random.Next(minCost, maxCost), random.Next(minDiscount, maxDiscount));
        }
    }
}
