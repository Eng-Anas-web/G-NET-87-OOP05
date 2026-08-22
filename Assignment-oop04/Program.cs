namespace Assignment_oop04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // Q1
            //a)  What is Abstraction in Object - Oriented Programming ?
            //A: Abstraction is the process of hiding the implemntation details and showing only the essential features of an object to the user
            //b)  Why is abstraction considered one of the four pillars of OOP?
            //A: 1- Reduces Complexity -- 2- improves maintainability -- 3- Enhaces Security -- 4- Promotes flesibilty and reusability

            #endregion

            #region Question02
            //Q2
            //a)  What is the difference between an Abstract Class and an Interface?
            //A: Abstract => Methode: Can have abstract and concrete methode , Fildes: Can have a feilds ,  Access Modifires: Can you use any access modifires , Constructor: Can have a constructor 
            //Interface =>  Methode: only abstruct methode , Fildes: Cannot have a feilds ,  Access Modifires: Members are public by default , Constructor: Cannot have a constructor 
            //b)  When would you choose an Interface instead of an Abstract Class?
            //A: We choose an Interface when we want to define a common contract that can be implemented by different classes, especially when the classes are not closely related.
            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            //A: No, a class cannot inherit from more than one Abstract Class , Yes, a class can implement multiple Interfaces. 
            #endregion
        }
    }
}
