using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PoolArray : MonoBehaviour
{
    public Letter letter;
    public GameObject grid;
    public GameObject latter;

    public char[] Array1 = new char[] { 'о', 'е', 'а', 'и', 'н', 'с', 'т', 'с', 'р', 'в' };
    public char[] Array2 = new char[] { 'л', 'к', 'м', 'д', 'п', 'у', 'я', 'ы' };
    public char[] Array3 = new char[] { 'ь', 'г', 'з', 'б', 'ч', 'й', 'х', 'ж' };
    public char[] Array4 = new char[] { 'ш', 'ю', 'ц', 'щ', 'э', 'ф', 'ъ', 'ё' };


    private void Start()
    {
        int randomizeArray = Random.Range(0, 5);
 
        if (randomizeArray == 1)
        {
            for (int i = 0; i < 30; i++)
            {
                var latterPref = Instantiate(latter, Vector3.zero, Quaternion.identity, grid.transform);

                latterPref.GetComponentInChildren<TextMeshProUGUI>().text = Array2[Random.Range(0, Array2.Length)].ToString();

            }
        }
            
        for (int i = 0; i < 40; i++)
        {
            var latterPref = Instantiate(latter, Vector3.zero, Quaternion.identity, grid.transform);

            latterPref.GetComponentInChildren<TextMeshProUGUI>().text = Array1[Random.Range(0, Array1.Length)].ToString();

        }

        for (int i = 0; i < 30; i++)
        {
            var latterPref = Instantiate(latter, Vector3.zero, Quaternion.identity, grid.transform);

            latterPref.GetComponentInChildren<TextMeshProUGUI>().text = Array2[Random.Range(0, Array2.Length)].ToString();

        }

        for (int i = 0; i < 20; i++)
        {
            var latterPref = Instantiate(latter, Vector3.zero, Quaternion.identity, grid.transform);

            latterPref.GetComponentInChildren<TextMeshProUGUI>().text = Array3[Random.Range(0, Array3.Length)].ToString();

        }

        for (int i = 0; i < 10; i++)
        {
            var latterPref = Instantiate(latter, Vector3.zero, Quaternion.identity, grid.transform);

            latterPref.GetComponentInChildren<TextMeshProUGUI>().text = Array4[Random.Range(0, Array4.Length)].ToString();

        }

    }

    public void FirstPool()
    {
        Random.Range(0, Array1.Length);
    }
}
