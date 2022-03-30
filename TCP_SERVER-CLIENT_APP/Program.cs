using System.Net;
using System.Net.Sockets;

namespace SERVER_APP
{
    class Program
    {
        const int port = 5500;
        static TcpListener? listener;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите максимальное количество одновременных подключений..");

                var connections = Console.ReadLine();

                while (connections?.All(char.IsNumber) != true)
                {
                    Console.WriteLine("Неверно введеный параметр. Введите новое значение");

                    connections = Console.ReadLine();
                }

                int conn = Convert.ToInt32(connections);

                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
                listener.Start(conn);

                Console.WriteLine($"Сервер запущен с максимальным количеством одновременных подключений в количестве {conn}");

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    ClientObject clientObject = new(client);

                    Thread clientThread = new(new ThreadStart(clientObject.Process));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (listener != null)
                    listener.Stop();
            }
        }
    }
}