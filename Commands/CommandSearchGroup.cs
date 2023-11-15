using ConsoleApp5.DB;

class CommandSearchGroup : CommandStudent
{
    private GroupDB groupDB;

    public CommandSearchGroup(GroupDB groupDB)
    {
        this.groupDB = groupDB;
    }

    public override void Execute()
    {
        Console.WriteLine("поиск группы чурок");
        List<Group> groups = groupDB.Search(Console.ReadLine());
        for (int i = 0; i < groups.Count; i++) 
        {
            Console.WriteLine($"{groups[i].Name}{groups[i].UID}");
        }
    }
}
