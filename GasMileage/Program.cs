class GasMileage
{
    static void Main(string[] args)
    {
        // declaring required varibales
        int milesDriven = 0;
        int gallonsUsedTankful;
        int totalMilesDriven = 0;
        int totalGallonsUsedTankful = 0;
        float average;

        while (milesDriven != -1)
        {
            // input miles driven
            Console.Write("Enter Miles Driven (Or -1 To Exit):  ");
            milesDriven = Convert.ToInt32(Console.ReadLine());

            totalMilesDriven += milesDriven;

            // input gallons used for tankful
            Console.Write("Enter Gallons Used For Tankful:  ");
            gallonsUsedTankful = Convert.ToInt32(Console.ReadLine());

            // keeping record of total gallons used for tankful
            totalGallonsUsedTankful += gallonsUsedTankful;

            // calculating average
            average = (float) milesDriven / gallonsUsedTankful;

            // displaying mile per gallon
            Console.WriteLine("Miles Per Gallon:  " + Math.Round(average, 2));
        }

        average = totalMilesDriven / totalGallonsUsedTankful;

        // total miles per gallon
        Console.WriteLine("Total Miles Per Gallon In This Trip:  " + average);

        Console.WriteLine();    // just for spacing purpose
    }
}