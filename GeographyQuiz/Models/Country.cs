namespace GeographyQuiz.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public Country() { }
        public Country(string name, string capital)
        {
            Name = name;
            Capital = capital;
        }
    }
}
