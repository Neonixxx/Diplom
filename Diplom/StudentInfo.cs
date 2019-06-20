namespace Diplom
{
    public class StudentInfo
    {
        public string FamilyName { get; set; }

        public string Name { get; set; }

        public string Group { get; set; }

        public override string ToString()
            => $"{FamilyName} {Name}, {Group}";
    }
}