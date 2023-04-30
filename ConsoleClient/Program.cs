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
            //Console.WriteLine(msg.ToString());
            //Console.WriteLine("Hello, World!");
        }
    }
}