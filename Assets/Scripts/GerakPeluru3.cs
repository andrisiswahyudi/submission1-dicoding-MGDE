using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakPeluru3 : MonoBehaviour
{
   
    float speed = 5f;
    public Sprite[] sprites;
    // Use this for initialization
    void Start()
    {
        int index = Random.Range(0, sprites.Length);
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[index];
    }

    // Update is called once per frame
    void Update()
    {
        float move = (speed * Time.deltaTime * -1f) + transform.position.x;
        transform.position = new Vector3(move, transform.position.y);
    }
}
