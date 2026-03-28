using UnityEngine;

public class ButtonTF_Diamond : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Door door;
    bool isPressed = false;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Bird")&&isPressed==false){
            door.Disappear(); 
            isPressed=true;
        }
    }
    
}