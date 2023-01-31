using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //implicit conversion  bilinçsiz dönüşüm  dilin kendi kendine çözdüğü dönüşümler
            sbyte uuu = 5, uuuu = 10;
            float ui = uuu + uuuu;
            Console.WriteLine(ui);

            //explicit conversion  bilinçli dönüşüm müdahele etmemiz gereken dönüşümler

            int u = 10;
            byte i = (byte)u;    // (içine yazılan) sonrasını kendisine dönüştürmeye çalışır.
            Console.WriteLine(i);

            double uu = 11.11;
            object ii = (object)uu;
            Console.WriteLine(ii);

            //ToString Method   parametreyi stringe dönüştürülmesi için kullanılır
            int j = 10;
            string jj = j.ToString();
            Console.WriteLine(jj);

            double ju = 10.61;
            string jju = ju.ToString();
            Console.WriteLine(jju);

            //System Convert Method  verilen string sayı ifadesini int,double,floata çevirmek için kullanılır
            string zz = "61";
            int zj = Convert.ToInt16(zz);
            Console.WriteLine(zj);

            string uj = "10";
            int uuj = Convert.ToInt16(uj);

            int r = zj + uuj;
            Console.WriteLine(r);

            //Parse Method   string değişkeni parse kullanarak int double float değere dönüştürme

            string kk = "15";
            int  k1 = Int16.Parse(kk);
            Console.WriteLine(k1);

            string kkk = "15,55";
            double k2 = Double.Parse(kkk);
            Console.WriteLine(k2);
        }
      
    }
}
