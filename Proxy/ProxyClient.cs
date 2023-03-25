namespace StructuralDesignPattern.Proxy
{
    public class ProxyClient
    {
        private ISubject _subject;


        public ProxyClient(ISubject subject)
        {
            _subject = subject;
        }
        public void DoJob()
        {
            _subject.Request();
        }
    }
}
