using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAPManager : MonoBehaviour
{
    public void Awake() {
        GameObject play = GameObject.Find("PlayButtonAds");
    }
    
    public void removeads() {
        Destroy(GameObject.Find("PlayButtonAds"));
    }

}
