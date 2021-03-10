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
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }

        //ENCOUNTER AFTER CHOICE #2
        else if (primeInt == 200)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jester";
            Char2speech.text = "Make no excuse, I've known your scheme,\nsince I laid eyes on you!";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jester";
            Char2speech.text = "But worry not, my dear old friend,\nI will not tell a soul.\nTo this old fool, that boy was cruel,\nI'm glad to see him go!";
        }
        else if (primeInt == 202)
        {
            Char1name.text = "You";
            Char1speech.text = "So you won't tell the guards?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 203)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jester";
            Char2speech.text = "I saw no thing and heard no thing,\nthere's nothing here to tell.\nSo use this time, start your decline,\nand all shall go quite well!";
        }
        else if (primeInt == 204)
        {
            Char1name.text = "You";
            Char1speech.text = "You're right, I should get going.\nThank you.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 205)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Jester";
            Char2speech.text = "If ever you need help from me,\nfeel free to give a shout.\nWithin this castle's twisting halls,\nI'll always be about!";
        }
        else if (primeInt == 206)
        {
            Char1name.text = "";
            Char1speech.text = "The jester cackles as you run out of the room.\nWhere do you go?";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
            NextScene3Button.SetActive(true);
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