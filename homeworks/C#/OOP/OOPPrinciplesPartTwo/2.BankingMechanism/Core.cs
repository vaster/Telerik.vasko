using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.
Customers could be individuals or companies.
All accounts have customer, balance and interest rate (monthly based).
Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months).
In the common case its is calculated as follows: number_of_months * interest_rate.
 
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces.
You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.

 
*/
namespace _2.BankingMechanism
{
    class Core
    {
        static void Main(string[] args)
        {
            //testing

            Coustumer aCompany = new Company();
            Coustumer aIndividual = new Individual();
            List<Account> account = new List<Account>()
            {
                new DepositeAccount(aCompany, 10000, 12),
                new LoanAccount(aIndividual, 12,12),
                new MortgageAccount(aCompany,3,3),
            };

            Bank<Account> sampleBank = new Bank<Account>(account);
           

            foreach (var acc in sampleBank)
            {
                Console.WriteLine("{0}'s IntRate: {1}",acc.GetType().Name,acc.CalcInterestAmout(14));
            }
        }
    }
}
