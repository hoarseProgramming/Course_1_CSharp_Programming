var dbReader = new DataBaseReader("192.168.0.1", "hoarseServer");
ShoppingCart databaseCart = new ShoppingCart(dbReader);

databaseCart.LoadProducts();
databaseCart.ShowProducts();

var fileReader = new FileReader("products.txt");
ShoppingCart fileCart = new ShoppingCart(fileReader);

fileCart.LoadProducts();
fileCart.ShowProducts();

class Product
{
    public string Name { get; set; }
    public Product(string name)
    {
        Name = name;
    }

}

class ShoppingCart
{
    private List<Product> products;
    private IReader reader;

    public ShoppingCart(IReader reader)
    {
        this.reader = reader;
    }
    public void ShowProducts()
    {
        products.ForEach(p => Console.WriteLine(p.Name));
    }
    public void LoadProducts()
    {
        products = reader.LoadProducts();
    }

    //Still hard coded what class is used while loading

    //public void LoadProducts()
    //{
    //    var reader = new DataBaseReader(); //New is glue.
    //    products = reader.LoadProducts();
    //}

    //Moved to databasereader class

    //public void LoadProducts()
    //{
    //    Console.WriteLine("Loading products from database");
    //    // Code that reads products from a database.Simulated

    //    products = new List<Product>();
    //    products.Add(new Product("database product A"));
    //    products.Add(new Product("database product B"));
    //}
}

class DataBaseReader : IReader
{
    private string serverName;
    private string databaseName;

    public DataBaseReader(string serverName, string databaseName)
    {
        this.serverName = serverName;
        this.databaseName = databaseName;
    }

    public List<Product> LoadProducts()
    {
        Console.WriteLine($"Loading products from database {databaseName} on server {serverName}");
        // Code that reads products from a database.Simulated

        var products = new List<Product>();
        products.Add(new Product("database product A"));
        products.Add(new Product("database product B"));

        return products;
    }
}

class FileReader : IReader
{
    private string filePath;

    public FileReader(string filePath)
    {
        this.filePath = filePath;
    }

    public List<Product> LoadProducts()
    {
        Console.WriteLine($"Loading products from {filePath}");
        // Code that reads products from a file. Simulated

        var products = new List<Product>();
        products.Add(new Product("file product A"));
        products.Add(new Product("file product B"));
        products.Add(new Product("file product C"));

        return products;
    }
}

interface IReader
{
    public List<Product> LoadProducts();
}