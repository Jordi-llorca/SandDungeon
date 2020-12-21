using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;

    private void Update()
    {
        if(openingDirection == 1)
        {
            //Need BOTTOM door
        }
        else if (openingDirection == 2)
        {
            //Need TOP door
        }
        else if (openingDirection == 3)
        {
            //Need LEFT door
        }
        else if (openingDirection == 4)
        {
            //Need RIGHT door
        }
    }
}
