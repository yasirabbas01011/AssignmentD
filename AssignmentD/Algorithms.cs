using System.Diagnostics;

namespace AssignmentD
{
    public static class Algorithms
    {
        public delegate int[] SortDelegate(int[] InputArray); //declaring a delegate


        //Swap function to swap 2 value in array with given positions
        public static int[] Swap(int position1, int position2, int[] inputarray)
        {
            int temp = 0;
            temp = inputarray[position1];
            inputarray[position1] = inputarray[position2];
            inputarray[position2] = temp;
            return inputarray;
        }
        //Randomize function to create a random array of data
        public static int[] Randomize(int[] inputarray)
        {
            Random rnd = new Random();// random class object

            for (int i = 0; i < inputarray.Length; i++)
            {
                inputarray[i] = rnd.Next(0, inputarray.Length * 10);
            }
            return inputarray;
        }
        //Prepare that takes an array size n as a parameter
        public static int[] Prepare(int ArraySize)
        {
            int[] ArrayToCreate = new int[ArraySize];
            ArrayToCreate = Randomize(ArrayToCreate);
            return ArrayToCreate;
        }
        //Insertion sort that takes an array
        public static int[] InsertionSort(int[] InputArray)
        {
            for (int i = 0; i < InputArray.Length; i++)
            {
                /*storing current element whose left side is checked for its 
                         correct position .*/

                int temp = InputArray[i];
                int j = i;

                /* check whether the adjacent element in left side is greater or
                     less than the current element. */

                while (j > 0 && temp < InputArray[j - 1])
                {

                    // moving the left side element to one position forward.
                    InputArray[j] = InputArray[j - 1];
                    j = j - 1;

                }
                // moving current element to its  correct position.
                InputArray[j] = temp;
            }

            return InputArray;
        }
        //SelectionSort that takes an array
        public static int[] SelectionSort(int[] InputArray)
        {
            int i, j, min_idx;

            // One by one move boundary of
            // unsorted subarray
            for (i = 0; i < InputArray.Length - 1; i++)
            {

                // Find the minimum element in
                // unsorted array
                min_idx = i;
                for (j = i + 1; j < InputArray.Length; j++)
                    if (InputArray[j] < InputArray[min_idx])
                        min_idx = j;

                // Swap the found minimum element
                // with the first element
                if (min_idx != i)
                    Swap(min_idx, i, InputArray);

            }

            return InputArray;
        }
        //BubbleSort that takes an array
        public static int[] BubbleSort(int[] InputArray)
        {
            int temp;
            for (int j = 0; j <= InputArray.Length - 2; j++)
            {
                for (int i = 0; i <= InputArray.Length - 2; i++)
                {
                    if (InputArray[i] > InputArray[i + 1])
                    {
                        temp = InputArray[i + 1];
                        InputArray[i + 1] = InputArray[i];
                        InputArray[i] = temp;
                    }
                }
            }

            return InputArray;
        }
        //MergeSort that takes an array
        public static int[] MergeSort(int[] InputArray)
        {
            // Code for MergeSort to be implemented here

            return InputArray;
        }
       public static  void MainMerge(int[] numbers, int l, int m, int r)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (m - 1);
            pos = l;
            num = (r - l + 1);

            while ((l <= eol) && (l <= r))
            {
                if (numbers[l] <= numbers[m])
                    temp[pos++] = numbers[l++];
                else
                    temp[pos++] = numbers[m++];
            }
            while (l <= eol)
                temp[pos++] = numbers[l++];
            while (m <= r)
                temp[pos++] = numbers[m++];
            for (i = 0; i < num; i++)
            {
                numbers[r] = temp[r];
                r--;
            }
        }
        static public void SortMerge(int[] numbers, int l, int r)
        {
            int m;
            if (r > l)
            {
                m = (r + l) / 2;
                SortMerge(numbers, l, m);
                SortMerge(numbers, (m + 1), r);
                MainMerge(numbers, l, (m + 1), r);
            }
        }
        //QuickSort that takes an array
        public static int[] QuickSort(int[] InputArray)
        {
            // Code for QuickSort to be implemented here

            return InputArray;
        }
        public static int[] SortByLambda(int[] InputArray)
        {
            // To Sort by Lambda Expression
            InputArray = InputArray.OrderBy(n => n).ToArray();
            return InputArray;
        }
        public static int DisplayRunningTime(int[] InputArray, SortDelegate SortDelegate)
        {
            // Create new stopwatch.
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Reset();
            // Begin timing.
            stopwatch.Start();
            SortDelegate.Invoke(InputArray); //To invoke the delegate

            // Stop timing.
            stopwatch.Stop();
            return (int)stopwatch.ElapsedTicks;

        }


    }
}