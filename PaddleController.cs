using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 水平方向の入力を取得
        float inputX = Input.GetAxis("Horizontal");

        // パドルを左右に動かす
        rb.linearVelocity = new Vector2(inputX * speed, 0);
    }
}