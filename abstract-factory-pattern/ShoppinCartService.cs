namespace ShoppingCartService {
    public interface IShoppingCartServiceFactory {
        IShoppingDiscountService CreateDiscountService();
        IShippingCostService CreateShippingCostService();
    }

    public interface IShoppingDiscountService {
        int GetDiscount { get; }
    }

    public interface IShippingCostService {
        int GetShippingCost { get; }
    }

    public class UKDiscountService : IShoppingDiscountService {
        public int GetDiscount => 10;
    }

    public class INDiscountService : IShoppingDiscountService {
        public int GetDiscount => 20;
    }

    public class UKShippingCostService : IShippingCostService {
        public int GetShippingCost => 50;
    }

    public class INShippingCostService : IShippingCostService {
        public int GetShippingCost => 100;
    }

    public class UKShoppingCartServiceFactory : IShoppingCartServiceFactory {
        public IShoppingDiscountService CreateDiscountService() => new UKDiscountService();
        public IShippingCostService CreateShippingCostService() => new UKShippingCostService();
    }

    public class INShoppingCartServiceFactory : IShoppingCartServiceFactory {
        public IShoppingDiscountService CreateDiscountService() => new INDiscountService();
        public IShippingCostService CreateShippingCostService() => new INShippingCostService();
    }

}