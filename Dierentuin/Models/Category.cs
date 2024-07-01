namespace Dierentuin.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Animals> Animals { get; set; }
    }
}
