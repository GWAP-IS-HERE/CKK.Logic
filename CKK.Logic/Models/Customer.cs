namespace CKK.Logic.Models
{
    public class Customer
    {
        private int id;
        private string name = "";
        private string address = "";

        public int GetId()
        {
            return id;
        }

        public void SetId(int idIn)
        {
            id = idIn;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string nameIn)
        {
            name = nameIn;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string addressIn)
        {
            address = addressIn;
        }
    }
}
