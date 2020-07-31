using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPaint : MonoBehaviour {

    // Use this for initialization

    public bool rightColor = false;
    public bool isActive = false;
    private float duration = 1f; // This will be your time in seconds.
    private float smoothness = 0.02f; // This will determine the smoothness of the lerp. Smaller values are smoother. Really it's the time between updates.
    private Color brown, skin, purple, orange, darkGreen, tmp1 = Color.white, tmp2;
    private Transform target;

    void Start () {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        target = go.transform;
        orange = new Color32(255, 140, 0, 1);
        purple = new Color32(75, 0, 130, 1);
        brown = new Color32(139, 69, 19, 1);
        skin = new Color32(245, 222, 179, 1);
        darkGreen = new Color32(0, 100, 0, 1);
        //Lerp();
    }
	
	// Update is called once per frame
	void Update () {
        Lerp();
    }

    public void Lerp()
    {
       if (isActive == false && hasChanged() == true)
       {
          StartCoroutine(LerpColor());
       }
    }
    public IEnumerator LerpColor()
    {
        float progress = 0; //This float will serve as the 3rd parameter of the lerp function.
        float increment = smoothness / duration; //The amount of change to apply.
        if (gameObject.name == "Black" && target.GetComponent<PaintCubes>().pick == 1 && rightColor == false)
        {
            while (progress < 1)
            {
                isActive = true;
                GetComponent<Renderer>().material.color = Color.Lerp(Color.black, Color.white, progress);
                progress += increment;
                yield return new WaitForSeconds(smoothness);
                isActive = false;
            }
        }
        if (gameObject.name == "Blue" && target.GetComponent<PaintCubes>().pick == 2 && rightColor == false)
        {
            while (progress < 1)
            {
                isActive = true;
                GetComponent<Renderer>().material.color = Color.Lerp(Color.blue, Color.white, progress);
                progress += increment;
                yield return new WaitForSeconds(smoothness);
                isActive = false;
            }
        }
        if (gameObject.name == "Brown" && target.GetComponent<PaintCubes>().pick == 3 && rightColor == false)
        {
            while (progress < 1)
            {
                isActive = true;
                GetComponent<Renderer>().material.color = Color.Lerp(brown, Color.white, progress);
                progress += increment;
                yield return new WaitForSeconds(smoothness);
                isActive = false;
            }
        }
        if (gameObject.name == "DarkGreen" && target.GetComponent<PaintCubes>().pick == 4 && rightColor == false)
        {
            while (progress < 1)
            {
                isActive = true;
                GetComponent<Renderer>().material.color = Color.Lerp(darkGreen, Color.white, progress);
                progress += increment;
                yield return new WaitForSeconds(smoothness);
                isActive = false;
            }
        }
        if (gameObject.name == "Gray" && target.GetComponent<PaintCubes>().pick == 11 && rightColor == false)
        {
            while (progress < 1)
            {
                isActive = true;
                GetComponent<Renderer>().material.color = Color.Lerp(Color.gray, Color.white, progress);
                progress += increment;
                yield return new WaitForSeconds(smoothness);
                isActive = false;
            }
        }
        if (gameObject.name == "Green" && target.GetComponent<PaintCubes>().pick == 5 && rightColor == false)
        {
            while (progress < 1)
            {
                isActive = true;
                GetComponent<Renderer>().material.color = Color.Lerp(Color.green, Color.white, progress);
                progress += increment;
                yield return new WaitForSeconds(smoothness);
                isActive = false;
            }
        }
        if (gameObject.name == "Orange" && target.GetComponent<PaintCubes>().pick == 6 && rightColor == false)
        {
            while (progress < 1)
            {
                isActive = true;
                GetComponent<Renderer>().material.color = Color.Lerp(orange, Color.white, progress);
                progress += increment;
                yield return new WaitForSeconds(smoothness);
                isActive = false;
            }
        }
        if (gameObject.name == "Purple" && target.GetComponent<PaintCubes>().pick == 7 && rightColor == false)
        {
            while (progress < 1)
            {
                isActive = true;
                GetComponent<Renderer>().material.color = Color.Lerp(purple, Color.white, progress);
                progress += increment;
                yield return new WaitForSeconds(smoothness);
                isActive = false;
            }
        }
        if (gameObject.name == "Red" && target.GetComponent<PaintCubes>().pick == 8 && rightColor == false)
        {
            while (progress < 1)
            {
                isActive = true;
                GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.white, progress);
                progress += increment;
                yield return new WaitForSeconds(smoothness);
                isActive = false;
            }
        }
        if (gameObject.name == "Skin" && target.GetComponent<PaintCubes>().pick == 9 && rightColor == false)
        {
            while (progress < 1)
            {
                isActive = true;
                GetComponent<Renderer>().material.color = Color.Lerp(skin, Color.white, progress);
                progress += increment;
                yield return new WaitForSeconds(smoothness);
                isActive = false;
            }
        }
        if (gameObject.name == "Yellow" && target.GetComponent<PaintCubes>().pick == 10 && rightColor == false)
        {
            while (progress < 1)
            {
                isActive = true;
                GetComponent<Renderer>().material.color = Color.Lerp(Color.yellow, Color.white, progress);
                progress += increment;
                yield return new WaitForSeconds(smoothness);
                isActive = false;
            }
        }
    }

    bool hasChanged()
    {
        if (target.GetComponent<PaintCubes>().atualColor != tmp1 || target.GetComponent<PaintCubes>().reserveColor != tmp2)
        {
            tmp1 = target.GetComponent<PaintCubes>().atualColor;
            tmp2 = target.GetComponent<PaintCubes>().reserveColor;
            return true;
        }
        else
        {
            return false;
        }
        
    }
}
