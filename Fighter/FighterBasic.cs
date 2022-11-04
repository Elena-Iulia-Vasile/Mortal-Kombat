namespace Fighter
{
    public class FighterBasic : BaseFighter
    {
        //ai fi putut aplica dependency inversion
        Notifier notifier = new Notifier();
        
        public FighterBasic(string name) : base(name, 100, 80, 80)
        {
            Console.WriteLine("It was created with succes a fighter!");
        }

        public override void Hit(BaseFighter fighter)
        {
            //fighter ar putea fi null 
            if (this.Power >= 50 && this.Life >= 75)
                fighter.HealthPoints -= 0.1f * this.Power - 0.1f * this.Life;
            else
                fighter.HealthPoints -= this.HealthPoints * 0.1f;
            notifier.Notifie(fighter, "Hit");
        }

        public override void Punch(BaseFighter fighter)
        {
            //fighter ar putea fi null 
            Random random = new Random();
            int randomNumber = random.Next(1, 5);
            fighter.Life -= randomNumber;
            notifier.Notifie(fighter, "Punch");
        }

        public override void DoubleHit(BaseFighter fighter)
        {
            //fighter ar putea fi null 
            Random random = new Random();
            int randomNumber = random.Next(5, 10);
            fighter.Power -= randomNumber / 100 * this.Power;
            int randomNumber2 = random.Next(8, 12);
            // imi e greu sa inteleg logica actiunii avand in vedere numele celor doua 
            // variabile randomNumber si randomNumber2
            fighter.HealthPoints -= randomNumber2 / 100 * this.HealthPoints;
            fighter.Life -= randomNumber2;
            notifier.Notifie(fighter, "DoubleHit");
        }

        public override void Kick(BaseFighter fighter)
        {
            //fighter ar putea fi null 
            if (this.Power >= 40 && this.HealthPoints >= 50)
            {
                fighter.Power -= 0.15f * this.Power;
                fighter.HealthPoints -= 0.15f * this.HealthPoints;
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
            //fighter ar putea fi null 
            fighter.Life -= 5;
            notifier.Notifie(fighter, "SpecialAbillity");
        }
    }
}