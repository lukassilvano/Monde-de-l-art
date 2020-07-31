using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ez.Msg;

public class Bullet : MonoBehaviour {

    public Color brown, skin, purple, orange, darkGreen;

    private int enemyLife;
    public GameObject blackInk, blueInk, brownInk, darkGreenInk, greenInk, orangeInk, purpleInk, redInk, skinInk, yellowInk, grayInk, rainbowInk;
    private float Radius = 7.0f;
    private GameObject player;

    public bool colidi = false;

    Collider[] collidersInRange;

    // Use this for initialization
    void Start () {
       
        player = GameObject.Find("Player");
        enemyLife = 5;
        orange = new Color32(255, 140, 0, 1);
        purple = new Color32(75, 0, 130, 1);
        brown = new Color32(139, 69, 19, 1);
        skin = new Color32(245, 222, 179, 1);
        darkGreen = new Color32(0, 100, 0, 1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Wait(Collision other)
    {
        
        yield return new WaitForSeconds(1f);

    }

    private EzMsg.EventAction<IColisao> ApplyDamageMsg
    {
        get { return _ => _.ApplyColisao(colidi); }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Equals("Parede") == true)
        {
            Destroy(this.gameObject);
            
        }

        if (other.gameObject.tag == "BlackEnemy" || other.gameObject.tag == "BlueEnemy" || other.gameObject.tag == "BrownEnemy" || other.gameObject.tag == "DarkGreenEnemy" || other.gameObject.tag == "GreenEnemy" || other.gameObject.tag == "OrangeEnemy"
            || other.gameObject.tag == "PurpleEnemy" || other.gameObject.tag == "RedEnemy" || other.gameObject.tag == "SkinEnemy" || other.gameObject.tag == "YellowEnemy" || other.gameObject.tag == "GrayEnemy" || other.gameObject.tag == "RainbowEnemy"
            || other.gameObject.tag == "EraserEnemy" || other.gameObject.tag == "BlackXEnemy" || other.gameObject.tag == "BlueXEnemy" || other.gameObject.tag == "BrownXEnemy" || other.gameObject.tag == "DarkGreenXEnemy" || other.gameObject.tag == "GreenXEnemy" || other.gameObject.tag == "OrangeXEnemy"
            || other.gameObject.tag == "PurpleXEnemy" || other.gameObject.tag == "RedXEnemy" || other.gameObject.tag == "SkinXEnemy" || other.gameObject.tag == "YellowXEnemy" || other.gameObject.tag == "GrayXEnemy" || other.gameObject.tag == "RainbowXEnemy")
        {
            colidi = true;
            //Debug.Log("Colidi em algo" + other.gameObject.name);
            EzMsg.Send<IColisao>(other.gameObject, _ => _.ApplyColisao(colidi)).Run();

            if (other.gameObject.tag == "BlackEnemy")
            {
                Destroy(this.gameObject);
                Instantiate(blackInk, other.gameObject.transform.position, other.gameObject.transform.rotation);
                Destroy(other.gameObject);
            }
            if (other.gameObject.tag == "BlueEnemy")
            {
                Destroy(this.gameObject);
                Instantiate(blueInk, other.gameObject.transform.position, other.gameObject.transform.rotation);
                Destroy(other.gameObject);
            }
            if (other.gameObject.tag == "BrownEnemy")
            {
                Destroy(this.gameObject);
                Instantiate(brownInk, other.gameObject.transform.position, other.gameObject.transform.rotation);
                Destroy(other.gameObject);
            }
            if (other.gameObject.tag == "DarkGreenEnemy")
            {
                Destroy(this.gameObject);
                Instantiate(darkGreenInk, other.gameObject.transform.position, other.gameObject.transform.rotation);
                Destroy(other.gameObject);
            }
            if (other.gameObject.tag == "GreenEnemy")
            {
                Destroy(this.gameObject);
                Instantiate(greenInk, other.gameObject.transform.position, other.gameObject.transform.rotation);
                Destroy(other.gameObject);
            }
            if (other.gameObject.tag == "OrangeEnemy")
            {
                Destroy(this.gameObject);
                Instantiate(orangeInk, other.gameObject.transform.position, other.gameObject.transform.rotation);
                Destroy(other.gameObject);
            }
            if (other.gameObject.tag == "PurpleEnemy")
            {
                Destroy(this.gameObject);
                Instantiate(purpleInk, other.gameObject.transform.position, other.gameObject.transform.rotation);
                Destroy(other.gameObject);
            }
            if (other.gameObject.tag == "RedEnemy")
            {
                Destroy(this.gameObject);
                Instantiate(redInk, other.gameObject.transform.position, other.gameObject.transform.rotation);
                Destroy(other.gameObject);
            }
            if (other.gameObject.tag == "SkinEnemy")
            {
                Destroy(this.gameObject);
                Instantiate(skinInk, other.gameObject.transform.position, other.gameObject.transform.rotation);
                Destroy(other.gameObject);
            }
            if (other.gameObject.tag == "YellowEnemy")
            {
                Destroy(this.gameObject);
                Instantiate(yellowInk, other.gameObject.transform.position, other.gameObject.transform.rotation);
                Destroy(other.gameObject);
            }
            if (other.gameObject.tag == "GrayEnemy")
            {
                Destroy(this.gameObject);
                Instantiate(grayInk, other.gameObject.transform.position, other.gameObject.transform.rotation);
                Destroy(other.gameObject);
            }
            if (other.gameObject.tag == "RainbowEnemy")
            {
                Destroy(this.gameObject);
                Instantiate(rainbowInk, other.gameObject.transform.position, other.gameObject.transform.rotation);
                Destroy(other.gameObject);
            }
            if (other.gameObject.tag == "EraserEnemy")
            {
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "OrangeXEnemy")
            {
                collidersInRange = Physics.OverlapSphere(other.gameObject.transform.position, Radius);
                foreach (Collider col in collidersInRange)
                {
                    if (col.gameObject.tag == "Cube" && col.GetComponent<CheckPaint>().rightColor == false && col.gameObject.name != "Blank")
                    {
                        col.GetComponent<Renderer>().material.color = orange;

                        if (col.gameObject.name == "Orange" && col.GetComponent<CheckPaint>().rightColor == false)
                        {
                            col.GetComponent<CheckPaint>().rightColor = true;
                            player.GetComponent<PaintCubes>().rightCubes++;
                            player.GetComponent<PaintCubes>().rightOrange++;
                        }
                    }
                }

                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "BlackXEnemy")
            {
                collidersInRange = Physics.OverlapSphere(other.gameObject.transform.position, Radius);
                foreach (Collider col in collidersInRange)
                {
                    if (col.gameObject.tag == "Cube" && col.GetComponent<CheckPaint>().rightColor == false && col.gameObject.name != "Blank")
                    {
                        col.GetComponent<Renderer>().material.color = Color.black;

                        if (col.gameObject.name == "Black" && col.GetComponent<CheckPaint>().rightColor == false)
                        {
                            col.GetComponent<CheckPaint>().rightColor = true;
                            player.GetComponent<PaintCubes>().rightCubes++;
                            player.GetComponent<PaintCubes>().rightBlack++;
                        }
                    }
                }

                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "BlueXEnemy")
            {
                collidersInRange = Physics.OverlapSphere(other.gameObject.transform.position, Radius);
                foreach (Collider col in collidersInRange)
                {
                    if (col.gameObject.tag == "Cube" && col.GetComponent<CheckPaint>().rightColor == false && col.gameObject.name != "Blank")
                    {
                        col.GetComponent<Renderer>().material.color = Color.blue;

                        if (col.gameObject.name == "Blue" && col.GetComponent<CheckPaint>().rightColor == false)
                        {
                            col.GetComponent<CheckPaint>().rightColor = true;
                            player.GetComponent<PaintCubes>().rightCubes++;
                            player.GetComponent<PaintCubes>().rightBlue++;
                        }
                    }
                }

                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "BrownXEnemy")
            {
                collidersInRange = Physics.OverlapSphere(other.gameObject.transform.position, Radius);
                foreach (Collider col in collidersInRange)
                {
                    if (col.gameObject.tag == "Cube" && col.GetComponent<CheckPaint>().rightColor == false && col.gameObject.name != "Blank")
                    {
                        col.GetComponent<Renderer>().material.color = brown;

                        if (col.gameObject.name == "Brown" && col.GetComponent<CheckPaint>().rightColor == false)
                        {
                            col.GetComponent<CheckPaint>().rightColor = true;
                            player.GetComponent<PaintCubes>().rightCubes++;
                            player.GetComponent<PaintCubes>().rightBrown++;
                        }
                    }
                    
                }

                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "DarkGreenXEnemy")
            {
                collidersInRange = Physics.OverlapSphere(other.gameObject.transform.position, Radius);
                foreach (Collider col in collidersInRange)
                {
                    if (col.gameObject.tag == "Cube" && col.GetComponent<CheckPaint>().rightColor == false && col.gameObject.name != "Blank")
                    {
                        col.GetComponent<Renderer>().material.color = darkGreen;

                        if (col.gameObject.name == "DarkGreen" && col.GetComponent<CheckPaint>().rightColor == false)
                        {
                            col.GetComponent<CheckPaint>().rightColor = true;
                            player.GetComponent<PaintCubes>().rightCubes++;
                            player.GetComponent<PaintCubes>().rightDarkGreen++;
                        }
                    }
                }

                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "GrayXEnemy")
            {
                collidersInRange = Physics.OverlapSphere(other.gameObject.transform.position, Radius);
                foreach (Collider col in collidersInRange)
                {
                    if (col.gameObject.tag == "Cube" && col.GetComponent<CheckPaint>().rightColor == false && col.gameObject.name != "Blank")
                    {
                        col.GetComponent<Renderer>().material.color = Color.gray;

                        if (col.gameObject.name == "Gray" && col.GetComponent<CheckPaint>().rightColor == false)
                        {
                            col.GetComponent<CheckPaint>().rightColor = true;
                            player.GetComponent<PaintCubes>().rightCubes++;
                            player.GetComponent<PaintCubes>().rightGray++;
                        }
                    }
                }

                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "GreenXEnemy")
            {
                collidersInRange = Physics.OverlapSphere(other.gameObject.transform.position, Radius);
                foreach (Collider col in collidersInRange)
                {
                    if (col.gameObject.tag == "Cube" && col.GetComponent<CheckPaint>().rightColor == false && col.gameObject.name != "Blank")
                    {
                        col.GetComponent<Renderer>().material.color = Color.green;

                        if (col.gameObject.name == "Green" && col.GetComponent<CheckPaint>().rightColor == false)
                        {
                            col.GetComponent<CheckPaint>().rightColor = true;
                            player.GetComponent<PaintCubes>().rightCubes++;
                            player.GetComponent<PaintCubes>().rightGreen++;
                        }
                    }
                }

                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "PurpleXEnemy")
            {
                collidersInRange = Physics.OverlapSphere(other.gameObject.transform.position, Radius);
                foreach (Collider col in collidersInRange)
                {
                    if (col.gameObject.tag == "Cube" && col.GetComponent<CheckPaint>().rightColor == false && col.gameObject.name != "Blank")
                    {
                        col.GetComponent<Renderer>().material.color = purple;

                        if (col.gameObject.name == "Purple" && col.GetComponent<CheckPaint>().rightColor == false)
                        {
                            col.GetComponent<CheckPaint>().rightColor = true;
                            player.GetComponent<PaintCubes>().rightCubes++;
                            player.GetComponent<PaintCubes>().rightPurple++;
                        }
                    }
                }

                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "RedXEnemy")
            {
                collidersInRange = Physics.OverlapSphere(other.gameObject.transform.position, Radius);
                foreach (Collider col in collidersInRange)
                {
                    if (col.gameObject.tag == "Cube" && col.GetComponent<CheckPaint>().rightColor == false && col.gameObject.name != "Blank")
                    {
                        col.GetComponent<Renderer>().material.color = Color.red;

                        if (col.gameObject.name == "Red" && col.GetComponent<CheckPaint>().rightColor == false)
                        {
                            col.GetComponent<CheckPaint>().rightColor = true;
                            player.GetComponent<PaintCubes>().rightCubes++;
                            player.GetComponent<PaintCubes>().rightRed++;
                        }
                    }
                }

                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "SkinXEnemy")
            {
                collidersInRange = Physics.OverlapSphere(other.gameObject.transform.position, Radius);
                foreach (Collider col in collidersInRange)
                {
                    if (col.gameObject.tag == "Cube" && col.GetComponent<CheckPaint>().rightColor == false && col.gameObject.name != "Blank")
                    {
                        col.GetComponent<Renderer>().material.color = skin;

                        if (col.gameObject.name == "Skin" && col.GetComponent<CheckPaint>().rightColor == false)
                        {
                            col.GetComponent<CheckPaint>().rightColor = true;
                            player.GetComponent<PaintCubes>().rightCubes++;
                            player.GetComponent<PaintCubes>().rightSkin++;
                        }
                    }
                }

                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "YellowXEnemy")
            {
                collidersInRange = Physics.OverlapSphere(other.gameObject.transform.position, Radius);
                foreach (Collider col in collidersInRange)
                {
                    if (col.gameObject.tag == "Cube" && col.GetComponent<CheckPaint>().rightColor == false && col.gameObject.name != "Blank")
                    {
                        col.GetComponent<Renderer>().material.color = Color.yellow;

                        if (col.gameObject.name == "Yellow" && col.GetComponent<CheckPaint>().rightColor == false)
                        {
                            col.GetComponent<CheckPaint>().rightColor = true;
                            player.GetComponent<PaintCubes>().rightCubes++;
                            player.GetComponent<PaintCubes>().rightYellow++;
                        }
                    }
                }

                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "RainbowXEnemy")
            {
                collidersInRange = Physics.OverlapSphere(other.gameObject.transform.position, Radius / 2);
                foreach (Collider col in collidersInRange)
                {
                    if (col.gameObject.tag == "Cube" && col.GetComponent<CheckPaint>().rightColor == false && col.gameObject.name != "Blank")
                    {
                        if (col.gameObject.name == "Gray")
                        {
                            col.GetComponent<Renderer>().material.color = Color.gray;

                            if (col.gameObject.name == "Gray" && col.GetComponent<CheckPaint>().rightColor == false)
                            {
                                col.GetComponent<CheckPaint>().rightColor = true;
                                player.GetComponent<PaintCubes>().rightCubes++;
                                player.GetComponent<PaintCubes>().rightGray++;
                            }
                        }
                        if (col.gameObject.name == "Green")
                        {
                            col.GetComponent<Renderer>().material.color = Color.green;

                            if (col.gameObject.name == "Green" && col.GetComponent<CheckPaint>().rightColor == false)
                            {
                                col.GetComponent<CheckPaint>().rightColor = true;
                                player.GetComponent<PaintCubes>().rightCubes++;
                                player.GetComponent<PaintCubes>().rightGreen++;
                            }
                        }
                        if (col.gameObject.name == "DarkGreen")
                        {
                            col.GetComponent<Renderer>().material.color = darkGreen;

                            if (col.gameObject.name == "DarkGreen" && col.GetComponent<CheckPaint>().rightColor == false)
                            {
                                col.GetComponent<CheckPaint>().rightColor = true;
                                player.GetComponent<PaintCubes>().rightCubes++;
                                player.GetComponent<PaintCubes>().rightDarkGreen++;
                            }
                        }
                        if (col.gameObject.name == "Blue")
                        {
                            col.GetComponent<Renderer>().material.color = Color.blue;

                            if (col.gameObject.name == "Blue" && col.GetComponent<CheckPaint>().rightColor == false)
                            {
                                col.GetComponent<CheckPaint>().rightColor = true;
                                player.GetComponent<PaintCubes>().rightCubes++;
                                player.GetComponent<PaintCubes>().rightBlue++;
                            }
                        }
                        if (col.gameObject.name == "Red")
                        {
                            col.GetComponent<Renderer>().material.color = Color.red;

                            if (col.gameObject.name == "Red" && col.GetComponent<CheckPaint>().rightColor == false)
                            {
                                col.GetComponent<CheckPaint>().rightColor = true;
                                player.GetComponent<PaintCubes>().rightCubes++;
                                player.GetComponent<PaintCubes>().rightRed++;
                            }
                        }
                        if (col.gameObject.name == "Yellow")
                        {
                            col.GetComponent<Renderer>().material.color = Color.yellow;

                            if (col.gameObject.name == "Yellow" && col.GetComponent<CheckPaint>().rightColor == false)
                            {
                                col.GetComponent<CheckPaint>().rightColor = true;
                                player.GetComponent<PaintCubes>().rightCubes++;
                                player.GetComponent<PaintCubes>().rightYellow++;
                            }
                        }
                        if (col.gameObject.name == "Skin")
                        {
                            col.GetComponent<Renderer>().material.color = skin;

                            if (col.gameObject.name == "Skin" && col.GetComponent<CheckPaint>().rightColor == false)
                            {
                                col.GetComponent<CheckPaint>().rightColor = true;
                                player.GetComponent<PaintCubes>().rightCubes++;
                                player.GetComponent<PaintCubes>().rightSkin++;
                            }
                        }
                        if (col.gameObject.name == "Purple")
                        {
                            col.GetComponent<Renderer>().material.color = purple;

                            if (col.gameObject.name == "Purple" && col.GetComponent<CheckPaint>().rightColor == false)
                            {
                                col.GetComponent<CheckPaint>().rightColor = true;
                                player.GetComponent<PaintCubes>().rightCubes++;
                                player.GetComponent<PaintCubes>().rightPurple++;
                            }
                        }
                        if (col.gameObject.name == "Orange")
                        {
                            col.GetComponent<Renderer>().material.color = orange;

                            if (col.gameObject.name == "Orange" && col.GetComponent<CheckPaint>().rightColor == false)
                            {
                                col.GetComponent<CheckPaint>().rightColor = true;
                                player.GetComponent<PaintCubes>().rightCubes++;
                                player.GetComponent<PaintCubes>().rightOrange++;
                            }
                        }
                        if (col.gameObject.name == "Brown")
                        {
                            col.GetComponent<Renderer>().material.color = brown;

                            if (col.gameObject.name == "Brown" && col.GetComponent<CheckPaint>().rightColor == false)
                            {
                                col.GetComponent<CheckPaint>().rightColor = true;
                                player.GetComponent<PaintCubes>().rightCubes++;
                                player.GetComponent<PaintCubes>().rightBrown++;
                            }
                        }
                        if (col.gameObject.name == "Black")
                        {
                            col.GetComponent<Renderer>().material.color = Color.black;

                            if (col.gameObject.name == "Black" && col.GetComponent<CheckPaint>().rightColor == false)
                            {
                                col.GetComponent<CheckPaint>().rightColor = true;
                                player.GetComponent<PaintCubes>().rightCubes++;
                                player.GetComponent<PaintCubes>().rightBlack++;
                            }
                        }
                    }
                }

                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}