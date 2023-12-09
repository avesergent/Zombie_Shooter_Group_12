using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 20f;
    public int bulletLifetime = 5;


    // Start is called before the first frame update
    void Start()
    {
        //Start despawn timer
        StartCoroutine(despawnTimer());
    }
    IEnumerator despawnTimer()
    {
        //Wait for time equal to integer set in distance
        yield return new WaitForSeconds(bulletLifetime);

        //Despawn bullet
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += bulletSpeed * transform.forward * Time.deltaTime;


    }
}
