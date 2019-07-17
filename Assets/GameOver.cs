using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;



public class GameOver : MonoBehaviour {
    public Text score;
//    public GameScript GameScript;

    // Start is called before the first frame update
    void Start()
    {
       score.text = string.Format("Score {0}", GameScript.AllScore);
    }



}
