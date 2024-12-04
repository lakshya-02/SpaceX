using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHeart : MonoBehaviour
{
    [SerializeField] public float fallSpeed = 3f;

    private void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        if (transform.position.y < -7f) // Adjust boundary based on your game area
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.RestoreHealth();
            Destroy(gameObject); // Always destroy the heart after interaction
        }
        else if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Asteroid") || collision.gameObject.CompareTag("baz"))
        {
            return;
        }
    }
}
