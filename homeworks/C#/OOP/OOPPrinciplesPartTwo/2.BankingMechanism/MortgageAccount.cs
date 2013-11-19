using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankingMechanism
{
    public class MortgageAccount : Account
    {
        private const int MortAccCoeff = 6;
         public MortgageAccount(Coustumer sampleCoustumer, decimal balance, decimal intRate)
            : base(sampleCoustumer, balance, intRate)
        {

        }

         //methods
         public override void Deposit(decimal amout)
         {
             this.Balance = this.Balance + amout;
         }
         public override void WithDraw(decimal amout)
         {
             throw new Exception("Not allowed procedure.");
         }
         public override decimal CalcInterestAmout(int timePeriod)
         {
             if (timePeriod < 0)
             {
                 throw new Exception("Time period must be greater than zero.");
             }
             if (this.SampleCoustumer is Company)
             {
                
                 if (timePeriod <= 12)
                 {
                     return base.CalcInterestAmout(timePeriod / 2);
                 }
                 else if (timePeriod > 12)
                 {
                     return base.CalcInterestAmout(timePeriod - MortAccCoeff);
                 }
             }
             if (this.SampleCoustumer is Individual)
             {
                 if (timePeriod <= 6)
                 {
                     return 0;
                 }
                 else if (timePeriod > 6)
                 {
                     return base.CalcInterestAmout(timePeriod - MortAccCoeff);
                 }
             }

             return 0;
             
         }
    }
}
