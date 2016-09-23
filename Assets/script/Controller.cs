using UnityEngine;

public class Controller : MonoBehaviour {
    public float paddleSpeed = 0.2f;
    public Vector3 PlayerPos;
    
   
    // Update is called once per frame
    void Update()
    {
        float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * paddleSpeed);
        PlayerPos = new Vector3(-14, Mathf.Clamp(yPos, -7, 7), 0);
        gameObject.transform.position = PlayerPos;
        
        

    }



}
