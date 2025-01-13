namespace Discount
{
    public abstract class DiscountService {
        public abstract int GetDiscount { get; }
        public override string ToString() => GetType().Name;
    }

    public class CountryDiscountService : DiscountService {
        private readonly string _country;

        public CountryDiscountService(string country) => _country = country;
        public override int GetDiscount {
            get {
                switch (_country) {
                    case "US": return 10;
                    case "UK": return 20;
                    default: return 0;
                }
            }
        }
    }

    public class ProductDiscountService : DiscountService {
        private readonly string _product;

        public ProductDiscountService(string product) => _product = product;
        public override int GetDiscount {
            get {
                switch (_product) {
                    case "Laptop": return 5;
                    case "Mobile": return 10;
                    default: return 0;
                }
            }
        }
    }
}