public class Variant19Utils
{
    public int CountCharactersWithoutSpaces(string text)
    {
        int count = 0;

        foreach (char symbol in text)
        {
            if (symbol != ' ')
            {
                count++;
            }
        }

        return count;
    }

    public int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        int[] result = new int[array1.Length + array2.Length];

        int i = 0;
        int j = 0;
        int k = 0;

        while (i < array1.Length && j < array2.Length)
        {
            if (array1[i] <= array2[j])
            {
                result[k] = array1[i];
                i++;
            }
            else
            {
                result[k] = array2[j];
                j++;
            }

            k++;
        }

        while (i < array1.Length)
        {
            result[k] = array1[i];
            i++;
            k++;
        }

        while (j < array2.Length)
        {
            result[k] = array2[j];
            j++;
            k++;
        }

        return result;
    }
}