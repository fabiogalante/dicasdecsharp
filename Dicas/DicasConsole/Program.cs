using System;

namespace DicasCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IfTernario();
            DefaultValueForNull();
            VerificarNullSemIf();
            NeatString();
        }

        private static void NeatString()
        {
            int n1 = 20;
            int n2 = 30;
            
            string msg = String.Format("Number1: {0}, Number2: {1}", n1, n2);
            Console.WriteLine(msg); // prints "Number1: 20, Number2: 30"
            
            string msg2 = $"Number1: {n1}, Number2: {n2}";
            Console.WriteLine(msg2); // prints "Number1: 20, Number2: 30"
        }

        private static void VerificarNullSemIf()
        {
            Restaurant restaurant = new Restaurant();
            
            
            int numCustomers = 0;
            if(restaurant.Customers != null){
                numCustomers = restaurant.Customers.Length;
            }
            Console.WriteLine(numCustomers); // prints 0
            
            
            int? numCustomers2 = restaurant.Customers?.Length;
            
            int numCustomers3 = restaurant.Customers?.Length ?? 0;
            
            
        }

        private static void DefaultValueForNull()
        {
            string name = null;
  
            string message = name ?? "Name is a null...";
            
            Console.WriteLine(message); // prints "Name is a null..."
            
            //possible_null ?? default_value
            //
        }

        private static void IfTernario()
        {
            int age = 10;
            string message = string.Empty;
            
            if (age > 18)
            {
                message = "You are an adult.";
            }
            else
            {
                message = "You are not an adult.";
            }

            Console.WriteLine(message); // "You are not an adult."
            
            //Substituir 
            
            message = age > 18 ? "You are an adult." : "You are not an adult.";
            Console.WriteLine(message); // "You are not an adult."
            
            //condition ? true_expression : false_expression;
        }
    }
    
    public class Restaurant {
        public string Name = "Badstaurant";
        public string[] Customers = null;
    }
}