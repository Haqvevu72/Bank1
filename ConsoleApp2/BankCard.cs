using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class bankcard
    {
        public string? bankname { get; set; }
        public string? fullname { get; set; }
        private string? pan;
        public DateTime expiredate { get; set; }
        public string? PAN
        {
            get { return pan; }
            set { if (value.Length == 16) {
                    pan = value;
                }
            }
        }

        private string? pin;


        public string? PIN
        {
            get { return pin; }
            set { if (value.Length == 4) {
                    pin = value;
                }
            }

        }
        public string? CVC{ get; set; }

        public  double Balance { get; set; }
        // => Constructor for `bankcard` class
        public bankcard(string? bankname, string? fullname, DateTime expiredate, string? pAN, string? pIN, string? cVC, double balance)
        {
            this.bankname = bankname;
            this.fullname = fullname;
            this.expiredate = expiredate;
            PAN = pAN;
            PIN = pIN;
            CVC = cVC;
            Balance = balance;
        }
       

        // => Overriding ToString() method
        public override string ToString()
        {
            return $"\nBank Account\nBank Name: {bankname}\nFull Name: {fullname}\nPAN: {PAN}\nPIN: {PIN}\nExpire Date:{expiredate.ToShortDateString()}\nCVC: {CVC}\nBalance: {Balance}";
        }
    }
}
