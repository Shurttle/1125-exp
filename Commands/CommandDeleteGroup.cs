using ConsoleApp5.DB;


internal class CommandDeleteGroup : CommandStudent
{
    private GroupDB groupDB;

    public CommandDeleteGroup(GroupDB groupDB)
    {
        this.groupDB = groupDB;
    }

    public override void Execute()
    {
        Console.WriteLine("поиск группы");
        List<Group> groups = groupDB.Search(Console.ReadLine());
        for (int j = 0; j < groups.Count; j++)
        {
            Console.WriteLine(groups[j]);
            Console.WriteLine("какую чурку удалить?");
            int.TryParse(Console.ReadLine(), out int delete);
            if ((groups.Count > delete - 1))
            {
                groupDB.Delete(groups[j]);
                Console.WriteLine("Вроде удалили");
            }
            else
                Console.WriteLine("значит не удалили");
        }
    }
}