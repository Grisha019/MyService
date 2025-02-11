using System;
using System.ServiceModel;
using WCFMyServiceLibrary;

namespace my_client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаём адрес нашей службы
            Uri tcpUri = new Uri("http://localhost:8000/MyService");
            // Создаём сетевой адрес, с которым клиент будет взаимодействовать
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            // Данный класс используется клиентами для отправки сообщений
            ChannelFactory<IMyService> factory = new ChannelFactory<IMyService>(binding, address);
            // Открываем канал для общения клиента с со службой
            IMyService service = factory.CreateChannel();
            Console.WriteLine(service.GetSum(3, 5));
            Console.WriteLine(service.GetSum(5, 12));
            Console.WriteLine(service.GetMult(3, 5));
            Console.WriteLine(service.GetMult(-3, 15));
            Console.WriteLine(service.SayHi());
            Console.ReadLine();
        }
    }
}