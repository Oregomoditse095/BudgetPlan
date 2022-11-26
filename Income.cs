using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlan
{
    class Income
    {
        //declarations
        protected int income, monthlyTax;

        //constructor method
        public Income()
        {
            income = 0;
            monthlyTax = 0;
        }

        //accessor and mutator methods for gross income
        public void setIncome()
        {
            Console.Write("Enter your gross monthly income: ");
            income = int.Parse(Console.ReadLine());
        }

        public int getIncome()
        {
            return income;
        }

        //accessor and mutator methods for monthly tax deductions
        public void setMonthlyTax()
        {
            Console.Write("Enter your monthly tax deduction: ");
            monthlyTax = int.Parse(Console.ReadLine());
        }

        public int getMonthlyTax()
        {
            return monthlyTax;
        }
    }
}
//Troelsen, A. Japikse, P. (2017). Pro C# 7 With .NET and .NET Core. Eighth Edition. APRESS: USA.