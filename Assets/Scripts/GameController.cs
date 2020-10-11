using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TextAsset csvFile;
    public GameObject AimingBullet;
    public GameObject enemy;
    CsvReader csvReader = new CsvReader();
    List<Row> rowList = new List<Row>();
    private float timer = 0.0f;
    private int curIndex = 0;
    private int lastIndex = 0;

    void Awake()
    {
        Time.timeScale = 1.0f;
    }
    void Start()
    {
        rowList = csvReader.Load(csvFile);
        lastIndex = rowList.Count;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (curIndex < lastIndex && timer > rowList[curIndex].time)
        {
            SpawnDanmaku(rowList[curIndex]);
            curIndex++;
        }
    }

    void SpawnDanmaku(Row row)
    {
        Debug.Log(row.ToString());
        Instantiate(AimingBullet, enemy.transform.position,  enemy.transform.rotation);
    }
}
