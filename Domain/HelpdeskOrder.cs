using System;

namespace Domain
{
    public class HelpdeskOrder
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Attachements { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedBy { get; set; }
        public int Category { get; set; }
        public int Priority { get; set; }
    }
}
