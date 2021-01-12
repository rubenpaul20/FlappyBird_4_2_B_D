using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;
    [SerializeField]
    private bool _randomizeHeight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3.left = Vector3(-1,0,0)
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        //check if the position of the seaweed on the x axis is smaller than -15
        if(transform.position.x < -15)
        {
            if(_randomizeHeight)
            {
                //Generate a random numberwith a range of -3,3
                float randomYPosition = Random.Range(-3f,3f);
                Debug.Log("Your random positionis:" + randomYPosition);
                //change the position to 15 on the x axis
                transform.position = new Vector3(15,randomYPosition,0);
            }
            
        }
    }
}
