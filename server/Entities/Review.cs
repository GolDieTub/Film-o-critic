using System;

namespace server.Entities
{
    public class Review 
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }

        public string Message { get; set; }

        public string Mark { get; set; }

       public string Summary { get; set; }

    }
}
