using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject BulletPrefab;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);

            Rigidbody rb = Bullet.GetComponent<Rigidbody>();
            rb. AddForce(transform.forward * 1000);

            Destroy(Bullet, 2f);
        }
    }
}
