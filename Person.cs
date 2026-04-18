using System;
using System.Runtime.Remoting.Messaging;


namespace ObjectOverrides
{
    public class Person
    {
        // Properties
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }

        public string SSN { get; set; } = "";
        // Constructors
        public Person (string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }

        public Person() { }

        // Methods

        public override string ToString()
        {
            string myState;
            myState = string.Format("[First Name : {0}; Last Name : {1}; Age : {2}]", FirstName, LastName, Age);
            return myState;
        }

        public override bool Equals(object obj)
        {
            // No need to cast "obj" to Person anymore,
            // as everything has a ToString() method.
            return obj.ToString() == this.ToString();

            //Because the class has a prim and proper implementation of ToString(), that accounts all field data up to the chain
            // of inheritance, you can simply perform a comparison of the object's string data.
            /*
            if (obj is Person && obj != null)
            {
                Person temp;
                temp = (Person)obj;// Treat obj as if it's a Person, and assign it to temp.
                if (temp.FirstName == this.FirstName && temp.LastName == this.LastName && temp.Age == this.Age)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
            */
        }

        // Return a hash code based on a point of unique string data.
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
