using Discount;
using System;

var factory_list = new List<DiscountFactory> {
    new CountryDiscountFactory("US"),
    new ProductDiscountFactory("Laptop"),
    new CountryDiscountFactory("UK"),
    new ProductDiscountFactory("Mobile")
};

foreach (var factory in factory_list) {
    // here discount service client is not aware of different discount services and how they are created
    // also discount service client is not aware of the discount service implementation
    var discount_service = factory.CreateDiscountService();
    Console.WriteLine($"Discount: {discount_service.GetDiscount} from {discount_service}");
}
