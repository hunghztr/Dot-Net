using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class Person
    {
        public static int nextId = 1001;
        public static string Id;
        public string Cccd {  get; set; }
        
        public string FullName { get; set; }
        private DateTime birth;
        public string Address { get; set; }
        public string Phone { get; set; }
        public Person()
        {
        }
        public Person(string Cccd  , string FullName , DateTime bir , string Address , string Phone)
        {
            this.Cccd = Cccd;
            
            this.FullName = FullName;
            
            setBirth(bir);
            this.Address = Address;
            this.Phone = Phone;
        }
        
         
        
        public static void setId(int size)
        {
            Id = "";
            Id += "000" + ++size;
        }
        public static string getId()
        {
             return Id;
        }
        public abstract void doWork();
        public string getBirth()
        {
            return birth.Day+"-"+birth.Month + "-" + birth.Year;
        }
        public void setBirth(DateTime bir)
        {
            birth = bir;
        }
        
    }
}
