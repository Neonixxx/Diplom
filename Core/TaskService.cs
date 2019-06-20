using System;
using System.Collections.Generic;
using System.Linq;
using Core.StraightLineTaskGenerators;

namespace Core
{
    public class TaskService
    {
        private List<StraightLineTaskGenerator> _taskGenerators = new StraightLineTaskGenerator[]
        {
            new NormalVectorTaskGenerator(),
            new TwoPointsOnLineTaskGenerator(),
            new NormalFromPointTaskGenerator(),
            new ParallelVectorTaskGenerator(),
            new DistanceFromPointTaskGenerator(), 
        }.Shuffle().ToList();

        private readonly Random _random = new Random();
        public int _currentTaskIndex = 0;

        public int CurrentTaskNumber => _currentTaskIndex + 1;

        private StraightLineTaskGenerator CurrentTaskGenerator => _taskGenerators[_currentTaskIndex];

        public TaskService()
        {
            CurrentTaskGenerator.Initialize(_random);
        }

        public void GoToNextTask()
        {
            _currentTaskIndex++;

            // Временно
            if (_currentTaskIndex == _taskGenerators.Count)
                _currentTaskIndex = 0;
            //

            CurrentTaskGenerator.Initialize(_random);
        }

        public bool CheckResult(string answer)
            => CurrentTaskGenerator.CheckResult(answer);

        public string GetTaskString()
            => CurrentTaskGenerator.GetString();
    }
}