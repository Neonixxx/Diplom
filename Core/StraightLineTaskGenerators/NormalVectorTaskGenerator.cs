using System;

namespace Core.StraightLineTaskGenerators
{
    // 3
    public class NormalVectorTaskGenerator: StraightLineTaskGenerator
    {
        public NormalVectorTaskGenerator()
        {
            TaskName = "Нормальный вектор прямой";
        }

        public override bool CheckResult(string answer)
        {
            var answers = answer.ToInts();

            if (answers.Length != 2)
                return false;

            var vector = new Vector(answers[0], answers[1]);

            return Line.IsNormalTo(vector);
        }

        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Найти нормальный вектор N(x, y)." +
                   $"{Environment.NewLine}Ответ введите в формате: \"x, y\".";
        }
    }
}