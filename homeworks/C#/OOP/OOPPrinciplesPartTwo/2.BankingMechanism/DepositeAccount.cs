using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankingMechanism
{
    public class DepositeAccount : Account
    {
        public DepositeAccount(Coustumer sampleCoustumer, decimal balance, decimal intRate)
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
            this.Balance = this.Balance - amout;
        }

        public override decimal CalcInterestAmout(int timePeriod)
        {
            if (this.Balance > 0 && this.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return base.CalcInterestAmout(timePeriod);
            }
        }
    }
}
