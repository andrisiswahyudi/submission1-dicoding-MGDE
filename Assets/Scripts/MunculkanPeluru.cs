using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanPeluru : MonoBehaviour
{
    public float jeda = 2f;
    float timer;
    public GameObject[] obyekPeluru;
    // Use this for initialization
    void Start() {

    }
    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;
        if (timer > jeda)
        { 
            int random = Random.Range(0, obyekPeluru.Length);
            Instantiate(obyekPeluru[random], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
