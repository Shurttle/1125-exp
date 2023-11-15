class CommandCreateStudent : CommandStudent
{
    private StudentDB studentDB;

    public CommandCreateStudent(StudentDB studentDB)
    {
        this.studentDB = studentDB;
    }
    
    public override void Execute()
    {
        Console.WriteLine("Создание чурки");
        Student newStudent = studentDB.Create();
        Console.WriteLine("Укажите имя чурки");
        newStudent.FirstName = Console.ReadLine();
        Console.WriteLine("Укажите фамилию чурки");
        newStudent.LastName = Console.ReadLine();

        if (studentDB.Update(newStudent))
            Console.WriteLine("Чурка создана!");
        else
            Console.WriteLine("Ошибка чурки");
    }
}
