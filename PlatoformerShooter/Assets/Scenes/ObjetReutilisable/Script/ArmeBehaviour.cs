using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmeBehaviour : MonoBehaviour
{
    public GameObject bulletPrefab;     
    public Transform firePoint;         
    public float fireRate = 0.5f;       

    private float nextFireTime = 0f;    

    // Update is called once per frame
    void Update()
    {
        SuivreLaSouris();

        if (Input.GetMouseButtonDown(0) && Time.time >= nextFireTime) 
        {
            Tirer();
            nextFireTime = Time.time + fireRate; 
        }
    }

    void SuivreLaSouris()
    {
        Vector3 positionSouris = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = positionSouris - transform.position;
        direction.z = 0;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void Tirer()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
