using System;
using System.Linq;
using PosterObjectsClassesMessages;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "1.234.567-2"); //"1.234.567-2" True
            john.IntroduceYourself();
            Person jane = new Person("Jane Doe", "8.765.432-7"); //"8.765.432-7" True
            jane.IntroduceYourself();
            Person juan = new Person("", "8.765.432-8"); 
            juan.IntroduceYourself();
            Person julio = new Person("Julio Doe", "8.765.432-5");
            julio.IntroduceYourself();
            Person juliana = new Person("","1.234.567-2");
            juliana.IntroduceYourself();  
        }
    }
}
