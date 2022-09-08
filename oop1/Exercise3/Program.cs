namespace Exercise3
{

    internal partial class Program
    {
        private static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                songs.Add(new Song(Console.ReadLine()));
            }

            string? type = Console.ReadLine();
            if (type != null)
            {
                if (type.Equals("all"))
                {
                    songs.ForEach(song => Console.WriteLine(song.Name));
                }
                else
                {
                    songs.FindAll(song => song.TypeList.Equals(type))
                        .ForEach(song => Console.WriteLine(song.Name));
                }
            }
        }
    }
}