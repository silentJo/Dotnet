using Microsoft.EntityFrameworkCore;
using Nortwind_API.Entities;

namespace Nortwind_API.Repository

{
    public class EmployeeRepository : IRepository<Employee>
    {
        private readonly NorthwindContext context = new NorthwindContext();

        public Task DeleteAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Employee>> GetAllAsync()
        {
            //TODO
            return await context.Employees.ToListAsync();
        }

        public Task<Employee?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool?> SaveAsync(Employee entity, System.Linq.Expressions.Expression<Func<Employee, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Employee>> SearchForAsync(System.Linq.Expressions.Expression<Func<Employee, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
