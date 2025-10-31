// Data model for the Pets table in the SQLite database
namespace VirtualPetAdoption.Models
{
    public class Pet
    {
        // Attributes for the Pet class
        // describe pet
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int EnergyLevel { get; set; }
    } //end Pet class
} //end namespace