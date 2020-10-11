using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int invokeTimer = 0;
    public TextAsset csvFile;
    CsvReader csvReader = new CsvReader();
    List<Row> rowList = new List<Row>();
    // Timer


    // Start is called before the first frame update
    void Start()
    {
        rowList = csvReader.Load(csvFile);

        // Timer start
        InvokeRepeating("InvokeTimer", 1.0f, 1.0f);
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        int index = 0;
        int lastIndex = rowList.Count - 1;

        while (true)
        {
            if (invokeTimer >= rowList[index].time)
            {
                Debug.Log(rowList[index].ToString());
                
                index++;
                if (index >= lastIndex)
                {
                    break;
                }
                yield return new WaitForSeconds(1);
            }
        }
    }

    void InvokeTimer()
    {
        invokeTimer++;
    }
}
