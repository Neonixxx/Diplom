using System;
using Fractions;

namespace Core.StraightLineTaskGenerators
{
    // 14
    public class NormalFromPointTaskGenerator : StraightLineTaskGenerator
    {
        private Fraction _mA;

        public NormalFromPointTaskGenerator()
        {
            TaskName = "Перпендикуляр к прямой через точку";
        }

        private Fraction _mB;

        public override void Initialize(Random random)
        {
            base.Initialize(random);

            do
            {
                _mA = new Fraction(random.Next(-10, 11));
                _mB = new Fraction(random.Next(-10, 11));
            } while (IsPointOnLine(_mA, _mB));
        }

        public override bool CheckResult(string answer)
        {
            var answers = answer.ToFractions();

            if (answers.Length != 3)
                return false;

            // Уравнение перпендикулярной прямой, проходящей через точку:
            // Bx - By + A * mB - B * mA = 0
            // Точка: (mA, mB)
            return answers[0] == B && answers[1] == A.Multiply(-1) && answers[2] == A * _mB - B * _mA
                || answers[0].Multiply(-1) == B && answers[1].Multiply(-1) == A.Multiply(-1) && answers[2].Multiply(-1) == A * _mB - B * _mA;
        }

        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Составить уравнение перпендикуляра Ax + By + C = 0, опущенного на эту прямую из точки M{FormatPoint(_mA, _mB)}." +
                   $"{Environment.NewLine}Ответ введите в формате: \"A, B, C\".";
        }
    }
}