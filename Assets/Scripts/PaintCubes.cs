using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaintCubes : MonoBehaviour
{
    public ParticleSystem ps;
    public GameObject canvas, script;
    public int rightCubes = 0, pick = 0;
    public int rightBlack = 0, rightBlue = 0, rightBrown = 0, rightDarkGreen = 0, rightGreen = 0, rightOrange = 0, rightPurple = 0, rightRed = 0, rightSkin = 0, rightYellow = 0, rightGray = 0;
    private bool istriggered = false;
    public bool readyToPaint = false, rainbowMode = false;
    public Color atualColor = Color.white, reserveColor = Color.white, brown, skin, purple, orange, darkGreen, x;
    public int actualInk = 0, reserveInk = 0, tmp;
    private int maxInk;
    public float timeLeft = 5f;
    public const int playerLife = 6;
    public int actualLife = playerLife;

    public AudioClip walkGrass, walkPaint, defeat;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        maxInk = 100;
        orange = new Color32(255, 140, 0, 1);
        purple = new Color32(75, 0, 130, 1);
        brown = new Color32(139, 69, 19, 1);
        skin = new Color32(245, 222, 179, 1);
        darkGreen = new Color32(0, 100, 0, 1);
        audioSource = GetComponent<AudioSource>();
    }

    IEnumerator Wait()
    {
        GetComponent<Animation>().Play("Attack");
        audioSource.PlayOneShot(defeat);
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("Menu");
    }

    public void TakeDamage(int amount)
    {
        actualLife -= amount;
        if (actualLife <= 0)
        {
            actualLife = 0;
            Destroy(this.gameObject);
            StartCoroutine(Wait());
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube" && other.GetComponent<CheckPaint>() && other.GetComponent<CheckPaint>().rightColor == false && other.gameObject.name != "Blank" && other.GetComponent<CheckPaint>().isActive == false)
        {
            //istriggered = true;
            if (audioSource.isPlaying == false)
            {
                audioSource.PlayOneShot(walkPaint, 1f);
            }
            checkColourChange(other);
        }

        if (other.gameObject.tag == "BlackInk" && istriggered == false)
        {
            pick = 1;
            istriggered = true;
            Destroy(other.gameObject);
            if (atualColor == Color.black && reserveColor != Color.black)
            {
                if (actualInk <= maxInk)
                {
                    actualInk += 10;
                }
            }
            if (atualColor != Color.black && reserveColor == Color.black)
            {
                if (reserveInk <= maxInk)
                {
                    reserveInk += 10;
                }
            }
            if (atualColor != Color.black && reserveColor != Color.black && actualInk == 0)
            {
                atualColor = Color.black;
                actualInk = 10;
            }
            if (atualColor != Color.black && reserveColor != Color.black && actualInk > 0 && reserveInk == 0)
            {
                reserveColor = Color.black;
                reserveInk = 10;
            }
            if (atualColor != Color.black && reserveColor != Color.black && actualInk > 0 && reserveInk > 0)
            {
                atualColor = Color.black;
                actualInk = 10;
            }

        }

        if (other.gameObject.tag == "BlueInk" && istriggered == false)
        {
            pick = 2;
            istriggered = true;
            Destroy(other.gameObject);
            if (atualColor == Color.blue && reserveColor != Color.blue)
            {
                if (actualInk <= maxInk)
                {
                    actualInk += 10;
                }
            }
            if (atualColor != Color.blue && reserveColor == Color.blue)
            {
                if (reserveInk <= maxInk)
                {
                    reserveInk += 10;
                }
            }
            if (atualColor != Color.blue && reserveColor != Color.blue && actualInk == 0)
            {
                atualColor = Color.blue;
                actualInk = 10;
            }
            if (atualColor != Color.blue && reserveColor != Color.blue && actualInk > 0 && reserveInk == 0)
            {
                reserveColor = Color.blue;
                reserveInk = 10;
            }
            if (atualColor != Color.blue && reserveColor != Color.blue && actualInk > 0 && reserveInk > 0)
            {
                atualColor = Color.blue;
                actualInk = 10;
            }
        }

        if (other.gameObject.tag == "BrownInk" && istriggered == false)
        {
            pick = 3;
            istriggered = true;
            Destroy(other.gameObject);

            if (atualColor == brown && reserveColor != brown)
            {
                if (actualInk <= maxInk)
                {
                    actualInk += 10;
                }
            }
            if (atualColor != brown && reserveColor == brown)
            {
                if (reserveInk <= maxInk)
                {
                    reserveInk += 10;
                }
            }
            if (atualColor != brown && reserveColor != brown && actualInk == 0)
            {
                atualColor = brown;
                actualInk = 10;
            }
            if (atualColor != brown && reserveColor != brown && actualInk > 0 && reserveInk == 0)
            {
                reserveColor = brown;
                reserveInk = 10;
            }
            if (atualColor != brown && reserveColor != brown && actualInk > 0 && reserveInk > 0)
            {
                atualColor = brown;
                actualInk = 10;
            }
        }

        if (other.gameObject.tag == "DarkGreenInk" && istriggered == false)
        {
            pick = 4;
            istriggered = true;
            Destroy(other.gameObject);

            if (atualColor == darkGreen && reserveColor != darkGreen)
            {
                if (actualInk <= maxInk)
                {
                    actualInk += 10;
                }
            }
            if (atualColor != darkGreen && reserveColor == darkGreen)
            {
                if (reserveInk <= maxInk)
                {
                    reserveInk += 10;
                }
            }
            if (atualColor != darkGreen && reserveColor != darkGreen && actualInk == 0)
            {
                atualColor = darkGreen;
                actualInk = 10;
            }
            if (atualColor != darkGreen && reserveColor != darkGreen && actualInk > 0 && reserveInk == 0)
            {
                reserveColor = darkGreen;
                reserveInk = 10;
            }
            if (atualColor != darkGreen && reserveColor != darkGreen && actualInk > 0 && reserveInk > 0)
            {
                atualColor = darkGreen;
                actualInk = 10;
            }
        }

        if (other.gameObject.tag == "GreenInk" && istriggered == false)
        {
            pick = 5;
            istriggered = true;
            Destroy(other.gameObject);

            if (atualColor == Color.green && reserveColor != Color.green)
            {
                if (actualInk <= maxInk)
                {
                    actualInk += 10;
                }
            }
            if (atualColor != Color.green && reserveColor == Color.green)
            {
                if (reserveInk <= maxInk)
                {
                    reserveInk += 10;
                }
            }
            if (atualColor != Color.green && reserveColor != Color.green && actualInk == 0)
            {
                atualColor = Color.green;
                actualInk = 10;
            }
            if (atualColor != Color.green && reserveColor != Color.green && actualInk > 0 && reserveInk == 0)
            {
                reserveColor = Color.green;
                reserveInk = 10;
            }
            if (atualColor != Color.green && reserveColor != Color.green && actualInk > 0 && reserveInk > 0)
            {
                atualColor = Color.green;
                actualInk = 10;
            }
        }

        if (other.gameObject.tag == "OrangeInk" && istriggered == false)
        {
            pick = 6;
            istriggered = true;
            Destroy(other.gameObject);

            if (atualColor == orange && reserveColor != orange)
            {
                if (actualInk <= maxInk)
                {
                    actualInk += 10;
                }
            }
            if (atualColor != orange && reserveColor == orange)
            {
                if (reserveInk <= maxInk)
                {
                    reserveInk += 10;
                }
            }
            if (atualColor != orange && reserveColor != orange && actualInk == 0)
            {
                atualColor = orange;
                actualInk = 10;
            }
            if (atualColor != orange && reserveColor != orange && actualInk > 0 && reserveInk == 0)
            {
                reserveColor = orange;
                reserveInk = 10;
            }
            if (atualColor != orange && reserveColor != orange && actualInk > 0 && reserveInk > 0)
            {
                atualColor = orange;
                actualInk = 10;
            }
        }

        if (other.gameObject.tag == "PurpleInk" && istriggered == false)
        {
            pick = 7;
            istriggered = true;
            Destroy(other.gameObject);

            if (atualColor == purple && reserveColor != purple)
            {
                if (actualInk <= maxInk)
                {
                    actualInk += 10;
                }
            }
            if (atualColor != purple && reserveColor == purple)
            {
                if (reserveInk <= maxInk)
                {
                    reserveInk += 10;
                }
            }
            if (atualColor != purple && reserveColor != purple && actualInk == 0)
            {
                atualColor = purple;
                actualInk = 10;
            }
            if (atualColor != purple && reserveColor != purple && actualInk > 0 && reserveInk == 0)
            {
                reserveColor = purple;
                reserveInk = 10;
            }
            if (atualColor != purple && reserveColor != purple && actualInk > 0 && reserveInk > 0)
            {
                atualColor = purple;
                actualInk = 10;
            }
        }

        if (other.gameObject.tag == "RedInk" && istriggered == false)
        {
            pick = 8;
            istriggered = true;
            Destroy(other.gameObject);
            if (atualColor == Color.red && reserveColor != Color.red)
            {
                if (actualInk <= maxInk)
                {
                    actualInk += 10;
                }
            }
            if (atualColor != Color.red && reserveColor == Color.red)
            {
                if (reserveInk <= maxInk)
                {
                    reserveInk += 10;
                }
            }
            if (atualColor != Color.red && reserveColor != Color.red && actualInk == 0)
            {
                atualColor = Color.red;
                actualInk = 10;
            }
            if (atualColor != Color.red && reserveColor != Color.red && actualInk > 0 && reserveInk == 0)
            {
                reserveColor = Color.red;
                reserveInk = 10;
            }
            if (atualColor != Color.red && reserveColor != Color.red && actualInk > 0 && reserveInk > 0)
            {
                atualColor = Color.red;
                actualInk = 10;
            }
        }

        if (other.gameObject.tag == "SkinInk" && istriggered == false)
        {
            pick = 9;
            istriggered = true;
            Destroy(other.gameObject);

            if (atualColor == skin && reserveColor != skin)
            {
                if (actualInk <= maxInk)
                {
                    actualInk += 10;
                }
            }
            if (atualColor != skin && reserveColor == skin)
            {
                if (reserveInk <= maxInk)
                {
                    reserveInk += 10;
                }
            }
            if (atualColor != skin && reserveColor != skin && actualInk == 0)
            {
                atualColor = skin;
                actualInk = 10;
            }
            if (atualColor != skin && reserveColor != skin && actualInk > 0 && reserveInk == 0)
            {
                reserveColor = skin;
                reserveInk = 10;
            }
            if (atualColor != skin && reserveColor != skin && actualInk > 0 && reserveInk > 0)
            {
                atualColor = skin;
                actualInk = 10;
            }
        }

        if (other.gameObject.tag == "YellowInk" && istriggered == false)
        {
            pick = 10;
            istriggered = true;
            Destroy(other.gameObject);

            if (atualColor == Color.yellow && reserveColor != Color.yellow)
            {
                if (actualInk <= maxInk)
                {
                    actualInk += 10;
                }
            }
            if (atualColor != Color.yellow && reserveColor == Color.yellow)
            {
                if (reserveInk <= maxInk)
                {
                    reserveInk += 10;
                }
            }
            if (atualColor != Color.yellow && reserveColor != Color.yellow && actualInk == 0)
            {
                atualColor = Color.yellow;
                actualInk = 10;
            }
            if (atualColor != Color.yellow && reserveColor != Color.yellow && actualInk > 0 && reserveInk == 0)
            {
                reserveColor = Color.yellow;
                reserveInk = 10;
            }
            if (atualColor != Color.yellow && reserveColor != Color.yellow && actualInk > 0 && reserveInk > 0)
            {
                atualColor = Color.yellow;
                actualInk = 10;
            }
        }

        if (other.gameObject.tag == "GrayInk" && istriggered == false)
        {
            pick = 11;
            istriggered = true;
            Destroy(other.gameObject);

            if (atualColor == Color.gray && reserveColor != Color.gray)
            {
                if (actualInk <= maxInk)
                {
                    actualInk += 10;
                }
            }
            if (atualColor != Color.gray && reserveColor == Color.gray)
            {
                if (reserveInk <= maxInk)
                {
                    reserveInk += 10;
                }
            }
            if (atualColor != Color.gray && reserveColor != Color.gray && actualInk == 0)
            {
                atualColor = Color.gray;
                actualInk = 10;
            }
            if (atualColor != Color.gray && reserveColor != Color.gray && actualInk > 0 && reserveInk == 0)
            {
                reserveColor = Color.gray;
                reserveInk = 10;
            }
            if (atualColor != Color.gray && reserveColor != Color.gray && actualInk > 0 && reserveInk > 0)
            {
                atualColor = Color.gray;
                actualInk = 10;
            }
        }

        if (other.gameObject.tag == "RainbowInk" && istriggered == false)
        {
            istriggered = true;
            Destroy(other.gameObject);
            actualInk = 1;
            reserveInk = 1;
            rainbowMode = true;
        }
    }

    void checkColourChange(Collider other)
    {

        if (readyToPaint == true && actualInk > 0)
        {
            if (other.GetComponent<Renderer>().material.color != atualColor && rainbowMode == false)
            {
                actualInk -= 1;
            }

            other.GetComponent<Renderer>().material.color = atualColor;
            //istriggered = false;

            if (rainbowMode == true)
            {
                if (other.gameObject.name == "Gray")
                {
                    other.GetComponent<Renderer>().material.color = Color.gray;
                    istriggered = false;
                }
                if (other.gameObject.name == "Green")
                {
                    other.GetComponent<Renderer>().material.color = Color.green;
                    istriggered = false;
                }
                if (other.gameObject.name == "DarkGreen")
                {
                    other.GetComponent<Renderer>().material.color = darkGreen;
                    istriggered = false;
                }
                if (other.gameObject.name == "Blue")
                {
                    other.GetComponent<Renderer>().material.color = Color.blue;
                    istriggered = false;
                }
                if (other.gameObject.name == "Red")
                {
                    other.GetComponent<Renderer>().material.color = Color.red;
                    istriggered = false;
                }
                if (other.gameObject.name == "Yellow")
                {
                    other.GetComponent<Renderer>().material.color = Color.yellow;
                    istriggered = false;
                }
                if (other.gameObject.name == "Skin")
                {
                    other.GetComponent<Renderer>().material.color = skin;
                    istriggered = false;
                }
                if (other.gameObject.name == "Purple")
                {
                    other.GetComponent<Renderer>().material.color = purple;
                    istriggered = false;
                }
                if (other.gameObject.name == "Orange")
                {
                    other.GetComponent<Renderer>().material.color = orange;
                    istriggered = false;
                }
                if (other.gameObject.name == "Brown")
                {
                    other.GetComponent<Renderer>().material.color = brown;
                    istriggered = false;
                }
                if (other.gameObject.name == "Black")
                {
                    other.GetComponent<Renderer>().material.color = Color.black;
                    istriggered = false;
                }
            }

            if (other.gameObject.name == "Brown" && other.GetComponent<Renderer>().material.color == brown && other.GetComponent<CheckPaint>().rightColor == false)
            {
                istriggered = false;
                other.GetComponent<CheckPaint>().rightColor = true;
                rightCubes++;
                rightBrown++;
            }
            if (other.gameObject.name == "Skin" && other.GetComponent<Renderer>().material.color == skin && other.GetComponent<CheckPaint>().rightColor == false)
            {
                istriggered = false;
                other.GetComponent<CheckPaint>().rightColor = true;
                rightCubes++;
                rightSkin++;
            }
            if (other.gameObject.name == "Red" && other.GetComponent<Renderer>().material.color == Color.red && other.GetComponent<CheckPaint>().rightColor == false)
            {
                istriggered = false;
                other.GetComponent<CheckPaint>().rightColor = true;
                rightCubes++;
                rightRed++;
            }
            if (other.gameObject.name == "Yellow" && other.GetComponent<Renderer>().material.color == Color.yellow && other.GetComponent<CheckPaint>().rightColor == false)
            {
                istriggered = false;
                other.GetComponent<CheckPaint>().rightColor = true;
                rightCubes++;
                rightYellow++;
            }
            if (other.gameObject.name == "Blue" && other.GetComponent<Renderer>().material.color == Color.blue && other.GetComponent<CheckPaint>().rightColor == false)
            {
                istriggered = false;
                other.GetComponent<CheckPaint>().rightColor = true;
                rightCubes++;
                rightBlue++;
            }
            if (other.gameObject.name == "Black" && other.GetComponent<Renderer>().material.color == Color.black && other.GetComponent<CheckPaint>().rightColor == false)
            {
                istriggered = false;
                other.GetComponent<CheckPaint>().rightColor = true;
                rightCubes++;
            }
            if (other.gameObject.name == "DarkGreen" && other.GetComponent<Renderer>().material.color == darkGreen && other.GetComponent<CheckPaint>().rightColor == false)
            {
                istriggered = false;
                other.GetComponent<CheckPaint>().rightColor = true;
                rightCubes++;
                rightDarkGreen++;
                
            }
            if (other.gameObject.name == "Green" && other.GetComponent<Renderer>().material.color == Color.green && other.GetComponent<CheckPaint>().rightColor == false)
            {
                istriggered = false;
                other.GetComponent<CheckPaint>().rightColor = true;
                rightCubes++;
                rightGreen++;
            }
            if (other.gameObject.name == "Orange" && other.GetComponent<Renderer>().material.color == orange && other.GetComponent<CheckPaint>().rightColor == false)
            {
                istriggered = false;
                other.GetComponent<CheckPaint>().rightColor = true;
                rightCubes++;
                rightOrange++;
            }
            if (other.gameObject.name == "Purple" && other.GetComponent<Renderer>().material.color == purple && other.GetComponent<CheckPaint>().rightColor == false)
            {
                istriggered = false;
                other.GetComponent<CheckPaint>().rightColor = true;
                rightCubes++;
                rightPurple++;
            }
            if (other.gameObject.name == "Gray" && other.GetComponent<Renderer>().material.color == Color.gray && other.GetComponent<CheckPaint>().rightColor == false)
            {
                istriggered = false;
                other.GetComponent<CheckPaint>().rightColor = true;
                rightCubes++;
                rightGray++;
            }
        }


    }

    void Victory(GameObject other)
    {
        if (SceneManager.GetActiveScene().name == "Teste")
        {
            if (rightCubes == 151)
            {
                //other.GetComponent<MenuToggle>().Victory();
                SceneManager.LoadScene("Fase 2");
                rightCubes = 0;
            }
        }

        if (SceneManager.GetActiveScene().name == "Fase 2")
        {
            if (rightCubes == 381)
            {
                //other.GetComponent<MenuToggle>().Victory();
                SceneManager.LoadScene("Fase 3");
                rightCubes = 0;
            }
        }

        if (SceneManager.GetActiveScene().name == "Fase 3")
        {
            if (rightCubes == 478)
            {
                other.GetComponent<MenuToggle>().Victory();
                rightCubes = 0;
            }
        }
    }

    void Update()
    {
        Text();
        Inputs();
        Victory(canvas);
        TimeRemaining();


    }


    void Inputs()
    {
        /* if (Input.GetKeyDown(KeyCode.P))
         {
             rightCubes = 151;
         }
         */
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("B"))
        {
            if (readyToPaint == false)
            {
                readyToPaint = true;
                ps.Play();
            }
            else
            {
                readyToPaint = false;
                ps.Stop();
            }
        }

        if (Input.GetButtonDown("Fire2") || Input.GetButtonDown("Y"))
        {
            tmp = actualInk;
            actualInk = reserveInk;
            reserveInk = tmp;

            x = atualColor;
            atualColor = reserveColor;
            reserveColor = x;
        }

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("Start"))
        {
            SceneManager.LoadScene("Menu");
        }
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene("Teste");
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            SceneManager.LoadScene("Fase 2");
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            SceneManager.LoadScene("Fase 3");
        }
    }

    void TimeRemaining()
    {
        if (rainbowMode == true)
        {
            timeLeft -= Time.deltaTime;
        }

        if (timeLeft <= 0)
        {
            rainbowMode = false;
            actualInk = 0;
            reserveInk = 0;
            atualColor = Color.white;
            reserveColor = Color.white;
            timeLeft = 5f;
        }
    }

    void OnTriggerExit(Collider coll)
    {
        istriggered = false;
    }

    void Text()
    {
        //Debug.Log(rightCubes);
        //Debug.Log("Tinta atual: " + actualInk);
        //Debug.Log("Tinta reserva: " + reserveInk);
    }

}