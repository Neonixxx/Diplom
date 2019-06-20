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
            var answers = answer.ToFractions();

            if (answers.Length != 2)
                return false;

            return answers[0] == B && answers[1] == A.Multiply(-1)
                   || answers[0] == B.Multiply(-1) && answers[1] == A;
        }

        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Найти нормальный вектор N(x, y)." +
                   $"{Environment.NewLine}Ответ введите в формате: \"x, y\".";
        }
    }
}