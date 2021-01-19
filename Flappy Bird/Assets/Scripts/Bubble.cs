using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _speed);
        //if the position on the y axis for the bubbke is greater than 10 we use reset.
        if(transform.position.y > 10)
        {
            Reset();
        }
    }

    void Reset()
    {
        float randomHeight = Random.Range(-8f,-18f);
        transform.position = new Vector3(transform.position.x,randomHeight,transform.position.z);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            //create a reference to our score script
            ScoreKeeper scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
            //check if we found the script
            if(scoreKeeper !=null)
            {
                //increase the score
                scoreKeeper.IncrementScore();
            }
            //reset the position of the bubble
            Reset();
        }
    }
}
