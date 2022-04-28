using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeListaCSV
{
    internal class CSV
    {
        private string[] columnsName;
        private List<string[]> rows;

        public CSV (string[] columnsName, List<string[]> rows)
        {
            this.columnsName = columnsName;
            this.rows = rows;
        }

        public string[] Columns
        {
            get { return columnsName; }
        }
        public List<string[]> Rows
        {
            get { return rows; }
        }
    }
}
