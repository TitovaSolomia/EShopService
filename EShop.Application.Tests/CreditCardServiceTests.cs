using EShop.Domain.Exceptions;
using Xunit;

namespace EShop.Application.Tests
{
    public class CreditCardServiceTest
    {

        //[Theory]
        //[InlineData("3497 7965 8312 797")]
        //public void ValidateCreditCardNumber_ShouldReturnTrue(string cardNumber)
        //{
        //    var credit = new CreditCardService();
        //    bool result = credit.ValidateCard(cardNumber);
        //    Assert.True(result);
        //}

        //[Theory]
        //[InlineData("1234 5678 9012", false)] 
        //[InlineData("12345671234567123456", false)] 
        //[InlineData("", false)] 
        //[InlineData("345-470-784-783-0108766", false)] 
        //[InlineData("9999 9999 9999 9999", false)] 
        //public void ValidateCreditCardNumber_ShouldReturnFalse(string cardNumber, bool expected)
        //{
        //    var credit = new CreditCardService();
        //    bool result = credit.ValidateCard(cardNumber);
        //    Assert.Equal(expected, result);
        //}

        [Theory]
        [InlineData("4532 2080 2150 4434", "Visa")] 
        [InlineData("5530016454538418", "MasterCard")] 
        [InlineData("3497 7965 8312 797", "AmericanExpress")] 
        public void GetCardType_ShouldReturnCorrectCardType(string cardNumber, string expected)
        {
            var credit = new CreditCardService();
            string result = credit.GetCardType(cardNumber);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("451567546754235785433578")]
        public void ValidateCard_ShouldThrowCardNumberTooLongException(string cardNumber)
        {
            var card = new CreditCardService();

            var action = () => card.ValidateCard(cardNumber);

            Assert.Throws<CardNumberTooLongException>(() => action);
        }

        [Theory]
        [InlineData("45155")]
        [InlineData("2")]
        public void ValidateCard_ShouldThrowCardNumberTooShortException(string cardNumber)
        {
            var card = new CreditCardService();

            var action = () => card.ValidateCard(cardNumber);

            Assert.Throws<CardNumberTooShortException>(() => action);
        }

        [Theory]
        [InlineData("00000000000")]
        public void ValidateCard_ShouldThrowCardNumberInvalidException(string cardNumber)
        {
            var card = new CreditCardService();

            var action = () => card.ValidateCard(cardNumber);

            Assert.Throws<CardNumberInvalidException>(() => action);
        }
    }
}
