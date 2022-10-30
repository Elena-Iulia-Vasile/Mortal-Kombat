namespace Fighter
{
    public class Sonya : BaseFighter
    {
        private readonly int agility;

        Notifier notifier = new Notifier();
        public Sonya(string name, int agility) : base(name, 100, 80, 100)
        {
            this.agility = agility;
            switch (this.agility)
            {
                case 10:
                    Power += 0.1f * Power;
                    break;
                case 20:
                    Power += 0.2f * Power;
                    break;
                case 30:
                    Power += 0.3f * Power;
                    break;
                default:
                    Power = Power;
                    break;
            }
            Console.WriteLine("It was created with succes a Sonya fighter!");
        }

        public override void Hit(BaseFighter fighter)
        {
            if (this.Power >= 55 && this.Life >= 60)
                fighter.HealthPoints -= 0.5f * this.Power - 0.1f * this.Life;
            else
                fighter.HealthPoints -= this.HealthPoints * 0.1f;
            notifier.Notifie(fighter, "Hit");
        }

        public override void Punch(BaseFighter fighter)
        {
            Random random = new Random();
            int randomNumber = random.Next(4, 8);
            fighter.Life -= randomNumber;
            notifier.Notifie(fighter, "Punch");
        }

        public override void DoubleHit(BaseFighter fighter)
        {
            Random random = new Random();
            int randomNumber = random.Next(5, 7);
            fighter.Power -= randomNumber / 100 * this.Power;
            int randomNumber2 = random.Next(5, 12);
            fighter.HealthPoints -= randomNumber2 / 100 * this.HealthPoints;
            fighter.Life -= randomNumber2;
            notifier.Notifie(fighter, "DoubleHit");
        }

        public override void Kick(BaseFighter fighter)
        {
            if (this.Power >= 50 && this.HealthPoints >= 40)
            {
                fighter.Power -= 0.15f * this.Power;
                fighter.HealthPoints -= 0.15f * this.HealthPoints;
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
            switch (agility)
            {
                case 10:
                    fighter.Power = fighter.Power - 0.1f * fighter.Power;
                    fighter.Life -= 5;
                    break;
                case 20:
                    fighter.Power -= 0.2f * fighter.Power;
                    fighter.Life -= 10;
                    break;
                case 30:
                    fighter.Power -= 0.3f * fighter.Power;
                    fighter.Life -= 15;
                    break;
                default:
                    fighter.Power = fighter.Power;
                    fighter.Life = fighter.Life;
                    break;
            }
            notifier.Notifie(fighter, "SpecialAbillity");
        }
    }
}