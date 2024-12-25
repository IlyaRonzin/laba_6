using System;

namespace laba_6
{
    class Fraction : ICloneable, IFraction
    {
        private int _numerator;
        private int _denominator;
        private double? _cachedValue;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0.");

            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }

            _numerator = numerator;
            _denominator = denominator;
            _cachedValue = null;
        }

        public override string ToString() => $"{_numerator}/{_denominator}";

        public double ToDecimal()
        {
            if (_cachedValue == null)
            {
                _cachedValue = (double)_numerator / _denominator;
            }
            return _cachedValue.Value;
        }

        public void SetValues(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0.");

            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }

            _numerator = numerator;
            _denominator = denominator;
            _cachedValue = null; // Сброс кэша при изменении полей
        }

        public Fraction Add(Fraction other) => this + other;

        public Fraction Minus(Fraction other) => this - other;

        public Fraction Multiply(Fraction other) => this * other;

        public Fraction Divide(Fraction other) => this / other;

        public Fraction Add(int number) => this + number;

        public Fraction Minus(int number) => this - number;

        public Fraction Multiply(int number) => this * number;

        public Fraction Divide(int number) => this / number;

        public override bool Equals(object obj)
        {
            return obj is Fraction other &&
                   _numerator == other._numerator &&
                   _denominator == other._denominator;
        }

        public object Clone()
        {
            return new Fraction(_numerator, _denominator);
        }

        // Перегрузка операторов
        public static Fraction operator +(Fraction a, Fraction b) => new Fraction(
            a._numerator * b._denominator + b._numerator * a._denominator,
            a._denominator * b._denominator);

        public static Fraction operator -(Fraction a, Fraction b) => new Fraction(
            a._numerator * b._denominator - b._numerator * a._denominator,
            a._denominator * b._denominator);

        public static Fraction operator *(Fraction a, Fraction b) => new Fraction(
            a._numerator * b._numerator,
            a._denominator * b._denominator);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b._numerator == 0)
                throw new DivideByZeroException("На 0 делить нельзя.");

            return new Fraction(
                a._numerator * b._denominator,
                a._denominator * b._numerator);
        }

        public static Fraction operator +(Fraction a, int b) => a + new Fraction(b, 1);

        public static Fraction operator -(Fraction a, int b) => a - new Fraction(b, 1);

        public static Fraction operator *(Fraction a, int b) => a * new Fraction(b, 1);

        public static Fraction operator /(Fraction a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("На 0 делить нельзя.");

            return a / new Fraction(b, 1);
        }

        public static Fraction operator +(int a, Fraction b) => new Fraction(a, 1) + b;

        public static Fraction operator -(int a, Fraction b) => new Fraction(a, 1) - b;

        public static Fraction operator *(int a, Fraction b) => new Fraction(a, 1) * b;

        public static Fraction operator /(int a, Fraction b)
        {
            if (b._numerator == 0)
                throw new DivideByZeroException("На 0 делить нельзя.");

            return new Fraction(a, 1) / b;
        }
    }
}
