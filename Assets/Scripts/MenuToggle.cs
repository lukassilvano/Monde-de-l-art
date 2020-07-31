using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToggle : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
       
    }

    IEnumerator Wait()
    {
        audioSource.Play();
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Victory");
    }


    public void Victory()
    {
        StartCoroutine(Wait());
    }

}
