using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Trigger hit by: " + col.gameObject.name + " | Tag: " + col.gameObject.tag);

        if (col.gameObject.CompareTag("Player"))
        {
            GameManager.instance.AddScore(10);
            Destroy(gameObject);
        }
    }
}