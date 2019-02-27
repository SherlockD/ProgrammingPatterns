#region INFO
/*
    Паттерн заместитель
    
    В примере сервис, доступ к которому можно получить через заместитель
    
    Service service = new Service();
            Proxy proxy = new Proxy(service);
            
            Console.WriteLine(proxy.GetSomeData());
            Console.WriteLine(proxy.GetSomeData1());
*/
#endregion

namespace ProgrammingPatters.Patterns.Structural
{
    interface IService
    {
        string GetSomeData();
        string GetSomeData1();
    }
    
    class Service:IService
    {
        public string GetSomeData() => "Some data";
        public string GetSomeData1() => "Some data1";
    }

    class Proxy : IService
    {
        private Service _service;

        public Proxy(Service service)
        {
            _service = service;
        }
        
        public string GetSomeData()
        {
            if (GetAccess())
            {
                return _service.GetSomeData();
            }

            return string.Empty;
        }

        public string GetSomeData1()
        {
            if (!GetAccess())
            {
                return _service.GetSomeData1();
            }

            return string.Empty;
        }

        private bool GetAccess() => true;
    }
}