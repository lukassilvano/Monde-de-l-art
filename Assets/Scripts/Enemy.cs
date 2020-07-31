using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

    public float life = 5;
    private GameObject player;
    public bool isWalking = true, hasTouched = false;

    public AudioClip defeat;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        audioSource = GetComponent<AudioSource>();
    }
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Wait()
    {
        GetComponent<Animation>().Play("Attack");
        audioSource.PlayOneShot(defeat);
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("Menu");      
    }

    IEnumerator Wait3s()
    {
        hasTouched = false;
        yield return new WaitForSeconds(3f);
        isWalking = true;
        StopCoroutine("Wait3s");
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            var hit = player.gameObject;
            var health = hit.GetComponent<PaintCubes>();
            if (health != null)
            {
                health.TakeDamage(1);
            }

            Destroy(this.gameObject);
            // hasTouched = true;
            /*if (hasTouched == true)
            {
                if (other.gameObject.GetComponent<PaintCubes>().playerLife <= 0)
                {
                    hasTouched = false;
                    Destroy(other.gameObject);
                    StartCoroutine(Wait());
                }
                else
                {
                    isWalking = false;
                    GetComponent<Animation>().Play("Attack");
                    other.gameObject.GetComponent<PaintCubes>().playerLife--;
                    StartCoroutine("Wait3s");
                }
            }*/
            //Destroy(other.gameObject);
            //StartCoroutine(Wait());

        }

        if (other.gameObject.name == "Parede")
        {
            Physics.IgnoreCollision(other.collider, GetComponent<Collider>());
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "EraserEnemy" && other.gameObject.tag == "Cube" && other.gameObject.name != "Blank")
        {
            other.GetComponent<Renderer>().material.color = Color.white;

            if (other.GetComponent<CheckPaint>().rightColor == true && player.GetComponent<PaintCubes>().rightCubes > 0)
            {
                if (other.gameObject.name == "Black")
                {
                    other.GetComponent<CheckPaint>().rightColor = false;
                    player.GetComponent<PaintCubes>().rightCubes--;
                    player.GetComponent<PaintCubes>().rightBlack--;
                }
                if (other.gameObject.name == "Blue")
                {
                    other.GetComponent<CheckPaint>().rightColor = false;
                    player.GetComponent<PaintCubes>().rightCubes--;
                    player.GetComponent<PaintCubes>().rightBlue--;
                }
                if (other.gameObject.name == "Brown")
                {
                    other.GetComponent<CheckPaint>().rightColor = false;
                    player.GetComponent<PaintCubes>().rightCubes--;
                    player.GetComponent<PaintCubes>().rightBrown--;
                }
                if (other.gameObject.name == "DarkGreen")
                {
                    other.GetComponent<CheckPaint>().rightColor = false;
                    player.GetComponent<PaintCubes>().rightCubes--;
                    player.GetComponent<PaintCubes>().rightDarkGreen--;
                }
                if (other.gameObject.name == "Gray")
                {
                    other.GetComponent<CheckPaint>().rightColor = false;
                    player.GetComponent<PaintCubes>().rightCubes--;
                    player.GetComponent<PaintCubes>().rightGray--;
                }
                if (other.gameObject.name == "Green")
                {
                    other.GetComponent<CheckPaint>().rightColor = false;
                    player.GetComponent<PaintCubes>().rightCubes--;
                    player.GetComponent<PaintCubes>().rightGreen--;
                }
                if (other.gameObject.name == "Orange")
                {
                    other.GetComponent<CheckPaint>().rightColor = false;
                    player.GetComponent<PaintCubes>().rightCubes--;
                    player.GetComponent<PaintCubes>().rightOrange--;
                }
                if (other.gameObject.name == "Purple")
                {
                    other.GetComponent<CheckPaint>().rightColor = false;
                    player.GetComponent<PaintCubes>().rightCubes--;
                    player.GetComponent<PaintCubes>().rightPurple--;
                }
                if (other.gameObject.name == "Red")
                {
                    other.GetComponent<CheckPaint>().rightColor = false;
                    player.GetComponent<PaintCubes>().rightCubes--;
                    player.GetComponent<PaintCubes>().rightRed--;
                }
                if (other.gameObject.name == "Skin")
                {
                    other.GetComponent<CheckPaint>().rightColor = false;
                    player.GetComponent<PaintCubes>().rightCubes--;
                    player.GetComponent<PaintCubes>().rightSkin--;
                }
                if (other.gameObject.name == "Yellow")
                {
                    other.GetComponent<CheckPaint>().rightColor = false;
                    player.GetComponent<PaintCubes>().rightCubes--;
                    player.GetComponent<PaintCubes>().rightYellow--;
                }
            }
        }
    }
}
