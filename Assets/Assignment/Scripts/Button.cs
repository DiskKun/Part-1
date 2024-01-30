using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject cubePrefab;
    public Transform t;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cubePrefab, t);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(cubePrefab, t);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
