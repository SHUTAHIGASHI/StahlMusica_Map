using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSave : MonoBehaviour
{
    MenuTest _menuTest;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            MenuTest.Test();
        }
    }
}
