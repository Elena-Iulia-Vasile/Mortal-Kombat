namespace Fighter
{
    public class Scorpion : BaseFighter
    {
        private readonly int venom;

        Notifier notifier = new Notifier();

        public Scorpion(string name, int venom) : base(name, 100, 100, 99)
        {
            this.venom = venom;
            if (venom > 50)
                Power += Power;
            else
                Power += Power / 2;
            Console.WriteLine("It was created with succes a Scorpion fighter!");
        }

        public override void Hit(BaseFighter fighter)
        {
            if (this.venom > 50)
                fighter.HealthPoints -= 0.2f * this.Power - 0.15f * this.Life;
            else
                fighter.HealthPoints -= this.HealthPoints * 0.16f;
            notifier.Notifie(fighter, "Hit");
        }

        public override void Punch(BaseFighter fighter)
        {
            Random random = new Random();
            int randomNumber = random.Next(15, 25);
            fighter.Life -= randomNumber;
            notifier.Notifie(fighter, "Punch");
        }

        public override void DoubleHit(BaseFighter fighter)
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 16);
            fighter.Power -= randomNumber / 100 * this.Power;
            int randomNumber2 = random.Next(8, 12);
            fighter.HealthPoints -= randomNumber2 / 100 * this.HealthPoints;
            fighter.Life -= randomNumber2;
            notifier.Notifie(fighter, "DoubleHit");
        }

        public override void Kick(BaseFighter fighter)
        {
            if (this.Power >= 50 && this.HealthPoints >= 60)
            {
                fighter.Power -= 0.15f * this.Power;
                fighter.HealthPoints -= 0.1f * this.HealthPoints;
            }
            else
            {
                fighter.Power -= 0.1f * fighter.Power;
                fighter.HealthPoints -= 0.2f * fighter.HealthPoints;
            }
            notifier.Notifie(fighter, "Kick");
        }

        public override void SpecialAbillity(BaseFighter fighter)
        {
            switch (venom)
            {
                case 10:
                    this.HealthPoints -= 0.2f * this.HealthPoints;
                    break;
                case 20:
                    this.HealthPoints -= 0.15f * this.HealthPoints;
                    break;
                case 30:
                    this.HealthPoints -= 0.10f * this.HealthPoints;
                    break;
                default:
                    this.HealthPoints -= 0.05f * this.HealthPoints;
                    break;

            }
            notifier.Notifie(fighter, "SpecialAbillity");
        }
    }
}