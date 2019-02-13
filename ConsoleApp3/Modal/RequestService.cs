using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Modal
{
    public class RequestService
    {
        public void CreatRequest()
        {
            Request r = new Request();
            Console.Write("Заполните Kunnr: ");
            r.Kunnr = Int32.Parse(Console.ReadLine());

            Console.Write("\nЗаполните Bukrs: ");
            r.Bukrs = Int32.Parse(Console.ReadLine());

            Console.Write("\nЗаполните Werks: ");
            r.Werks = Int32.Parse(Console.ReadLine());

            Console.Write("\nЗаполните Date1: ");
            r.Data1 = DateTime.Parse(Console.ReadLine());

            Console.Write("\nЗаполните Date2: ");
            r.Data2 = DateTime.Parse(Console.ReadLine());

            r.RequestType = RequestType.SALES;
        }
        public void GenerateReport(Request request)
        {
            switch (request.RequestType)
            {
                case RequestType.SALES:
                    {

                    }
                    break;
                case RequestType.SALESIMS:
                    break;
                case RequestType.STORED:
                    break;
                case RequestType.MOVING:
                    break;
                case RequestType.GOODS_RECEIPT:
                    break;
                default:
                    break;
            }
        }
    }
   
}
