using System;
using System.Collections.Generic;
using System.Linq;
using Core;

namespace Diplom
{
    public class TestResult
    {
        public List<(string, TaskResult)> TaskResults { get; set; } = new List<(string, TaskResult)>();

        public DateTime Date { get; set; }

        public TimeSpan Elapsed{ get; set; }

        public int SuccessTasksCount => TaskResults.Count(t => t.Item2 == TaskResult.Success);

        public int FailedTasksCount => TaskResults.Count(t => t.Item2 == TaskResult.Failed);
    }
}