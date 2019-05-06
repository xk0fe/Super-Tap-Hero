using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPref
{
    public string levelName { get; set; }
    public int star1 { get; set; }
    public int star2 { get; set; }
    public int star3 { get; set; }
    public int locked { get; set; }

    void Level(string levelName, int star1, int star2, int star3, bool locked)
    {
        this.levelName = levelName;
        this.star1 = 0;
        this.star2 = 0;
        this.star3 = 0;
        this.locked = 0;
    }
}
