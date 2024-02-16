namespace GeographyQuiz.Models
{
    public class Continent
    {
        public string Name { get; set; }
        public List<Country> Countries { get; set; }
        public Continent() { }
        public Continent(string name, List<Country> countries)
        {
            Name = name;
            Countries = countries;
        }
    }
}
