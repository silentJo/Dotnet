using Nortwind_API.Entities;

namespace Nortwind_API.DTO
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }

        public string LastName { get; set; } = null!;

        public string FirstName { get; set; } = null!;
    }
}
