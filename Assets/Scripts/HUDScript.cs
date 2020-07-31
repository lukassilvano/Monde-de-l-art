using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDScript : MonoBehaviour {

    public Text actualColor, reserveColor, ready;
    public Image actual, reserve, myImageComponent, brush, life;
    public GameObject player, RM1, RM2;
    private Color brown, skin, purple, orange, darkGreen, x;
    private double progressionMario = 0f;
    private double progressionSamus = 0f;
    private double progressionMajora = 0f;
    public Sprite Bolhas00, Bolhas01, Bolhas02, Bolhas03, Bolhas04, Bolhas05, Bolhas06, Bolhas07, Bolhas08, Bolhas09, Bolhas10, brushOn, brushOff, life6, life5, life4, life3, life2, life1, life0;
    // Use this for initialization
    void Start () {
        player.GetComponent<PaintCubes>();
        orange = new Color32(255, 140, 0, 255);
        purple = new Color32(75, 0, 130, 255);
        brown = new Color32(139, 69, 19, 255);
        skin = new Color32(245, 222, 179, 255);
        darkGreen = new Color32(0, 100, 0, 255);

        myImageComponent.sprite = Bolhas00;
    }
	
	// Update is called once per frame
	void Update () {
        CoresDaPaleta();
        Progressão();
    }

    void CoresDaPaleta()
    {
        //Cor atual
        if (player.GetComponent<PaintCubes>().atualColor.Equals(Color.white) == true)
        {
            actualColor.text = player.GetComponent<PaintCubes>().actualInk.ToString();
            actual.color = Color.white;
        }

        if (player.GetComponent<PaintCubes>().atualColor.Equals(Color.green) == true)
        {
            actualColor.text = player.GetComponent<PaintCubes>().actualInk.ToString();
            actual.color = Color.green;
        }

        if (player.GetComponent<PaintCubes>().atualColor.Equals(Color.yellow) == true)
        {
            actualColor.text = player.GetComponent<PaintCubes>().actualInk.ToString();
            actual.color = Color.yellow;
        }

        if (player.GetComponent<PaintCubes>().atualColor.Equals(Color.red) == true)
        {
            actualColor.text = player.GetComponent<PaintCubes>().actualInk.ToString();
            actual.color = Color.red;
        }

        if (player.GetComponent<PaintCubes>().atualColor.Equals(Color.gray) == true)
        {
            actualColor.text = player.GetComponent<PaintCubes>().actualInk.ToString();
            actual.color = Color.gray;
        }

        if (player.GetComponent<PaintCubes>().atualColor.Equals(Color.black) == true)
        {
            actualColor.text = player.GetComponent<PaintCubes>().actualInk.ToString();
            actual.color = Color.black;
        }

        if (player.GetComponent<PaintCubes>().atualColor.Equals(Color.blue) == true)
        {
            actualColor.text = player.GetComponent<PaintCubes>().actualInk.ToString();
            actual.color = Color.blue;
        }

        if (player.GetComponent<PaintCubes>().atualColor.Equals(player.GetComponent<PaintCubes>().brown) == true)
        {
            actualColor.text = player.GetComponent<PaintCubes>().actualInk.ToString();
            actual.color = brown;
        }

        if (player.GetComponent<PaintCubes>().atualColor.Equals(player.GetComponent<PaintCubes>().orange) == true)
        {
            actualColor.text = player.GetComponent<PaintCubes>().actualInk.ToString();
            actual.color = orange;
        }

        if (player.GetComponent<PaintCubes>().atualColor.Equals(player.GetComponent<PaintCubes>().skin) == true)
        {
            actualColor.text = player.GetComponent<PaintCubes>().actualInk.ToString();
            actual.color = skin;
        }

        if (player.GetComponent<PaintCubes>().atualColor.Equals(player.GetComponent<PaintCubes>().purple) == true)
        {
            actualColor.text = player.GetComponent<PaintCubes>().actualInk.ToString();
            actual.color = purple;
        }

        if (player.GetComponent<PaintCubes>().atualColor.Equals(player.GetComponent<PaintCubes>().darkGreen) == true)
        {
            actualColor.text = player.GetComponent<PaintCubes>().actualInk.ToString();
            actual.color = darkGreen;
        }
        //Cor Reserva
        if (player.GetComponent<PaintCubes>().reserveColor.Equals(Color.white) == true)
        {
            reserveColor.text = player.GetComponent<PaintCubes>().reserveInk.ToString();
            reserve.color = Color.white;
        }

        if (player.GetComponent<PaintCubes>().reserveColor.Equals(Color.green) == true)
        {
            reserveColor.text = player.GetComponent<PaintCubes>().reserveInk.ToString();
            reserve.color = Color.green;
        }

        if (player.GetComponent<PaintCubes>().reserveColor.Equals(Color.yellow) == true)
        {
            reserveColor.text = player.GetComponent<PaintCubes>().reserveInk.ToString();
            reserve.color = Color.yellow;
        }

        if (player.GetComponent<PaintCubes>().reserveColor.Equals(Color.red) == true)
        {
            reserveColor.text = player.GetComponent<PaintCubes>().reserveInk.ToString();
            reserve.color = Color.red;
        }

        if (player.GetComponent<PaintCubes>().reserveColor.Equals(Color.gray) == true)
        {
            reserveColor.text = player.GetComponent<PaintCubes>().reserveInk.ToString();
            reserve.color = Color.gray;
        }

        if (player.GetComponent<PaintCubes>().reserveColor.Equals(Color.black) == true)
        {
            reserveColor.text = player.GetComponent<PaintCubes>().reserveInk.ToString();
            reserve.color = Color.black;
        }

        if (player.GetComponent<PaintCubes>().reserveColor.Equals(Color.blue) == true)
        {
            reserveColor.text = player.GetComponent<PaintCubes>().reserveInk.ToString();
            reserve.color = Color.blue;
        }

        if (player.GetComponent<PaintCubes>().reserveColor.Equals(player.GetComponent<PaintCubes>().brown) == true)
        {
            reserveColor.text = player.GetComponent<PaintCubes>().reserveInk.ToString();
            reserve.color = brown;
        }

        if (player.GetComponent<PaintCubes>().reserveColor.Equals(player.GetComponent<PaintCubes>().orange) == true)
        {
            reserveColor.text = player.GetComponent<PaintCubes>().reserveInk.ToString();
            reserve.color = orange;
        }

        if (player.GetComponent<PaintCubes>().reserveColor.Equals(player.GetComponent<PaintCubes>().skin) == true)
        {
            reserveColor.text = player.GetComponent<PaintCubes>().reserveInk.ToString();
            reserve.color = skin;
        }

        if (player.GetComponent<PaintCubes>().reserveColor.Equals(player.GetComponent<PaintCubes>().purple) == true)
        {
            reserveColor.text = player.GetComponent<PaintCubes>().reserveInk.ToString();
            reserve.color = purple;
        }

        if (player.GetComponent<PaintCubes>().reserveColor.Equals(player.GetComponent<PaintCubes>().darkGreen) == true)
        {
            reserveColor.text = player.GetComponent<PaintCubes>().reserveInk.ToString();
            reserve.color = darkGreen;
        }

        // Pintar ligado

        if (player.GetComponent<PaintCubes>().readyToPaint == true)
        {
            ready.text = "Modo Pintar: Ligado";
            brush.sprite = brushOn;
        }
        else
        {
            ready.text = "Modo Pintar: Desligado";
            brush.sprite = brushOff;
        }

        //Rainbow Mode

        if (player.GetComponent<PaintCubes>().rainbowMode == true)
        {
            RM1.SetActive(true);
            RM2.SetActive(true);
            actualColor.text = player.GetComponent<PaintCubes>().timeLeft.ToString("F0") + "s";
            reserveColor.text = player.GetComponent<PaintCubes>().timeLeft.ToString("F0") + "s";
        }
        if (player.GetComponent<PaintCubes>().rainbowMode == false)
        {
            RM1.SetActive(false);
            RM2.SetActive(false);
        }
    }

    void Progressão()
    {
        if (SceneManager.GetActiveScene().name == "Teste")
        {
            progressionMario = (100 * player.GetComponent<PaintCubes>().rightCubes) / 151;
        }
        if (SceneManager.GetActiveScene().name == "Fase 2")
        {
            progressionSamus = (100 * player.GetComponent<PaintCubes>().rightCubes) / 381;
        }
        if (SceneManager.GetActiveScene().name == "Fase 3")
        {
            progressionMajora = (100 * player.GetComponent<PaintCubes>().rightCubes) / 478;
        }

        if (progressionMario >= 10 || progressionSamus >= 10 || progressionMajora >= 10)
        {
            myImageComponent.sprite = Bolhas01;
        }

        if (progressionMario >= 20 || progressionSamus >= 20 || progressionMajora >= 20)
        {
            myImageComponent.sprite = Bolhas02;
        }

        if (progressionMario >= 30 || progressionSamus >= 30 || progressionMajora >= 30)
        {
            myImageComponent.sprite = Bolhas03;
        }

        if (progressionMario >= 40 || progressionSamus >= 40 || progressionMajora >= 40)
        {
            myImageComponent.sprite = Bolhas04;
        }

        if (progressionMario >= 50 || progressionSamus >= 50 || progressionMajora >= 50)
        {
            myImageComponent.sprite = Bolhas05;
        }

        if (progressionMario >= 60 || progressionSamus >= 60 || progressionMajora >= 60)
        {
            myImageComponent.sprite = Bolhas06;
        }

        if (progressionMario >= 70 || progressionSamus >= 70 || progressionMajora >= 70)
        {
            myImageComponent.sprite = Bolhas07;
        }

        if (progressionMario >= 80 || progressionSamus >= 80 || progressionMajora >= 80)
        {
            myImageComponent.sprite = Bolhas08;
        }

        if (progressionMario >= 90 || progressionSamus >= 90 || progressionMajora >= 90)
        {
            myImageComponent.sprite = Bolhas09;
        }

        if (progressionMario >= 100 || progressionSamus >= 100 || progressionMajora >= 100)
        {
            myImageComponent.sprite = Bolhas10;
        }

        //Life

        if (player.GetComponent<PaintCubes>().actualLife == 6)
        {
            life.sprite = life6;
        }
        if (player.GetComponent<PaintCubes>().actualLife == 5)
        {
            life.sprite = life5;
        }
        if (player.GetComponent<PaintCubes>().actualLife == 4)
        {
            life.sprite = life4;
        }
        if (player.GetComponent<PaintCubes>().actualLife == 3)
        {
            life.sprite = life3;
        }
        if (player.GetComponent<PaintCubes>().actualLife == 2)
        {
            life.sprite = life2;
        }
        if (player.GetComponent<PaintCubes>().actualLife == 1)
        {
            life.sprite = life1;
        }
        if (player.GetComponent<PaintCubes>().actualLife == 0)
        {
            life.sprite = life0;
        }
    }
}
