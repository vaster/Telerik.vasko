using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankingMechanism
{
    public class LoanAccount : Account
    {
        private const int noInterestCoeffForIndividual = 3;
        private const int noIntresetCeoffForCompany = 2;


        public LoanAccount(Coustumer sampleCoustumer, decimal balance, decimal intRate)
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
            if (this.SampleCoustumer is Individual)
            {
                if (timePeriod <= 3)
                {
                    return base.CalcInterestAmout(timePeriod - timePeriod);
                }
                else
                {
                    return base.CalcInterestAmout(timePeriod - noInterestCoeffForIndividual);
                }
            }
            if (this.SampleCoustumer is Company)
            {
                if (timePeriod <= 2)
                {
                    return base.CalcInterestAmout(timePeriod - timePeriod);
                }
                else
                {
                    return base.CalcInterestAmout(timePeriod - noIntresetCeoffForCompany);
                }
            }
            return 0;    
        }
    }
}
