using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Client.Utils
{
    public static class PathHelpers
    {

        public static string? FindPath(this string dirName, string nextFileName)
        {
            DirectoryInfo info = new(Environment.CurrentDirectory);
            while (info.GetDirectories().All(x => x.Name != dirName))
            {
                info = info.Parent!;
                if (info == null) break;
            }
            if (info == null) return null;
            info = new DirectoryInfo(Path.Combine(info.FullName, dirName));
            return info.GetFiles().Any(x => x.Name == nextFileName) ? Path.Combine(info.FullName, nextFileName) : null;
        }
        public static string? FindPath(this string fileName)
        {
            DirectoryInfo info = new(Environment.CurrentDirectory);
            while (info.GetFiles().All(x => x.Name != fileName))
            {
                info = info.Parent!;
                if (info == null) break;
            }
            return info == null ? null : Path.Combine(info.FullName, fileName);
        }

    }
}
