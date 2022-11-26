using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlan
{
    abstract class Expense
    {

        //declarations of abstract methods
        public abstract void setRentalAmount();

        public abstract int getRentalAmount();

        public abstract void setPurchasePrice();

        public abstract int getPurchasePrice();

        public abstract void setDeposit();

        public abstract int getDeposit();

        public abstract void setInterestRate();

        public abstract double getInterestRate();

        public abstract void setMonthsToRepay();

        public abstract int getMonthsToRepay();

        
    }
}
//Troelsen, A. Japikse, P. (2017). Pro C# 7 With .NET and .NET Core. Eighth Edition. APRESS: USA.