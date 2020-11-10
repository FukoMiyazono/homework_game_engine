using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawline : MonoBehaviour
{
    [SerializeField]
    private Transform trans_a;
    [SerializeField]
    private Transform trans_b;
    [SerializeField]
    private LineRenderer Line;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Line.SetPosition(0, trans_a.position);
        Line.SetPosition(1, trans_b.position);
        
    }
}
