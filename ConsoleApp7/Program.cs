using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jeff,Alice試行別為student的object

            student Jeff = new student();

           // Jeff.Age = 20;
            Jeff.Email = "jeff@gmail.com";
            Jeff.Gender = true;
            Jeff.DateofBirth = new DateTime(2002, 5, 15);
            DateTime dt = Jeff.DateofBirth;

            student Alice=new student();
           // Alice.Age = 25;
            Alice.Email = "alice@gmail.com";
            Alice.Gender = false;

            Alice.DateofBirth = new DateTime(1997, 12, 05);//設定(set)屬性值
            DateTime dt2 = Alice.DateofBirth;//取得(get)屬性值

        }
    }
    /// <summary>
    /// 學生
    /// </summary>

    class student {
        //filed(欄位),若寫public(公開),外界(例如Program.Main)才能叫用
        //若不寫public,表示為private(私有的),外界無法叫用,只有本類內部可以使用
        //習慣上,field都宣告成private,不會宣告成public

        string Name;
        public string Email;
        //public int Age;
        public bool Gender;

        private DateTime DateOfBirth;
        //property(屬性),優點是可以寫驗證,不允許不合理的數值進入屬性,filed做不到這點
        public DateTime DateofBirth
        {
            get
            {
                return DateOfBirth;
            }
    
            set
            {
                if (value > DateTime.Today)
                {
                    //丟出例外(throw  Exception)
                    throw new Exception("生日不可能比今天晚");
                }

                DateOfBirth = value;
                
            }
        }
         
        //readonly(唯獨)屬性

        public int Age
        {
            get
            {
                return DateTime.Today.Year-DateofBirth.Year;
            }
        }

       public string GetInfo()
        {
            return $"Name={Name},生日{DateofBirth:yyyy/<</dd},年紀:{Age}";
        }





    }




}
