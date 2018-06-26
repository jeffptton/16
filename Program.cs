using System;
using System.Diagnostics;

namespace MyStory
{
    class Program
    {


        static void Main(string[] args)
        {

            ProcessStartInfo flygirl = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            flygirl.Arguments = "https://cdn.pixabay.com/photo/2014/11/16/23/39/superhero-534120_960_720.jpg";
            ProcessStartInfo superheroattack = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            superheroattack.Arguments = "https://orig00.deviantart.net/939a/f/2016/109/8/7/black_panther___transparent_background__by_camo_flauge-d9zgpl6.png";



            Console.WriteLine("This story takes place in Compton ,Ca in the Year of 1994");
            Console.ReadKey();
            Console.WriteLine("The Crenshaw Mafia had a plan to take over but was the hood to do with no proteection");
            Console.ReadKey();
            Console.WriteLine("Then a flash of light shot from the sky to the middle of Caldwell St.");
            Process.Start(flygirl);
            Console.ReadKey();
            Console.WriteLine("There is no need to fear .. ya girl  is here !!");
            Console.ReadKey();
            Console.Write("The ground begin to rumble and shake.. then a dark cloud appered his name was [enter name]");
            string Cray = Console.ReadLine();
            Console.ReadKey();
            SuperVillain Villain = new SuperVillain(Cray, 100, 7, "Fast Hands");
            Console.WriteLine("Please name the superhero of Compton  [Enter name]");
            string HERO = Console.ReadLine();
            Console.ReadKey();
            SuperHero SHero = new SuperHero(HERO, 100, 95, "kick ass");
            Console.ReadKey();
            Console.WriteLine("Please name the superhuman of Compton  [Enter name]");
            string Sly = Console.ReadLine();
            Console.ReadKey();
            SuperHuman Phuman = new SuperHuman(Sly, 88, 110);
            Console.WriteLine("{0} and {1} had two little kids that was known around the way who like to code ..", HERO, Sly, Cray);
            Console.ReadKey();
            Console.Write(" KayKay  and [enter name] were most defintly gone hold it down   ", Cray);
            string AHero = Console.ReadLine();
            Console.ReadKey();
         
            Console.WriteLine("{0} got them hands no doubt and with the support of the love in Compton the Good Guys could take down any evil !", HERO);
            Console.WriteLine("But as we all know Crenshaw Mafia wasnt having that..l {0} was ready to slide on somebody to end this beef once and for all ", Cray);
            Console.ReadKey();
            Console.WriteLine("After waiting all day the sun goes down .... and BLAM {0} had popped up on the scene ready to regulate ", Cray);
            Console.ReadKey();
            Console.WriteLine("{0} went into attack mode right away with  her kick ass strength", HERO, SHero._strength);
            Console.ReadKey();
            Process.Start(superheroattack);
            Console.ReadKey();
            int Vhp = Villain._hp;
          
            Console.WriteLine("{0}'s health points diminished to {1}", Cray, Vhp);
            Console.ReadKey();
            Console.WriteLine("{0} attacked {1} next with her {2} attack.", HERO, Cray, Phuman._strength);
            Console.ReadKey();
            Vhp -= Phuman._strength;
            Console.WriteLine("{0}'s hp diminished to {1}", Cray, Vhp);
            Console.ReadKey();
            Process.Start(superheroattack);
            Console.ReadKey();

        }
    }
}
       
          