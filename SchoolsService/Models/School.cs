using System;

namespace SchoolsService.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Established { get; set; }
        public string PhoneNumber { get; set; }
    }
}