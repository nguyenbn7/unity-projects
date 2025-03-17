using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    [SerializeField]
    float destroyDelay = 0.5f; // 1s

    [SerializeField]
    Color32 hasPackageColor;

    [SerializeField]
    Color32 noPackageColor;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Bump");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!!!!!");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered!!!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
