using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionCentre.BL
{
    public class BookingItem
    {
        public BookingItem()
        {

        }

        public BookingItem(int bookingItemId)
        {
            this.BookingItemId = bookingItemId;
        }


        public int BookingItemId { get; private set; }

        public int BookingQuantity { get; set; }

        public int BookingPurchasePrice { get; set; }

    }
}
