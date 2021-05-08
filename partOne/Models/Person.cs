namespace partOne.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DNI { get; set; }
        public string ShowDatapPerson() 
        { 
            return $"{Name} {Age} {DNI}"; 
        }

        public string IsBiggerAge()
        {
            if(this.Age > 18)
            {
                return "This person is major of age";
            }else
            {
                return "This person is minor of age";
            }
        }
    }
}