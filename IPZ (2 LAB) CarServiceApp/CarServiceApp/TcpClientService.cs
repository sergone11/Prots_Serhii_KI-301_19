using System;
using System.Net.Sockets;
using System.Text;

namespace CarServiceAdministration
{
    public class TcpClientService
    {
        private TcpClient client;
        private NetworkStream stream;
        private readonly string serverIP = "127.0.0.1"; // IP сервера
        private readonly int serverPort = 5000; // Порт сервера

        public TcpClientService()
        {
            client = new TcpClient();
        }

        // Метод для підключення до сервера
        public bool ConnectToServer()
        {
            try
            {
                client.Connect(serverIP, serverPort);
                stream = client.GetStream();
                Console.WriteLine("Підключено до сервера.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка підключення: {ex.Message}");
                return false;
            }
        }

        // Метод для надсилання даних на сервер
        public string SendData(string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // Читання відповіді від сервера
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при надсиланні даних: {ex.Message}");
                return "Помилка";
            }
        }

        // Метод для відключення від сервера
        public void Disconnect()
        {
            stream.Close();
            client.Close();
            Console.WriteLine("Відключено від сервера.");
        }
    }
}
