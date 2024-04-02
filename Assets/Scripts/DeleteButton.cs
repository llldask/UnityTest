using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Obj;
    public void DestroyScriptInstance()
    {
        
        Destroy(Obj);
        Debug.Log("You have clicked the button!");
    }
}
