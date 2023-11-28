namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Хлеб", 30.1, 5);
            Product product2 = new Product("Яблоки", 15, 0);
            Product product3 = new Product("Масло", 20.15, 15);

            ShoppingList shoppingList = new ShoppingList(product1);

            //Добавление в лист
            shoppingList.AddProduct(product2);
            shoppingList.AddProduct(product3);
            Console.WriteLine(shoppingList);

            //Удаление элемента из листа при помощи двух способов
            shoppingList.RemoveProduct(product1);
            Console.WriteLine(shoppingList);
            shoppingList.RemoveProduct(1);
            Console.WriteLine(shoppingList);

            //Создание случайных продуктов и добавление их в лист
            DataStore ds = new DataStore();
            shoppingList.AddProduct(ds.CreateProductRecord());
            shoppingList.AddProduct(ds.CreateProductRecord());
            Console.WriteLine(shoppingList);
        }
    }
}