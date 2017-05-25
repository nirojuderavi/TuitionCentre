using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionCentre.BL
{
    public class Booking
    {
        public Booking()
        {

        }

        public Booking(int bookingId)
        {
            this.BookingId = bookingId;
        }

        public int BookingId { get; private set; }

        public DateTimeOffset? BookingDate { get; set; }

        public Booking Retrieve(int bookingId)
        {
            return new Booking();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if(BookingDate == null)
            {
                isValid = false;
            }

            return isValid;
        }

    }
}
