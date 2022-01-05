using NacktBank.Models.Employees;

namespace NacktBank.Models.Reports
{
    public class ManageBonus
    {
        private double _totalBonus;
        public void Register(Employee employee) {
            _totalBonus += employee.GetBonus();
        }
        public double getTotalBonus() {
            return _totalBonus;
        }
    }
}