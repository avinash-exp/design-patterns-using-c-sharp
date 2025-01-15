namespace ClassAdapter {

    public class ExternalCity {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public int people { get; set; }

        public ExternalCity(string firstName, string lastName, int people) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.people = people;
        }
    }

    public class ExternalCitySystem {
        public ExternalCity GetCity() {
            return new ExternalCity("New York", "City", 1000000);
        }
    }

    public class City {
        public string name { get; set; }
        public long people { get; set; }

        public City(string name, long people) {
            this.name = name;
            this.people = people;
        }
    }

    public interface ICity {
        void GetCity();
    }

    public class CityAdapter : ExternalCitySystem, ICity {
        public void GetCity() {
            var externalCity = base.GetCity();
            var city = new City(externalCity.firstName + " " + externalCity.lastName, externalCity.people);
            System.Console.WriteLine($"City: {city.name}, People: {city.people}");
        }
    }

    public class Client {
        private readonly ICity _city;

        public Client(ICity city) {
            _city = city;
        }

        public void GetCity() {
            _city.GetCity();
        }
    }
}