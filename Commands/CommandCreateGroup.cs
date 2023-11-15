using ConsoleApp5.DB;

class CommandCreateGroup : CommandStudent
{
    private GroupDB groupDB;

    public CommandCreateGroup(GroupDB groupDB)
    {
        this.groupDB = groupDB;
    }

    public override void Execute()
    {
        Console.WriteLine("Создание группы чурок");
        Group newgroup = groupDB.Create();
        Console.WriteLine("Укажите название аула чурок");
        newgroup.Name = Console.ReadLine();
        if (groupDB.Update(newgroup))
            Console.WriteLine("группа чурок создана");
        else
            Console.WriteLine("группа чурок не создана");
    }
}