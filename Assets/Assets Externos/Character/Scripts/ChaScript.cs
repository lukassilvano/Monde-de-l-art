using UnityEngine;
using System.Collections;

public class ChaScript : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            anim.SetBool("RunLeft", true);
        }
        else
        {
            anim.SetBool("RunLeft", false);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("RunRight", true);
        }
        else
        {
            anim.SetBool("RunRight", false);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            anim.SetBool("RunBack", true);
        }
        else
        {
            anim.SetBool("RunBack", false);
        }

        if (Input.GetButton("Fire1"))
        {
            anim.SetBool("Attack", true);
        }
        else
        {
            anim.SetBool("Attack", false);
        }
        /*
        if (Input.GetButton("Fire1") && Input.GetKey(KeyCode.A) || Input.GetButton("Fire1") && Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Correndo e atirando.");
            anim.SetBool("RunLeft02_Attack", true);
        }
        else
        {
            anim.SetBool("RunLeft02_Attack", false);
        }*/
    }
}
