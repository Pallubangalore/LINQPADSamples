<Query Kind="Program" />

 void Main()
        {
            List<Person> persons = new List<Person>()
            {
               new Person(){Firstname= "test1",Lastname ="test2"},
               new Person(){Firstname= "test1",Lastname ="test2"},
               new Person(){Firstname= "test3",Lastname ="test4"},
               new Person(){Firstname= "test5",Lastname ="test6"},
               new Person(){Firstname= "test7",Lastname ="test8"}
            };

            var selectDistinct = (from p in persons
                                  select p).Distinct(new PersonEqualityComparer()).OrderBy(p => p.Firstname).ToList();


           selectDistinct.Dump();
            
        }

class PersonEqualityComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
           if(x==null && y==null)
            {
                return true;
            }
           else if( x==null || y==null)
            {
                return false;
            }
            else if(x.Firstname.Equals(y.Firstname,StringComparison.OrdinalIgnoreCase) 
                && x.Lastname.Equals(y.Lastname,StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Person obj) =>  (obj.Firstname.GetHashCode() ^ obj.Lastname.GetHashCode());
    }


    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Person()
        {
        }
    }