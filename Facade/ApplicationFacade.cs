namespace StructuralDesignPattern.Facade
{
    public class ApplicationFacade
    {
        private protected  Subsystem1 _subsystem1;
        private protected Subsystem2 _subsystem2;
        public ApplicationFacade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;   
        }
        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1.Operation1();
            result += this._subsystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.OperationN();
            result += this._subsystem2.OperationZ();
            return result;
        }
    }
}
