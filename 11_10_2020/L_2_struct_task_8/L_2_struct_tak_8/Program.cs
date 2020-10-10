using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L_2_struct_task_8
{

    struct Article
    {     
        public int product_code;
        public string product_name;
        public double product_price;
              

        enum ArticleTips
        {
            refrigerator,
            microwave_oven,
            iron,
            toaster,
            washing_machine,
            vacuum_cleaner,
            TV_set
        }      
    }

    struct Client
    {
        private string last_name_first_name_patronymic;
        private int address;
        private int telephone;
        private int col_of_orders;
        private int all_sum_orders;

        enum ClientType
        {
            client_payment_up_to_100,
            client_payment_up_to_200,
            client_payment_up_to_500,
            client_payment_up_to_1000,
            client_VIP_more_1000
        }
    }

    struct RequestItem
    {
        private string product;
        private int quantity_product;       
    }

    struct Request
    {
        private int order_code;
        private string client;
        private int order_date;
        private int list_ordered_products;

        public int order_sum////////
        {
        get
            {
               return this.//cant see enather struct;
            }
        }
    
        enum PayType
        {
            clearing_settlement,
            cash
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Article ar = new Article(20, ";lk", 2.5);

            ar.GetType();
          

             //ar.ArticleTips = new Article();
             //ar = new Article();
             //Console.WriteLine(ar.ArticleTips + " ");

        }
    }
}
