using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggleflame : MonoBehaviour
{
    public  GameObject flame;

    /*void Awake()
    {
        flame = GetComponent<GameObject>();
    }*/

    public void ToggleFlame()
    {
        if(flame.activeSelf)
            flame.SetActive(false);
        else flame.SetActive(true);
    }
    
}
