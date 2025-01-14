using ShoppingCartService;

namespace ShoppingCartClient {
    public class Client {
        private readonly IShoppingDiscountService _discountService;
        private readonly IShippingCostService _shippingCostService;

        private int _orderPrice;
        public void CalculateTotalCost() {
            var discount = _discountService.GetDiscount;
            var shippingCost = _shippingCostService.GetShippingCost;
            Console.WriteLine($"Total cost: {_orderPrice - discount + shippingCost}");
        }

        public Client(IShoppingCartServiceFactory factory) {
            _discountService = factory.CreateDiscountService();
            _shippingCostService = factory.CreateShippingCostService();
            _orderPrice = 100;
        }
    }
    
}