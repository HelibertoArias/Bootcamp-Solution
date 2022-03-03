namespace OOPConsoleApp.Entities;

public class Person
{
    public static int MAX_CHILDREN=0;

    // Constant
    public const string Species = "Hommo sapien";

    // Readonly field
    public readonly int id;

    private int Dummy;

    // Property
    public string Name { get; set; }

 
    public string LastName { get; set; }

    public int Age { get; set; }

    // Public read but private set
    public int MinAge { get; private set ; }

    public Person[] Children { get; set; }

    // No parameters, default constructor
    public Person()
    {   
        // fail
         // Species = "";

        // Here, set default values for fields, including read-only.
    }
    
    // Setting readonly field
    public Person(int id)
    {
        this.id = id;
        this.MinAge = 21;
    }

    public Person(string name, int age )
    {
        this.Name = name;
        this.Age = age;
    }

    public void ChangeId()
    {
       // Will fail, only in constructor can asign a value.
       //  this.id = 2;
    }



    public int GetMaxChildren()
    {
        return MAX_CHILDREN;
    }

    public void AddChildrenData()
    {
        var person = new Person(2);

        this.Children = new Person [3]
        {
            person,
            new Person(){ Name= "Jane", LastName="Doe", Age=3},
            new Person("Petter", 1)
        };
    }

    // Controlling access using indexers
    public Person this[int i]
    {
        get { return Children[i]; }
        set { Children[i] = value; }
    }

    // Tuples: Combine multiple returned values
    // Available since C# 7.0
    public (string, int) LastScore()
    {
        /*
         */
        return ("Maths", 10);
    }

    /*
     One way to avoid tuples

    public class CourseScore
    {
        public string CourseName { get; set; }
        public int Score { get; set; }

    }
    */

    public (string course, int score) LastScoreWithNames()
    {
        // Inferring tuples

        var result = ("Spanish", 1); // Item1, Item2, Item3 ....
        string courseName = result.Item1;

        // return result;
        return (course: "Literature",score: 2);
    }

    

}

