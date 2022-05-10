using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangingWithDelegates : MonoBehaviour
{
    public delegate void ActionButtonClick();
    public static event ActionButtonClick buttonClick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CubeColorToChange()
    {
        if(buttonClick != null)
        {
            buttonClick();
        }

    }
}
