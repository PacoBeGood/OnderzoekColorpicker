using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    float coordX;
    float coordY;
    float coordZ;
    Color pickedColor;


    [SerializeField] Material myMaterial;

    void Start()
    {
        //Texture2D texture1 ScreenCapture.CaptureScreenshotAsTexture();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {

                coordX = hit.transform.position.x;
                coordY = hit.transform.position.y;


            }
            int intCoordX = (int)coordX;
            int intCoordY = (int)coordY;
            Debug.Log("CoordX " + intCoordX);
            Debug.Log("CoordY " + intCoordY);
            if (intCoordX > 0 && intCoordY > 0)
            {
                Texture2D texture1 = new Texture2D(intCoordX, intCoordY);

                pickedColor = texture1.GetPixel(intCoordX, intCoordY);

                myMaterial.color = pickedColor;
            }

        }

    }
}