using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlan
{
    abstract class VehicleExpense
    {
        //added abstract methods to task 1
        public abstract void setModel();

        public abstract string getModel();

        public abstract void setMake();

        public abstract string getMake();

        public abstract void setPrice();

        public abstract int getPrice();

        public abstract void setDeposit();

        public abstract int getDeposit();

        public abstract void setRate();

        public abstract double getRate();

        public abstract void setInsurancePremium();

        public abstract int getInsurancePremium();
    }
}
//Troelsen, A. Japikse, P. (2017). Pro C# 7 With .NET and .NET Core. Eighth Edition. APRESS: USA.