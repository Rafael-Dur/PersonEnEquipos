using System; 
 
namespace PosterObjectsClassesMessages 
{ 
    public class Person 
    { 
        //REFERENCIA: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
        private string name; 

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if(String.IsNullOrEmpty(value) )
                {
                    Console.WriteLine("El nombre es inválido");
                    name = "Error";
                }

                else
                {
                    name = value;
                }
            }
        }

        private string id; 

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                if(!IdUtils.IdIsValid(value))
                {
                    Console.WriteLine("El ID es inválido");
                    id = "Error";
                }

                else
                {
                    id = value;
                }
            }

        }

        public Person(string name, string id) 
        { 
            Name = name; 
            Id = id; 
        } 

        public void IntroduceYourself() 
        { 
            Console.WriteLine( 
                $"Soy {this.name} y mi cédula es {this.id}"); 
        } 
    } 
}