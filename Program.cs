using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Описать стуктуру Article, содержащую следующие поля:
 * код товара
 * название товара
 * цена товара
 */
namespace _13_1
{
    struct Article
    {
        public int ProductId;
        public string ProductName;
        public double ProductPrice;
        
        public ArticleType articletype;
    }
    
    struct Client
    {
        public int ClientId;
        public string ClientName;
        public string ClientAddress;
        public string ClientPhone;
        public int ClientOrdersCount;
        public double ClientAllOrdersSum;

        public ClientType clienttype;
    }

    struct Request
    {
        public int RequestID;
        public string Client;
        public DateTime RequestDate;
        public string ItemList;
        public PayType paytype;
        public double RequestSum { get; set; }  //Вычисляемое свойство 
        
    }

    struct RequestItem
    {
       
        public string ItemName;
        public int ItemCount;
        

        
    }

    enum ArticleType
    {
        Electronics, FrozenFood, Food, DomesticChemistry,BuildingMaterials, Petrol
    }

    enum ClientType
    {
        NotImportant, Important, VeryImportant
    }

    enum PayType
    {
        Cash, CreditCard
    }

    class Program
    {
        static void Main(string[] args)
        {
            Article a = new Article();
            a.ProductId = 1;
            a.ProductName = "телевизор";
            a.ProductPrice = 3500;
            a.articletype = ArticleType.Electronics;
            Console.WriteLine($"Код товара - {a.ProductId}\nТип товара - {a.articletype}\nНазвание товара - {a.ProductName}\nЦена продукта - {a.ProductPrice}");

            Console.WriteLine("-------------------------------------");

            Client c = new Client();
            c.ClientId = 1;
            c.ClientName = "Ivanov";
            c.ClientAddress = "Moscow";
            c.ClientPhone = "+74965432345";
            c.clienttype = ClientType.Important;
            c.ClientOrdersCount = 5;

            Console.WriteLine($"Код клиента - {c.ClientId}\nФИО клиента - {c.ClientName}\nАдрес клиента - {c.ClientAddress}\nТелефон клиента - {c.ClientPhone}\nТип клиента - {c.clienttype}");

            Console.WriteLine("-------------------------------------");

            RequestItem ri = new RequestItem();
            ri.ItemCount = 4;
            ri.ItemName = "телевизор";


            Request r = new Request();
            r.RequestSum = a.ProductPrice * ri.ItemCount;
            Console.WriteLine($"Сумма заказа - {r.RequestSum} руб.");

        }
    }
}
