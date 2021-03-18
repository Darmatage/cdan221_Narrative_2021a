using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueSceneIntro : MonoBehaviour
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
            ArtChar2.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "COMMANDER";
            Char2speech.text = "Private, what's your status?";
        }
        else if (primeInt == 3)
        {
            ArtChar2.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "I d-did it commander. I.. I killed him.\nOh god, commander, he was just a boy! I-I killed a child!\nWhat is wrong with me!?!";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "COMMANDER";
            Char2speech.text = "Keep your head on straight, private!\nRemember what's at stake here.\nThat was no innocent kid.";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "COMMANDER";
            Char2speech.text = "That was Prince Gunther, the same kid that would grow up to be the tyrant that makes our lives a living hell.\nYou understand what I'm saying?";
        }
        else if (primeInt == 6)
        {
            ArtChar2.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Commander...\nI think I'm gonna be sick...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "COMMANDER";
            Char2speech.text = "There's no time to be sick, private!\nYour job's not done yet!\nYou need to get back to our time period in order for the past to change!";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "COMMANDER";
            Char2speech.text = "Do you remember where you put the time machine?";
        }
        else if (primeInt == 9)
        {
            ArtChar2.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Yeah... It's in the d-dungeon of the castle...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "COMMANDER";
            Char2speech.text = "Well get moving, private!\nOur connection's already starting to break up...\nThe timelines are separ...";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "COMMANDER";
            Char2speech.text = "You need to get bac...\nOr this will all be for nothi...";
        }
        else if (primeInt == 12)
        {
            ArtChar2.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "C-commander? Are you t-there?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "COMMANDER";
            Char2speech.text = "...";
        }
        else if (primeInt == 14)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Okay, okay. I just gotta g-get to the dungeon. For the f-future of humanity...";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "";
            Char1speech.text = "You book it past the jester and out of the room.\nWhere do you go?";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
            NextScene3Button.SetActive(true);
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
        Char1name.text = "";
        Char1speech.text = "Why is this here, anyway?";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "This one too...";
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
        SceneManager.LoadScene("Scene1a");
    }
    public void SceneChange2c()
    {
        SceneManager.LoadScene("Scene2c");
    }
}