using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//to relaod the scene when ball falls down

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;//determines how fast the ball moves ...
    Rigidbody rb;//to refer the ridit body attached to the ball..
    //to store our inputs..left,right,up and down.
    float xInput;
    float yInput;
    int score = 0;
    public int winscore;
    public GameObject winText;
    //to acess rigid body
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


  
    // Update is called once per frame
    void Update()
    {
      if(transform.position.y < -5f)
        {
            SceneManager.LoadScene("game");
        }
    }
    //fix properties when we use physics  and to give smooth movements
    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");//default will give input from left and right arrow keys
        yInput = Input.GetAxis("Vertical");//input from up and down arrows
        //addforce use to move the ball
        rb.AddForce(xInput * speed,0,yInput * speed);
    }


    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "coin")
        {
            other.gameObject.SetActive(false);
            score++;
            if(score >= winscore)
            {
                winText.SetActive(true);
            }
        }
    }

}
