namespace ConsoleApp_OOP01
{

    // 1. Class
    // 2. Struct
    // 3. Interface
    // 4. Enum

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            // Struct : Value Types : Stack

            // Employee
            // Id , Name , Salary

            // Point : X,Y


            //Point P01;
            // Declare For Object From Type 'Point'
            // P01: Object 
            //Allocate UnInitialized 8 Bytes at STACK


            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);


            //P01.X = 12;
            //P01.Y= 12;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            // P01 = new Point();

            // New : Used For Select The Constructor

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //Console.WriteLine(P01);


            // P01.PrintPoint();

            // Console.WriteLine(P01.ToString()); // 
            #endregion

            #region OOP Overview

            // OOP : Object Oriented Programming
            // Programming Paradigm
            // OOP : The Paradigm Use For Build Any Business


            // Class  : Blueprint Of The Object
            // Object : Specific Instance From Class

            // 4 Pillars 
            // ================
            // 1. Encapsulation 
            // 2. Inheritance
            // 3. Ploymorphism
            // 4. Abstraction

            //object O1;
            //O1 = 1;
            //O1 = 1.5;
            //O1 = 1.5f;

            // Console.WriteLine();

            #endregion


            #region Encapsulation
            // 1. Encapsulation :
            // Class Or Struct
            // Seperate The Data (Attributes) Definition From Its Use
            // [Setter Getter Method or Properties]


            // Employee
            // Id ,Name , Salary

            // 1. End User Access data itself
            // 2. No Data Validation
            // 3. No Read Only Filed

            // Apply Encapsulation
            // 1. Make All Data (Attributes) Private
            // 2. Access Data Through
            //   2.1. Setter Getter Method
            //   2.2. Properties


            //Employee E01 = new Employee(1, "Ahmed Amin" , 20000);
            //Console.WriteLine(E01);


            // Id : Read Only Attributes

            //E01.id = 1;
            //E01.name = "Ahmed";
            //E01.salary = 20000;

            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.salary);

            //E01.SetId(1);
            //E01.SetName("Ahmed");
            //E01.SetSalary(20000);

            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary()); 



            //   2.2. Properties

            //Employee E01 = new Employee();

            //E01.Id = 12;
            //E01.Name = "Ahmed Amin";
            //E01.Salary = 20000;
            //E01.Address = "Cairo";


            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);
            //Console.WriteLine(E01.Address);
            #endregion

            #region Indexer
            //// Indexer : Special Property
            ////         1.Named  thise
            //// Phonebook :
            //Phonebook phonebook = new Phonebook(3);

            //phonebook.AddPerson("Ahmed",111,0);
            //phonebook.AddPerson("Menna",222,1);
            //phonebook.AddPerson("Omar",333,2);

            ////Console.WriteLine(phonebook.GetNumber("Ahmed"));

            ////phonebook.UpdateNumber("Ahmed", 999);

            //Console.WriteLine(phonebook["Ahmed"]); // long
            //phonebook["Ahmed"] = 1111;// long 
            #endregion


            #region  Class - Internal Constructor

            //// Class : Reference Type : HEAP

            //// Car : Id Model Speed 

            //Car C01;

            //// Decaler For Refernce (Pointer) From Type 'Car'
            //// C01 : Can Refer To Object From Type 'Car' Or Any Class Inherited From Car
            //// C01 : Refer To Null 

            ////Console.WriteLine(C01);

            //// 8 Bytes Will Be Allocated At STACK For The Reference 'C01'
            //// 0 Bytes Will Be Allocated At HEAP

            ////C01 = new Car(1);
            ////C01 = new Car(1 , 200);
            //C01 = new Car(1, 200, "XYZ");



            ////new 
            //// 1. Allocate The Number Of Required Bytes At HEAP For The Object  
            //// 2. Initailized The Allocated Bytes With The Value Of The DataTypes
            //// 3. Call User-Defined Constructor If Exists
            //// 4. Assign The Object To The Reference

            ////Console.WriteLine(C01.Id);
            ////Console.WriteLine(C01.Modle);
            ////Console.WriteLine(C01.Speed);

            //Console.WriteLine(C01); // ConsoleApp_OOP01.Car  
            #endregion


        }
    }
}
