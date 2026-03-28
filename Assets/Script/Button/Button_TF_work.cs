using UnityEngine;

public class ButtonTF_work : MonoBehaviour
{
    public Door door;

    public Sprite offSprite;   // 原本圖片
    public Sprite onSprite;    // 切換後圖片

    private SpriteRenderer sr;
    private bool isOn = false;

    private bool canTrigger = true; // 避免角色卡在裡面時一直觸發

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = offSprite;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird") && canTrigger)
        {
            canTrigger = false;

            isOn = !isOn; // 切換狀態

            if (isOn)
            {
                sr.sprite = onSprite;
                if (door != null) door.Disappear();
            }
            else
            {
                sr.sprite = offSprite;
                if (door != null) door.Appear();
            }

            Debug.Log("toggle: " + isOn);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
            canTrigger = true;
        }
    }
}