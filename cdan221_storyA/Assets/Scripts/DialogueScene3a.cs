using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3a : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtChar2;
    public GameObject ArtChar3;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice1c;
    public GameObject Choice1d;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public GameObject gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        Choice1d.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
    }

    void FixedUpdate()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            ArtChar1.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Man, it's hot down here. Where am I?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "WEIRD RAT";
            Char2speech.text = "You there! M'boy!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 4)
        {
            ArtChar2.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Huh? Who are you?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "WEIRD RAT";
            Char2speech.text = "Ratthew's my name.\nI run these here furnaces, keep the castle warm!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "RATTHEW";
            Char2speech.text = "By runnin' on this here wheel, I burn the coal and power them furnaces! Been doin' it fer sixty years m'boy!\nYa must be the new recruit!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtChar2.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "No, no, I'm not a recruit.\nI'm actually looking for a way out of here.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 8)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "RATTHEW";
            Char2speech.text = "Ain't no way out, m'boy! If yer down 'ere, yer 'ere for a reason! ";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 9)
        {
            ArtChar2.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "What? No, you got it all wrong.\nI came down here on my own--";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 10)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "RATTHEW";
            Char2speech.text = "Don't all in a tizzy, m'boy! It ain't a bad life down here!\nE'ry once in a while they'll throw down a wedge of cheese for you to snack on.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "RATTHEW";
            Char2speech.text = "Next time they come 'round I'll make sure they throw down an extra wedge for ya!\nNow come on, let's get to work, m'boy!";
            Char3name.text = "";
            Char3speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "RATTHEW";
            Char2speech.text = "C’mon m’boy! Hop up on yer wheel and get to runnin’! We got at least five hundred pounds of coal to burn through before the day’s done!";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        //ENCOUNTER AFTER CHOICE #2
        else if (primeInt == 200)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "RATTHEW";
            Char2speech.text = "What sound ya talkin' 'bout, m'boy?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 201)
        {
            ArtChar2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "(You walk back over to the chute you fell out of. You hear a sing-songy voice echo from the top.)";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 202)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "???";
            Char3speech.text = "Hee hee hee...";
        }
        else if (primeInt == 203)
        {
            ArtChar3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "JESTER";
            Char3speech.text = "Oh heavens sake, what horrid fate,\nhas now befallen you!\nBut a while back, you scratched my back,\nso I shall scratch yours too!";
        }
        else if (primeInt == 204)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "JESTER";
            Char3speech.text = "So if you wish, my help in this,\nto escape from all this hassle,\nMy fingers snap, and you go back, to elsewhere in the castle!”";
        }
        else if (primeInt == 205)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JESTER";
            Char2speech.text = "It's the only chance for your release,\nso speak up now, or hold your peace...";
            Char3name.text = "";
            Char3speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1c.SetActive(true); // function Choice1aFunct()
            Choice1d.SetActive(true); // function Choice1bFunct()
        }

        //ENCOUNTER AFTER CHOICE #3
        else if (primeInt == 300)
        {
            ArtChar1.SetActive(false);
            ArtChar3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "JESTER";
            Char3speech.text = "It shall be done, you will be gone,\nand somewhere else appear,\nBut please beware, and take more care,\nif you wish to get out of here!”";
        }
        else if (primeInt == 301)
        {
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "(A wall in the furnace dislodges and spins around, revealing a secret passage.)";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }

        //ENCOUNTER AFTER CHOICE #4
        else if (primeInt == 400)
        {
            ArtChar1.SetActive(false);
            ArtChar3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "JESTER";
            Char3speech.text = "You may so do, that which you like,\nbut please, save me the jeers.\nIn not too late, the wheel of fate,\nwill crush you in its gears.";
        }
        else if (primeInt == 401)
        {
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "(The jester's cackles grow quieter and quieter until there is only silence.\nYou feel like you've made a terrible mistake...)";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 402)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "RATTHEW";
            Char2speech.text = "C’mon m’boy! Hop up on yer wheel and get to runnin’! We got at least five hundred pounds of coal to burn through before the day’s done!";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        ArtChar2.SetActive(false);
        ArtChar1.SetActive(true);
        Char1name.text = "YOU";
        Char1speech.text = "This can't be happening...";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        ArtChar2.SetActive(false);
        ArtChar1.SetActive(true);
        Char1name.text = "YOU";
        Char1speech.text = "What's that sound.\nIt sounds like...laughing?";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1cFunct()
    {
        ArtChar3.SetActive(false);
        ArtChar1.SetActive(true);
        Char1name.text = "YOU";
        Char1speech.text = "Yes! Yes! Get me out of here!";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 299;
        Choice1c.SetActive(false);
        Choice1d.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1dFunct()
    {
        ArtChar3.SetActive(false);
        ArtChar1.SetActive(true);
        Char1name.text = "YOU";
        Char1speech.text = "Get lost. I can handle this myself.";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 399;
        Choice1c.SetActive(false);
        Choice1d.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChangeGAMEOVER()
    {
        SceneManager.LoadScene("SceneEnd1");
    }
    public void SceneChange2c()
    {
        SceneManager.LoadScene("Scene2c");
    }
}