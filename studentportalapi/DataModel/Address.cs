namespace studentportalapi.DataModel
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }


        //Naviagation properties

        public Guid StudentId { get; set; }








    }
    
}
