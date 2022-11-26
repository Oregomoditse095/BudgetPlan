using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlan
{   //inherits from abstract class, VehicleExpense
    //a class that consists of override methods
    class VehiclePurchase : VehicleExpense

    {   //private declarations
        private string model, make;
        private int price, deposit, insurance, totalCost;
        private double rate;

        //default constructor
        public VehiclePurchase()
        {
            make = "";
            model = "";
            price = 0;
            deposit = 0;
            rate = 0.0;
            insurance = 0;
            totalCost = 0;
        }

        public override void setMake()
        {
            Console.Write("Which car make do you wish to purchase? ");
            make = Console.ReadLine();
        }

        public override string getMake()
        {
            return make;
        }

        public override void setModel()
        {
            Console.Write("What model is it? ");
            model = Console.ReadLine();
        }

        public override string getModel()
        {
            return model;
        }

        public override void setPrice()
        {
            Console.Write("What is the price for your dream vehicle? ");
            price = int.Parse(Console.ReadLine());
        }

        public override int getPrice()
        {
            return price;
        }

        public override void setDeposit()
        {
            Console.Write("What is the deposit amount? ");
            deposit = int.Parse(Console.ReadLine());
        }

        public override int getDeposit()
        {
            return deposit;
        }

        public override void setRate()
        {
            Console.Write("What is the interest rate (Example: 2,8; 5,0; 3,4; etc)? ");
            rate = double.Parse(Console.ReadLine());
        }

        public override double getRate()
        {
            return rate;
        }

        public override void setInsurancePremium()
        {
            Console.Write("What is an estimate amount of the insurance premium? ");
            insurance = int.Parse(Console.ReadLine());
        }

        public override int getInsurancePremium()
        {
            return insurance;
        }

       

        
       
    }
}
//Troelsen, A. Japikse, P. (2017). Pro C# 7 With .NET and .NET Core. Eighth Edition. APRESS: USA.