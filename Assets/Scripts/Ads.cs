using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour
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
     // Setup your ads here
     if(Advertisement.IsReady()){
         Advertisement.Show();
     }
     Debug.Log(PlayerPrefs.HasKey("AdFree"));
 }
 
 public void RemoveAds()
 {
     if (PlayerPrefs.HasKey("AdFree"))
         print("Ads already removed");
     else{
         PlayerPrefs.SetInt("AdFree", 1);
         PlayerPrefs.Save();
     }
 }

}
