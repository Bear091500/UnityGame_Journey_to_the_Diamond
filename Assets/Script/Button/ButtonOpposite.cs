using UnityEngine;

public class ButtonOpposite : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Door_transparent door;
    void Start()
    {
        door.Disappear();
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Bird")){
            door.Appear();
            Debug.Log("press");
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if (other.CompareTag("Bird")){
            door.Disappear();
            Debug.Log("ex");
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
