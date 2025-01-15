var externalCity = new ObjectAdapter.ExternalCity("New York", "City", 1000000);
var city = new ObjectAdapter.CityAdapter(new ObjectAdapter.ExternalCitySystem(externalCity));
var client = new ObjectAdapter.Client(city);
client.GetCity();

var city_ = new ClassAdapter.CityAdapter();
var client_ = new ClassAdapter.Client(city_);
client_.GetCity();