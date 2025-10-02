using SqlSugar;

DirectoryInfo info = new(Environment.CurrentDirectory);
while (info.GetFiles().All(x=>x.Name!="PayRoll.db"))
{
    info = info.Parent!;
    if (info == null) break;
}
var x = info!.GetFiles().First(x => x.Name == "PayRoll.db");

SqlSugarClient client = new(new ConnectionConfig()
{
    DbType = DbType.Sqlite,
    ConnectionString = @$"DataSource={x.FullName}",
    IsAutoCloseConnection = true
});

client.DbFirst.CreateClassFile(Path.Combine(x.DirectoryName!,"Build"));

