using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    [Header("Missile")]
    public GameObject missile;
    public Transform missileSpawnPosition;
    public float destroyTime;
    public Transform muzzleSpawnPos;

    private void Update()
    {
        PlayerMovement();
        PlayerShoot();
    }

    void PlayerMovement()
    {
        // Player Movement
        float xPos = Input.GetAxis("Horizontal");
        float yPos = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(xPos, yPos, 0) * speed * Time.deltaTime;
        transform.Translate(movement);
    }

    void PlayerShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnMissile();
            Spawnmuzzlee();
        }
    }
    void SpawnMissile()
    {
        GameObject gm = Instantiate(missile, missileSpawnPosition);
       
        gm.transform.SetParent(null);
        Destroy(gm, destroyTime);
    }
    void Spawnmuzzlee()
    {
        GameObject muzzle = Instantiate(Gamemanager.instance.muzzlee, muzzleSpawnPos);
        muzzle.transform.SetParent(null);
        Destroy(muzzle, destroyTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject gm = Instantiate(Gamemanager.instance.explosion, transform.position, transform.rotation);
            Destroy(gm, 2f);
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Debug.Log("Game Over");
        }
    }
    

}
