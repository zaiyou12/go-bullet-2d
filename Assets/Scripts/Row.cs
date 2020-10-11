using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row
{
    public int time;
    public int danmakuType;
    public int danmakuCount;

    public override string ToString()
    {
        return "time: " + this.time + ", type: " + this.danmakuCount + ", count: " + this.danmakuCount;
    }
}