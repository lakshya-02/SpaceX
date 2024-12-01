using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCon : MonoBehaviour
{
    public float missilespeed = 1.0f;
    public Storwe store;
    public int num;

    private void Start()
    {
        num = 0;
    }
    void Update()
    {
        transform.Translate(Vector3.up*missilespeed*Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            GameObject gm = Instantiate(Gamemanager.instance.explosion,transform.position,transform.rotation);
            Destroy(gm, 2f);
            Destroy (this.gameObject);
            Destroy (collision.gameObject);
            store.x += 1;
            num = store.x;
        }
        
    }
}
