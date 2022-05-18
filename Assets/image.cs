using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class image : MonoBehaviour
{
    public Image Image = null;
    public Text AudioText = null;
    public AudioSource AudioPlayer = null;
    public Sprite Image1 = null;
    public Sprite Image2 = null;
    public Sprite Image3 = null;
    public Sprite Image4 = null;
    public Sprite Image5 = null;
    public Sprite Image6 = null;
    public Sprite Image7 = null;
    public Sprite Image8 = null;
    public Sprite Image9 = null;
    public Sprite Image10 = null;
    public Sprite Image11 = null;
    public Sprite Image12 = null;


    public Sprite defaultsprite = null;
    public Sprite pauseSprite = null;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var imageGame = Image;
        var audio1 = AudioText;
        var audioPlayer = AudioPlayer;


        if (audioPlayer.isPlaying)
        {
            if (audio1.text == "Dream - Mask")
            {
                imageGame.sprite = Image1;
            }
            else if (audio1.text == "Lyin' To Me - CG5")
            {
                imageGame.sprite = Image2;
            }
            else if (audio1.text == "Vision - Lost Sky")
            {
                imageGame.sprite = Image3;
            }
            else if (audio1.text == "Wilbur Soot - Your New Boyfriend")
            {
                imageGame.sprite = Image4;
            }
            else if (audio1.text == "In the Nether - Larry Poppins")
            {
                imageGame.sprite = Image5;
            }
            else if (audio1.text == "RoadTrip Remix - Larry Poppins")
            {
                imageGame.sprite = Image6;
            }
            else if (audio1.text == "Clear My Head - Ellis")
            {
                imageGame.sprite = Image7;
            }
            else if (audio1.text == "Arcadia - TheFatRat")
            {
                imageGame.sprite = Image8;
            }
            else
            {
                imageGame.sprite = defaultsprite;
            }
            
        }
        else
        {
            imageGame.sprite = pauseSprite;
        }


    }
}
