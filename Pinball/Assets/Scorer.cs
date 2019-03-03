using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    public Text holeText;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "PlayBalls") {
            holeText.text += "X";
        }
    }
}
