using System;
using System.Collections.Generic;
using System.Linq;
using Core.StraightLineTaskGenerators;
using Diplom;

namespace Core
{
    public class TaskService
    {
        private List<StraightLineTaskGenerator> _taskGenerators = new List<StraightLineTaskGenerator>
        {
            new TwoPointsOnLineTaskGenerator(),
            new NormalVectorTaskGenerator(),
            new ParallelVectorTaskGenerator(),
            new NormalFromPointTaskGenerator(),
            new DistanceFromPointTaskGenerator(),
            new SegmentIntersectionTaskGenerator(),
            new LinesIntersectionPointTaskGenerator(),
        }/*.Shuffle()*/.ToList();

        private List<TaskResult> _taskResults = new List<TaskResult>();

        private readonly Random _random = new Random();
        public int _currentTaskIndex = 0;

        public int CurrentTaskNumber => _currentTaskIndex + 1;

        private StraightLineTaskGenerator CurrentTaskGenerator => _taskGenerators[_currentTaskIndex];

        public TaskService()
        {
            CurrentTaskGenerator.Initialize(_random);
            for (int i = 0; i < _taskGenerators.Count; i++)
                _taskResults.Add(TaskResult.None);
        }

        public TestResult GetTestResult()
        {
            var testResult = new TestResult();
            for (int i = 0; i < _taskGenerators.Count; i++)
                testResult.TaskResults.Add((_taskGenerators[i].TaskName, _taskResults[i]));

            return testResult;
        }

        public bool GoToNextTask()
        {
            _currentTaskIndex++;

            if (_currentTaskIndex == _taskGenerators.Count)
                return true;

            CurrentTaskGenerator.Initialize(_random);
            return false;
        }

        public bool CheckResult(string answer)
            => CurrentTaskGenerator.CheckResult(answer);

        public string GetTaskString()
            => CurrentTaskGenerator.GetString();

        public void SaveResult(string answer)
        {
            var result = CheckResult(answer);
            if (result)
                _taskResults[_currentTaskIndex] = TaskResult.Success;
            else
                _taskResults[_currentTaskIndex] = TaskResult.Failed;
        }
    }
}