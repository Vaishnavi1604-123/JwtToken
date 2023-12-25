using JwtToken.Interface;
using JwtToken.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtToken.Repository
{
    public class EmployeeRepository:IEmployee
    {
        readonly DataBaseContext _dbContext;
        public EmployeeRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Employee> GetEmployeeDetails()
        {
            try
            {
                return _dbContext.Employee.ToList();
            }
            catch
            {
                throw;
            }
        }
        public Employee GetEmployeeDetails(int id)
        {
            try
            {
                Employee? employee = _dbContext.Employee.Find(id);
                if (employee != null)
                {
                    return employee;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        public void AddEmployee(Employee employee)
        {
            try
            {
                _dbContext.Employee.Add(employee);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public void UpdateEmployee(Employee employee)
        {
            try
            {
                _dbContext.Entry(employee).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public Employee DeleteEmployee(int id)
        {
            try
            {
                Employee? employee = _dbContext.Employee.Find(id);

                if (employee != null)
                {
                    _dbContext.Employee.Remove(employee);
                    _dbContext.SaveChanges();
                    return employee;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        public bool CheckEmployee(int id)
        {
            return _dbContext.Employee.Any(e => e.userid == id);
        }
    }
}
