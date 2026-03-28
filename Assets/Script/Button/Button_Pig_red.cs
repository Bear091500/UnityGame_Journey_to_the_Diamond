using UnityEngine;

public class Button_Pig_red : MonoBehaviour
{
    public string targetObjectName;
    float pressDepth = 0.1f; // 按下去的距離
    float speed = 5f;        // 動畫速度
    public Door2pressed door;
    private Vector3 originalPos;
    private Vector3 pressedPos;
    private bool isPressed = false;

    void Start()
    {
        originalPos = transform.localPosition;
        pressedPos = originalPos + new Vector3(0, -pressDepth, 0);
    }

    void Update()
    {
        if (isPressed)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, pressedPos, Time.deltaTime * speed);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, originalPos, Time.deltaTime * speed);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
            isPressed = true;

            if (door != null)
                door.Button1Pressed = true;

            Debug.Log("press");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
            isPressed = false;

            if (door != null)
                door.Button1Pressed = false;

            Debug.Log("ex");
        }
    }
    public void Disappear()
    {
        GetComponent<SpriteRenderer>().enabled = false; 
        GetComponent<Collider2D>().enabled = false;  
    }
}