using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileHelper helper=new FileHelper();

            string folderName = @"d:\temp\files\";
            string fileName = "readme.txt";
            helper.Delete(folderName, fileName);

            Order order = new Order();
            int origTotal = 100;//原始總價
            decimal discount = 0.8M;
            int total = order.CalcTotal(origTotal, discount);
            Console.WriteLine(total);

            var imageHelper = new ImageHelper();
            int targeWidth = 60;
            int targeHeight = 60;
            string imageSourceFile = @"d:\files\pic.jpg";
            string targetPath = @"e:\files\";
            ImageHelper.ResizeImage(imageSourceFile,Size targetSize,targetPath);
        }
    }

    class ImageHelper
    {
        public void ResizeImage(string imageSourceFile,
                                Size targetSize,
                                string targetPath)//將大圖按比例縮圖
        {

        }
    }
    class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    class Order//訂單
    {
        public int CalcTotal (int total,decimal discount)//可以計算折扣後的新總價
        {
            if (total <= 0) throw new Exception("原始金額必須大於零");
            if (discount <= 0 || discount > 1) throw new Exception("折扣必須介於0~1之間");
            
            return(int)((decimal)total / discount);
        }
    }

    class FileHelper
    {

        public void Delete(string folderName,string fileName)
        {

        }

    }


}

