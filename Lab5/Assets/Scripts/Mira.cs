using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mira : MonoBehaviour
{
    public Texture2D mira;
    //public Rect position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //position = new Rect((Screen.width - mira.width) / 2, (Screen.height - mira.height) / 2, mira.width, mira.height); 
    }

    void OnGUI()
    {
        float width = mira.width / 2;
        float height = mira.height / 2;
        float position = Rect((Screen.width - width) / 2, (Screen.height - height) / 2, width, height);
        //float x = Screen.width - (Screen.width - Input.mousePosition.x) - (mira.width / 2);
        //float y = (Screen.height - Input.mousePosition.y) - (mira.height / 2);
        if(!Input.GetButton("Fire2"))
        {
            GUI.DrawTexture(position, mira);
        }
        //GUI.DrawTexture(new Rect(x, y, mira.width, mira.height), mira);
    }
}
