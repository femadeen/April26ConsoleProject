using System;
namespace April26thProject
{
    public class ShopRite
    {
         public string FirstName {get; set;}
        public string LastName {get; set;}
        public Category Product {get; set;}

        public ShopRite(string firstName, string lastName, Category product)
        {
          FirstName = firstName;
          LastName = lastName; 
          Product = product; 
        }
        public ShopRite()
        {
            
        }
    }
}