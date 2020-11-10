using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{

    private Transform boy;
    private Vector3 offset;
    private float smoothing = 3;

    // Use this for initialization
    void Start()
    {
        boy = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - boy.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (boy.position.x <=-8 || boy.position.x >= 26)
        {
            offset.x = transform.position.x - boy.position.x;
        }
    
            Vector3 targetPosition = boy.position + boy.TransformDirection(offset);
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothing);
    
    }
}
