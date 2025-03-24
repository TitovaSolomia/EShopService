using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions
{
    public class CardNumberTooShortException : Exception
    {
        public int StatusCode { get; }
        public CardNumberTooShortException()
            : base("Card number is too short")
        {
            StatusCode = 400;
        }
    }
}
