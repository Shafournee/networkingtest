using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleDropper : MonoBehaviour
{
    [SerializeField] GameObject layoutGroup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void colorize(GameObject slot)
    {
        Color color = Color.white;
        slot.GetComponent<Image>().color = color;
    }
}
