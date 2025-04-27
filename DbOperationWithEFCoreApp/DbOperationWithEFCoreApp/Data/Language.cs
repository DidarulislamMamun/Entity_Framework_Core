namespace DbOperationWithEFCoreApp.Data
{
    public class Language
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
