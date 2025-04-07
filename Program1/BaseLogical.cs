using System;

namespace Logic
{
    class BaseLogic
    {
        protected bool firstElement { get; set; }
        protected bool secondElement { get; set; }

        //Поиск дизъюнкта
        public bool Disjunction()
        {
            bool disjunct = this.firstElement | this.secondElement;
            return disjunct;
        }

        //Перегрузка метода ToString
        public override string ToString()
        {
            return $"State1: {firstElement}, State2: {secondElement}, Disjunction: {Disjunction()}";
        }

        // Конструктор копирования
        public BaseLogic(BaseLogic original)
        {
            this.firstElement = original.firstElement;
            this.secondElement = original.secondElement;
        }

        //Конструктор класса
        public BaseLogic(bool first_element, bool second_element)
        {
            this.firstElement = first_element;
            this.secondElement = second_element;
        }

    }
}