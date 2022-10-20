using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

    }
   
    //prop+(tab*2)10/20  16:23
    
    class Address
    {
    public string City { get; set; }

    public string ZipCode { get; set; }

    public string MyProperty { get; set; }

    }
    class Member
    {
        public Address Addr { get; set; }
        public void Register() { get; set; }
    }

   

}
