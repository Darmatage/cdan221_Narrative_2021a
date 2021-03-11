using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene5c : MonoBehaviour
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
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject NextScene3Button;
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
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
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
            ArtChar3.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Keeper";
            Char3speech.text = "Alright, your opponent is already in the ring.\nKnock 'em dead.";
        }
        else if (primeInt == 3)
        {
            ArtChar3.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "Huh? Where are they?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cheevers";
            Char2speech.text = "Hey! Over here!\nPlease help me!\nThey chained me up in this dungeon!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "You";
            Char1speech.text = "What? So you're imprisoned down here?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cheevers";
            Char2speech.text = "Yeah, I'm just a little beaver! Cheevers the Beaver! I need to get back to my beaver family! They've been making me fight in their bloodbaths for months!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "You";
            Char1speech.text = "Listen, I'm sorry, but I have my own goals here.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cheevers";
            Char2speech.text = "The gold chalice, right? You're fighting for that?\nI know a way to get that without winning the competition!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cheevers";
            Char2speech.text = "If you unlock these chains with that key across the room I can crawl through the ducts and get it for you!\nSo how 'bout it?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "You";
            Char1speech.text = "Hold on, give me some time to think...";
            Char2name.text = "";
            Char2speech.text = "";
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
            Char1name.text = "";
            Char1speech.text = "You release Cheevers from the chains";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cheevers";
            Char2speech.text = "Th-Thank you, sir...";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 102)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "For your pathetic naivety!\nAHAHAHAHAHAHAHA!!!";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 103)
        {
            Char1name.text = "";
            Char1speech.text = "Cheevers locks the chains tightly around your wrists.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 104)
        {
            Char1name.text = "You";
            Char1speech.text = "But...you were just a helpless beaver...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 105)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cheevers";
            Char2speech.text = "Oh, did I say Cheevers the Beaver?\n I meant Cheevers...The Deceiver!\nAHAHAHAHAHAHA!!!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 106)
        {
            Char1name.text = "";
            Char1speech.text = "Cheevers retrieves a knife from a drawer across the room.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 107)
        {
            Char1name.text = "You";
            Char1speech.text = "I knew I shouldn't have trusted you...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 108)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cheevers";
            Char2speech.text = "Awww. Don't cry now. You'll have the chance to be a little more cautious in the next life!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 108)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cheevers";
            Char2speech.text = "NOW DIE!!!";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        //ENCOUNTER AFTER CHOICE #2
        else if (primeInt == 200)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Cheevers";
            Char2speech.text = "No! You can’t do this! I thought you were different!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "You";
            Char1speech.text = "Don't make this difficult.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 202)
        {
            ArtChar2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "With a single punch, you knock Cheevers out cold.\nA bell rings out in the room.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 203)
        {
            ArtChar3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Keeper";
            Char3speech.text = "Wow, you knocked out that helpless beaver without a shred of mercy! I like your ruthlessness!";
        }
        else if (primeInt == 204)
        {
            Char1name.text = "You";
            Char1speech.text = "Where's my prize?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 205)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Keeper";
            Char3speech.text = "Not one for conversation, huh? Fine, fine. Here you go.";
        }
        else if (primeInt == 206)
        {
            Char1name.text = "";
            Char1speech.text = "The dungeon keeper hands over the golden chalice, and your time machine back to the future.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 207)
        {
            Char1name.text = "";
            Char1speech.text = "Right as you grab the chalice, you hear the royal guards enter the dungeon.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 208)
        {
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Guard";
            Char2speech.text = "The prince has been killed! Place the castle on lockdown immediately!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 209)
        {
            ArtChar3.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "Alright, time to go!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 210)
        {
            Char1name.text = "";
            Char1speech.text = "You press the gems adorning the outside of the chalice in a specific sequence and a white light glows from the chalice. It grows brighter and fills the room, blinding the guards.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 211)
        {
            Char1name.text = "";
            Char1speech.text = "It grows brighter and brighter, until...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "Okay, Cheevers. Let's get out of here.";
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
        Char1name.text = "You";
        Char1speech.text = "Sorry Cheevers, but I work alone.";
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

    public void SceneChange2a()
    {
        SceneManager.LoadScene("Scene2a");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("Scene2b");
    }
    public void SceneChange2c()
    {
        SceneManager.LoadScene("Scene2c");
    }
}