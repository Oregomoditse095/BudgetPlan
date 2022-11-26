using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlan
{
    class Expenditures : Income
    {
        //declarations
        private int groceries, waterLights, travelCosts, phone, other;

        //constructor method
        public Expenditures()
        {
            groceries = 0;
            waterLights = 0;
            travelCosts = 0;
            phone = 0;
            other = 0;
        }

        //accessor and mutator method for groceries
        public void setGroceries()
        {
            Console.Write("Enter an estimate amount for your monthly groceries: ");
            groceries = int.Parse(Console.ReadLine());
        }

        public int getGroceries()
        {
            return groceries;
        }

        //accessor and mutator methods for water and lights
        public void setWaterLghts()
        {
            Console.Write("Enter an estimate bill amount for you water and lights: ");
            waterLights = int.Parse(Console.ReadLine());
        }

        public int getWaterLights()
        {
            return waterLights;
        }

        //accessor and mutator methods for traveling costs
        public void setTravelCosts()
        {
            Console.Write("Enter an estimate amount for your traveling costs (including petrol): ");
            travelCosts = int.Parse(Console.ReadLine());
        }

        public int getTravelCosts()
        {
            return travelCosts;
        }

        //accessor and mutator methods for phone bills
        public void setPhone()
        {
            Console.Write("Enter an estimate amount for your phone bill: ");
            phone = int.Parse(Console.ReadLine());
        }
        public int getPhone()
        {
            return phone;
        }

        //accesor and mutator methods for other expenses
        public void setOther()
        {
            Console.Write("Enter an estimate amount for ALL your other expenses: ");
            other = int.Parse(Console.ReadLine());
        }

        public int getOther()
        {
            return other;
        }
    }
}
//Troelsen, A. Japikse, P. (2017). Pro C# 7 With .NET and .NET Core. Eighth Edition. APRESS: USA.