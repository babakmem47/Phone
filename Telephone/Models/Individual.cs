
namespace Telephone.Models
{
    public class Individual
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Gender { get; set; }

        public string TelDirect { get; set; }

        public string TelInternal { get; set; }

        public string Mobile { get; set; }

        public string WorkPlace { get; set; }

        public string FieldOfActivity { get; set; }

        public Setad Setad { get; set; }

        public int? SetadId { get; set; }

        public string Description { get; set; }
    }
}