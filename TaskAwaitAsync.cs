namespace ConsoleProjectLearing
{
    public class TaskAwaitAsync
    {
        public void HaveDinner()
        {
            Console.WriteLine("Order food at the restaurant");
            CookFood();  // Blocking call
            Console.WriteLine("Eat the food");
        }

        public void CookFood()
        {
            Console.WriteLine("I am from CookFood ");
            Thread.Sleep(5000);  // Simulate 5 seconds cooking time
            Console.WriteLine("Food is ready!");
        }

        //public async Task HaveDinnerAsync()
        //{
        //    Console.WriteLine("Order food at the restaurant");

        //    Task cookTask = CookFoodAsync();  // Start cooking food asynchronously

        //    Console.WriteLine("Read a book while waiting for the food");
        //    await cookTask;  // Wait for the food to be ready

        //    Console.WriteLine("Eat the food");
        //}

        //public async Task CookFoodAsync()
        //{
        //    await Task.Delay(5000);  // Simulate 5 seconds cooking asynchronously
        //    Console.WriteLine("Food is ready!");
        //}

        public async Task HaveDinnerAsync()
        {
            Console.WriteLine("Order food at the restaurant");

            Task cookTask = CookFoodAsync();  // Start cooking food asynchronously

            Console.WriteLine("Read a book while waiting for the food");
            await ReadBookAsync();            // Simulate reading a book that takes longer

            await cookTask;                   // Wait for the food to be ready

            Console.WriteLine("Eat the food");
        }

        public async Task CookFoodAsync()
        {
            await Task.Delay(5000);           // Simulate cooking for 5 seconds
            Console.WriteLine("Food is ready!");
        }

        public async Task ReadBookAsync()
        {
            await Task.Delay(7000);           // Simulate reading for 7 seconds
            Console.WriteLine("Finished reading the book");
        }

        //private readonly IApiService _apiService;

        //public HomeController(IApiService apiService)
        //{
        //    _apiService = apiService;
        //}

        //public async Task<IActionResult> Index()
        //{
        //    // Start fetching data from APIs asynchronously
        //    Task<List<User>> usersTask = _apiService.GetUsersAsync();
        //    Task<List<Order>> ordersTask = _apiService.GetOrdersAsync();
        //    Task<List<Product>> productsTask = _apiService.GetProductsAsync();

        //    // Await all tasks to complete
        //    await Task.WhenAll(usersTask, ordersTask, productsTask);

        //    // Get the results
        //    var users = await usersTask;
        //    var orders = await ordersTask;
        //    var products = await productsTask;

        //    // Combine the data as needed
        //    var viewModel = new CombinedViewModel
        //    {
        //        Users = users,
        //        Orders = orders,
        //        Products = products
        //    };
        //}
    }
}
