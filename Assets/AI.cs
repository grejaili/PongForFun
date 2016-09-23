using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {


    public float speed = 1;
    Vector3 targetpos;
    GameObject ballObj;
    Vector3 PlayerPos;
   



    // Use this for initialization
    void Start () {


       
	}
	
	// Update is called once per frame
	void Update () {
        ballObj = GameObject.FindGameObjectWithTag("Ball");
        targetpos = Vector3.Lerp(gameObject.transform.position,ballObj.transform.position,Time.deltaTime*speed);
        PlayerPos = new Vector3(-14, Mathf.Clamp(targetpos.y, -7, 7), 0);
        gameObject.transform.position = new Vector3(13, PlayerPos.y, 0);




	
	}
}
