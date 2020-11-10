using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catch_coin : MonoBehaviour
{
    private Vector3 boy_position;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        boy_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().MovePosition(boy_position);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coin")
        {
            Destroy(col.gameObject);
            score++;
        }
        if (col.gameObject.name == "stone")
        {
            GameObject.FindGameObjectWithTag("Finish").GetComponent<Renderer>().enabled = true;
        }
    }
}
