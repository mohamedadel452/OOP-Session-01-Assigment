namespace OOP01_SmartDelivery
{
    #region PART 01: THEORETICAL QUESTIONS
    /* 
   ===================================================================================
   PART 01: THEORETICAL QUESTIONS
   ===================================================================================
   */
    #region Question 1:
    /*  - What happens when a DeliveryAddress (struct) is copied and modified?
      Answer: Since structs are Value Types, copying a DeliveryAddress creates a completely 
      independent clone in the Stack. Modifying the copy will NOT affect the original variable.

        - What happens when a Customer (class) is copied and modified?
      Answer: Since classes are Reference Types, copying a Customer variable only copies 
      the reference (the pointer). Both variables will point to the SAME object in the Heap. 
      Modifying one will affect the other.
    */
    #endregion

    #region Question 2:

    /* a) Identify at least three problems with the given struct design from an encapsulation perspective:
       1. No Data Validation: Public fields can be assigned any value (e.g., negative Weight or DeliveryFee).
       2. No Read-Only Control: Anyone can modify all fields at any time; there's no way to restrict modification .
       3. Loss of Control over State: If requirements change (e.g., calculating a tax on DeliveryFee), we cannot implement this logic easily without breaking existing code that accesses the field directly.

    b) How can private fields and public properties improve this design?
       Answer: Using private fields protects the actual data, while public properties provide 
       a controlled gateway. We can add validation logic inside the 'set' accessors to reject 
       invalid values, and we can make some properties read-only by removing the 'set' accessor 
       or making it private.

      */


    #endregion
    /*
   ===================================================================================
    */


    #endregion




    class Program
    {

        static void Main(string [] args)
        {
            Console.WriteLine(" Smart Delivery Management System \n");


        }


    }



}
