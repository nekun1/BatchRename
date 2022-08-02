namespace Batch_Rename
{
    class Program
	{
        static void Main()
	    {
            List<string> filenames = new();
            string path = ReceiveInput("Please enter the file's full path: ");
            AddFilenames(path);

        } 
        static string ReceiveInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
        static void AddFilenames(string path)
        {
            List<string> filenames = new();
            foreach (string line in File.ReadLines(@path))
            {
                filenames.Add(line);
            }
        }
        static void Rename()
        {
            int index = 1;
            foreach (string filename in filenames)
            {
                File.Move(@$"G:\Gry\Darkest Dungeon\audio\secondary_banks\Fmod Bank Tools\wav\{filename}.wav", @$"G:\Gry\Darkest Dungeon\audio\secondary_banks\Fmod Bank Tools\wav\{filename}");
                index++;
            }
        }
	}
}