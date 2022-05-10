using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOneScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        CubeChangingPosition.onActionClick += ToChangePosition;
        
    }

    // Update is called once per frame
    void Update()
    {



    }
    public void ToChangePosition()
    {
        transform.position = new Vector3(5f, 5f, 5f);
    }

}
