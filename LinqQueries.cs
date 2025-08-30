using ConsoleProjectLearing.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace ConsoleProjectLearning
{
    internal class LinqQueries
    {
        private readonly MyAppDbContext _context;

        public LinqQueries(MyAppDbContext context)
        {
            _context = context;
        }

        // 1. Get All Employees
        public void GetAllEmployees()
        {
            var employees = _context.Employees
                                    .Include(e => e.Department)
                                    .ToList();

            employees.ForEach(e =>
                Console.WriteLine($"ID: {e.EmployeeID}, Name: {e.FirstName} {e.LastName}, Dept: {e.Department?.DepartmentName}")
            );
        }

        // 2. Get Employees with Salary greater than 50,000
        public void GetHighSalaryEmployees()
        {
            var result = _context.Employees
                                 .Where(e => e.Salary > 50000)
                                 .ToList();

            result.ForEach(e =>
                Console.WriteLine($"{e.FirstName} {e.LastName} - Salary: {e.Salary}")
            );
        }

        // 3. Join Employee with Department
        public void GetEmployeesWithDepartment()
        {
            var result = from emp in _context.Employees
                         join dept in _context.Departments on emp.DepartmentID equals dept.DepartmentID
                         select new { emp.FirstName, emp.LastName, dept.DepartmentName };

            foreach (var item in result)
                Console.WriteLine($"{item.FirstName} {item.LastName} works in {item.DepartmentName}");
        }

        // 4. Count of Employees in each Department
        public void GetEmployeeCountByDepartment()
        {
            var result = _context.Employees
                                 .GroupBy(e => e.DepartmentID)
                                 .Select(g => new { DeptId = g.Key, Count = g.Count() });

            foreach (var item in result)
                Console.WriteLine($"DeptId: {item.DeptId}, Employee Count: {item.Count}");
        }

        // 5. Get All Orders
        public void GetAllOrders()
        {
            var orders = _context.Orders.ToList();

            foreach (var order in orders)
            {
                Console.WriteLine($"OrderID: {order.OrderID}, Customer: {order.CustomerName}, Amount: {order.Amount}, Status: {order.Status}");
            }
        }

        // 6. Get Orders with Amount greater than 1000
        public void GetHighValueOrders()
        {
            var orders = _context.Orders
                                 .Where(o => o.Amount > 1000)
                                 .ToList();

            foreach (var order in orders)
            {
                Console.WriteLine($"OrderID: {order.OrderID}, Amount: {order.Amount}");
            }
        }

        // 7. Get Employees along with their Manager's Name
        public void GetEmployeesWithManagers()
        {
            var result = _context.Employees
                                 .Include(e => e.Manager)
                                 .ToList();

            foreach (var emp in result)
            {
                string managerName = emp.Manager != null ? $"{emp.Manager.FirstName} {emp.Manager.LastName}" : "No Manager";
                Console.WriteLine($"Employee: {emp.FirstName} {emp.LastName}, Manager: {managerName}");
            }
        }

        // 8. Get Employee with Max Salary
        public void GetMaxSalaryEmployee()
        {
            var emp = _context.Employees
                              .OrderByDescending(e => e.Salary)
                              .FirstOrDefault();

            if (emp != null)
                Console.WriteLine($"Max Salary: {emp.FirstName} {emp.LastName} - {emp.Salary}");
        }

        // 9. Group Employees by Department and show average salary
        public void GetAverageSalaryByDepartment()
        {
            var result = _context.Employees
                                 .GroupBy(e => e.DepartmentID)
                                 .Select(g => new
                                 {
                                     DeptId = g.Key,
                                     AverageSalary = g.Average(e => e.Salary)
                                 });

            foreach (var item in result)
                Console.WriteLine($"DeptId: {item.DeptId}, Average Salary: {item.AverageSalary}");
        }

        //LINQ Query (Query Syntax):
        public void GroupEmployeesByDepartment()
        {
            var result = from emp in _context.Employees
                         join dept in _context.Departments
                         on emp.DepartmentID equals dept.DepartmentID
                         group dept by dept.DepartmentName into g
                         select new
                         {
                             DepartmentName = g.Key,
                             Count = g.Count(),
                         };

            foreach (var item in result)
                Console.WriteLine($"{item.DepartmentName} has total employees : {item.Count}");

            //var Test = from emp in _context.Employees
            //           join dept in _context.Departments
            //           on emp.DepartmentID equals dept.DepartmentID
            //           group dept by dept.DepartmentName into g
            //           select new
            //           {
            //               DepartmentName = g.Key,
            //               Count = g.Count(),
            //           };

            //Join with LINQ Method Syntax:
            //var result1 = _context.Employees
            //              .Join(_context.Departments,
            //              emp=> emp.DepartmentID,
            //              dept=> dept.DepartmentID,
            //              (emp,dept)=> new { DepartmentName = dept.DepartmentName })
            //              .GroupBy(e => e.DepartmentName)
            //              .Select(g=> new
            //              {
            //                  DepartmentName = g.Key,
            //                  Count = g.Count()
            //              });




        }





        // 10. Get Employees who joined after a specific date
        public void GetEmployeesJoinedAfter(DateTime date)
        {
            var employees = _context.Employees
                                    .Where(e => e.JoiningDate > date)
                                    .ToList();

            foreach (var e in employees)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} joined on {e.JoiningDate.ToShortDateString()}");
            }
        }

        //Joins
        public void InnerJoin()
        {
            var test = _context.CustomerOrders.ToList();
            var orderUsers1 = _context.CustomerOrders
            .Select(CustomerOrders => new
            {
                CustomerOrders.OrderID,
                CustomerOrders.TotalAmount,
                CustomerOrders.User.UserName  // Directly accessing UserName
            })
            .ToList();
            var orderUsers = _context.CustomerOrders
            .Join(_context.Users,
             CustomerOrder => CustomerOrder.UserID,
             user => user.UserID,
            (CustomerOrder, user) => new { CustomerOrder.OrderID, CustomerOrder.TotalAmount, user.UserName })
            .ToList();

            foreach (var item in orderUsers)
            {
                Console.WriteLine($"Order ID: {item.OrderID}, Total Amount: {item.TotalAmount}, User: {item.UserName}");
            }
        }

        public void InnerJoinWithThreeTables()
        {

            var result = _context.OrderDetails
            .Join(_context.CustomerOrders,
            od => od.OrderID,  // Foreign Key in OrderDetails
            co => co.OrderID,  // Primary Key in CustomerOrders
            (od, co) => new { od, co }) // Combine OrderDetails & CustomerOrders
            .Join(_context.Users,
            temp => temp.co.UserID,  // Foreign Key in CustomerOrders
            u => u.UserID,           // Primary Key in Users
            (temp, u) => new         // Combine with Users
            {
                u.UserName,
                temp.od.ProductName,
                temp.co.TotalAmount,
                temp.co.Discount,
                temp.od.Quantity
            })
            .ToList();



            var orderDetails = _context.CustomerOrders
            .Join(_context.OrderDetails,
            CustomerOrder => CustomerOrder.OrderID,
            OrderDetail => OrderDetail.OrderID,
            (CustomerOrder, OrderDetail) => new { CustomerOrder, OrderDetail })
            .Join(_context.Users,
            OrderUser => OrderUser.CustomerOrder.UserID,
            user => user.UserID,
            (OrderUser, user) => new { OrderUser.CustomerOrder.OrderID, OrderUser.CustomerOrder.TotalAmount, user.UserName, OrderUser.OrderDetail.ProductName })
            .ToList();
            foreach (var item in orderDetails)
            {
                Console.WriteLine($"Order ID: {item.OrderID}, Total Amount: {item.TotalAmount}, User: {item.UserName}, Product: {item.ProductName}");
            }
        }
        public void LeftJoin()
        {
            var leftJoinQuery = _context.CustomerOrders
            .GroupJoin(_context.Users,
                order => order.UserID,
                user => user.UserID,
                (order, users) => new { order, users })
            .SelectMany(x => x.users.DefaultIfEmpty(), (order, user) => new
            {
                OrderID = order.order.OrderID,
                TotalAmount = order.order.TotalAmount,  // Handle possible null value
                UserName = user != null ? user.UserName ?? "No User" : "No User"
            })
            .ToList();

            foreach (var item in leftJoinQuery)
            {
                Console.WriteLine($"");
            }

        }

        public void RightJoin()
        {
            //var rightJoinQuery = _context.Users
            //.GroupJoin(_context.CustomerOrders,
            //    user => user.UserID,  // Primary Key in Users
            //    order => order.UserID,  // Foreign Key in CustomerOrders
            //    (user, orders) => new { user, orders }) // GroupJoin preserves all users
            //.SelectMany(x => x.orders.DefaultIfEmpty(), (user, order) => new
            //{
            //    UserID = user.user.UserID,
            //    UserName = user != null ? user.user.UserName : "no user",
            //    OrderID = order != null ? order.OrderID : 0,  // Handle NULL case safely
            //    TotalAmount = order != null ? (decimal?)order.TotalAmount : null  // Nullable decimal
            //})
            //.ToList();

            var rightJoinQuery = _context.Users // Start with Users to simulate Right Join
    .GroupJoin(_context.CustomerOrders,
        user => user.UserID,
        order => order.UserID,
        (user, orders) => new { user, orders }) // Keep all users
    .SelectMany(x => x.orders.DefaultIfEmpty(), (user, order) => new
    {
        OrderID = order != null ? order.OrderID : (int?)null, // Nullable to match SQL result
        UserID = user.user.UserID,
        UserName = user != null ? user.user.UserName : "no user",
        Email = user != null ? user.user.Email : "No Email",
        TotalAmount = order != null ? order.TotalAmount : (decimal?)null, // Nullable decimal
        OrderDate = order != null ? order.OrderDate : null // Safe null check
    })
    .ToList();



            foreach (var item in rightJoinQuery)
            {
                Console.WriteLine($"");

            }
        }

        public void GroupBY()
        {
            var employeeCounts = _context.EmployeeGB
            .GroupBy(e => e.DeptID)
            .Select(g => new
            {
                DeptID = g.Key,
                TotalEmployees = g.Count()
            })
            .ToList();
            foreach (var employee in employeeCounts)
            {
                Console.WriteLine($"employee with departmentID is : {employee.DeptID} and totalEmployees are :  {employee.TotalEmployees}");
            }

            var employeesCouts =
                """
                SELECT d.DeptName, COUNT(e.EmpID) AS EmployeeCount
                FROM DepartmentGB d
                JOIN EmployeeGB e ON d.DeptID = e.DeptID
                GROUP BY d.DeptName;
                """;
        }

        public void AvrageSalaryOfEmployeeInEachDepartment()
        {
            var avarageSalaray = _context.EmployeeGB
                .GroupBy(e => e.DeptID)
                .Select(g => new
                {
                    DepartmentID = g.Key,
                    AvargeSalary = g.Average(e => e.Salary)
                })
                .ToList();
            foreach (var item in avarageSalaray)
            {
                Console.WriteLine($"Department : {item.DepartmentID} and AvargeSalary is {item.AvargeSalary}");
            }

            var avarageSalary =
                """
                SELECT d.DeptName, AVG(e.Salary) AS AverageSalary
                FROM DepartmentGB d
                JOIN EmployeeGB e ON d.DeptID = e.DeptID
                GROUP BY d.DeptName;
                """;
        }

        public void groupBy()
        {
            var NumberOfEmployeesInEachDepartment = _context.EmployeeGB
                .Join(_context.DepartmentGB,
                emp => emp.DeptID,
                dept => dept.DeptID,
                (emp, dept) => new { emp, dept })
                .GroupBy(e => e.dept.DeptName)
                .Select(g => new
                {
                    DepartmentName = g.Key,
                    TotalEmployees = g.Count()
                });

            var innerJoin = _context.EmployeeGB
                .Join(_context.DepartmentGB,
                emp => emp.DeptID,
                dept => dept.DeptID,
                (emp, dept) => new { emp, dept })
                .Select(e => new
                {
                    e.emp.EmpName,
                    e.emp.Salary,
                    e.dept.DeptName
                })
                .ToList();

            var result = (from e in _context.EmployeeGB
                          join d in _context.DepartmentGB on e.DeptID equals d.DeptID
                          group e by d.DeptName into g
                          select new
                          {
                              DeptName = g.Key,
                              NoOfEmployees = g.Count()
                          }).ToList();

            var result1 = (from e in _context.EmployeeGB
                           join d in _context.DepartmentGB on e.DeptID equals d.DeptID
                           select new { e.EmpName, d.DeptName }).ToList();
        }

        public void HighestSalaryEachDepartment()
        {
            var result = from e in _context.EmployeeGB
                         join d in _context.DepartmentGB on e.DeptID equals d.DeptID
                         where e.Salary == _context.EmployeeGB
                                        .Where(emp => emp.DeptID == e.DeptID)
                                        .Max(emp => emp.Salary)
                         select new
                         {
                             e.EmpName,
                             d.DeptName,
                             e.Salary
                         };

            var highestPaidEmployees = result.ToList();
            var result1 =
                """
                --Get Employees with the Highest Salary in Each Department
                SELECT e.EmpName, d.DeptName, e.Salary
                FROM EmployeeGB e
                JOIN DepartmentGB d ON e.DeptID = d.DeptID
                WHERE e.Salary = (SELECT MAX(Salary) FROM EmployeeGB WHERE DeptID = e.DeptID);
                """;

            var highestPaidEmployees1 = _context.EmployeeGB
                .Join(_context.DepartmentGB,
                      e => e.DeptID,
                      d => d.DeptID,
                      (e, d) => new { e, d })
                .Where(ed => ed.e.Salary == _context.EmployeeGB
                                               .Where(emp => emp.DeptID == ed.e.DeptID)
                                               .Max(emp => emp.Salary))
                .Select(ed => new
                {
                    ed.e.EmpName,
                    ed.d.DeptName,
                    ed.e.Salary
                })
                .ToList();




        }

        public void DuplicateRecords()
        {
            var result = _context.EmployeesDuplicate
                .GroupBy(e => new { e.EmpName })  // Grouping by EmpName
                .Where(g => g.Count() > 1)        // Filtering groups with count > 1 (like HAVING in SQL)
                .Select(g => new
                {
                    g.Key.EmpName,
                    Count = g.Count()
                })
                .ToList();
            var duplicateRecords =
                """
                --Find Duplicate Records in SQL
                SELECT FirstName, LastName, Salary, COUNT(*) AS Count
                FROM EmployeesDuplicate
                GROUP BY FirstName, LastName, Salary
                HAVING COUNT(*) > 1;
                """;
            var demo = "";
        }


        public void InMemory()
        {
            var employees = _context.Employees
                .AsNoTracking() // Use AsNoTracking for in-memory operations
                .ToList();
            //var highSalaryEmployees = employees
            //    .Where(e => e.Salary > 50000)
            //    .Select(e => new { e.FirstName, e.LastName, e.Salary })
            //    .ToList();
            //foreach (var emp in highSalaryEmployees)
            //{
            //    Console.WriteLine($"{emp.FirstName} {emp.LastName} - Salary: {emp.Salary}");
            //}



            //foreach (var emp in employees)
            //{
            //    Console.WriteLine($"{emp.FirstName} {emp.LastName} - Salary: {emp.Salary}");
            //}


            var result = _context.Employees
                .AsNoTracking() // Use AsNoTracking for in-memory operations
                .Where(e => e.Salary > 50000)
                .Select(e => e.Salary)
                .ToList();

            foreach (var e in result)
            {
                Console.WriteLine($"{e}  - Salary:");
            }


        }

        public void LinqOnEmployee()
        {
            var result = _context.Employees
                .AsNoTracking()
                .GroupBy(e => e.DepartmentID)
                .Select(e => new
                {
                    DepartmentID = e.Key,
                    TotalEmployees = e.Count(),
                }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"DepartmentID: {item.DepartmentID}, Total Employees: {item.TotalEmployees}");
            }
        }

        public void EmployeeTotalAvgSum()
        {
            var result = _context.Employees
                .AsNoTracking()
                .GroupBy(e => e.DepartmentID)
                .Select(e => new
                {
                    DepartmentID = e.Key,
                    TotalEmployees = e.Count(),
                    TotalSalary = e.Sum(emp => emp.Salary),
                    AverageSalary = e.Average(emp => emp.Salary),
                    MaxSalary = e.Max(emp => emp.Salary),
                    MinSalary = e.Min(emp => emp.Salary)
                }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"DepartmentID: {item.DepartmentID}, Total Employees: {item.TotalEmployees}, TotalSalary: {item.TotalSalary}, MaxSalary is: {item.MaxSalary}, MinSalary is : {item.MinSalary}, Average salary is : {item.AverageSalary}");
            }
        }
    }
}
