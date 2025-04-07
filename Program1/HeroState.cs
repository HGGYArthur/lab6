namespace Logic
{
    class HeroState: BaseLogic
    {
        public string heroName { get; set; }

        public HeroState(bool isInCombat, bool isUsingAbility, string heroName) : base(isInCombat, isUsingAbility)
        {
            this.heroName = heroName;
        }

        // Конструктор копирования
        public HeroState(HeroState other) : base(other)
        {
            heroName = other.heroName;
        }

        // Метод определения активного состояния героя
        public bool IsActive()
        {
            return Disjunction(); // Герой активен, если находится в бою ИЛИ использует способность
        }

        // Метод входа в боевой режим
        public void EnterCombat()
        {
            firstElement = true; // Установка боевого состояния
        }

        // Метод использования способности
        public void UseAbility()
        {
            secondElement = true; // Активация использования способности
        }

        ///// Метод смерти героя
        public void HeroDie()
        {
            firstElement=secondElement=false;
        }

        // Переопределение метода ToString()
        public override string ToString()
        {
            return $"Hero: {heroName}, In Combat: {firstElement}, Using Ability: {secondElement}, Active Status: {IsActive()}";
        }
    }
}
