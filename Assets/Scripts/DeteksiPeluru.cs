using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeteksiPeluru : MonoBehaviour
{
    public string nameTag;
    public AudioClip audio1;
    private AudioSource MediaPlayer;
    public Text textScore;

    // Use this for initialization
    void Start()
    {
        MediaPlayer = gameObject.AddComponent<AudioSource>();
        MediaPlayer.clip = audio1;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            Data.score += 1;
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayer.Play();
        }
    }
}
