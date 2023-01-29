using System;
using System.Collections.Generic;

namespace April26thProject
{
    public class Manager : ShopRite
    { 
        static List<string> SaleManagerList = new List<string>(); 
       Manager saleManager;
       public Manager(string firstName, string lastName, Category product): base(firstName, lastName, product)
       {

       }
       public Manager()
       {

       }
    
       public void AddSalesManager()
       {
           Console.WriteLine("Enter Sale's manager first name");
           var saleManagerFirstName = Console.ReadLine();
           Console.WriteLine("Enter sale's manager last name");
           var saleMangerLastName = Console.ReadLine();
           saleManager.FirstName = saleManagerFirstName;
           saleManager.LastName = saleMangerLastName;
           SaleManagerList.Add(saleManager.FirstName);
           SaleManagerList.Add(saleManager.LastName);
       }
       public string FindSaleManagerWithLastname(string lastName)
       {
           string findSaleManager = " ";
           try
           {
               if(lastName == saleManager.LastName)
               {
                   findSaleManager = lastName;
               }
               else
               {
                   Console.WriteLine("no such Sale's Manager exist");
               }
           } 
           catch(Exception ex)
           {
               Console.WriteLine(ex.Message);
           }
           return $"{saleManager.FirstName} {findSaleManager}";
       }
       public void DeleteSaleManager()
       {
           Console.WriteLine("please enter the sale manager last name you would like to delete");
           string result = Console.ReadLine();
           var saleManagerLastName = FindSaleManagerWithLastname(result);
           if(saleManagerLastName != null)
           {
               SaleManagerList.Remove(saleManagerLastName);
               SaleManagerList.Remove(saleManager.FirstName);
               Console.WriteLine("the sale's man successfully deleted");
           }
           else
           {
               Console.WriteLine("no such sale's manager last name exist");
           }

       }
    }
}