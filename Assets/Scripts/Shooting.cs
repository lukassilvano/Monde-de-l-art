using System.Collections;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform bulletSpawn;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.2f);
        InstanciateBullet();
        audioSource.Play();
        yield return new WaitForSeconds(0.05f);
        InstanciateBullet();
        audioSource.Play();
        yield return new WaitForSeconds(0.05f);
        InstanciateBullet();
        audioSource.Play();
        yield return new WaitForSeconds(0.05f);
        InstanciateBullet();
        audioSource.Play();
    }

    void InstanciateBullet()
    {/*
        Rigidbody rocketInstance;
        rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
        rocketInstance.AddForce(barrelEnd.forward * 5000);*/

        var bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 60;

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("A"))
        {
            StartCoroutine(Wait());
        }
       
    }
}