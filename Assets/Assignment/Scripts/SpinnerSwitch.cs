using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerSwitch : MonoBehaviour
{
    public GameObject spinner;
    public Color c_On;
    public Color c_Off;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (spinner.activeInHierarchy)
        {
            spinner.SetActive(false);
            sr.color = c_Off;
        } else
        {
            spinner.SetActive(true);
            sr.color = c_On;
        }
    }
}
