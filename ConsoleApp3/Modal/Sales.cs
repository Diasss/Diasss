using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Modal
{
    public class Sales
    {
        public int Burks { get; set; }
        public int Werks { get; set; }
        public int Lgort { get; set; }
        public int SalesChanel { get; set; }
        public string SalesChanelTxt { get; set; }
        public int Kunnr { get; set; }
        public int KunnrTxt { get; set; }

        private string ID_OUT_DELIVERY_DATA_;
        public string ID_OUT_DELIVERY_DATA
        {
            get
            { return ID_OUT_DELIVERY_DATA_; }
            set
            {
                DateTime tmp;
                if (DateTime.TryParse(value, out tmp))
                {
                    ID_OUT_DELIVERY_DATA_ = string.Format("{0:dd-mm-yy}", tmp);
                }
                else
                    ID_OUT_DELIVERY_DATA_ = "";
            }
        }

    }
}
