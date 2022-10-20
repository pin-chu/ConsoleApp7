using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var member = new Member();
            member.Register ("allen", "123", "Allen Kuo", "allen@gmail.com");

            string value = "abcdef";
            string result = new StringHelper().Left(value, 3);

            StringHelper helper= new StringHelper();
            result= helper.Left(value, 3);

        }
    }



    class StringHelper
    {
        public string Left(string source,int lenght)
        {
            if(string.IsNullOrEmpty(source))return string.Empty;
            if(lenght <= 0)return string.Empty;
            if(source.Length < lenght) return source;
            
            return source.Substring(0,lenght);
        }
    }
    class Member //會員
    {
        public void Register(string account, string password, string name, string email)
        {




        }
    
    
    }
    
}
