using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2 {
    internal class Student {
        // Fields
        private String firstName, lastName;
        private String year, course, section;
        private double midtermGrade, finalGrade;

        // Properties
        public String FirstName {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public String LastName {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public String Year {
            get { return this.year; }
            set { this.year = value; }
        }
        public String Course {
            get { return this.course; }
            set { this.course = value; }
        }
        public String Section {
            get { return this.section; }
            set { this.section = value; }
        }
        public double MidtermGrade {
            get { return this.midtermGrade; }
            set { this.midtermGrade = value; }
        }
        public double FinalGrade {
            get { return this.finalGrade; }
            set { this.finalGrade = value; }
        }

        public Student(String firstName, String lastName, String year, String course,
            String section, double midtermGrade, double finalGrade) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.year = year;
            this.course = course;
            this.section = section;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

        public void introduceSelf() {
            Console.WriteLine($"Name : {FirstName} {LastName}");
            Console.WriteLine($"Course : {Course}");
            Console.WriteLine($"Year : {Year}");
            Console.WriteLine($"Section : {Section}");
            Console.WriteLine();
        }

        public (double, String) evaluateGrade() {
            double average = (this.midtermGrade + this.finalGrade) / 2;
            String standing = "";

            if(average > 100) {
                standing = "Invalid Grade.";
                return (average, standing);
            }

            if(average >= 90 && average <= 100) {
                standing = "With Honors";
            } else if(average >= 75 && average <= 89) {
                standing = "Passed";
            } else {
                standing = "Failed";
            }

            return (average, standing);
        }

    }
}
