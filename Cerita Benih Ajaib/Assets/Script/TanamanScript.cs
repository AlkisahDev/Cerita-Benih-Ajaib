using UnityEngine;

public class TanamanScript : MonoBehaviour
{
    public TanamanGenerator tanamanGenerator;
    void Update()
    {
        transform.Translate(Vector2.up * tanamanGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Spawner"))
        {
            tanamanGenerator.generateTanaman();
        }
    }
}
