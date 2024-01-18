using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public Color off;
    public Color on;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger from: " + collision.gameObject);
        spriteRenderer.color = on;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = off;
    }

}
