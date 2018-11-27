using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace day_02_workshop.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }
        public bool GoodOrBad { get; set; }

        public BankAccount(string name, double balance, string animalType, bool isKing, bool goodOrBad)
        {
            this.Name = name;
            this.Balance = balance;
            this.AnimalType = animalType;
            this.IsKing = isKing;
            this.GoodOrBad = goodOrBad;
        }

//        public void RaiseBalance()
//        {
//            if (this.IsKing)
//            {
//                this.Balance += 100;
//            }
//            else
//            {
//                this.Balance += 10;
//            }
//        }
    }
}
