using System;
using System.Collections;

namespace Loaner.Models
{
    public class LoanEvent
    {
        public int Id { get; set; }
        public DateTime LoanDate { get; set; }
        public Item LoanedItem { get; set; }
        public Person Borrower { get; set; }
        //public IEnumerable<Person> Borrowers { get; set; }
    }
}
