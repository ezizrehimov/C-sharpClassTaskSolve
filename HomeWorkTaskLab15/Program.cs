using HomeWorkTaskLab15;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student("Ali", "Aliyev", "IT", new int[] {32,15,25,25,45 });


        Exam exam = new Exam(new string[] { "Informatika1", "Informatika2", "Informatika3","Informatika4" , "Informatika5" },
           new int[] {15,24,34,45,49} );

        student.checkExam(exam);

        student.info(exam);
    }
}