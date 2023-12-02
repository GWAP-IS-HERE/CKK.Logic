using CKK.Logic.Models;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    public abstract class Entity
    {
        private int id;
        private string name = "";
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 0)
                    throw new InvalidIdException();
                id = value;
            }
        }
        public string Name { get; set; } = "";
    }
}
