using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCW_DataManagement
{
    public class Rental
    {
        public int RentalID { get; set; }
        public int CustomerID { get; set; }
        public int ToolID { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
        public string Notes { get; set; }

        
        public Rental() { }

        /// <summary>
        /// Creates Rental data when no dummy data is provided.
        /// </summary>
        /// <param name="customer">int</param>
        /// <param name="tool">int</param>
        /// <param name="renttime">int</param>
        /// <returns> Rental Data with specified parameters </returns>
        public Rental(int customer, int tool, DateTime renttime)
        {
            CustomerID = customer;
            ToolID = tool;
            DateRented = renttime;
        }

        /// <summary>
        /// Creates Rental data when dummy data is provided
        /// </summary>
        /// <param name="customer">int</param>
        /// <param name="tool">int</param>
        /// <param name="renttime">DateTime</param>
        /// <param name="returntime">DateTime?</param>
        /// <param name="note">string</param>
        /// <returns> Rental Data with specified parameters </returns>
        public Rental(int customer, int tool, DateTime renttime, DateTime? returntime, string note)
        {
            CustomerID = customer;
            ToolID = tool;
            DateRented = renttime;
            DateReturned = returntime;
            Notes = note;
        }
    }
}
