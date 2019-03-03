using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    public static GameObject currentBallToJump;
    public GameObject[] balls;
    public InputField input;
    public GameObject stopperWall;
    public int currentCount = 0;
    private int jumpForce = 37;
    // Start is called before the first frame update
    void Start()
    {
        if(stopperWall == null){
            stopperWall = GameObject.Find("StopperWall");
        }
      // jumpForce = GameObject.Find
    }

    // Update is called once per frame
    void Update()
    {
      int.TryParse(input.text, out jumpForce);

      if(Input.GetKeyDown("f")){
        if(jumpForce < 37){
            Debug.Log("Please input a number");
        } else {
        Debug.Log("pressed F");
            try{
              GameObject currBall = balls[currentCount];
              currBall.GetComponent<Rigidbody>().AddForce(0,( 30 * jumpForce) ,0);
              StartCoroutine(WaitForNextBall());
            }
            catch(Exception e){
              Debug.Log(e);
            }
        }
      }
    }

    IEnumerator WaitForNextBall(){
        stopperWall.GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(1);
        stopperWall.GetComponent<Collider>().enabled = true;
        currentCount++;
    }
}
