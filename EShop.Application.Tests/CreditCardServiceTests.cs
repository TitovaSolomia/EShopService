using Xunit;

namespace EShop.Application.Tests
{
    public class CreditCardServiceTest
    {
        [Theory]
        [InlineData("3497 7965 8312 797")]
        [InlineData("345-470-784-783-0108766")] // nie dziala
        [InlineData("4532289052809")] // i ten nie dziala
        public void ValidateCreditCardNumber_ShouldReturnTrue(string cardNumber)
        {
            var credit = new CreditCardService();
            bool result = credit.ValidateCard(cardNumber);
            Assert.True(result);
        }

        [Theory]
        [InlineData("1234 5678 9012", false)] 
        [InlineData("12345671234567123456", false)] 
        [InlineData("", false)] 
        [InlineData("345-470-784-783-0108766", false)] 
        [InlineData("9999 9999 9999 9999", false)] 
        public void ValidateCreditCardNumber_ShouldReturnFalse(string cardNumber, bool expected)
        {
            var credit = new CreditCardService();
            bool result = credit.ValidateCard(cardNumber);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("4532 2080 2150 4434", "Visa")] 
        [InlineData("5530016454538418", "MasterCard")] 
        [InlineData("378523393817437", "American Express")] 
        [InlineData("9999 9999 9999 9999", "Nieznany wydawca")] 
        public void GetCardType_ShouldReturnCorrectCardType(string cardNumber, string expected)
        {
            var credit = new CreditCardService();
            string result = credit.GetCardType(cardNumber);
            Assert.Equal(expected, result);
        }
    }
}
