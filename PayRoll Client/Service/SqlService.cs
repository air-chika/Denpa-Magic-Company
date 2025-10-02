using PayRoll_Client.Models;
using PayRoll_Client.Utils;
using SqlSugar;

namespace PayRoll_Client.Service
{
    //SqlService
    public static class Sql
    {
        static Sql()
        {
            DirectoryInfo info = new(Environment.CurrentDirectory);
            while (info.GetFiles().All(x => x.Name != "PayRoll.db"))
            {
                info = info.Parent!;
                if (info == null) throw new FileNotFoundException();
            }
            var x = info!.GetFiles().First(x => x.Name == "PayRoll.db");

            DB = new SqlSugarClient(new ConnectionConfig()
            {
                DbType = DbType.Sqlite,
                ConnectionString = @$"DataSource={x.FullName}",
                //IsAutoCloseConnection = true
            });
        }

        public static SqlSugarClient DB { get; set; }

        public static ISugarQueryable<T> Query<T>() where T : class, new()
        {
            return DB.Queryable<T>();
        }
        public static T QueryID<T>(int id) where T : IDable, new()
        {
            return DB.Queryable<T>().First(x => x.ID == id);
        }

        public static List<T> PageQuery<T>(this ISugarQueryable<T> query, int pn)
        {
            return query.ToPageList(pn, CRUDview.numInPage);
        }

        public static List<T> PageQuery<T>(int pn) where T : class, new()
        {
            return Query<T>().ToPageList(pn, CRUDview.numInPage);
        }

        public static T? PageAt<T>(int pn, int idx) where T : class, new()
        {
            var list = Query<T>().ToPageList(pn, CRUDview.numInPage);
            if (list.Count <= idx)
                return null;
            else
                return list[idx];
        }

        public static int PageLength<T>() where T : class, new()
        {
            int n1 = 0, n2 = 0;
            Query<T>().ToPageList(1, CRUDview.numInPage, ref n1, ref n2);
            return n2;
        }

        public static void Insert<T>(T t) where T : class, new()
        {
            DB.Insertable(t).ExecuteCommand();
        }

        public static void Update<T>(T t) where T : class, new()
        {
            DB.Updateable(t).ExecuteCommand();
        }

        public static void CU<T>(T t, int id) where T : class, new()
        {
            if (id == 0)
                Insert(t);
            else Update(t);
        }

        public static void Delete<T>(T t) where T : class, new()
        {
            DB.Deleteable(t).ExecuteCommand();
        }

        public static void DeletePageAt<T>(int pn, int i) where T : class, new()
        {
            Delete(PageAt<T>(pn, i));
        }
    }
}
