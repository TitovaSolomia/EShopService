namespace EShop.Application.Services
{
    public interface ICreditCardService
    {
        public bool ValidateCard(string cardNumber);

        public string GetCardType(string cardNumber);
    }
}
