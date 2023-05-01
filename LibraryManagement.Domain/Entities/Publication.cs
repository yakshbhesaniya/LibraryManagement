namespace LibraryManagement.Domain.Entities
{
    public class Publication
    {
            public Guid PublicationId { get; set; }
            public int Edition { get; set; }
            public int Year { get; set; }

            //public Publication(int edition, int year)
            //{
            //    Edition = edition;
            //    Year = year;
            //}
    }
}

