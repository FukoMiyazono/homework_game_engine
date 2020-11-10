using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_control : MonoBehaviour
{

    //public Controller2D controller2D;

    public Texture coin;
    public Texture icon;

    private float screenPositionX = 0;
    private float screenPositionY = 0;

    private int iconSize;

    GameObject boy;

    void Start()
    {
        boy = GameObject.FindGameObjectWithTag("Player");
        GameObject.FindGameObjectWithTag("Finish").GetComponent<Renderer>().enabled = false;
        iconSize = UnityEngine.Screen.height/15;
    }
    
    void OnGUI()
    {
        GUI.DrawTexture(new Rect(screenPositionX, screenPositionY+0.5f*iconSize, 2*iconSize, 2*iconSize), icon, ScaleMode.StretchToFill, true, 0);
        int score = boy.GetComponent<catch_coin>().score;
        if (score <= 4)
        {
            for (int i = 0; i < score; i++)
            {
                GUI.DrawTexture(new Rect(screenPositionX + ((i + 2) * iconSize), screenPositionY, iconSize, iconSize), coin, ScaleMode.StretchToFill, true, 0);
            }
        }
        else
        {
            for (int i = 0; i < 4; i++)
            {
                GUI.DrawTexture(new Rect(screenPositionX + ((i + 2) * iconSize), screenPositionY, iconSize, iconSize), coin, ScaleMode.StretchToFill, true, 0);
            }
            for (int i = 0; i < score-4; i++)
            {
                GUI.DrawTexture(new Rect(screenPositionX + ((i + 2) * iconSize), screenPositionY + iconSize, iconSize, iconSize), coin, ScaleMode.StretchToFill, true, 0);
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
