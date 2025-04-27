namespace DbOperationWithEFCoreApp.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Tital { get; set; }
        public string Description { get; set; }
        public int NoOfPage { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateOn { get; set; }
        public int LanguageId { get; set; }

        public Language Language { get; set; } = null!;

    }
}
