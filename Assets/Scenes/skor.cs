using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int skor = PlayerPrefs.GetInt("skor");
        GetComponent<Text> ().text = PlayerPrefs.GetInt("skor").ToString();
        if (skor != 0)
        {
            
            PlayerPrefs.SetInt("skor",0 );
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    
}
