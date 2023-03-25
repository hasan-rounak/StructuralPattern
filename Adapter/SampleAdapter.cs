namespace StructuralDesignPattern.Adapter
{
    public class SampleAdapter:ITarget
    {
        private Adaptee _adaptee;
        public SampleAdapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            Console.WriteLine("Called GetRequest in SampleAdapter");
            return this._adaptee.GetSpecificRequest();
        }
    }
}
