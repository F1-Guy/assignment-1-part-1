namespace assignment1
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public int ShirtNumber { get; set; }

        public void ValidateName()
        {
            if (Name.Length < 2)
            {
                throw new ArgumentOutOfRangeException("Name cannot be less than 2 characters");
            }
        }

        public void ValidateAge()
        {
            if (Age < 1)
            {
                throw new ArgumentOutOfRangeException("Age cannot be less than 1");
            }
        }

        public void ValidateNo()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99)
            {
                throw new ArgumentOutOfRangeException("Shirt number must be between 1 and 99");
            }
        }
    }
}