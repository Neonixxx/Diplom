using System;

namespace Core.StraightLineTaskGenerators
{
    // 8
    public class ParallelVectorTaskGenerator : StraightLineTaskGenerator
    {
        public override bool CheckResult(string answer)
        {
            var answers = answer.ToFractions();

            if (answers.Length != 2)
                return false;

            return answers[0] == B.Multiply(-1) && answers[1] == A
                || answers[0] == B && answers[1] == A.Multiply(-1);
        }

        public override string GetString()
        {
            return $"{base.GetString()}" +
                   $"{Environment.NewLine}Найти направляющий вектор." +
                   $"{Environment.NewLine}Ответ введите в формате: \"x, y\".";
        }
    }
}