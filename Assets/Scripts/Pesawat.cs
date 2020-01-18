using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pesawat : MonoBehaviour
{
    public float kecepatan;
    public string axis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float gerak = Input.GetAxis(axis) * kecepatan * Time.deltaTime;
        transform.Translate(0, gerak, 0);
    }
}
