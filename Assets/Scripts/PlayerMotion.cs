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

        if (Input.GetKey(KeyCode.D)){
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
    public void PositionReset()
    {
        Vector3 res = new Vector3(0, 1, -45);
        rb.position = res;
        Vector3 resvel = new Vector3(0, 0, 0);
        rb.velocity = resvel;
    }
}
