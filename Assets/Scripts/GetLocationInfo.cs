using UnityEngine;
using UnityEngine.UI;

public class GetLocationInfo : MonoBehaviour {

    public Text text;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("StartLocation", 1, 5);
    }

    public void StartLocation()
    {
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        text.text = jo.Call<string>("GetInfo");
    }
}
