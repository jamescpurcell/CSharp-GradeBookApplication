using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count() < 5)
            {
                throw  new InvalidOperationException();
            }

            if (averageGrade >= 80.00)
            {
                return 'A';
            }
            else if (averageGrade >= 60.00 && averageGrade < 80.00)
            {
                return 'B';
            }
            else if (averageGrade >= 40.00 && averageGrade < 60.00)
            {
                return 'C';
            }
            else if (averageGrade >= 20.00 && averageGrade < 40.00)
            {
                return 'D';
            }
            else 
            {
                return 'F';
            }
        }

        public override void CalculateStatistics()
        {
            if (Students.Count() < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            else 
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count() < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            else 
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}
