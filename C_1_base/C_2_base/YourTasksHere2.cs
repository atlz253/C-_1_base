using C_1_base;

namespace C_2_base
{
    // Необходимо реализовать объектную модель геометрических фигур (прямоугольник, тругольник, круг).
    // Ко всем фигурам должно быть возможно осуществить доступ по одному имени
    // Через это имя должно быть возможно получить доступ к площади и периметру фигур
    // Все числа пусть имееют тип double

    interface IFigure
    {
        double S { get; }
        double P { get; }
    }

    class Rectangle : IFigure
    {
        private double _a, _b;

        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public double S
        {
            get
            {
                return _a * _b;
            }
        }

        public double P
        {
            get
            {
                return 2 * (_a + _b);
            }
        }
    }

    class Triangle : IFigure
    {
        private double _a, _b, _c;

        public Triangle(double _a, double _b, double _c)
        {
            if (YourTasksHere1.isTrungle(_a, _b, _c))
            {
                this._a = _a;
                this._b = _b;
                this._c = _c;
            }
            else
            {
                throw new System.Exception("Чел, ты в муте");
            }
        }

        public double S
        {
            get
            {
                double p = P / 2;
                return System.Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
            }
        }

        public double P
        {
            get
            {
                return _a + _b + _c;
            }
        }
    }

    class Circle : IFigure
    {
        private double _r;

        public Circle(double _r)
        {
            this._r = _r;
        }

        public double S
        {
            get
            {
                return _r * _r * System.Math.PI;
            }
        }

        public double P
        {
            get
            {
                return 2 * System.Math.PI * _r;
            }
        }
    }
}
