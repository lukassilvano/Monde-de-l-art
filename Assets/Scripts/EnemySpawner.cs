using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    public GameObject redEnemy, blueEnemy, yellowEnemy, blackEnemy, skinEnemy, brownEnemy, greenEnemy, darkGreenEnemy, orangeEnemy, purpleEnemy, grayEnemy, rainbowEnemy, eraser;
    public GameObject redXEnemy, blueXEnemy, yellowXEnemy, blackXEnemy, skinXEnemy, brownXEnemy, greenXEnemy, darkGreenXEnemy, orangeXEnemy, purpleXEnemy, grayXEnemy, rainbowXEnemy;
    public GameObject player;
    private float spawnTime;
    public Transform[] spawnPoints;


    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Teste")
        {
            spawnTime = 5f;
            InvokeRepeating("Spawn", spawnTime, spawnTime);
            InvokeRepeating("RainbowEnemy", 30, 60);
        }

        if (SceneManager.GetActiveScene().name == "Fase 2")
        {
            spawnTime = 5f;
            InvokeRepeating("Spawn", spawnTime, spawnTime);
            InvokeRepeating("RainbowEnemy", 30, 60);
        }

        if (SceneManager.GetActiveScene().name == "Fase 3")
        {
            spawnTime = 5f;
            InvokeRepeating("Spawn", spawnTime, spawnTime);
            InvokeRepeating("RainbowEnemy", 30, 60);
        }

        player.GetComponent<PaintCubes>();
    }

    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);


        if (SceneManager.GetActiveScene().name == "Teste")
        {
            int randomEnemy = Random.Range(1, 14);
            

            if (randomEnemy == 1 && player.GetComponent<PaintCubes>().rightRed < 43)
            {
                Instantiate(redEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 2 && player.GetComponent<PaintCubes>().rightBlue < 33)
            {
                Instantiate(blueEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 3 && player.GetComponent<PaintCubes>().rightYellow < 2)
            {
                Instantiate(yellowEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 4 && player.GetComponent<PaintCubes>().rightBlack < 7)
            {
                Instantiate(blackEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 5 && player.GetComponent<PaintCubes>().rightSkin < 40)
            {
                Instantiate(skinEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 6 && player.GetComponent<PaintCubes>().rightBrown < 26)
            {
                Instantiate(brownEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }

            if (randomEnemy == 7 && player.GetComponent<PaintCubes>().rightRed < 43)
            {
                Instantiate(redXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 8 && player.GetComponent<PaintCubes>().rightBlue < 33)
            {
                Instantiate(blueXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 9 && player.GetComponent<PaintCubes>().rightYellow < 2)
            {
                Instantiate(yellowXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 10 && player.GetComponent<PaintCubes>().rightBlack < 7)
            {
                Instantiate(blackXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 11 && player.GetComponent<PaintCubes>().rightSkin < 40)
            {
                Instantiate(skinXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 12 && player.GetComponent<PaintCubes>().rightBrown < 26)
            {
                Instantiate(brownXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 13 && player.GetComponent<PaintCubes>().rightBrown < 26)
            {
                Instantiate(rainbowXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            /*
            else if (randomEnemy == 14)
            {
                Instantiate(eraser, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
                Destroy(eraser, 30f);
            }
            */

        }

        if (SceneManager.GetActiveScene().name == "Fase 2")
        {
            int randomEnemy = Random.Range(1, 16);

            if (randomEnemy == 1 && player.GetComponent<PaintCubes>().rightRed < 70)
            {
                Instantiate(redEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 2 && player.GetComponent<PaintCubes>().rightGreen < 24)
            {
                Instantiate(greenEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 3 && player.GetComponent<PaintCubes>().rightYellow < 27)
            {
                Instantiate(yellowEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 4 && player.GetComponent<PaintCubes>().rightBlack < 156)
            {
                Instantiate(blackEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 5 && player.GetComponent<PaintCubes>().rightOrange < 81)
            {
                Instantiate(orangeEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 6 && player.GetComponent<PaintCubes>().rightDarkGreen < 12)
            {
                Instantiate(darkGreenEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 7 && player.GetComponent<PaintCubes>().rightGray < 12)
            {
                Instantiate(grayEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }

            if (randomEnemy == 8 && player.GetComponent<PaintCubes>().rightRed < 70)
            {
                Instantiate(redXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 9 && player.GetComponent<PaintCubes>().rightGreen < 24)
            {
                Instantiate(greenXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 10 && player.GetComponent<PaintCubes>().rightYellow < 27)
            {
                Instantiate(yellowXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 11 && player.GetComponent<PaintCubes>().rightBlack < 156)
            {
                Instantiate(blackXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 12 && player.GetComponent<PaintCubes>().rightOrange < 81)
            {
                Instantiate(orangeXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 13 && player.GetComponent<PaintCubes>().rightDarkGreen < 12)
            {
                Instantiate(darkGreenXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 14 && player.GetComponent<PaintCubes>().rightGray < 12)
            {
                Instantiate(grayXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 15 && player.GetComponent<PaintCubes>().rightGray < 12)
            {
                Instantiate(rainbowXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            /*
            else if (randomEnemy == 16)
            {
                Instantiate(eraser, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
                Destroy(eraser, 30f);
            }
            */
        }

        if (SceneManager.GetActiveScene().name == "Fase 3")
        {
            int randomEnemy = Random.Range(1, 16);

            if (randomEnemy == 1 && player.GetComponent<PaintCubes>().rightRed < 66)
            {
                Instantiate(redEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 2 && player.GetComponent<PaintCubes>().rightGreen < 24)
            {
                Instantiate(greenEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 3 && player.GetComponent<PaintCubes>().rightYellow < 58)
            {
                Instantiate(yellowEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 4 && player.GetComponent<PaintCubes>().rightBlack < 180)
            {
                Instantiate(blackEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 5 && player.GetComponent<PaintCubes>().rightOrange < 60)
            {
                Instantiate(orangeEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 6 && player.GetComponent<PaintCubes>().rightPurple < 76)
            {
                Instantiate(purpleEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 7 && player.GetComponent<PaintCubes>().rightBlue < 10)
            {
                Instantiate(blueEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }

            // Explosives
            if (randomEnemy == 8 && player.GetComponent<PaintCubes>().rightRed < 66)
            {
                Instantiate(redXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 9 && player.GetComponent<PaintCubes>().rightGreen < 24)
            {
                Instantiate(greenXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 10 && player.GetComponent<PaintCubes>().rightYellow < 58)
            {
                Instantiate(yellowXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 11 && player.GetComponent<PaintCubes>().rightBlack < 180)
            {
                Instantiate(blackXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 12 && player.GetComponent<PaintCubes>().rightOrange < 60)
            {
                Instantiate(orangeXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 13 && player.GetComponent<PaintCubes>().rightPurple < 76)
            {
                Instantiate(purpleXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 14 && player.GetComponent<PaintCubes>().rightBlue < 10)
            {
                Instantiate(blueXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            else if (randomEnemy == 15)
            {
                Instantiate(rainbowXEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            }
            /*
            else if (randomEnemy == 16)
            {
                Instantiate(eraser, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
                Destroy(eraser, 30f);
            }
            */
        }
    }

    void RainbowEnemy()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);   
        Instantiate(rainbowEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
