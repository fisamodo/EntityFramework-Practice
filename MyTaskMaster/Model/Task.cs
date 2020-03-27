using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskMaster.Model
{
    class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DueDate { get; set; }

        public int StatusId { get; set; } //foreign key naming convention with Id
        
        public Status Status { get; set; } //navigation property
    }
}
