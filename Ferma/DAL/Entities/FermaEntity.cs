using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class FermaEntity : IDeletable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public int AmountOfAnimals { get; set; }
        public bool IsDelete { get; set; }
        public double Cost { get; set; }
    }
}
