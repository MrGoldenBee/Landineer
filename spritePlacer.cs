using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritePlacer : MonoBehaviour
{
    public void OnLeftClick()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("u have pressed the left button");
        }

        if (Input.GetMouseButton(1))
        {
            Debug.Log("u have pressed the right mouse button");
        }
    }
}