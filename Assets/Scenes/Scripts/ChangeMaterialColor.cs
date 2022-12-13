using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeMaterialColor : MonoBehaviour
{
    [SerializeField] private Material myMaterial;
    [SerializeField] private Button green;
    [SerializeField] private Button red;
    [SerializeField] private Button blue;
    [SerializeField] private Button black;
    private Color output;
    // Start is called before the first frame update
    void Start()
    {
        green.onClick.AddListener(GreenPressed);
        red.onClick.AddListener(RedPressed);
        blue.onClick.AddListener(BluePressed);
        black.onClick.AddListener(BlackPressed);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GreenPressed()
    {
        myMaterial.color  = Color.green;
    }
    void RedPressed()
    {
        myMaterial.color  = Color.red;
    }
    void BluePressed()
    {
        myMaterial.color  = Color.blue;
    }
    void BlackPressed()
    {
        myMaterial.color  = Color.black;
    }
    
}
