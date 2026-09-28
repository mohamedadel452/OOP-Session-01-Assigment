namespace OOP01_SmartDelivery
{

    /* 
   ===================================================================================
   PART 01: THEORETICAL QUESTIONS
   ===================================================================================
   Question 1:
   - What happens when a DeliveryAddress (struct) is copied and modified?
     Answer: Since structs are Value Types, copying a DeliveryAddress creates a completely 
     independent clone in the Stack. Modifying the copy will NOT affect the original variable.

   - What happens when a Customer (class) is copied and modified?
     Answer: Since classes are Reference Types, copying a Customer variable only copies 
     the reference (the pointer). Both variables will point to the SAME object in the Heap. 
     Modifying one will affect the other.

   
   ===================================================================================
   */




    class Program
    {

        static void Main(string [] args)
        {
            Console.WriteLine(" Smart Delivery Management System \n");


        }


    }



}
