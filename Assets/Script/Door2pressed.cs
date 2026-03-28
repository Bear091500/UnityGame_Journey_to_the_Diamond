using UnityEngine;

public class Door2pressed : MonoBehaviour
{
    public bool Button1Pressed = false;
    public bool Button2Pressed = false;
    void Start(){
        
    }

    void Update()
    {
        if(Button1Pressed == true && Button2Pressed == true)
        {
            Disappear();
        }
    }
    public void Disappear()
    {
        GetComponent<SpriteRenderer>().enabled = false; 
        GetComponent<Collider2D>().enabled = false;  
    }
}
