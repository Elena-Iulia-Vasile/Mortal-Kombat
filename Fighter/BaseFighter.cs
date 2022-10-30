namespace Fighter
{
    public abstract class BaseFighter : IBaseFighter
    {
        public string Name { get; set; }

        public int Life { get; set; }

        public float Power { get; set; }

        public float HealthPoints { get; set; }
        public BaseFighter()
        {
            Name = " ";
            Life = 0;
            Power = 0;
            HealthPoints = 0;
        }

        public BaseFighter(string name, int life, float power, float healthPoints)
        {
            Name = name;
            Life = life;
            Power = power;
            HealthPoints = healthPoints;
        }

        public abstract void Hit(BaseFighter fighter);

        public abstract void Punch(BaseFighter fighter);

        public abstract void DoubleHit(BaseFighter fighter);

        public abstract void Kick(BaseFighter fighter);

        public abstract void SpecialAbillity(BaseFighter fighter);
    }
}
