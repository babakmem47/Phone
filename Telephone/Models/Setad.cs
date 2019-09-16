using System.Collections.Generic;

namespace Telephone.Models
{
    public class Setad
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Individual> Persons { get; set; }
    }
}