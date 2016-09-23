using UnityEngine;
using System.Collections;

public class Acell : MonoBehaviour
{

    Rigidbody rigid;
 
    // Update is called once per frame
    void Awake()
    {
        rigid = gameObject.GetComponent<Rigidbody>();

    }



    void OnCollisionEnter(Collision collision)
    {
        float aceleracao = 500;
        if (collision.gameObject.name == "PaddleLeft")
        {
            
            
            rigid.AddForce(new Vector3(aceleracao, aceleracao, 0));
        }

        if (collision.gameObject.name == "PaddleRight")
        {
            rigid.AddForce(new Vector3(-aceleracao, -aceleracao, 0));
        }



    }

}
