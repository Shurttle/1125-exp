class CommandDeleteStudent : CommandStudent
{
    private StudentDB studentDB;

    public CommandDeleteStudent(StudentDB studentDB)
    {
        this.studentDB = studentDB;
    }

    public override void Execute()
    {
        Console.WriteLine("Поиск чурки");
        List<Student> students = studentDB.Search(Console.ReadLine());
        for (int j = 0; j < students.Count; j++) 
        {
            Console.WriteLine(students[j]);
            Console.WriteLine("Какую чурку отчислить?");
            int.TryParse(Console.ReadLine(), out int delete);
            if (students.Count > delete - 1)
            {
                studentDB.Delete(students[j]);
                Console.WriteLine("Отчислен");
            }
            else
                Console.WriteLine("нет такой");
        }
    }
}