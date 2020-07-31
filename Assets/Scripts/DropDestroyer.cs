using System.Collections;
using UnityEngine;

public class DropDestroyer : MonoBehaviour {

    float lifetime = 15.0f;
    
// Use this for initialization
    void Start () {
       InvokeRepeating("Blink", 10f, 0.4f);
       Destroy(this.gameObject, lifetime);
    }

    IEnumerator Blinking()
    {
        GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(0.2f);
        GetComponent<Renderer>().enabled = true;
    }

    void Blink()
    {
        StartCoroutine("Blinking");
    }

    // Update is called once per frame
    void Update () {
        {
            
        }
    }
}
