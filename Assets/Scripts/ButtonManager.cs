using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject ScrollViewContent;
    public GameObject ButtonTemplate;



    void Start()
    {
        int btnCount = 20;
        for (int i = 0; i < btnCount; i++)
        {
            GameObject btn = (GameObject)Instantiate(ButtonTemplate);
            btn.transform.SetParent(ScrollViewContent.transform);
            btn.GetComponentInChildren<Text>().text = "Button "+(i+1);
           
        }
       
    }
  
}
