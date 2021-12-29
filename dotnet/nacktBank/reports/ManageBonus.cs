using nacktBank.Employees;

namespace nacktBank.reports
{
    public class ManageBonus
    {
        private double _totalBonus;

        public void Register(Employee employee) {
            _totalBonus += employee.GetBonus();
        }
        public void Register(Manager manager) {
            _totalBonus += manager.GetBonus();
        }

        public double getTotalBonus() {
            return _totalBonus;
        }
    }
}