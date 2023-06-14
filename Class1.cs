using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    public class Task {
        public int id { get; set; }

        public string Name { get; set; }

        public DateTime DateTime { get; set; }

        public Task() { }

        public Task(DataRow row) {
            id = int.Parse(row.ItemArray[0].ToString());
            DateTime = DateTime.Parse(row.ItemArray[1].ToString());
            Name = row.ItemArray[2].ToString();
        }
    }
}
