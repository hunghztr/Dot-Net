using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Teacher : Person
    {
        
        public List<Course> courses = new List<Course>();
        public int Salary {  get; set; }
        
        public string SubjectId { get; set; }
        public Teacher()
        {
        }
        public Teacher(string Cccd, string FullName, DateTime bir, string Address, string Phone, 
            int Salary ,string SubjectId ) : base(Cccd,FullName,bir,Address,Phone)
            {
            this.Salary = Salary;
            this.SubjectId = SubjectId;
            }
        public override void doWork()
        {
            throw new NotImplementedException();
        }
    }
}
