using CollectionViewDemo.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollectionViewDemo.MVVM.ViewModels
{
     [AddINotifyPropertyChangedInterface]
     public class DataViewModel
     {
          private Product selectedProduct;          

          public ObservableCollection<Product> Products { get; set; } =
                         new ObservableCollection<Product>();
          public bool IsRefreshing { get; set; }

          public Product SelectedProduct
          {
               get => selectedProduct;
               set
               {
                    selectedProduct = value;
               }
          }

          public List<object> SelectedProducts { get; set; } =
               new List<object>();

          public ICommand RefreshCommand =>
               new Command(async () =>
               {
                    IsRefreshing = true;
                    await Task.Delay(3000);
                    RefreshItems();
                    IsRefreshing = false;
               });

          public ICommand ThresholdReachedCommand =>
               new Command(async () =>
               {
                    RefreshItems(Products.Count);
               });

          public ICommand ProductChangedCommand =>
               new Command(() =>
               {
                    var selectedProduct =
                         SelectedProduct;
               });

          public ICommand ProductsChangedCommand =>
               new Command(() =>
               {
                    var productsList =
                         SelectedProducts;
               });

          public ICommand ClearCommand =>
               new Command(() =>
               {
                    SelectedProducts = null;
               });


          public DataViewModel()
          {
               RefreshItems();
               SelectedProducts.Add(Products.Skip(5).FirstOrDefault());
               SelectedProducts.Add(Products.Skip(7).FirstOrDefault());

               SelectedProduct = Products.Skip(2).FirstOrDefault();

          }
          private void RefreshItems(int lastIndex = 0)
          {
               int numberOfItemsPerPage = 10;

               var items = new ObservableCollection<Product>
               {
                    new Product
                     {
                         Name = "Yogurt",
                         Price = 60.0m,
                         Image = "yogurt.png",
                         HasOffer = false,
                         Stock = 28
                     },
                     new Product
                     {
                         Name = "Watermelon",
                         Price = 30.0m,
                         Image = "watermelon.png",
                         HasOffer = false,
                         Stock = 87
                     },
                     new Product
                     {
                         Name = "Water Bottle",
                         Price = 80.0m,
                         Image = "water_bottle.png",
                         HasOffer = true,
                         OfferPrice = 69.99m,
                         Stock = 33
                     },
                     new Product
                     {
                         Name = "Tomato",
                         Price = 120.0m,
                         Image = "tomato.png",
                         HasOffer = false,
                         Stock = 0
                     },
                     new Product
                     {
                         Name = "Tea",
                         Price = 65.0m,
                         Image = "tea_bag.png",
                         HasOffer = false,
                         Stock = 82
                     },
                     new Product
                     {
                         Name = "Sparkling Drink",
                         Price = 35.0m,
                         Image = "sparkling_drink.png",
                         HasOffer = false,
                         Stock = 728
                     },
                     new Product
                     {
                         Name = "Spaguetti",
                         Price = 15.0m,
                         Image = "spaguetti.png",
                         HasOffer = false,
                         Stock = 0
                     },
                     new Product
                     {
                         Name = "Cream",
                         Price = 48.0m,
                         Image = "cream.png",
                         HasOffer = false,
                         Stock = 22
                     },
                     new Product
                     {
                         Name = "Snack",
                         Price = 25.0m,
                         Image = "009_snack.png",
                         HasOffer = false,
                         Stock = 2
                     },
                     new Product
                     {
                         Name = "Shrimp",
                         Price = 300.0m,
                         Image = "shrimp.png",
                         HasOffer = true,
                         OfferPrice = 250.0m,
                         Stock = 58
                     },
                     new Product
                     {
                         Name = "Seasoning",
                         Price = 185.0m,
                         Image = "seasoning.png",
                         HasOffer = false,
                         Stock = 99
                     },
                     new Product
                     {
                         Name = "Sauce",
                         Price = 220.0m,
                         Image = "sauce.png",
                         HasOffer = false,
                         Stock = 72
                     },
                     new Product
                     {
                         Name = "Rice",
                         Price = 48.0m,
                         Image = "rice.png",
                         HasOffer = false,
                         Stock = 143
                     },
                     new Product
                     {
                         Name = "Peas",
                         Price = 114.0m,
                         Image = "peas.png",
                         HasOffer = false,
                         Stock = 0
                     },
                     new Product
                     {
                         Name = "Ham",
                         Price = 215.0m,
                         Image = "ham_1.png",
                         HasOffer = true,
                         OfferPrice = 189.0m,
                         Stock = 732
                     },
                     new Product
                     {
                         Name = "Chicken Leg",
                         Price = 142.0m,
                         Image = "chicken_leg.png",
                         HasOffer = true,
                         OfferPrice = 125.0m,
                         Stock = 20
                     },
                     new Product
                     {
                         Name = "Pizza",
                         Price = 321.0m,
                         Image = "pizza.png",
                         HasOffer = false,
                         Stock = 559
                     },
                     new Product
                     {
                         Name = "Pineapple",
                         Price = 49.0m,
                         Image = "pineapple.png",
                         HasOffer = false,
                         Stock = 41
                     },
                     new Product
                     {
                         Name = "Pepper",
                         Price = 60.0m,
                         Image = "pepper.png",
                         HasOffer = true,
                         OfferPrice = 30.0m,
                         Stock = 64
                     },
                     new Product
                     {
                         Name = "Pasta",
                         Price = 52.0m,
                         Image = "pasta.png",
                         HasOffer = false,
                         Stock = 0
                     },
                     new Product
                     {
                         Name = "Oil Bottle",
                         Price = 152.0m,
                         Image = "oil_bottle",
                         HasOffer = false,
                         Stock = 87
                     },
                     new Product
                     {
                         Name = "Mushroom",
                         Price = 28.0m,
                         Image = "mushroom.png",
                         HasOffer = false,
                         Stock = 17
                     },
                     new Product
                     {
                         Name = "Milk Bottle",
                         Price = 85.0m,
                         Image = "milk_bottle.png",
                         HasOffer = false,
                         Stock = 39
                     },
                     new Product
                     {
                         Name = "Meat",
                         Price = 450.0m,
                         Image = "meat.png",
                         HasOffer = false,
                         Stock = 28
                     },
                     new Product
                     {
                         Name = "Lemon",
                         Price = 20.0m,
                         Image = "lemon.png",
                         HasOffer = false,
                         Stock = 87
                     },
                     new Product
                     {
                         Name = "Tomato Sauce",
                         Price = 15.0m,
                         Image = "tomato_sauce.png",
                         HasOffer = false,
                         Stock = 26
                     },
                     new Product
                     {
                         Name = "Juice",
                         Price = 60.0m,
                         Image = "juice.png",
                         HasOffer = false,
                         Stock = 31
                     },
                     new Product
                     {
                         Name = "Ice Cream",
                         Price = 251.0m,
                         Image = "ice_cream.png",
                         HasOffer = true,
                         OfferPrice = 200.0m,
                         Stock = 88
                     },
                     new Product
                     {
                         Name = "Ham",
                         Price = 290.0m,
                         Image = "ham.png",
                         HasOffer = false,
                         Stock = 0
                     },
                     new Product
                     {
                         Name = "Ice",
                         Price = 125.0m,
                         Image = "ice.png",
                         HasOffer = false,
                         Stock = 22
                     },
                     new Product
                     {
                         Name = "Flour",
                         Price = 86.0m,
                         Image = "flour.png",
                         HasOffer = false,
                         Stock = 28
                     },
                     new Product
                     {
                         Name = "Fish",
                         Price = 440.0m,
                         Image = "fish_1.png",
                         HasOffer = false,
                         Stock = 80
                     },
                     new Product
                     {
                         Name = "Fish 2",
                         Price = 425.0m,
                         Image = "fish.png",
                         HasOffer = false,
                         Stock = 24
                     },
                     new Product
                     {
                         Name = "Eggs",
                         Price = 150.0m,
                         Image = "eggs.png",
                         HasOffer = false,
                         Stock = 47
                     },
                     new Product
                     {
                         Name = "Cucumber",
                         Price = 35.0m,
                         Image = "cucumber.png",
                         HasOffer = false,
                         Stock = 74
                     },
                     new Product
                     {
                         Name = "Croissant",
                         Price = 68.0m,
                         Image = "croissant.png",
                         HasOffer = true,
                         OfferPrice = 50.0m,
                         Stock = 27
                     },
                     new Product
                     {
                         Name = "Cookies",
                         Price = 95.0m,
                         Image = "cookie.png",
                         HasOffer = false,
                         Stock = 56
                     },
                     new Product
                     {
                         Name = "Coffee",
                         Price = 154.0m,
                         Image = "toffee.png",
                         HasOffer = false,
                         Stock = 83
                     },
                     new Product
                     {
                         Name = "Chocolate Bar",
                         Price = 32.0m,
                         Image = "chocolate_bar.png",
                         HasOffer = false,
                         Stock = 21
                     },
                     new Product
                     {
                         Name = "Cheese",
                         Price = 36.0m,
                         Image = "cheese.png",
                         HasOffer = true,
                         OfferPrice = 25.0m,
                         Stock =73
                     },
                     new Product
                     {
                         Name = "Carrot",
                         Price = 15.0m,
                         Image = "carrot.png",
                         HasOffer = false,
                         Stock = 28
                     },
                     new Product
                     {
                         Name = "Canned Food",
                         Price = 89.0m,
                         Image = "canned_food.png",
                         HasOffer = false,
                         Stock = 773
                     },
                     new Product
                     {
                         Name = "Soda",
                         Price = 45.0m,
                         Image = "can.png",
                         HasOffer = false,
                         Stock = 843
                     },
                     new Product
                     {
                         Name = "Candies",
                         Price = 55.0m,
                         Image = "candy.png",
                         HasOffer = false,
                         Stock = 71
                     },
                     new Product
                     {
                         Name = "Cake",
                         Price = 250.0m,
                         Image = "cake.png",
                         HasOffer = true,
                         OfferPrice = 200.0m,
                         Stock = 0
                     },
                     new Product
                     {
                         Name = "Bread",
                         Price = 100.0m,
                         Image = "bread_1.png",
                         HasOffer = false,
                         Stock =134
                     },
                     new Product
                     {
                         Name = "Bread",
                         Price = 85.0m,
                         Image = "bread.png",
                         HasOffer = false,
                         Stock = 8
                     },
                     new Product
                     {
                         Name = "Banana",
                         Price = 15.0m,
                         Image = "banana.png",
                         HasOffer = true,
                         OfferPrice = 10.0m,
                         Stock = 72
                     },
                     new Product
                     {
                         Name = "Apple",
                         Price = 40.0m,
                         Image = "apple.png",
                         HasOffer = false,
                         Stock = 737
                     },
                     new Product
                     {
                         Name = "Alcohol",
                         Price = 370.0m,
                         Image = "alcohol.png",
                         HasOffer = false,
                         Stock = 9
                     },
               };

               var pageItems =
                    items.Skip(lastIndex)
                    .Take(numberOfItemsPerPage);

               foreach (var item in pageItems)
               {
                    Products.Add(item);
               }

          }
     }
}
