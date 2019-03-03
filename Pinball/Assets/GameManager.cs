using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    public static GameObject currentBallToJump;
    public GameObject[] balls;
    public int currentCount = 0;
    public InputField input;
    private int jumpForce = 37;
    // Start is called before the first frame update
    void Start()
    {
      // jumpForce = GameObject.Find
    }

    // Update is called once per frame
    void Update()
    {
      int.TryParse(input.text, out jumpForce);
      if(Input.GetKeyDown("f")){
        if(jumpForce < 37){
            Debug.Log("Please input a number")
        } else {
        Debug.Log("pressed F");
            try{
              GameObject currBall = balls[currentCount];
              Debug.Log(currBall);
              currBall.GetComponent<Rigidbody>().AddForce(0,( 30 * jumpForce) ,0);
              currentCount++;
            }
            catch(Exception e){
              Debug.Log(e);
            }
        }
      }
    }
}
