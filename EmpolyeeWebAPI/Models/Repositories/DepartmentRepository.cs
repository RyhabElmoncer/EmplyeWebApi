namespace EmpolyeeWebAPI.Models.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext AppDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.AppDbContext = appDbContext;
        }
        public Department GetDepartment(int departmentId)
        {
            return AppDbContext.Departments
                 .FirstOrDefault(d => d.DepartmentID == departmentId);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return AppDbContext.Departments;
                }
    }
}
