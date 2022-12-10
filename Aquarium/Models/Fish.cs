namespace Aquarium.Models
{
    public class Fish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Length { get; set; }

        public void ValidateName()
        {
            if (Name == null) throw new ArgumentNullException(nameof(Name));
            if (Name.Length < 2) throw new ArgumentException(nameof(Name));
        }
        public void ValidateLength()
        {
            if(Length == null) throw new ArgumentNullException(nameof(Length));
            if(Length <= 0) throw new ArgumentOutOfRangeException(nameof(Length));
        }

        public void Validate()
        {
            ValidateName();
            ValidateLength();
        }
        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name + " Length: " + Length;
        }
    }
}
