using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlan
{
    class HomeLoan : Expense
    {
        //declaration
        private int purchasePrice, deposit, monthsToRepay;
        private int rentAmount;
        private double interestRate;

        //constructor method
        public HomeLoan()
        {
            purchasePrice = 0;
            deposit = 0;
            monthsToRepay = 0;
            interestRate = 0.0;
        }

        //override accessor and mutator methods for rental amount
        public override void setRentalAmount()
        {
            Console.Write("What is the monthly rental amount for the property? ");
            rentAmount = int.Parse(Console.ReadLine());
        }
        public override int getRentalAmount()
        {
            return rentAmount;
        }

        //override accessor and mutator methods for purchase price
        public override void setPurchasePrice() 
        {
            //promts the user for purchase price
            Console.Write("How much is the property that you wish to purchase? ");
            purchasePrice = int.Parse(Console.ReadLine());
        }
        public override int getPurchasePrice()
        {
            return purchasePrice;
        }

        //override accessor and mutator methods for deposit
        public override void setDeposit() 
        {
            //prompts the user for the total deposit
            Console.Write("What is the total deposit for the property you wish to purchase? ");
            deposit = int.Parse(Console.ReadLine());
        }
        public override int getDeposit()
        {
            return deposit;
        }

        //override accessor and mutator methods for interest rate
        public override void setInterestRate()
        { 
            //prompts the user for the interest rate
            Console.Write("What is the interest rate from the property? (Example: 1,0; 2,5; 10,8; etc) ");
            interestRate = double.Parse(Console.ReadLine());
        }
        public override double getInterestRate()
        {
            return interestRate;
        }

        //override accessor and methods for months to pay
        public override void setMonthsToRepay()
        { 
            //prompts the user for the months in which they will repay 
            Console.Write("What is the total MONTHS to repay for your property? (Choose between 240 & 360 months) ");
            monthsToRepay = int.Parse(Console.ReadLine());
        }
        public override int getMonthsToRepay()
        {
            //nested if statements for different monthly repayment outcomes
            if (monthsToRepay < 240)
            { 
                monthsToRepay = 240;
                return monthsToRepay;
            }
            else
                if (monthsToRepay > 360)
            {
                monthsToRepay = 360;
                return monthsToRepay;
            }
            else
            return monthsToRepay;
        }

    }
}
//Troelsen, A. Japikse, P. (2017). Pro C# 7 With .NET and .NET Core. Eighth Edition. APRESS: USA.