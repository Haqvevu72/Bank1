using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class bank
    {
        public  List<client> clients { get; set; }

        // => Constructor for `bank` class
        public bank(List<client> clients)
        {
            this.clients = clients;
        }

        // => Show balance method
        public void ShowCardBalance(bankcard BankCard) {
            Console.WriteLine($"Balance: {BankCard.Balance}");
        }

    }
}
