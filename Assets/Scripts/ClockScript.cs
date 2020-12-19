using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockScript : MonoBehaviour
{

    [SerializeField] Transform secondsPivot=default, minutesPivot=default, hoursPivot=default;
    
    float hoursToDegrees = 30f;
    float minutesToDegrees = 6f;
    float secondsToDegrees = 6f;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime time= DateTime.Now;

        hoursPivot.localRotation = Quaternion.Euler(0,hoursToDegrees*time.Hour,0);
        minutesPivot.localRotation = Quaternion.Euler(0,minutesToDegrees*time.Minute,0);
        secondsPivot.localRotation = Quaternion.Euler(0,secondsToDegrees*time.Second,0);
    }
}
