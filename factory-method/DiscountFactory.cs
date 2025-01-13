namespace Discount {
    public abstract class DiscountFactory {
        public abstract DiscountService CreateDiscountService();
    }

    public class CountryDiscountFactory : DiscountFactory {
        private readonly string _country;
        public CountryDiscountFactory(string country) => _country = country;
        public override DiscountService CreateDiscountService() => new CountryDiscountService(_country);
    }

    public class ProductDiscountFactory : DiscountFactory {
        private readonly string _product;
        public ProductDiscountFactory(string product) => _product = product;
        public override DiscountService CreateDiscountService() => new ProductDiscountService(_product);
    }
}