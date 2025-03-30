namespace EShop.Application
{
    public interface ICreditCardService
    {
        public Boolean ValidateCard(string cardNumber);

        public string GetCardType(string cardNumber);
    }
}
