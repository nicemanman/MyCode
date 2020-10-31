﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Backend.Models
{
    public class AssignedProblem
    {
        public int AssignedProblemId { get; set; }
        public int StudentId { get; set; }
        public int ProblemId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Problem Problem { get; set; }
    }
}
