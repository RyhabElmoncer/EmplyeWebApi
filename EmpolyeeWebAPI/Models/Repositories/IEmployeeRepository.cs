namespace EmpolyeeWebAPI.Models.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeID);

        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdatEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int employeeId);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<IEnumerable<Employee>> search(string name , Gender? gender );


    }
}
