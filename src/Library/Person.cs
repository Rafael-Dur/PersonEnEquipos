using System; 
 
namespace PosterObjectsClassesMessages 
{ 
    public class Person 
    { 
        public string name; 

        private string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if(String.IsNullOrEmpty(value) )
                {
                    Console.WriteLine("El nombre es inválido");
                    this.name = "Error";
                }

                else
                {
                    this.name = value;
                }
            }
        }

        public string id; 

        public Person(string name, string id) 
        { 
            this.name = name; 
            this.id = id; 
        } 

        public void IntroduceYourself() 
        { 
            Console.WriteLine( 
                $"Soy {this.name} y mi cédula es {this.id}"); 
        } 
    } 

    class Program 
    { 
        static void Main(string[] args) 
        { 
            Person john = new Person("John Doe", "1.234.567-8"); 
            Person jane = new Person("Jane Doe", "8.765.432-1"); 
            john.IntroduceYourself(); 
            jane.IntroduceYourself(); 
        } 
    } 
}