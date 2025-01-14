using ShoppingCartClient;
using ShoppingCartService;

var UKShopping = new UKShoppingCartServiceFactory();

var INShopping = new INShoppingCartServiceFactory();
var client = new Client(UKShopping);

client.CalculateTotalCost();

client = new Client(INShopping);
client.CalculateTotalCost();

