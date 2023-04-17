using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    bool hasPackage;
    [SerializeField] float destroyDelay = 0f;
    [SerializeField] Color32 hasPackageColor = new Color32(255,0,0,255);
    [SerializeField] Color32 noPackageColor = new Color32(0,255,255,255);



    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor;
    }




    private void OnCollisionEnter2D(Collision2D other) 
    {
        

        Debug.Log(message: "Ouch");


    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        
        if(other.tag == "Package" && !hasPackage){
            Debug.Log(message: "Package Picked Up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(obj: other.gameObject, t: destroyDelay);
            
            
        }

        if (other.tag == "DropZone" && hasPackage){
            Debug.Log(message: "Package Dropped Off");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }


}
