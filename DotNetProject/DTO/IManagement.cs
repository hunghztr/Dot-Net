using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public interface IManagement
    {
        DataTable getElements(string table);
        DataTable sort(string result, string table, string bySome);
        DataTable findElements(string name, string nameColumn, string table);
    }
}
