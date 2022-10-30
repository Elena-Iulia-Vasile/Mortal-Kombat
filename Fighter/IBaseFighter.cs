namespace Fighter
{
    public interface IBaseFighter
    {
        float HealthPoints { get; set; }
        int Life { get; set; }
        string Name { get; set; }
        float Power { get; set; }

        void DoubleHit(BaseFighter fighter);
        void Hit(BaseFighter fighter);
        void Kick(BaseFighter fighter);
        void Punch(BaseFighter fighter);
        void SpecialAbillity(BaseFighter fighter);
    }
}