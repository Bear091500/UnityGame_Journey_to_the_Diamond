using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Door door;
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Bird")){
            door.Disappear();
            Debug.Log("press");
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if (other.CompareTag("Bird")){
            door.Appear();
            Debug.Log("ex");
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
