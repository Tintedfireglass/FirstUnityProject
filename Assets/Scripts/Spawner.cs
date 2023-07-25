using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public Transform[] points;
    private float timer;
    public float tt = 0;
    private int temp = 10;
    public int gap = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
 
    Vector3 pos = FindObjectOfType<PlayerMotion>().rb.position;
        

        pos.z += temp;
        if (timer > tt)
        {
            temp += gap;
            gap += 5;
            GameObject obstacle = Instantiate(obstacles[0], points[Random.Range(0, 3)]);
            obstacle.transform.localPosition = pos;
            timer -= tt;
        }
        timer += Time.deltaTime;

        
    }
}
