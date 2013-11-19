using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankingMechanism
{
    public abstract class Account
    {
        private Coustumer sampleCoustumer;
        private decimal balance;
        private decimal intRate;

        public Account(Coustumer sampleCoustumer, decimal balance, decimal intRate)
        {
            this.SampleCoustumer = sampleCoustumer;
            this.Balance = balance;
            this.IntRate = intRate;
        }


        //methods

        public abstract void Deposit(decimal amout);
        public abstract void WithDraw(decimal amout);

        public virtual decimal CalcInterestAmout(int timePeriod /*in months*/)
        {
            return this.IntRate * timePeriod;
        }

        //properties
        protected Coustumer SampleCoustumer
        {
            get { return this.sampleCoustumer; }
            set { this.sampleCoustumer = value; }
        }
        protected decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        protected decimal IntRate
        {
            get { return this.intRate; }
            set { this.intRate = value; }
        }

        
    }
}
