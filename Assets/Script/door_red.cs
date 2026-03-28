using UnityEngine;

public class door_red : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool ispressed_red = false;
    void Start(){
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ispressed_red == true){
            GetComponent<SpriteRenderer>().enabled = false; // 門隱形
            GetComponent<Collider2D>().enabled = false;    // 門不擋路
        }

        if (ispressed_red == false){
            GetComponent<SpriteRenderer>().enabled = true;  // 門出現
            GetComponent<Collider2D>().enabled = true;     // 門擋住路
        }
    }
}
