using UnityEngine;

public class Door_transparent : MonoBehaviour
{
    public float hiddenAlpha = 0.05098039f; // 淡顯示透明度
    public float showAlpha = 1f;     // 正常透明度

    private SpriteRenderer sr;
    private Collider2D col;
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
    }
    void Start()
    {
        

        // 一開始：淡 + 不能踩
        SetAlpha(hiddenAlpha);
        col.enabled = false;
    }

    public void Disappear() // 👉 現在代表「變實體」
    {
        SetAlpha(hiddenAlpha);
        col.enabled = false;
    }

    public void Appear() // 👉 現在代表「變回淡」
    {
        SetAlpha(showAlpha);
        col.enabled = true;
    }

    void SetAlpha(float alpha)
    {
        Color c = sr.color;
        c.a = alpha;
        sr.color = c;
    }
}