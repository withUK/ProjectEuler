﻿using ProjectEuler.Interfaces;
using System;

namespace ProjectEuler.Models
{
    public class EulerProblem : IEulerSolution
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan TimeTaken { get; set; }
        public bool Completed { get; set; }

        public virtual object GetResult()
        {
            throw new NotImplementedException();
        }
    }
}
