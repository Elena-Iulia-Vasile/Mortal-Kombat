namespace Fighter
{
    public class Warrior : BaseFighter
    {

        public int NumberOfWeapons { get; set; }

        Notifier notifier = new Notifier();
        public Warrior(string name, int numberOfWeapons) : base(name, 100, 102, 98)
        {
            NumberOfWeapons = numberOfWeapons;
            Console.WriteLine("It was created with succes a Warrior fighter!");
        }

        public override void Hit(BaseFighter fighter)
        {
            fighter.HealthPoints -= 0.1f * this.Power - 0.1f * this.Life;
            notifier.Notifie(fighter, "Hit");
        }

        public override void Punch(BaseFighter fighter)
        {
            Random random = new Random();
            int randomNumber = random.Next(5, 14);
            fighter.Life -= randomNumber;
            notifier.Notifie(fighter, "Punch");
        }

        public override void DoubleHit(BaseFighter fighter)
        {
            Random random = new Random();
            int randomNumber = random.Next(8, 12);
            fighter.Power -= randomNumber / 100 * this.Power;
            int randomNumber2 = random.Next(6, 10);
            fighter.HealthPoints -= randomNumber2 / 100 * this.HealthPoints;
            fighter.Life -= randomNumber2;
            notifier.Notifie(fighter, "DoubleHit");
        }

        public override void Kick(BaseFighter fighter)
        {
            if (this.Power >= 40 && this.HealthPoints >= 50)
            {
                fighter.Power -= 0.25f * this.Power;
                fighter.HealthPoints -= 0.25f * this.HealthPoints;
            }
            else
            {
                fighter.Power -= 0.2f * fighter.Power;
                fighter.HealthPoints -= 0.2f * fighter.HealthPoints;
            }
            notifier.Notifie(fighter, "Kick");
        }

        public override void SpecialAbillity(BaseFighter fighter)
        {
            if (NumberOfWeapons > 0)
            {
                fighter.HealthPoints -= 2 * NumberOfWeapons;
                NumberOfWeapons--;
            }
            notifier.Notifie(fighter, "SpecialAbillity");
        }
    }
}
