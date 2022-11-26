using System;
using System.Collections.Generic;

namespace BudgetPlan
{
    class Program
    {

        //delegate defined

        public delegate string Note();
        static void Main(string[] args)
        {
            //declares variables
            string answer, response;
            int expenses, YEARS = 5, PERCENTAGE = 75;
            double moneyLeft, totalExpenses, sum1, sum2;
            //declarations for property
            double i, n, P, num, A, monthlyHomeLoan, m1, m2, amount;
            //declarations for vehicle
            double interest, principle, number, futureVal, installment, totalMonthlyPayment, m3, m4;


            //decalare generic collection list
            List<int> alist = new List<int>();


            //object declarations
            Income income = new Income();
            Expenditures expenditure = new Expenditures();
            HomeLoan property = new HomeLoan();
            VehiclePurchase vehicle = new VehiclePurchase();


            income.setIncome();
            income.setMonthlyTax();
            expenditure.setGroceries();
            expenditure.setWaterLghts();
            expenditure.setTravelCosts();
            expenditure.setPhone();
            expenditure.setOther();
            
            //saving "variables" using generics
            alist.Add(expenditure.getGroceries());
            alist.Add(expenditure.getWaterLights());
            alist.Add(expenditure.getTravelCosts());
            alist.Add(expenditure.getPhone());
            alist.Add(expenditure.getOther());



            //console output
            Console.WriteLine("\nYour monthly gross income is: R" + income.getIncome() + "\n"
                + "With the tax fee of : R" + income.getMonthlyTax() + "\nGrocery expense: R"
                + alist[0] + "\nWater and Lights expense: R" + alist[1] +
                "\nTraveling costs (including petrol): R" + alist[2] + "\nPhone bills: R"
                + alist[3] + "\nOther expenses: R" + alist[4]);

            //promots the user if they would like to rent or buy
            Console.Write("\n" + "\nWould to like to rent or buy a property (Please input 'rent', 'buy', or 'neither')? ");
            answer = Console.ReadLine();

            //if statement of selection between rent and buy
            if (answer == "rent" || answer == "rent property")
            {
                property.setRentalAmount();
                Console.WriteLine("\n" + "\nYour rental monthly amount is R" + property.getRentalAmount());
                Console.WriteLine("\nPress 'Enter' to continue...");
                Console.ReadLine();
            }
            else
                if (answer == "buy" || answer == "buy property")
            {
                property.setPurchasePrice();
                property.setDeposit();
                property.setInterestRate();
                property.setMonthsToRepay();
            }

            //calc a certain percentage of the price input
            num = property.getInterestRate() * property.getPurchasePrice() / 100;
            //calc principle
            P = property.getPurchasePrice() - num;
            //calc interest rate
            i = property.getInterestRate() / 100;
            //calc number of years
            n = property.getMonthsToRepay() / 12;
            //calc "future" value of property
            //using function to get a proper value
            m1 = i * Math.Round(n);
            m2 = 1 + m1;
            A = P * m2;
            //calc monthly installment of property
            monthlyHomeLoan = A / property.getMonthsToRepay();
            //calculating a third of monthly payment
            amount = 1 / 3 * income.getIncome();

            //calculating the money left that the user will have
            expenses = income.getMonthlyTax() + expenditure.getGroceries() + expenditure.getWaterLights() 
                       + expenditure.getTravelCosts() + expenditure.getPhone() + expenditure.getOther();

            if (income.getIncome() < amount)
            {
                double moneyLeft1;
                //calculate money left if not eligable for property
                moneyLeft1 = income.getIncome() - expenses;

                Console.WriteLine("\n" + "\nYou are not eligable for this loan or property.\nTherefore...");
                //Console output for the money left
                Console.WriteLine("\n" + "\nThe money left from your expenses will be: R" + moneyLeft1);
                Console.WriteLine("\nPress 'Enter' to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n" + "\nProperty price: R" + property.getPurchasePrice() +
               "\nDeposit for property: R" + property.getDeposit() + "\nProperty interest rate: "
               + property.getInterestRate() + "%" + "\nMonths to pay for property: " + property.getMonthsToRepay()
               + " months.\nThe monthly payment is: R" + monthlyHomeLoan);
                
                //calculate money left if eligable for property purchase
                moneyLeft = income.getIncome() - expenses - monthlyHomeLoan;

                //Console output for the money left
                Console.WriteLine("\n" + "\nThe money left from your expenses will be: R" + moneyLeft);
                Console.WriteLine("\nPress 'Enter' to continue...");
                Console.ReadLine();

            }



            //addded question that prompts user if they want to purchase a vehicle
            Console.Write("Do you wish to purchase a vehicle? (Please input 'yes' or 'no') ");
            response = Console.ReadLine();

            //'if' statement(s) that relate to the vehicle prompt question
            if (response == "yes")
            {
                vehicle.setMake();
                vehicle.setModel();
                vehicle.setPrice();
                vehicle.setDeposit();
                vehicle.setRate();
                vehicle.setInsurancePremium();
            }
            else
                if (response == "no")
            {
                Console.WriteLine("Smart way to save money. Wink. ");
            }

            //calc a certain percentage of the price input
            number = vehicle.getRate() * vehicle.getPrice() / 100;
            //calc principle
            principle = vehicle.getPrice() - number;
            //calc interest rate
            interest = vehicle.getRate() / 100;
            //calc "future" value of vehicle
            m3 = interest * YEARS;
            m4 = 1 + m3;
            futureVal = m4 * principle;
            //calc monthly installment of vehicle
            installment = futureVal / vehicle.getPrice();
            //calc insurance
            totalMonthlyPayment = installment + vehicle.getInsurancePremium();

            //Console output
            Console.WriteLine("\nMake : " + vehicle.getMake() + "\nModel: " + vehicle.getModel() + "\nPurchase Price: R"
                 + vehicle.getPrice() + "\nDeposit: R" + vehicle.getDeposit() + "\nInterest Rate: " + vehicle.getRate()
                 + "% \nThe Insurance Premium payment is: R" + vehicle.getInsurancePremium() +
                 "\nTherefore the monthly cost for your vehicle alone is R" + totalMonthlyPayment);
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();

            //calculating if the user's expenses cost more than 75% of their income
            totalExpenses = expenses + monthlyHomeLoan;
            sum1 = PERCENTAGE / 100;
            sum2 = sum1 * income.getIncome();

            if (totalExpenses < sum2)
            {
                //calling Notice() using delegate - instantiating the delegate
                Note notice = new Note(Notice);
                Console.WriteLine(notice());
            }
            else
                Console.WriteLine("You are a smart saver.");


            Console.WriteLine("Thank you for using our console application");
            Console.ReadLine();

        }
        //method created for delegate
        public static string Notice()
        {
            return "Your expenses take more than 75% of your income. Cut down some expenses.";
        }
    }
}

//Troelsen, A. Japikse, P. (2017). Pro C# 7 With .NET and .NET Core. Eighth Edition. APRESS: USA. 