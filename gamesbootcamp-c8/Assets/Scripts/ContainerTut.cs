using TMPro;
using UnityEngine;

public class ContainerTut : MonoBehaviour
{

    public int[] ages;
    public TextMeshProUGUI onScreenText;

    private void Start()
    {
        int average = Mean(ages);
        int range = Range(ages);

        onScreenText.text = "Average Age: " + average;
        onScreenText.text += ", Range of Age: " + range;
    }

    int Mean(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        { 
            sum += array[i];
        }


        return sum / array.Length;
    }

    int Range(int[] array)
    {
        System.Array.Sort(array);

        int min = array[0];
        int max = array[array.Length - 1];

        return max - min;
    }
}