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

        #region Fields And Properties
        public string City;
        public string Street;
        public int BuildingNumber;

        #endregion

        #region Constructors
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        #endregion

        #region Methods
        public string GetFullAddress()
        {
            return $"{BuildingNumber} {Street}, {City}";
        }
        #endregion
    }
    #endregion


    #region 2.  Create Shipment struct
    public struct Shipment
    {

        #region Fields And Properties
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;

        // Destination: public read/write property.
        public DeliveryAddress Destination { get; set; }

        // TrackingCode: read-only from outside the struct.
        // It's set in the constructor. We provide a public getter and private setter.
        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }

        // Description: read/write property with validation.
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        // Weight: read/write property with validation.
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        // DeliveryFee: public getter and private setter.
        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        // EstimatedCost: a calculated property
        public decimal EstimatedCost
        {
            get { return DeliveryFee + (decimal)(Weight * 5); }
        }

        #endregion

        #region Constructors

        // Constructor 1: uses default values
        public Shipment(string trackingCode)
        {
            // Must initialize all fields in struct before calling property setters
            this.trackingCode = string.Empty;
            this.description = "Unknown";
            this.weight = 1.0;
            this.deliveryFee = 50.0m;
            this.Destination = new DeliveryAddress("Unknown City", "Unknown Street", 0);

            this.TrackingCode = trackingCode;
        }

        // Constructor 2: specific values
        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = string.Empty;
            this.description = "Unknown";
            this.weight = 1.0;
            this.deliveryFee = 50.0m;
            this.Destination = destination;

            this.TrackingCode = trackingCode;
            this.Description = description;
            this.Weight = weight;
            this.DeliveryFee = deliveryFee;
        }

        #endregion

        #region Methods
        // UpdateDeliveryFee Method
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                this.DeliveryFee = newFee;
            }
        }

        // PrintShipment Method
        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine(new string('-', 30));
        }

        #endregion 

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


            #region Part 02 : Q2



            #endregion







        }



    }
}
