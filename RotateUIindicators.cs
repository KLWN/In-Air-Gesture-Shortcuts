using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUIindicators : MonoBehaviour
{


    public GameObject uIIndicators;
    
    void Update()
    {
        var eulerAngles = this.transform.eulerAngles;
        
        Vector3 newScaleX = new Vector3(eulerAngles.x, eulerAngles.y, eulerAngles.z);
        uIIndicators.transform.eulerAngles = newScaleX;
    }
}










