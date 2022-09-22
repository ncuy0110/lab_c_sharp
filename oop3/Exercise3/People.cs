namespace Exercise3
{
    public class People
    {
        private string? name;
        public string? GetName() => name;

        public void SetName(string? name_)
        {
            if (name_ == null || name_.Equals(""))
            {
                throw new Exception("Invalid name!");
            }
            this.name = name_;
        }

    }
}