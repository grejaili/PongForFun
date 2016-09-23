using UnityEngine;
using System.Collections;

public class ScorePlayer : MonoBehaviour {

    Rigidbody rb;
    GameObject ball;

    int i;
    public float ballVelocity = 1000;

    public int score = 0;
    bool gambs = false;
    bool isPlay;
    int randInt;

    public TextMesh currSco;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        randInt = Random.Range(1, 3);
    }

    void Update()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        currSco.text = "" + score;
        rb = GetComponent<Rigidbody>();
        restart();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "left")
        {
            gambs = true;
            if (gambs == true)
            {
                score++;
                Debug.Log(score);
                transform.position = new Vector3(0f, 0f, 0f);
                rb.velocity = new Vector3(0, 0, 0);
                isPlay = false;
                restart();
            }
            gambs = false;
        }
    }


    void restart()
    {
        if (Input.GetMouseButton(0) == true && isPlay == false)
        {
            transform.parent = null;
            isPlay = true;
            rb.isKinematic = false;
            if (randInt == 1)
            {
                rb.AddForce(new Vector3(ballVelocity, ballVelocity, 0));
            }
            if (randInt == 2)
            {
                rb.AddForce(new Vector3(-ballVelocity, -ballVelocity, 0));
            }
        }
        
    }





}
