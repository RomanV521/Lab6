using System;

namespace Lab6
{
    internal class Product
    {
        private string _productName;
        private double _cost;
        private double _discount;

        /// <summary>
        /// Название продукта
        /// </summary>
        public string ProductName
        {
            get { return _productName; }
            init
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _productName = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        /// <summary>
        /// Цена продукта
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            init
            {
                if(value > 0) 
                {
                    _cost = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// Скидка, указывается в процентах
        /// </summary>
        public double Discount
        {
            get { return _discount; }
            init
            {
                if (value >= 0 && value < 100)
                {
                    _discount = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// Конструктор с параметрами продукта
        /// </summary>
        /// <param name="productName">Название продукта</param>
        /// <param name="cost">Стоимость продукта</param>
        /// <param name="discount">Скидка</param>
        public Product(string productName, double cost, double discount)
        {
            ProductName = productName;
            Cost = cost;
            Discount = discount;
        }

        /// <summary>
        /// Вывод данных
        /// </summary>
        public override string ToString()
        {
            return $"\tProduct: Name: {ProductName}, Cost: {Cost}, Discount: {Discount}%, Final cost: {Cost - Discount/100}";
        }
    }
}
