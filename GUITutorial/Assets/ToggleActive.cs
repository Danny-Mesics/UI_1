using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleActive : MonoBehaviour
{
    public void Toggle()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
