using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUdemyLearningProject
{
    internal class ErsteKlasse
    {
        public class Human
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string  eyeColor { get; set; }
            public int age { get; set; }
            public Human(string firstName = "Vorname", string lastName="Nachname", string eyeColor ="keine", int age = 0)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.eyeColor = eyeColor;
                this.age = age;
            }

            public void IntroduceYourSelf()
            {
                if (this.firstName == "Vorname") this.firstName = "Max";
                if (this.lastName == "Nachname") this.lastName = "Muster";
                Console.WriteLine($"Hallo mein Name ist {firstName} {lastName} bin {age} und habe {eyeColor.ToLower()}e Augen");
            }
        }
    }
}
