
namespace Fighter
{
    //numele clasei difera de numele fisierului
    public class Notifier
    {
        public Notifier()
        {
        }

        public void Notifie(BaseFighter fighter, string Hit)
        {
            //parametrul fighter ar putea fi null
            if(fighter == null)
            {
                throw new ArgumentNullException(nameof(fighter));
            }
            Console.WriteLine($"Fighter {fighter.Name} had been hit with {Hit}. His updated properties are:\nLife: {fighter.Life}\nPower: {fighter.Power}\nHealthPoints: {fighter.HealthPoints}\n");
        }

        public void NotifieWrong()
        {
            Console.WriteLine("You didn't made a right decision so you lost your turn!\n");
        }
    }
}

