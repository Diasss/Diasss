using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace ConsoleApp3.Modal
{
    public enum RequestType
    {
        SALES,
        SALESIMS,
        STORED,
        MOVING,
        GOODS_RECEIPT
    }
    public class Request
    {
        /// <summary>
        /// Структура запроса
        /// </summary>
        public Request()
        {

        }
        public Request(DateTime Date1, DateTime Date2)
        {

        }
        public RequestType RequestType{get;set;}
        /// <summary>
        /// Код поставщика из системы SAP ERP (или BIN).
        /// </summary>
        public int Kunnr { get; set; }
        /// <summary>
        /// Код БЕ в SAP ERP. Код БЕ может быть заполнен, а может и не заполнен. 
        /// </summary>
        public int Bukrs { get; set; }
        /// <summary>
        /// Завод, в рамках которого необходимо передать данные по продажам из системы SAP ERP. 
        /// </summary>
        public int Werks { get; set; }
        /// <summary>
        /// Дата с начало периода
        /// </summary>
        public DateTime Data1 { get; set; }
        /// <summary>
        /// Дата конец периода
        /// </summary>
        public DateTime Data2 { get; set; }
    }
}
