//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace vid1_2
//{

//    internal class Employee
//    {
//        public int Id { get; internal set; } 
//        public string Name { get; internal set; }
//        public decimal Salary { get; internal set; }


//        public override bool Equals(object? obj)
//        {
//            if(obj is Employee R)
//            {
//                if(R == null) return false;

//                if(this.GetType() != obj.GetType()) return false;

//                if(object.ReferenceEquals(this, R)) return true;

//                return (Id == R.Id && Name == R.Name && Salary == R.Salary);
//            }
//            return false;
//        }

//        public override string ToString()
//        {
//            return $"ID:{Id} , Name;{Name} , Salary{Salary}";
//        }

//        public override int GetHashCode()
//        {
//            return base.GetHashCode();
//        }

//    }
//}
