namespace LibraryManagement.Domain.Entities
{
    public class Publication
    {
            public Guid PublicationId { get; set; }
            public int PublicationEdition { get; set; }
            public int PublicationYear { get; set; }

            //public Publication(int edition, int year)
            //{
            //    Edition = edition;
            //    Year = year;
            //}
    }
}

