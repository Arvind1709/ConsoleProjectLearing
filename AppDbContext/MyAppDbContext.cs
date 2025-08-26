using ConsoleProjectLearing.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleProjectLearing.AppDbContext
{
    internal class MyAppDbContext : DbContext
    {
        ////public DbSet<OrderModel> Orders { get; set; }
        ////public DbSet<OrderItemModel> OrderItems { get; set; }
        ////public DbSet<OrderSubItemModel> OrderSubItems { get; set; }
        //public DbSet<EmployeeModel> Employees { get; set; }
        //public DbSet<DepartmentModel> Departments { get; set; }
        //public DbSet<OrdersModel> Orders { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // optionsBuilder.UseSqlServer("Data Source=DESKTOP-US2RJ9L;Initial Catalog=Task;Integrated Security=True;Trust Server Certificate=True");
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-US2RJ9L;Initial Catalog=RevisionDMForInterview;Integrated Security=True;Trust Server Certificate=True");
        //}

        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<OrdersModel> Orders { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<CustomerOrderModel> CustomerOrders { get; set; }
        public DbSet<OrderDetailModel> OrderDetails { get; set; }
        public DbSet<DepartmentGB> DepartmentGB { get; set; }
        public DbSet<EmployeeGB> EmployeeGB { get; set; }
        public DbSet<EmployeesDuplicateModel> EmployeesDuplicate { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-US2RJ9L;Initial Catalog=RevisionDMForInterview;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
