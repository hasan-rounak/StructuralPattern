using StructuralDesignPattern.Facade;
using StructuralDesignPattern.Proxy;
using StructuralDesignPattern.Adapter;

namespace StructuralDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("======== Structural Design Patern ============\n");
            //Console.WriteLine("Facade : provides a simplified (but limited) interface to a complex system of classes, library or framework.\n");
            //ApplicationFacade facade = new(
            //    new Subsystem1(), new Subsystem2());
            //FacadeClient.DoJob(facade);
            //Console.WriteLine();



            ////Console.WriteLine("Proxy: provides an object that acts as a substitute for a real service object./n");
            //RealSubject subject = new();
            //ProxyClient proxyClient = new(subject);
            ////Console.WriteLine("Client: Executing the client code with a real subject:");
            ////proxyClient.DoJob();
            ////Console.WriteLine();

            //proxyClient = new(new ProxySubject(subject));
            //Console.WriteLine("Client: Executing the client code with a Proxy subject:");
            //proxyClient.DoJob();
            //Console.WriteLine();

            Console.WriteLine("Adapter : allows incompatible objects to collaborate.");
            ITarget target = new SampleAdapter(new Adaptee());
            Console.WriteLine(target.GetRequest());

        }
    }
}