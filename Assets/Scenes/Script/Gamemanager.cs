using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    public GameObject enemyPrefab;
    public float minInstantiateValue;
    public float maxInstantiateValue;
    [SerializeField] private float enemyDestroytime = 3f ;

    [Header("Particle Effects")]
    public GameObject explosion;
    public GameObject muzzlee;

    private void Awake()
    {
        instance = this;                                           
    }


    private void Start()
    {
        InvokeRepeating("InstantiateEnemy", 1f, 1f);
    }

    void InstantiateEnemy()
    {
        Vector3 enemyPos = new Vector3(Random.Range(minInstantiateValue, maxInstantiateValue), 6f);
        GameObject enemy = Instantiate(enemyPrefab, enemyPos, Quaternion.Euler(0f, 0f, 180f));
        Destroy(enemy,enemyDestroytime);
    }
    
}
