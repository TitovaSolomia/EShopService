using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions
{
    public class CardNumberTooLongException : Exception
    {
        public int StatusCode { get; }

        public CardNumberTooLongException()
            : base("Card number is too long")
        {
            StatusCode = 414;
        }

        public CardNumberTooLongException(Exception innerException)
            : base("Card number is too long", innerException)
        {
            StatusCode = 414;
        }

    }
}
