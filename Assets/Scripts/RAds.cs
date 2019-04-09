using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class RAds : MonoBehaviour
{
   public void Awake()
 {
    SetupAds();
 }
 
 public void SetupAds()
 {
     if(PlayerPrefs.HasKey("AdFree")){
         return;
     }
     else if(Advertisement.IsReady()){
         Advertisement.Show();
     }
     Debug.Log(PlayerPrefs.HasKey("AdFree"));
 }
}
