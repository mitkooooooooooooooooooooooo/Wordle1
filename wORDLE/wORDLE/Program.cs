using static System.Net.Mime.MediaTypeNames;

namespace Wordle
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            Application.Run(new WordleForm());
        }
    }
}