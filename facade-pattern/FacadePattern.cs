namespace FacadePattern {
    class CustomerDiscount {
        public bool IsEligibleForDiscount(int customerID) {
            if (customerID < 5) {
                return false;
            }
            return true;
        }
    }

    class CustomerDiscountBaseService {
        public double GetDiscount(int customerID) {
            if (customerID > 8) {
                return 10;
            } else {
                return 20;
            }
        }
        
    }

    class DayOfWeekDiscountService {
        public double DayOfWeekDiscount() {
            switch (DateTime.Now.DayOfWeek) {
                case DayOfWeek.Saturday:
                    return 20;
                case DayOfWeek.Sunday:
                    return 20;
                default:
                    return 30;
            }
        }
    }

    class DiscountFacade {
        private readonly CustomerDiscount _customerDiscount;
        private readonly CustomerDiscountBaseService _customerDiscountBaseService;
        private readonly DayOfWeekDiscountService _dayOfWeekDiscount;

        public DiscountFacade() {
            _customerDiscount = new CustomerDiscount();
            _customerDiscountBaseService = new CustomerDiscountBaseService();
            _dayOfWeekDiscount = new DayOfWeekDiscountService();
        }

        public double GetDiscount(int customerID) {
            if (_customerDiscount.IsEligibleForDiscount(customerID)) {
                return _customerDiscountBaseService.GetDiscount(customerID) + _dayOfWeekDiscount.DayOfWeekDiscount();
            } else {
                return _dayOfWeekDiscount.DayOfWeekDiscount();
            }
        }
    }
}