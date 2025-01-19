using FacadePattern;

var discountFacade = new DiscountFacade();
var discount = discountFacade.GetDiscount(3);
Console.WriteLine($"Discount: {discount}");

