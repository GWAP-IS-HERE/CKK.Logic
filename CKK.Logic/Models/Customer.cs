using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Customer : Entity
    {
        public string Address { get; set; } = "";


        /* No longer necessary
        public int Id
        {
            return Id;
        }

        public void SetId(int IdIn)
        {
            Id = IdIn;
        }

        public string Name
        {
            return Name;
        }

        public void SetName(string nameIn)
        {
            Name = nameIn;
        }

        public string Address
        {
            return address;
        }

        public void SetAddress(string addressIn)
        {
            address = addressIn;
        }*/
    }
}
