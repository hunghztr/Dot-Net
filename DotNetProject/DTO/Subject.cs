using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Subject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Subject() { }
        public Subject(string Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
