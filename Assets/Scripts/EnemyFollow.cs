/*
using UnityEngine;
using System.Collections;

public class EnemyFollow : MonoBehaviour
{
    private Transform target;
    public int moveSpeed;
    public int rotationSpeed;
    public int maxDistance;

    private Transform myTransform;

    AudioSource audioSource;

    void Awake()
    {
        myTransform = transform;
    }
    // Use this for initialization
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        target = go.transform;
        audioSource = GetComponent<AudioSource>();
        //maxDistance = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (target != null)
        {
            Debug.DrawLine(target.position, myTransform.position, Color.yellow);

            //Look at target
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);

            if (Vector3.Distance(target.position, myTransform.position) < maxDistance)
            {
                //Move towards target
                GetComponent<Animation>().Play("Walk");
                if (audioSource.isPlaying == false)
                {
                    audioSource.Play(22100);
                }
                myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
            }
            else
            {
                GetComponent<Animation>().Play("Wait");
            }
        }

        
    }


}*/


using UnityEngine;
using System.Collections;
 
public class EnemyFollow : MonoBehaviour {
 
    public float wanderRadius;
    public float wanderTimer;
 
    private Transform target;
    private UnityEngine.AI.NavMeshAgent agent;
    private float timer;

    AudioSource audioSource;

    public int moveSpeed;
    public int rotationSpeed;
    public int maxDistance;

    private Transform myTransform;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        target = go.transform;
        //maxDistance = 1;
    }

    // Use this for initialization
    void OnEnable () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
        timer = wanderTimer;
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.tag == "BlackEnemy" || gameObject.tag == "BlueEnemy" || gameObject.tag == "BrownEnemy" || gameObject.tag == "DarkGreenEnemy" || gameObject.tag == "GreenEnemy" || gameObject.tag == "OrangeEnemy"
            || gameObject.tag == "PurpleEnemy" || gameObject.tag == "RedEnemy" || gameObject.tag == "SkinEnemy" || gameObject.tag == "YellowEnemy" || gameObject.tag == "GrayEnemy" || gameObject.tag == "RainbowEnemy")
        {
            if (gameObject.GetComponent<Enemy>().isWalking == true)
            {
                timer += Time.deltaTime;

                if (timer >= wanderTimer)
                {
                    Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
                    agent.SetDestination(newPos);
                    timer = 0;
                }

                if (agent.hasPath == true)
                {
                    GetComponent<Animation>().Play("Walk");
                    if (audioSource.isPlaying == false)
                    {
                        audioSource.Play(22100);
                    }
                }
                else
                {
                    GetComponent<Animation>().Play("Wait");
                }
            }
        }

        if (gameObject.tag == "BlackXEnemy" || gameObject.tag == "BlueXEnemy" || gameObject.tag == "BrownXEnemy" || gameObject.tag == "DarkGreenXEnemy" || gameObject.tag == "GreenXEnemy" || gameObject.tag == "OrangeXEnemy"
            || gameObject.tag == "PurpleXEnemy" || gameObject.tag == "RedXEnemy" || gameObject.tag == "SkinXEnemy" || gameObject.tag == "YellowXEnemy" || gameObject.tag == "GrayXEnemy" || gameObject.tag == "RainbowXEnemy"
            || gameObject.tag == "EraserEnemy")
        {
            if (gameObject.GetComponent<Enemy>().isWalking == true)
            {
                if (target != null)
                {
                    Debug.DrawLine(target.position, myTransform.position, Color.yellow);

                    //Look at target
                    myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);

                    if (Vector3.Distance(target.position, myTransform.position) < maxDistance)
                    {
                        //Move towards target
                        GetComponent<Animation>().Play("Walk");
                        if (audioSource.isPlaying == false)
                        {
                            audioSource.Play(22100);
                        }
                        myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
                    }
                    else
                    {
                        GetComponent<Animation>().Play("Wait");
                    }
                }

            }
        }
    }
 
    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;
 
        randDirection += origin;
 
        UnityEngine.AI.NavMeshHit navHit;
 
        UnityEngine.AI.NavMesh.SamplePosition (randDirection, out navHit, dist, layermask);
 
        return navHit.position;
    }
    void Awake()
    {
        myTransform = transform;
    }
}
