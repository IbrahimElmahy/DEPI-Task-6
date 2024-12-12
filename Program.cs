#region the first problem

//using System;

//struct Point
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Point()
//    {
//        X = 0;
//        Y = 0;
//    }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Point p1 = new Point();
//        Console.WriteLine(p1.ToString());  

//        Point p2 = new Point(3, 4);
//        Console.WriteLine(p2.ToString());  
//    }
//}

//preventing structs from inheriting from other structs or classes helps maintain their simplicity, efficiency, and clear semantics as value types. If you need inheritance, 
//    it's generally recommended to use classes instead of structs. This design decision ensures that structs remain performant and easy to use for their intended scenarios.

#endregion


#region  the second problem 

//using System;

//namespace AccessModifiersDemo
//{
//    public class TypeA
//    {
//        private int F;

//        internal int G;

//        public int H;

//        public TypeA(int f, int g, int h)
//        {
//            F = f;
//            G = g;
//            H = h;
//        }

//        public int GetF()
//        {
//            return F;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            TypeA instance = new TypeA(1, 2, 3);

//            Console.WriteLine("Public field H: " + instance.H);

//            Console.WriteLine("Internal field G: " + instance.G);

//            Console.WriteLine("Private field F: " + instance.GetF());
//        }
//    }
//}





//Private:
//Scope: Limited to the class where it is declared.

//Visibility: Not accessible from outside the class. Use methods or properties to expose it if necessary.

//Internal:

//Scope: Limited to the same assembly (project).

//Visibility: Accessible from any code within the same assembly, but not from another assembly.

//Public:

//Scope: Unlimited.

//Visibility: Accessible from any code in the same or different assemblies.

#endregion


#region  the third problem

//using System;

//struct Employee
//{
//    private int empId;
//    private string name;
//    private decimal salary;

//    public Employee(int empId, string name, decimal salary)
//    {
//        this.empId = empId;
//        this.name = name;
//        this.salary = salary;
//    }

//    public int EmpId
//    {
//        get { return empId; }
//        set { empId = value; }
//    }

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public decimal Salary
//    {
//        get { return salary; }
//        set { salary = value; }
//    }

//    public string GetName()
//    {
//        return name;
//    }

//    public void SetName(string name)
//    {
//        this.name = name;
//    }

//    public override string ToString()
//    {
//        return $"Employee Id: {empId}, Name: {name}, Salary: {salary:C}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp = new Employee(1, "John Doe", 50000m);

//        Console.WriteLine("Employee Details (using properties):");
//        Console.WriteLine($"EmpId: {emp.EmpId}");
//        Console.WriteLine($"Name: {emp.Name}");
//        Console.WriteLine($"Salary: {emp.Salary:C}");

//        emp.Name = "Jane Smith";
//        emp.Salary = 60000m;

//        Console.WriteLine("\nEmployee Details (after modification):");
//        Console.WriteLine(emp.ToString());
//    }
//}


//Encapsulation is critical in software design for several reasons:

//Data Hiding: Encapsulation allows internal data of an object to be hidden from the outside world. This protects the integrity of the data by preventing unauthorized access and modifications.

//Control: By using methods and properties to access and modify data, you can enforce rules and validation, ensuring that the object remains in a valid state.

//Maintainability: Encapsulation simplifies maintenance by localizing changes. If the internal implementation of a class changes, the external interface (methods and properties) remains consistent, reducing the impact on other parts of the code.

//Modularity: Encapsulation promotes modular design by bundling data and behavior within a single unit (class or struct). This makes the code easier to understand, test, and reuse.

//Flexibility: Encapsulation allows you to modify the internal implementation of a class without affecting its external behavior, providing flexibility to evolve and optimize the code over time.


#endregion


#region the fourth problem 

//using System;

//struct Point
//{
//    public int X { get; }
//    public int Y { get; }

//    public Point(int x)
//    {
//        X = x;
//        Y = 0;
//    }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Point p1 = new Point(5);
//        Console.WriteLine("Point p1: " + p1.ToString());  

//        Point p2 = new Point(3, 4);
//        Console.WriteLine("Point p2: " + p2.ToString());  
//    }
//}



//Encapsulation ensures that the struct is initialized to a valid state and provides different ways to create instances with specific initial values,
//    making the struct versatile and easy to use.

#endregion


#region the fifth problem 

//using System;

//struct Point
//{
//    public int X { get; }
//    public int Y { get; }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"Point: [X = {X}, Y = {Y}]";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Point p1 = new Point(3, 4);
//        Point p2 = new Point(7, 1);
//        Point p3 = new Point(0, 0);

//        Console.WriteLine(p1.ToString());
//        Console.WriteLine(p2.ToString()); 
//        Console.WriteLine(p3.ToString()); 
//    }
//}


//Overriding methods like ToString significantly improves code readability and maintainability:

//Clarity: Custom ToString methods provide a clear and concise way to represent the object's state, making it easier for developers to understand the content of an object at a glance.

//Debugging: When printing objects for debugging purposes, a well-defined ToString method gives useful information about the object's current state, aiding in quicker identification of issues.

//Consistency: By standardizing how objects are represented as strings, it ensures a consistent format across the application, making the output predictable and easier to read.

//Communication: It improves the communication of an object's purpose and data, especially when objects are logged, displayed in user interfaces, or transmitted over networks.

//Ease of Use: Developers can call ToString on an object without needing to know the internal details, simplifying the process of logging or displaying object information.

#endregion


#region the sixth problem

//using System;

//struct Point
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}

//class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public Employee(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }

//    public override string ToString()
//    {
//        return $"Employee: {Name} (ID: {Id})";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Point point1 = new Point(5, 10);
//        Console.WriteLine("Original point: " + point1);
//        ModifyPoint(point1);
//        Console.WriteLine("Point after method call: " + point1);

//        Employee employee1 = new Employee(1, "John Doe");
//        Console.WriteLine("\nOriginal employee: " + employee1);
//        ModifyEmployee(employee1);
//        Console.WriteLine("Employee after method call: " + employee1);
//    }

//    static void ModifyPoint(Point p)
//    {
//        p.X = 100;
//        p.Y = 200;
//    }

//    static void ModifyEmployee(Employee e)
//    {
//        e.Name = "Jane Smith";
//    }
//}


//Structs(Value Types):

//Memory Allocation: Structs are allocated on the stack. When a struct is passed to a method, a copy of the struct is made.This means changes made to the struct inside the method do not affect the original struct.

//Performance: Stack allocation is generally faster and involves less overhead compared to heap allocation. This makes structs suitable for small, simple data structures.

//Lifetime: Structs have a shorter lifetime and are automatically deallocated when they go out of scope.

//Classes (Reference Types):

//Memory Allocation: Classes are allocated on the heap. When a class instance is passed to a method, a reference to the original instance is passed. This means changes made to the class instance inside the method do affect the original instance.

//Performance: Heap allocation is slower and involves more overhead compared to stack allocation. However, it allows for dynamic memory allocation, making classes suitable for complex, larger data structures.

//Lifetime: Class instances have a longer lifetime and are managed by the garbage collector, which automatically deallocates memory when they are no longer needed.


#endregion

