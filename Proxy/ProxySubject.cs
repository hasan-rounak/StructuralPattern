﻿namespace StructuralDesignPattern.Proxy
{
    class ProxySubject : ISubject
    {
        private RealSubject _realSubject;
        public ProxySubject(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        public void Request()
        {
            if (this.CheckAccess())
            {
                _realSubject.Request();
                this.LogAccess();
                
            }
        }
        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}
