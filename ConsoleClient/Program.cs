using Newtonsoft.Json;

namespace MyMessanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Iambakhh", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{ "UserName":"Iambakhh","MessageText":"Privet","TimeStamp":"2023-05-09T07:26:26.0282108Z"}
            //Console.WriteLine(msg.ToString());
            //Console.WriteLine("Hello, World!");
        }
    }
}