using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Portfolio
{
    class SavingsAccount : IAsset
    {
        public String Id{get;set;}
        public double Value{get;set;}
        public double InterestRate{get;set;}

        public SavingsAccount(){}
        public SavingsAccount(String Id, double Value, double InterestRate)
        {
            this.Id           = Id;
            this.Value        = Value;
            this.InterestRate = InterestRate;
        }

        public double GetValue(){return Value;}

        public void ApplyInterest()
        {
            Value += Value * (InterestRate/100);
        }

        public override String ToString()
        {
            return "SavingsAccount[value="+Value.ToString("F1").Replace(',', '.')+",interestRate="+InterestRate.ToString().Replace(',','.')+"]";
        }
    }
}
