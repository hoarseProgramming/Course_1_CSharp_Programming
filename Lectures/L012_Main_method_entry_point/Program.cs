namespace L012_Main_method_entry_point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";

            NonStaticLocalFunctionPrintHello();
            StaticLocalFunctionPrintHello(greeting);
            StaticMethodPrintHello();

            void NonStaticLocalFunctionPrintHello()
            {
                Console.WriteLine(greeting);
            }
            static void StaticLocalFunctionPrintHello(string greeting)
            {
                Console.WriteLine(greeting);
            }
        }

        
        private static void StaticMethodPrintHello()
        {
            Console.WriteLine("Hello");
        }
    }    
}
