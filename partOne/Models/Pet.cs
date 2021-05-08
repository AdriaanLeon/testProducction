namespace partOne.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Raza { get; set; }
        public string TypeAnimal { get; set; }
        public string ShowDataPet(){
            return $"{this.Name} {this.Age} {this.Raza} {this.TypeAnimal}";
        }                
    }
}