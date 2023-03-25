namespace StructuralDesignPattern.Facade
{
    public class FacadeClient
    {
        public static void DoJob(ApplicationFacade facade)
        {
           Console.WriteLine( facade.Operation());
        }
    }
}
