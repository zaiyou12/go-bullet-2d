using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsvReader
{
    public List<Row> Load(TextAsset csv){
        List<Row> rowList = new List<Row>();
        string[][] grid = CsvParser2.Parse(csv.text);

        for (int i = 1; i <grid.Length; i++){
            Row row = new Row();
            row.time = int.Parse(grid[i][0]);
            row.danmakuType = int.Parse(grid[i][1]);
            row.danmakuCount = int.Parse(grid[i][2]);

            rowList.Add(row);
        }
        return rowList;
    }
}
