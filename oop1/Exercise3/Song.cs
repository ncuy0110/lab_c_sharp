namespace Exercise3
{
    public class Song
    {
        public string TypeList { get; set; } = "";
        public string Name { get; set; } = "";
        public string Time { get; set; } = "0:00";

        public Song(string? raw)
        {
            if (raw == null)
            {
                throw new ArgumentException("Song cannot null");
            }
            string[] rawArray = raw.Split('_');
            this.TypeList = rawArray[0];
            this.Name = rawArray[1];
            this.Time = rawArray[2];
        }
    }
}