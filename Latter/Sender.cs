using RabbitMQ.Client;
using System;
using System.Text;

namespace Producer
{
    class Sender
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName="localhost"};
            using(var connection = factory.CreateConnection())
            {
                using(var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("BasicTest", false, false, false, null);
                    string message = "Start with microservice";
                    var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish("", "BasicTest", null,body);
                    Console.WriteLine("Send message {0}",message);
                }
            }

            Console.WriteLine("Press [ENTER] to exit");
            Console.ReadKey();
        }
    }
}
