using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open3DSound : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void click()
    {
        if (cube.GetComponent<Play3DSound>().play==false)
        {
            cube.GetComponent<Play3DSound>().play = true;
        }
        else
        {
            cube.GetComponent<Play3DSound>().play = false;
        }
        
    }
}
