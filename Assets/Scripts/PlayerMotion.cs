using UnityEngine;

public class PlayerMotion : MonoBehaviour
{

    public Rigidbody rb; 
    public float fdforce = 2000f;
    public float sdforce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,fdforce*Time.deltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(sdforce,0,0);
        }
        else if (Input.GetKey("a")){
            rb.AddForce(-sdforce,0,0);
        }
        else{
            rb.AddForce(0,0,0);
        }
        if (rb.position.y < 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
