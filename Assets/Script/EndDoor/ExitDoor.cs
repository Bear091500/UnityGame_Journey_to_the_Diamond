using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public string targetObjectName;   // 這扇門對應哪隻鳥，例如 "RedBird" 或 "BlueBird"
    public Transform ceilingPoint;    // 門最高升到哪裡
    public float moveSpeed = 2f;      // 升降速度
    private float closedY;            // 門一開始的Y位置（最低點）
    private float openY;              // 門最高的Y位置
    private bool shouldOpen = false;  // 是否應該往上升
    public bool isFullyOpen = false;  // 門是否已經完全打開

    void Start()
    {
        closedY = transform.position.y;

        openY = ceilingPoint.position.y;
    }

    void Update()
    {
        Vector3 pos = transform.position;

        if (shouldOpen)
        {
            // 往上升
            if (pos.y < openY)
            {
                pos.y += moveSpeed * Time.deltaTime;

                // 不要超過最高點
                if (pos.y > openY)
                {
                    pos.y = openY;
                }

                transform.position = pos;
            }

            // 升到最高點才算 fully open
            if (Mathf.Abs(transform.position.y - openY) < 0.001f)
            {
                isFullyOpen = true;
            }
            else
            {
                isFullyOpen = false;
            }
        }
        else
        {
            // 往下降
            if (pos.y > closedY)
            {
                pos.y -= moveSpeed * Time.deltaTime;

                // 不要低過初始位置
                if (pos.y < closedY)
                {
                    pos.y = closedY;
                }

                transform.position = pos;
            }

            // 只要不是打開狀態，就不是 fully open
            isFullyOpen = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == targetObjectName)
        {
            shouldOpen = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == targetObjectName)
        {
            shouldOpen = false;
        }
    }
}