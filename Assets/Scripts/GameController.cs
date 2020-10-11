using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TextAsset csvFile;
    public float bulletSpeed = 5.0f;
    public GameObject AimingBullet;
    public GameObject DirectBullet;
    GameObject spawn;
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
        spawn = GameObject.FindGameObjectWithTag("Spawn");
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
        GameObject clone;

        switch (row.danmakuType)
        {
            case 1:
                // Aimming Bullet
                clone = Instantiate(AimingBullet, spawn.transform.position, spawn.transform.rotation);
                break;
            case 2:
            default:
                // Direct Bullet
                clone = Instantiate(DirectBullet, spawn.transform.position, spawn.transform.rotation);
                break;
        }
        BaseBullet bullet = clone.GetComponent<BaseBullet>();
        // Debug.Log(bullet.ToString());
        bullet.LoadFire();
        bullet.Fire(bulletSpeed);
    }
}
