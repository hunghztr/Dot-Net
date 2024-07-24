using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student : Person
    {
        public string SchoolYear { get; set; }
        public string CourseId { get; set; }
        
        public Student() { }
        public Student(string Cccd, string FullName, DateTime bir, string Address, string Phone, 
            string SchoolYear , string CourseId ) : base(Cccd,FullName,bir,Address,Phone)
        {
            this.SchoolYear = SchoolYear;
            this.CourseId = CourseId;
            
        }
        public override void doWork()
        {
            throw new NotImplementedException();
        }
    }
}
