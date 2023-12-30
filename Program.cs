namespace Encapsulation2 {
    internal class Program {
        static void Main(string[] args) {
            String firstName = "Michael Angelo", lastName = "Zara";
            String year = "3rd Year College", course = "BSCS", section = "N/A";
            double midtermGrade = 92, finalGrade = 92;
            Student student = new Student(firstName, lastName, year, course, section, midtermGrade, finalGrade);

            (double average, String standing) = student.evaluateGrade();
            student.introduceSelf();
            Console.WriteLine($"Average : {average}");
            Console.WriteLine($"Standing : {standing}");
        }
    }
}
