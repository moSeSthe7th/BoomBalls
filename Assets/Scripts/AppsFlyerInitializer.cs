﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppsFlyerInitializer : MonoBehaviour
{
    void Start()
    {
        /* Mandatory - set your AppsFlyer’s Developer key. */
        AppsFlyer.setAppsFlyerKey("zcKrZYJWnrWWctCxcLNnyT");
        /* For detailed logging */
        /* AppsFlyer.setIsDebug (true); */
#if UNITY_IOS
  /* Mandatory - set your apple app ID
   NOTE: You should enter the number only and not the "ID" prefix */
  AppsFlyer.setAppID ("1474653825");
  AppsFlyer.trackAppLaunch ();
#elif UNITY_ANDROID
        /* Mandatory - set your Android package name */
        AppsFlyer.setAppID("com.UtmostGames.BoomBalls");
        /* For getting the conversion data in Android, you need to add the "AppsFlyerTrackerCallbacks" listener.*/
        AppsFlyer.init("zcKrZYJWnrWWctCxcLNnyT", "AppsFlyerTrackerCallbacks");
#endif
    }

}
