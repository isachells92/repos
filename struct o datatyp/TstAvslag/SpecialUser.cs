namespace TstAvslag
{
    struct SpecialUser
    {
        public const string Name = "Anna Andersson";
        public string Location { get; set; }
        public int Age { get; set; }

        public SpecialUser(string location, int age)
        {
            Location = location;
            Age = age;
        }
    }
}
