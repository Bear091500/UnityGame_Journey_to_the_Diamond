using UnityEngine;

public class Door : MonoBehaviour
{
    void Start(){
        
    }

    void Update()
    {
        
    }
    public void Disappear()
    {
        GetComponent<SpriteRenderer>().enabled = false; 
        GetComponent<Collider2D>().enabled = false;  
    }
    public void Appear()
    {
        GetComponent<SpriteRenderer>().enabled = true;  
        GetComponent<Collider2D>().enabled = true;   
    }
}
