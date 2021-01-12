using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    [SerializeField]
    private float _scrollSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Find the current position of the texture
        Vector2 currentTextureOffset = this.GetComponent<Renderer>().material.GetTextureOffset("_MainTex");
        //Determine the amount of movement in a fream
        float distanceToScrollLeft = Time.deltaTime * _scrollSpeed;
        //Set new offset for the texture
        float newTextureOffset_X = currentTextureOffset.x + distanceToScrollLeft;
        //Change the old offset with the new one
        currentTextureOffset = new Vector2(newTextureOffset_X,currentTextureOffset.y);
        //Set the final position on the texture
        this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex",currentTextureOffset);
    }
}
