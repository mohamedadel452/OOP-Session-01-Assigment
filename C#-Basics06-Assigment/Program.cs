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


    #region 1. Create a DeliveryAddress struct
    public struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"{BuildingNumber} {Street}, {City}";
        }
    }
    #endregion


    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" Smart Delivery Management System \n");

            #region Read data form user 
            Console.WriteLine("please enter this data  ");
           
            Console.Write("City: ");
            string ?city = Console.ReadLine();

            Console.Write("Street: ");
            string ?street = Console.ReadLine();

            int buildNum;
            while (true)
            {
                Console.Write("Building Number: ");
              
                if (int.TryParse(Console.ReadLine(), out buildNum))
                {
                    break;
                }
                
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            #endregion

            #region Part 02 : Q1
            // Demonstrate the DeliveryAddress struct copy behavior
            Console.WriteLine("\n=== Struct Copy Test ===");
            DeliveryAddress originalAddress = new DeliveryAddress(city, street, buildNum);
            DeliveryAddress copiedAddress = originalAddress; // Copying a struct

            Console.WriteLine();

            //Print the two variable to see it before modificatio
            Console.WriteLine("Print the two variable to see it before modification "); 
            Console.WriteLine($"Original Address: {originalAddress.GetFullAddress()}");
            Console.WriteLine($"Copied Address: {copiedAddress.GetFullAddress()}");

            Console.WriteLine();

            //modify the data of the copy to see what will happen 
            copiedAddress.Street = "Makram Ebeid Street";
            copiedAddress.BuildingNumber = 20;

            //Print the two variable to see it after modification
            Console.WriteLine("Print the two variable to see it after modification ");
            Console.WriteLine($"Original Address: {originalAddress.GetFullAddress()}");
            Console.WriteLine($"Copied Address: {copiedAddress.GetFullAddress()}");
           
            Console.WriteLine();
            
            Console.WriteLine("As shown, modifying the copied address did not affect the original address because structs are passed by value.");

            #endregion





        }



    }
}
