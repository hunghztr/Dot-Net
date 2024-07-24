using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GradeList
    {
        public string StudentId { get; set; }
        public double Math { get; set; }
        public double Literature {  get; set; }
        public double English {  get; set; }
        public double Physical { get; set; }
        public double Chemistry { get; set; }
        public double History { get; set; }
        public double Geography { get; set; }
        public double Avg { get; set; }
        public GradeList() { }
        public GradeList(string StudentId , double Math , double Literature , double English , double Physical , double Chemistry , double History , double Geography,double Avg)
        {
            this.StudentId = StudentId;
            this.Math = Math;
            this.Literature = Literature;
            this.English = English;
            this.Physical = Physical;
            this.Chemistry = Chemistry;
            this.History = History;
            this.Geography = Geography;
            this.Avg = Avg;
        }
    }
}
