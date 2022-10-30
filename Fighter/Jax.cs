namespace Fighter
{
    public class Jax : BaseFighter
    {
        Notifier notifier = new Notifier();
        public Jax(string name) : base(name, 100, 80, 100)
        {
            Console.WriteLine("It was created with succes a Jax fighter!");
        }

        public override void Hit(BaseFighter fighter)
        {
            if (this.Power >= 50 && this.Life >= 75)
                fighter.HealthPoints -= 0.2f * this.Power - 0.2f * this.Life;
            else
                fighter.HealthPoints -= this.HealthPoints * 0.2f;
            notifier.Notifie(fighter, "Hit");
        }

        public override void Punch(BaseFighter fighter)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 6);
            fighter.Life -= randomNumber;
            notifier.Notifie(fighter, "Punch");
        }

        public override void DoubleHit(BaseFighter fighter)
        {
            Random random = new Random();
            int randomNumber = random.Next(5, 11);
            fighter.Power -= randomNumber / 100 * this.Power;
            int randomNumber2 = random.Next(4, 8);
            fighter.HealthPoints -= randomNumber2 / 100 * this.HealthPoints;
            fighter.Life -= randomNumber2;
            notifier.Notifie(fighter, "DoubleHit");
        }

        public override void Kick(BaseFighter fighter)
        {
            if (this.Power >= 30 && this.HealthPoints >= 60)
            {
                fighter.Power -= 0.25f * this.Power;
                fighter.HealthPoints -= 0.25f * this.HealthPoints;
            }
            else
            {
                fighter.Power -= 0.15f * fighter.Power;
                fighter.HealthPoints -= 0.15f * fighter.HealthPoints;
            }
            notifier.Notifie(fighter, "Kick");
        }
        public override void SpecialAbillity(BaseFighter fighter)
        {
            if (this.Life <= 90 && this.Power <= 35 && this.HealthPoints >= 40)
                this.Life += 10;
            notifier.Notifie(fighter, "SpecialAbillity");
        }

    }

}