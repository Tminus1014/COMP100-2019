using System;
/*
 ********************************************************************************
 * Programming I - Winter 2019 Test 3 (Version C)
 * Name: Trent B Minia
 * Date: April 17, 2019
 * Student #: 301041132
 * Test 3 - 25% of final grade
 * 
 ******************************************************************************** 
 */

namespace VersionC
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuDisplay = true;
            string userSelection;

            while (menuDisplay == true)
            {
                DisplayMenu();
                userSelection = Console.ReadLine();
                switch (userSelection.ToUpper())
                {
                    case "A":
                        DemoQuestion3();
                        break;
                    case "V":
                        DemoQuestion4();
                        break;
                    case "P":
                        DemoQuestion5();
                        break;
                    case "T":
                        DemoQuestion6();
                        break;
                    case "X":
                        menuDisplay = false;
                        break;
                    default:
                        Console.WriteLine("error message");
                        break;
                }
            }
        }

        #region Question 1 - 12 marks
        /* 
         * Write a method that does not take any argument nor does it
         * return a value. The method only displays the following text.
         * 
         * YOU MUST INSERT YOUR NAME IN THE TOP LINE OF THE MENU 
         * 
         * +---------------------COMP100------------------------+
         * |           a) Working with array of integer         |
         * |           v) Volume Conversion                     |
         * |           p) Photo Electric Effect                 |
         * |           t) Calculate Federal Tax                 |
         * |                                                    | 
         * |           x) To exit the program                   |
         * +----------------------------------------------------+
         * Press the letter corresponding to your choice-> ");
         * 
         */
        
        static void DisplayMenu()
        {
            Console.WriteLine("+-------------Trent's-COMP100-Program----------------+");
            Console.WriteLine("|           a) Working with array of integer         |");
            Console.WriteLine("|           v) Volume Conversion                     |");
            Console.WriteLine("|           p) Photo Electric Effect                 |");
            Console.WriteLine("|           t) Calculate Federal Tax                 |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|           x) To exit the program                   |");
            Console.WriteLine("+----------------------------------------------------+");
            Console.Write("Press the letter corresponding to your choice-> ");
        }
        #endregion

        #region Question 2 - 26 marks
        /* 
         * In your Main() method, using a suitable looping structure, write the 
         * code to call this method repeatedly. 
         * Using a suitable branching structure, write the code to implement the 
         * following required functionality for all valid responses.
         * Valid responses includes both upper and lower case of the input. The 
         * following must be implemented:
         * A will call the DemoQuestion3() method
         * V will call the DemoQuestion4() method
         * P will call the DemoQuestion5() method
         * T will call the DemoQuestion6() method
         * X will terminate the program
         * Any other key will produce an error message
         * 
         * YOU DON'T HAVE TO CREATE A NEW METHOD FOR THIS QUESTION
         */
        #endregion

        #region Question 3 - 39 marks
        /* Question 3c (12 marks)
         * 
         * Write a method with the following specification
         * name     : DisplayOnlyEvenInt
         * arguments: array of int
         * returns  : nothing
         * display  : only the even items in the space
         * task     : use a suitable looping structure to send each 
         *            even item to the screen.
         * 
         * YOU MUST USE A FOR loop
         */

        static void DisplayOnlyEvenInt(int[] array)
        {
            for (int position = 0; position < array.Length; position++)
            {
                if (array[position] % 2 == 0)
                {
                    Console.Write($"{array[position]} ");
                }
            }
        }
       
        /* Question 3b (9 marks)
         * 
         * Write a method with the following specification
         * name     : DisplayIntArray
         * arguments: array of int
         * returns  : nothing
         * display  : all the items in the array seperated by a single space
         * task     : use a suitable looping structure to send each
         *            item to the screen.
         *            
         * YOU MUST USE A FOREACH loop
         */

        static void DisplayIntArray (int[] array)
        {
            foreach (int x in array)
            {
                Console.Write($"{x} ");
            }
        }
       

        /* Question 3a (11 marks)
         * 
         * Write a method with the following specification
         * name     : GenerateIntArray
         * arguments: int representing the number of char to generate
         *            i.e. the size of the resulting array
         * returns  : int array
         * display  : nothing
         * task     : 1) create the random object to generate random numbers
         *            2) declare and allocate storage for the array
         *            3) using a suitable looping structure get a random value 
         *               and assign it the element of the array
         *               use random.Next(10) to obtain a random char
         *            4) return the array
         */

        static int[] GenerateIntArray(int arraySize)
        {
            Random numbers = new Random();
            int[] array = new int[arraySize];

            for (int position = 0; position < arraySize; position++)
            {
                array[position] = numbers.Next(10);
            }

            return array;
        }
        

        /* The driver for question 3 (7 marks)
         * 
         * 1) Call GenerateIntArray with argument 35 and assign the 
         *    returned value to a suitable variable
         * 2) Use DisplayIntArray to print the above stored value
         * 3) Print an empty line
         * 4) Use DisplayOnlyEvenInt to print only the even items in the 
         *    above stored value
         */
        static void DemoQuestion3()
        {
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            int[] array = GenerateIntArray(35);
            DisplayIntArray(array);
            Console.WriteLine();
            DisplayOnlyEvenInt(array);

            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }
        #endregion

        #region Question 4 - 20 marks
        /* Question 4 (13 marks)
         * 
         * Write a method with the following specification
         * name     : VolumeConversion
         * arguments: an double representing the liter value to convert
         *            an double to store the milliliters
         *            an double to store the gallon
         *            an double to store the ounce
         * returns  : nothing
         * display  : nothing
         * task     : converts the first argument (liter amount) into 
         *            mils, gallons and ounces
         *           
         * hint     : 1 liter = 1000 mils                    
         *            1 liter = 0.2642 gallons
         *            1 liter = 33.8135 ounce
         */

        static void VolumeConversion(double liter, out double milliliters, out double gallon, out double ounce)
        {
            milliliters = liter * 1000;
            gallon = liter * 0.2642;
            ounce = liter * 33.8135;
        }
        

        /* The driver for question 4 (7 marks) 
         * 
         * 1) Declare a double variable (this will be your first argument) 
         *    and initialized it to 1
         * 2) Declare three other variables to store the mils, gallons and ounces
         * 3) Call the VolumeConversion with the appropriate arguments. 
         * 4) Print all of the arguments after the method call 
         * 5) Now change the first argument to 1.25 and repeat step 3 and 4.  
         */
        static void DemoQuestion4()
        {
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            double liter = 1, mils = 0, gallons = 0, ounces = 0;

            VolumeConversion(liter, out mils, out gallons, out ounces);
            Console.WriteLine($"{liter}L = {mils}ml, {gallons:F4}gal, {ounces:F4}oz");

            liter = 1.25; VolumeConversion(liter, out mils, out gallons, out ounces);
            Console.WriteLine($"{liter}L = {mils}ml, {gallons:F4}gal, {ounces:F4}oz");

            Console.WriteLine("\n**********End Question 4 **********\n\n");
        }
        #endregion

        #region Question 5 - 16 marks
        /* Question 5 (8 marks)
         * 
         * Einstein explained the photoelectric effect using the relationship
         * e=hc/l where h is the Planck constant and c is the speed of light and
         * l is the wavelength of the light involved
         * 
         * Write a method that calculates and returns the energy required to
         * emmit a photon of light. 
         * The specifications is as follows:
         * 
         * Name: 
         *  PhotoElectric
         *  
         * Argument: 
         *  a double representing the wavelength of the photon emited
         *  
         * Returns:
         *  a double indicating the energy change in this process
         *  
         * Action:
         *  Calculates and return the energy required. The  equation will 
         *  be writen on the whiteboard
         *  
         * Displays:
         *  nothing.
         * 
         */
        static double PhotoElectric(double wavelength)
        {
            double energyChange;

            // Energy = hc / upsidedown y

            const double h = 6.626e-034;
            const double c = 2.998e-008;

            energyChange = (h * c) / wavelength;

            return energyChange;
        }

        /* The driver for question 5 (8 mark)
         * 
         * 1) Declare a variable of type double and initialize to 5.55X10^-7
         * 2) Invoke the method with this variable and display the resulting value
         * 3) change the variable to 4.50X10^-7 and repeat Step 2.
         * 
         * HINT: use e for the format specifier 
         */
        static void DemoQuestion5()
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");
            double wavelength = 5.550e-007; double energyChange = PhotoElectric(wavelength);
            Console.WriteLine($"Photon of wavelength {wavelength} will req. {energyChange}J energy.");

            wavelength = 4.500e-007; energyChange = PhotoElectric(wavelength);
            Console.WriteLine($"Photon of wavelength {wavelength} will req. {energyChange}J energy.");
            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }
        #endregion

        #region Question 6 - 24 marks
        /* Question 6 (16 marks)
         * 
         * All Canadian are required to pay federal and provincial taxes. This question deals 
         * with federal tax calculation. The question specifications are as follows:
         * 
         * Name: 
         *  CalculateFederalTax
         *  
         * Argument: 
         *  a double representing the annual taxable income
         *  
         * Returns:
         *  a double indicating the federal tax owned to the government 
         *    
         * Action:
         *  Calculates and return the tax based on the following abridge table:
         *  15% on the first $45,282 of taxable income, +
         *  20.5% on the next $45,281 of taxable income (on the portion of taxable income over $45,282 up to $90,563), +
         *  33% of taxable income over $90,563.
         *  
         * Displays: nothing.
         *         
         */


        static double CalculateFederalTax(double taxableIncome)
        {
            double taxOwed = 0;

            if (taxableIncome <= 45282)
            {
                taxOwed += taxableIncome * 0.15;
            }
            if (taxableIncome >= 45282 && taxableIncome <= 90563)
            {
                taxOwed += (45282 * 0.15) + (taxableIncome - 45281) * 0.205;
            }
            if (taxableIncome > 90563)
            {
                taxOwed += (45282 * 0.15) + (45281 * 0.205) + (taxableIncome - 90563) * 0.33;
            }
            return taxOwed;
        }
       
        /* The driver for question 6 8 marks)
         * 
         * 1) Declare a double variable and initialized it to 40,000
         * 2) Invoke the CalculateFederalTax method with this variable and print the returned value
         * 3) Change the variable to 80,000 and repeat step 2
         * 4) Change the variable to 120,000 and repeat step 2
         */
        static void DemoQuestion6()
        {
            Console.WriteLine("\n\n**********Begin Question 6 **********");
            //code for invoking question 6 goes here
            double income = 40000;
            double owed = CalculateFederalTax(income);
            Console.WriteLine($"Income: {income:C} | Tax: {owed:C}");

            income = 80000;
            owed = CalculateFederalTax(income);
            Console.WriteLine($"Income: {income:C} | Tax: {owed:C}");

            income = 120000;
            owed = CalculateFederalTax(income);
            Console.WriteLine($"Income: {income:C} | Tax: {owed:C}");

            Console.WriteLine("\n**********End Question 6 **********\n\n");
        }
        #endregion
    }
}


