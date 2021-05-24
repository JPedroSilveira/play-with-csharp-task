using System.Threading.Tasks;

namespace playWithCsharpTasks
{
    class Program
    {
        static async Task Main(string[] args)
        {
           await RunPlayOne();
        }

        private static Task RunPlayOne()
        {
            return PlayOne.Run();
        }

        private static Task RunPlayTwo()
        {
            return PlayTwo.Run();
        }
    }
}
