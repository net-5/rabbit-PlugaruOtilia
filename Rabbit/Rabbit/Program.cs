using System;

namespace Rabbit
{
    public enum EyeColors { Blue, Red, Black};
    public enum FurColors { White, Black, Grey};
    public enum Gender { Male, Female};

    public class Mammal
    {
        public void Characteristics()
        {
            Console.WriteLine("I am a mammal and i jump all over the place, a have a lot of speed. I sleep on the grass and i eat carrots.");
        }
    }

    public class Rabbit: Mammal
    {
        private string eyes;
        private string fur;
        private string gender;
        private DateTime dateofbirth;

        public Rabbit(string eyes, string fur, string gender, string dateofbirth)
        {
            Console.WriteLine((int)Gender.Female);
            if (gender.Equals(Gender.Female) || gender.Equals(Gender.Male))
            {
                this.gender = gender;
            }
            if(eyes.Equals(EyeColors.Black) || eyes.Equals(EyeColors.Red) || eyes.Equals(EyeColors.Red))
            {
                this.eyes = eyes;
            }
            if(fur.Equals(FurColors.White) || fur.Equals(FurColors.Black)|| fur.Equals(FurColors.Grey))
            {
                this.fur = fur;
            }
            this.dateofbirth = DateTime.Parse(dateofbirth);

        }
        
        public string GetAge()
        {
            int years = DateTime.Now.Subtract(this.dateofbirth).Days / 365;
            int days = DateTime.Now.Subtract(this.dateofbirth).Days % 365;
            if (years < 0 || days < 0)
            { return "unborn"; }
            else if (years == 0)
            { return days + " days"; }
            else
            {
                return (years + " years and " + days + " days");
            }
        }
        public override string ToString()
        {
            return "I'm a rabbit. My eyes are " + this.eyes + ", my fur is " + this.fur + ". I am a " + this.gender + " and I'm born in " + this.dateofbirth.ToShortDateString() + " , so I'm " + this.GetAge() + " old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            Rabbit tuptup = new Rabbit("Blue", "Black", "Male", "10,01,2018");
            tuptup.Characteristics();
            Console.WriteLine(tuptup);

            
        }

        
    }
}
