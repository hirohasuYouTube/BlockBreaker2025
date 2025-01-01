using UnityEngine;

public class BlockController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // 衝突したオブジェクトがボールか確認
        if (collision.gameObject.CompareTag("Ball"))
        {
            // ブロックを削除
            Destroy(gameObject);
        }
    }
}
