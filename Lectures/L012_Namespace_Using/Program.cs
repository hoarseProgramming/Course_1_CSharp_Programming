//Using as loading namespaces to use for the code
using myNamespace.anotherNamespace;
using myNamespace;
//Alternative namespace definition
//namespace myNamespace; Puts all the code in the document in a namespace

myNamespace.Cat.SayHello();

myNamespace.anotherNamespace.Dog.SayHello();

namespace myNamespace
{
    class Cat
    {
        static public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}
namespace myNamespace.anotherNamespace
{
    class Dog
    {
        static public void SayHello()
        {
            Console.WriteLine("Hello! I'm a dog");
        }
    }
}


