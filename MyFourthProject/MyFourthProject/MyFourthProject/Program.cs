using System;
using static System.Console;

class MyFourthProgram
{
    public static void Main()
    {
        string  loanAmountAsString, interestAsString, monthlyPaymentAsString; 
        double loanAmount, interestRate, monthlyAmount; 

        Write("Enter the total loan amount: ");
        loanAmountAsString = ReadLine();
        loanAmount = Convert.ToDouble(loanAmountAsString);


        Write("What is your intrest rate: ");
        interestAsString = ReadLine();
        interestRate = Convert.ToDouble(interestAsString);

        Write("What is the monthly payment: ");
        monthlyPaymentAsString = ReadLine();
        monthlyAmount = Convert.ToDouble(monthlyPaymentAsString);

        int month = 0;
        month++;

        double interestMonthly = (interestRate / 12) / 100; 
        WriteLine("Month - Interest - Principle - Balance");
        WriteLine($"{month}",3);
        

        // Calculate the intrest rate for the current month.
        double currentIntrest;

       currentIntrest  = (loanAmount * interestMonthly); Math.Round(currentIntrest, 2);
        
        Write($"{currentIntrest}", 6);
    }
}