using System;

namespace Line
{
    class LineSegment
    {
        private double _beginSegment; // Поле для начала отрезка
        private double _endSegment;  // Поле для конца отрезка

        // Свойства
        public double beginSegment
        {
            get => _beginSegment;
            set => _beginSegment = value;
        }

        public double endSegment
        {
            get => _endSegment;
            set
            {
                if (value > _beginSegment)
                {
                    _endSegment = value; 
                }
                else
                {
                    _endSegment = _beginSegment;
                    _beginSegment = value;
                }
            }
        }

    //Проверка пересечения отрезков
    public bool IsIntersection(LineSegment secondSegment)
        {
            if (Math.Max(secondSegment.endSegment, this.endSegment) - Math.Min(secondSegment.beginSegment, this.beginSegment) < (this.endSegment - this.beginSegment + secondSegment.endSegment - secondSegment.beginSegment)) { 
                return true;
            }
            else { 
                return false; 
            }
        }

        // ! - вычислить длину диапазона
        public static double operator !(LineSegment line)
        {
            return Math.Abs(line.endSegment - line.beginSegment);
        }

        // ++ - расширить отрезок на 1 вправо и влево
        public static LineSegment operator ++(LineSegment line)
        {
            return new LineSegment(line.beginSegment - 1, line.endSegment + 1);
        }

        // Неявное приведение в int - возвращает целую часть координаты x
        public static implicit operator int(LineSegment line)
        {
            return (int)line.beginSegment;
        }

        // Явное приведение в double - возвращает координату y
        public static explicit operator double(LineSegment line)
        {
            return line.endSegment;
        }

        // Левосторонняя операция: LineSegment - int
        public static LineSegment operator -(LineSegment line, int value)
        {
            return new LineSegment(line.beginSegment - value, line.endSegment);
        }

        // Правосторонняя операция: int - LineSegment
        public static LineSegment operator -(int value, LineSegment line)
        {
            return new LineSegment(line.beginSegment, line.endSegment - value);
        }

        // Операция < сравнивает отрезки на пересечение
        public static bool operator <(LineSegment first, LineSegment second)
        {
            return first.IsIntersection(second);
        }

        public static bool operator >(LineSegment first, LineSegment second)
        {
            return !first.IsIntersection(second);
        }
        //Конструктор
        public LineSegment(double beginSegment, double endSegment)
        {
            this.beginSegment = beginSegment;
            this.endSegment = endSegment;
        }

        //Перегрузка оператора ToString
        public override string ToString()
        {
            return $"beginSegment:{beginSegment}, endSegment:{endSegment}";
        }

        //Конструктор копирования
        public LineSegment(LineSegment original)
        {
            this.beginSegment = original.beginSegment;
            this.endSegment = original.endSegment;
        }
    }
}
