using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 5;
    public GameObject missilePrefab;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(speed * Time.deltaTime * direction, 0, 0);
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missilePrefab, spawn.position, spawn.rotation);
        }
    }
}
