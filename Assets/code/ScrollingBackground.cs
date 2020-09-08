using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public Renderer background;
    public float backgroundspeed;
    void Start()
    {
        
    }

    
    void Update()
    {
        background.material.mainTextureOffset += new Vector2(backgroundspeed* Time.deltaTime, 0f);
    }
}
