using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Army army = new Army();
            army.SelectSoldiers();
        }

        class Army
        {
            private List<Soldier> _soldiers;

            public Army()
            {
                _soldiers = new List<Soldier>();
                _soldiers.Add(new Soldier("John", Armament.AssaultRifle, MillitaryRank.Sergeant));
                _soldiers.Add(new Soldier("Olivia", Armament.GrenadeBased, MillitaryRank.Corporal));
                _soldiers.Add(new Soldier("Josh", Armament.SubmachineGun, MillitaryRank.Major));
                _soldiers.Add(new Soldier("Mark", Armament.Pistol, MillitaryRank.General));
                _soldiers.Add(new Soldier("Frank", Armament.GrenadeBased, MillitaryRank.Private));
                _soldiers.Add(new Soldier("Lucas", Armament.MishineGun, MillitaryRank.Colonel));
            }

            public void SelectSoldiers()
            {
               var soldiers =  _soldiers.Select(soldier => new { Name = soldier.Name, MillitaryRank = MillitaryRank.Corporal});

                foreach (var soldier in soldiers)
                {
                    Console.WriteLine($"Имя:{soldier.Name} / Звание:{soldier.MillitaryRank}");
                }
                Console.ReadKey();
            }
        }

        class Soldier
        {
            public string Name { get; private set; }
            public Armament Armament { get; private set; }
            public MillitaryRank MillitaryRank { get; private set; }

            public int MilitaryServiceInMonths { get; private set; }

            public Soldier (string name, Armament armament, MillitaryRank millitaryRank, int militaryServiceInMonths = 12)
            {
                Name = name;
                Armament = armament;
                MillitaryRank = millitaryRank;
                MilitaryServiceInMonths = militaryServiceInMonths;
            }

            public void ShowInfo() => Console.WriteLine($"{Name} - {MillitaryRank} - {Armament} - {MilitaryServiceInMonths}");
        }

        public enum Armament
        {
            Pistol,
            SubmachineGun,
            AssaultRifle,
            MishineGun,
            GrenadeBased
        }

        public enum MillitaryRank
        {
            Private,
            Corporal,
            Sergeant,
            Major,
            Captain,
            Colonel,
            General
        }
    }
}
