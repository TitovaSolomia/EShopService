using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions
{
    public class CardNumberInvalidException : Exception
    {
        public int StatusCode { get; }

        public CardNumberInvalidException()
            : base("Card issuer is not supported")
        {
            StatusCode = 406;
        }
    }

}
