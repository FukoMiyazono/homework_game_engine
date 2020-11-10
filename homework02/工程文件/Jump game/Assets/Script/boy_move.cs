using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boy_move : MonoBehaviour
{
    public Rigidbody2D boy;
    public float speed_x;
    public float speed_y;
    private bool flag = true;
    public Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flag==true&&!Input.GetKeyDown(KeyCode.Return))
        {
            return;
        }
        else
        {
            GameObject.FindGameObjectWithTag("Instruction").GetComponent<Renderer>().enabled = false;
            flag = false;
            Move();
        }
        Move();
    }

    void Move() 
    {
        float horizontal_move = Input.GetAxisRaw("Horizontal");
        float vertical_move = Input.GetAxisRaw("Vertical");
        if (boy.position.x <= -11 && horizontal_move==-1)
        {
            horizontal_move = 0;
        }
        if (boy.position.x >=28 && horizontal_move == 1)
        {
            horizontal_move = 0;
        }
        boy.velocity = new Vector2(horizontal_move * speed_x, boy.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && boy.velocity.y==0)
        {

            boy.velocity = new Vector2(boy.velocity.x, speed_y);

        }
        if(horizontal_move!=0)
        {
            transform.localScale = new Vector3(horizontal_move, 1, 1);
        }
        anime.SetFloat("x_speed",Mathf.Abs(boy.velocity[0]));
        anime.SetFloat("y_speed", Mathf.Abs(boy.velocity[1]));
    }
}
