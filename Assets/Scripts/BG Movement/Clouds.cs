using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : BGMove
{

    void Start()
    {
        if (this.gameObject.name == "Clouds")
        {
            Clouds();
        }
        else if (this.gameObject.name == "CloudsAlt")
        {
            CloudsAlt();
        }
        else
        {
            Debug.LogWarning("Check Gameobject name! Movement speed set to default");
            Clouds();
        }
    }
}
