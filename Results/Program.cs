using AssignmentD;
using static AssignmentD.Algorithms;

namespace Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ResultArray;//This array will be used to get response from DLL after each function
            int choice = 0;
            DisplayMenu();
            do
            {

                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("*************************************************");

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Swap");
                        Console.WriteLine("*************************************************");
                        Console.Write("\n\nEnter number of elements: ");
                        int max1 = Convert.ToInt32(Console.ReadLine());
                        int[] numbers1 = new int[max1];
                        for (int i = 0; i < max1; i++)
                        {
                            Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                            numbers1[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("\n");
                        Console.Write("Input int array : ");
                        Console.Write("\n");
                        for (int k = 0; k < max1; k++)
                        {
                            Console.Write(numbers1[k] + " ");

                        }
                        Console.Write("\n\nEnter Position To Swap: ");
                        int posistion = 2;
                        int[] array = new int[posistion];
                        for (int p = 0; p < posistion; p++)
                        {
                            Console.Write("\nEnter [" + (p + 1).ToString() + "] Position: ");
                            array[p] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("\n");

                        ResultArray = Algorithms.Swap(array[0], array[1], numbers1);
                        for (int i = 0; i < ResultArray.Length; i++)
                            Console.Write(numbers1[i] + " ");
                        Console.ReadLine();
                      
                        break;
                    case 2:
                        Console.WriteLine("Randomize");
                        Console.WriteLine("*************************************************");
                        Console.Write("\n\nEnter number of elements: ");
                        int max2 = Convert.ToInt32(Console.ReadLine());
                        int[] numbers2 = new int[max2];
                        for (int i = 0; i < max2; i++)
                        {
                            Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                            numbers2[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("\n");
                        Console.Write("Input int array : ");
                        Console.Write("\n");
                        for (int k = 0; k < max2; k++)
                        {
                            Console.Write(numbers2[k] + " ");

                        }
                        Console.Write("\n");
                        Console.WriteLine("Randomize");

                        ResultArray = Algorithms.Randomize(numbers2);
                        for (int i = 0; i < max2; i++)
                            Console.Write(ResultArray[i] + " ");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Prepare");
                        Console.WriteLine("*************************************************");
                        Console.Write("\n\nEnter number of elements: ");
                        int max = Convert.ToInt32(Console.ReadLine());
                        int[] numbers = new int[max];
                        for (int i = 0; i < max; i++)
                        {
                            Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("\n");
                        Console.Write("Input int array : ");
                        Console.Write("\n");
                        for (int k = 0; k < max; k++)
                        {
                            Console.Write(numbers[k] + " ");

                        }
                        Console.Write("\n");
                        Console.WriteLine("Prepare");

                        ResultArray = Algorithms.Prepare(numbers.Length);
                        for (int i = 0; i < max; i++)
                            Console.Write(ResultArray[i] + " ");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Insert Sort");
                        Console.WriteLine("*************************************************");
                        Console.Write("\n\nEnter number of elements: ");
                        int max4 = Convert.ToInt32(Console.ReadLine());
                        int[] numbers4 = new int[max4];
                        for (int i = 0; i < max4; i++)
                        {
                            Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                            numbers4[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("\n");
                        Console.Write("Input int array : ");
                        Console.Write("\n");
                        for (int k = 0; k < max4; k++)
                        {
                            Console.Write(numbers4[k] + " ");

                        }
                        Console.Write("\n");
                        Console.WriteLine("Insertion Sort");

                        Algorithms.InsertionSort(numbers4);
                        for (int i = 0; i < max4; i++)
                            Console.Write(numbers4[i] + " ");
                        Console.ReadLine();
                        SortDelegate SortDelegate = Algorithms.InsertionSort; //Initiating a Delegate
                        Console.WriteLine("Sorted array by using SortDelegate");
                        int ElapsedTimeInsertion = DisplayRunningTime(numbers4, SortDelegate);
                        foreach (int item in numbers4)
                        {
                            Console.Write(item + " ");
                        }
                        Console.Write("\n");
                        Console.WriteLine("Total number of values in array are {0} ", numbers4.Length);
                        Console.WriteLine("Insertion Sort Total Time elapsed: {0} MilliSeconds", ElapsedTimeInsertion);
                        break;
                    case 5:
                        Console.WriteLine("Selection Sort");
                        Console.WriteLine("*************************************************");
                        Console.Write("\n\nEnter number of elements: ");
                        int max5 = Convert.ToInt32(Console.ReadLine());
                        int[] numbers5 = new int[max5];
                        for (int i = 0; i < max5; i++)
                        {
                            Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                            numbers5[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("\n");
                        Console.Write("Input int array : ");
                        Console.Write("\n");
                        for (int k = 0; k < max5; k++)
                        {
                            Console.Write(numbers5[k] + " ");

                        }
                        Console.Write("\n");
                        Console.WriteLine("Selection Sort");

                        Algorithms.SelectionSort(numbers5);
                        for (int i = 0; i < max5; i++)
                            Console.Write(numbers5[i] + " ");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Bubble Sort");
                        Console.WriteLine("*************************************************");
                        Console.Write("\n\nEnter number of elements: ");
                        int max6 = Convert.ToInt32(Console.ReadLine());
                        int[] numbers6 = new int[max6];
                        for (int i = 0; i < max6; i++)
                        {
                            Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                            numbers6[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("\n");
                        Console.Write("Input int array : ");
                        Console.Write("\n");
                        for (int k = 0; k < max6; k++)
                        {
                            Console.Write(numbers6[k] + " ");

                        }
                        Console.Write("\n");
                        Console.WriteLine("Bubble Sort");

                        Algorithms.BubbleSort(numbers6);
                        for (int i = 0; i < max6; i++)
                            Console.Write(numbers6[i] + " ");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Merg Sort");
                        Console.WriteLine("*************************************************");
                        Console.Write("\n\nEnter number of elements: ");
                        int max7 = Convert.ToInt32(Console.ReadLine());
                        int[] numbers7 = new int[max7];
                        for (int i = 0; i < max7; i++)
                        {
                            Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                            numbers7[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("\n");
                        Console.Write("Input int array : ");
                        Console.Write("\n");
                        for (int k = 0; k < max7; k++)
                        {
                            Console.Write(numbers7[k] + " ");
                        }
                        Console.Write("\n");
                        Console.WriteLine("Merg Sort");

                        Algorithms.MergeSort(numbers7);
                        for (int i = 0; i < max7; i++)
                            Console.Write(numbers7[i] + " ");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Quick Sort");
                        Console.WriteLine("*************************************************");

                        Console.Write("\n\nEnter number of elements: ");
                        int max8 = Convert.ToInt32(Console.ReadLine());
                        int[] numbers8 = new int[max8];
                        for (int i = 0; i < max8; i++)
                        {
                            Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                            numbers8[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("\n");
                        Console.Write("Input int array : ");
                        Console.Write("\n");
                        for (int k = 0; k < max8; k++)
                        {
                            Console.Write(numbers8[k] + " ");

                        }
                        Console.Write("\n");
                        Console.WriteLine("Quick Sort");

                        Algorithms.QuickSort(numbers8);
                        for (int i = 0; i < max8; i++)
                            Console.Write(numbers8[i] + " ");
                        Console.ReadLine();
                        break;
                    case 9:
                        Console.WriteLine("Using Lambda");
                        Console.Write("\n\nEnter number of elements: ");
                        int max9 = Convert.ToInt32(Console.ReadLine());
                        int[] numbers9 = new int[max9];
                        for (int i = 0; i < max9; i++)
                        {
                            Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                            numbers9[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("\n");
                        Console.Write("Input int array : ");
                        Console.Write("\n");
                        for (int k = 0; k < max9; k++)
                        {
                            Console.Write(numbers9[k] + " ");
                        }
                        ResultArray = Algorithms.SortByLambda(numbers9);
                        Console.Write("\n");
                        Console.WriteLine("Lambda Expression");
                        for (int i = 0; i < max9; i++)
                            Console.Write(ResultArray[i] + " ");
                        Console.ReadLine();
                        break;
                    case 0: //end session (exit loop)
                        break;

                    default:
                        Console.WriteLine("Invalid option.  Choose between 0 and 9.");
                        break;
                }


            } while (choice != 0);
        }
        public static void DisplayMenu()
        {
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 6 + "}", "*************************************************"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 6 + "}", "MAIN MENU"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 6 + "}", "Swap           : 1"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 6 + "}", "Randomize      : 2"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 6 + "}", "Prepare        : 3"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 6 + "}", "Insert Sort    : 4"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 6 + "}", "Selection Sort : 5"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 6 + "}", "Bubble Sort    : 6"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 6 + "}", "Merg Sort      : 7"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 6 + "}", "Quick Sort     : 8"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 6 + "}", "Using Lambda   : 9"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 6 + "}", "Exit           : 0"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 6 + "}", "*************************************************"));
            Console.Write("\n");

        }
    }
}