using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Course
    {
        public static int nextId = 1001;
        public static string Id;
        public string Name { get; set; }
        public string HomeRoomTeacherId { get; set; }
        public Course() { }
        public Course( string Name , string HomeRoomTeacherId)
        {
            
            this.Name = Name;
            this.HomeRoomTeacherId = HomeRoomTeacherId;
        }
        public static void setId(int size)
        {
            Id = "";
            Id += "12" + ++size;
        }
        public static string getId()
        {
            return Id;
        }
    }
}
