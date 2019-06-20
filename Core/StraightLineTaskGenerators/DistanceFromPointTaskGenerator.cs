﻿using System;
using Fractions;

namespace Core.StraightLineTaskGenerators
{
    // 12
    public class DistanceFromPointTaskGenerator : StraightLineTaskGenerator
    {
        private readonly (int, int)[] _possiblePairs = {(3, 4), (5, 12), (6, 8), (8, 15), (9, 12), (12, 16)};

        private Fraction _mA;
        private Fraction _mB;

        public override void Initialize(Random random)
        {
            base.Initialize(random);

            var pair = _possiblePairs[random.Next(0, _possiblePairs.Length)];
            if (random.FlipCoin())
            {
                var temp = pair.Item1;
                pair.Item1 = pair.Item2;
                pair.Item2 = temp;
            }
            if (random.FlipCoin())
                pair.Item1 *= -1;
            if (random.FlipCoin())
                pair.Item2 *= -1;

            A = pair.Item1;
            B = pair.Item2;
            NormalizeLine();

            do
            {
                _mA = new Fraction(random.Next(-10, 11));
                _mB = new Fraction(random.Next(-10, 11));
            } while (IsPointOnLine(_mA, _mB));
        }

        public override bool CheckResult(string answer)
        {
            var answers = answer.ToFractions();

            if (answers.Length != 1)
                return false;

            // d = |A * mA + B * mB + C| / sqrt(A^2 + B^2)
            // Прямая: Ax + By + C = 0
            // Точка: (mA, mB)
            return answers[0] ==
                   (A * _mA + B * _mB + C).Abs() / new Fraction(Math.Sqrt((A * A + B + B).ToInt32()));
        }

        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Найти расстояние от точки M({_mA.ToStringWithZero()}; {_mB.ToStringWithZero()}).";
        }
    }
}