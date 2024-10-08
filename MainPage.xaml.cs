using System.Collections.ObjectModel;
using Homework_4._4.Models;

namespace Homework_4._4
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Product> products;

        public MainPage()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>
            {
                new Food { 
                    Name = "Апельсини", 
                    Price = 150,
                    OriginCountry = "Іспанія", 
                    PackagingDate = DateTime.Now, 
                    Description = "Свіжі апельсини", 
                    ExpirationDate = DateTime.Now.AddMonths(1), 
                    Quantity = 10, 
                    UnitOfMeasure = "кг" 
                },
               new Book
                {
                    Name = "Кайдашева сім'я",
                    Price = 200,
                    OriginCountry = "Україна",
                    PackagingDate = DateTime.Now,
                    Description = "Класичний український роман",
                    NumberOfPages = 300,
                    Publisher = "Веселка",
                    Authors = new List<string> { "Іван Нечуй-Левицький" }
                }
            };
            ProductCollectionView.ItemsSource = products;
        }
        private async void AddProduct(object sender, EventArgs e)
        {
            var newProduct = new Food
            {
                Name = "Новий продукт",
                Price = 100,
                OriginCountry = "Невідомо",
                PackagingDate = DateTime.Now,
                Description = "Новий продукт",
                ExpirationDate = DateTime.Now.AddMonths(2),
                Quantity = 1,
                UnitOfMeasure = "шт"
            };
            products.Add(newProduct);
        }

        private void DeleteProduct(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                products.RemoveAt(products.Count - 1);
            }
            else
            {
                DisplayAlert("Помилка", "Список продуктів порожній", "OK");
            }
        }
    }
}