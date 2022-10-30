
namespace Fighter
{
    public class Notifier
    {
        public Notifier()
        {


        }


        public void Notifie(BaseFighter fighter, string Hit)
        {
            Console.WriteLine($"Fighter {fighter.Name} had been hit with {Hit}. His updated properties are:\nLife: {fighter.Life}\nPower: {fighter.Power}\nHealthPoints: {fighter.HealthPoints}\n");
        }

        public void NotifieWrong()
        {
            Console.WriteLine("You didn't made a right decision so you lost your turn!\n");
        }
    }
}

