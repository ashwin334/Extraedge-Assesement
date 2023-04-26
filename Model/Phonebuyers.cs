using System.ComponentModel.DataAnnotations;

namespace Extraedge_Assesement.Model
{
    public class Phonebuyers
    {
        public int ConsumerId { get; set; }
        public DateTime BuyersDate { get; set; }
        public int BuyersPrice { get; set; }

        public int Cashback { get; set; }

        public int FinalPrice { get; set; }

        public int Price { get; set; }
    }
}
