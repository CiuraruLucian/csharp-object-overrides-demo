
using System;


namespace ObjectOverrides
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");
            Person p1 = new Person();

            // Use inherited members of System.Object.
            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("Hash code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}",p1.GetType());

            //Make some other references to p1.
            Person p2 = p1;
            object o = p2;
            // Are the references pointing to the same object in memory?
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance!");
            }

            // NOTE : We want these to be identical to test
            // the Equals() and GetHashCode() methods.
            Person p3 = new Person("Lucian", "Ciuraru", 22);
            Person p4 = new Person("Lucian", "Ciuraru", 22);

            // Get stringified version of objects.
            Console.WriteLine("p3.ToString() = {0}", p3.ToString());
            Console.WriteLine("p4.ToString() = {0}", p4.ToString());

            // Test overriden Equals().
            Console.WriteLine("Check if p3 = p4? : {0}", p3.Equals(p4));

            // Test hash codes.
            Console.WriteLine("Same hash codes? : {0}", p3.GetHashCode() == p4.GetHashCode());

            Console.WriteLine();

            // Change age of p4 and test again
            p4.Age = 23;
            
            Console.WriteLine("p3.ToString() = {0}", p3.ToString());
            Console.WriteLine("p4.ToString() = {0}", p4.ToString());
            Console.WriteLine("Check if p3 = p4? : {0}", p3.Equals(p4));
            Console.WriteLine("Same hash codes? : {0}", p3.GetHashCode() == p4.GetHashCode());

            StaticMemberOfObject();

            Console.ReadLine();
        }
        
        static void StaticMemberOfObject()
        {
            // Static members of System.Object
            Person p5 = new Person("Luci", "Ciu", 22);
            Person p6 = new Person("Luci", "Ciu", 22);
            Console.WriteLine("P5 and P6 have same state: {0}", object.Equals(p5,p6));
            Console.WriteLine("P5 and P6 are pointing to same object: {0}", object.ReferenceEquals(p5,p6));
            
        }
    }
}
