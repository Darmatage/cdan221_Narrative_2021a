using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2a : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    //public Text Char3name;
    //public Text Char3speech;
    //public Text Char4name;
    //public Text Char4speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtChar2;
    //public GameObject ArtChar3;
    //public GameObject ArtChar4;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice2a;
    public GameObject Choice2b;
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
        //ArtChar3.SetActive(false);
        //ArtChar4.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
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
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(false);
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "This looks like a dead end, I gotta get out of here.";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "";
            //Char3speech.text = "";
            //Char4name.text = "";
            //Char4speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            //ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "WYLIE";
            Char2speech.text = "Oh, hi there. You’re one of dad’s advisors, right?";
            //Char3name.text = "";
            //Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Uh, yeah, t-that’s right...";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "";
            //Char3speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            //ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "WYLIE";
            Char2speech.text = "Why are you acting so weird? You look like you’ve seen a ghost.";
            //Char3name.text = "";
            //Char3speech.text = "";
            //nextButton.SetActive(false);
            //allowSpace = false;
        }
        else if (primeInt == 6)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            //ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "WYLIE";
            Char2speech.text = "Why are you acting so weird? You look like you’ve seen a ghost. \nIs there something on my face? What?";
            //Char3name.text = "";
            //Char3speech.text = "";
            //nextButton.SetActive(false);
            //allowSpace = false;
            //Choice1a.SetActive(true); // function Choice1aFunct() Whatever, how tough could this dude be?
            //Choice1b.SetActive(true); // function Choice1bFunct() Maybe this was a bad idea after all.
        }
        else if (primeInt == 7)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "N-Nothing your majesty! What are you doing here?";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "";
            //Char3speech.text = "";
        }
        else if (primeInt == 8)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            //ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "WYLIE";
            Char2speech.text = "My dad made me go and get some of his old battle maps he keeps locked away in here. \nHe has hundreds of servants, so why am I always the one waiting on him?";
            //Char3name.text = "";
            //Char3speech.text = "";
        }
        else if (primeInt == 8)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Y-yeah! I agree! T-There’s gotta be some brother--I mean OTHER person that could do this job.";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "";
            //Char3speech.text = "";
        }
        else if (primeInt == 9)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Y-yeah! I agree! T-There’s gotta be some brother--I mean OTHER person that could do this job. Heh heh.";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "";
            //Char3speech.text = "";
        }
        else if (primeInt == 10)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            //ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "WYLIE";
            Char2speech.text = "Oh yeah! I should just make Gunther do this for me!";
            //Char3name.text = "";
            //Char3speech.text = "";
        }
        else if (primeInt == 11)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            //ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "WYLIE";
            Char2speech.text = "Oh yeah! I should just make Gunther do this for me! Why didn’t I think of that? Thanks for the idea!";
            //Char3name.text = "";
            //Char3speech.text = "";
        }
        else if (primeInt == 12)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Y-Your majesty! Wait!";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "";
            //Char3speech.text = "";
        }
        else if (primeInt == 13)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "(But Princess Wylie was already walking swiftly down the hall towards her brother’s room.)";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "";
            //Char3speech.text = "";
        }
        else if (primeInt == 14)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Oh no, no, no… I’ve gotta get out of here now!";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "";
            //Char3speech.text = "";
        }
        else if (primeInt == 15)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Oh no, no, no… I’ve gotta get out of here now! Is there another exit in this room?";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "";
            //Char3speech.text = "";
        }
        else if (primeInt == 16)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "(You spy two chutes at the far side of the room. They appear to be your only option. You need to act fast. Which one?)";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct() Go down left chute (kitchen)
            Choice1b.SetActive(true); // function Choice1bFunct() Go down right chute (furnace)
        }
        //Char1name.text = "YOU";
        //Char1speech.text = "";
        //Char2name.text = "";
        //Char2speech.text = "";
        ////gameHandler.AddPlayerStat(1);
        //// Turn off "Next" button, turn on "Choice" buttons
        //nextButton.SetActive(false);
        //allowSpace = false;
        //Choice1a.SetActive(true); // function Choice1aFunct() OGRE OGRE PLEASE DON’T SQUASH ME!
        //Choice1b.SetActive(true); // function Choice1bFunct() OG-ahem! Uh, yeah I’m okay. Thanks for the concern.

        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(true);
            //ArtChar4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "";
            //Char3speech.text = "";
            //Char4name.text = "KEEPER";
            //Char4speech.text = "Holy shit, Stew, you didn’t even take a look at the guy!";
            nextButton.SetActive(true);
            //allowSpace = false;
            //NextScene1Button.SetActive(false);
            //NextScene2Button.SetActive(false);
        }
        else if (primeInt == 101)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(true);
            //ArtChar4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "";
            //Char3speech.text = "";
            //Char4name.text = "KEEPER";
            //Char4speech.text = "Holy shit, Stew, you didn’t even take a look at the guy! \nJumping in and obliterating your opponent with no warning like that? Classic Stewie!";
            NextScene1Button.SetActive(false);
        }
        else if (primeInt == 102)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(true);
            //ArtChar4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "OGRE";
            //Char3speech.text = "HAH, YEAH! You know me, I’m always business down in the dungeons!";
            //Char4name.text = "";
            //Char4speech.text = "";
            NextScene1Button.SetActive(false);
        }
        else if (primeInt == 103)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(true);
            //ArtChar4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "";
            //Char3speech.text = "";
            //Char4name.text = "KEEPER";
            //Char4speech.text = "Yeah… you never even learned their name though.";
            NextScene1Button.SetActive(false);
        }
        else if (primeInt == 104)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(true);
            //ArtChar4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "";
            //Char3speech.text = "";
            //Char4name.text = "KEEPER";
            //Char4speech.text = "Yeah… you never even learned their name though. \nLook at them, they’re totally unrecognizable now!";
            NextScene1Button.SetActive(false);
        }
        else if (primeInt == 105)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            //ArtChar3.SetActive(true);
            //ArtChar4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            //Char3name.text = "OGRE";
            //Char3speech.text = "Eh, I’m sure it wouldn’t have made a difference anyway.";
            //Char4name.text = "";
            //Char4speech.text = "";
            NextScene1Button.SetActive(true);
        }
        //else if (primeInt == 106)
        //{
        //    Char1name.text = "";
        //    Char1speech.text = "";
        //    Char2name.text = "OGRE";
        //    Char2speech.text = "MOST ogres you’ve met? So what, we’re all the same?";
        //    nextButton.SetActive(true);
        //    allowSpace = false;
        //    NextScene1Button.SetActive(false);
        //}
        //else if (primeInt == 107)
        //{
        //    Char1name.text = "";
        //    Char1speech.text = "";
        //    Char2name.text = "OGRE";
        //    Char2speech.text = "MOST ogres you’ve met? So what, we’re all the same? \nWell, I bet most ogres out there would have probably eaten you alive by now, wouldn’t they?";
        //    nextButton.SetActive(true);
        //    allowSpace = false;
        //    NextScene1Button.SetActive(false);
        //}
        //else if (primeInt == 108)
        //{
        //    Char1name.text = "YOU";
        //    Char1speech.text = "...";
        //    Char2name.text = "";
        //    Char2speech.text = "";
        //    nextButton.SetActive(true);
        //    allowSpace = false;
        //    NextScene1Button.SetActive(false);
        //}
        //else if (primeInt == 109)
        //{
        //    Char1name.text = "";
        //    Char1speech.text = "";
        //    Char2name.text = "OGRE";
        //    Char2speech.text = "Down the hatch!";
        //    nextButton.SetActive(false);
        //    allowSpace = false;
        //    NextScene1Button.SetActive(true);
        //}

        //else if (primeInt == 200)
        //{
        //    Char1name.text = "YOU";
        //    Char1speech.text = "I’m trying to find my way to the dungeon, I’ve left an important item behind there and am a bit lost.";
        //    Char2name.text = "";
        //    Char2speech.text = "";
        //}
        //else if (primeInt == 201)
        //{
        //    Char1name.text = "";
        //    Char1speech.text = "";
        //    Char2name.text = "OGRE";
        //    Char2speech.text = "Oh, just down this hatch my friend!";
        //    nextButton.SetActive(true);
        //    allowSpace = false;
        //    NextScene1Button.SetActive(false);
        //}
        //else if (primeInt == 202)
        //{
        //    Char1name.text = "";
        //    Char1speech.text = "";
        //    Char2name.text = "OGRE";
        //    Char2speech.text = "Oh, just down this hatch my friend!\n I have to warn you though, it’s pretty spooky down there.";
        //    nextButton.SetActive(true);
        //    allowSpace = false;
        //    NextScene1Button.SetActive(false);
        //}
        //else if (primeInt == 203)
        //{
        //    Char1name.text = "";
        //    Char1speech.text = "";
        //    Char2name.text = "OGRE";
        //    Char2speech.text = "They got the whole set-up going on.";
        //    nextButton.SetActive(true);
        //    allowSpace = false;
        //    NextScene1Button.SetActive(false);
        //}
        //else if (primeInt == 204)
        //{
        //    Char1name.text = "";
        //    Char1speech.text = "";
        //    Char2name.text = "OGRE";
        //    Char2speech.text = "They got the whole set-up going on.\n We’re talking giant rats, skeletons hanging from shackles, eternal screaming of those who made an enemy of the king.";
        //    nextButton.SetActive(true);
        //    allowSpace = false;
        //    NextScene1Button.SetActive(false);
        //}
        //else if (primeInt == 205)
        //{
        //    Char1name.text = "YOU";
        //    Char1speech.text = "Uh-huh….. Okay, thanks for the tip.";
        //    Char2name.text = "";
        //    Char2speech.text = "";
        //    nextButton.SetActive(true);
        //    allowSpace = false;
        //    NextScene1Button.SetActive(false);
        //}
        //else if (primeInt == 206)
        //{
        //    Char1name.text = "YOU";
        //    Char1speech.text = "Uh-huh….. Okay, thanks for the tip.\n Guess I’ll be on my way. Don’t wanna keep those rats waiting!";
        //    Char2name.text = "";
        //    Char2speech.text = "";
        //    nextButton.SetActive(true);
        //    allowSpace = false;
        //    NextScene1Button.SetActive(false);
        //}
        //else if (primeInt == 207)
        //{
        //    Char1name.text = "";
        //    Char1speech.text = "";
        //    Char2name.text = "OGRE";
        //    Char2speech.text = "Hey, I can't blame ya! Good luckdown there pal!";
        //    nextButton.SetActive(true);
        //    allowSpace = false;
        //    NextScene1Button.SetActive(false);
        //}
        //else if (primeInt == 208)
        //{
        //    Char1name.text = "YOU";
        //    Char1speech.text = "";
        //    Char2name.text = "";
        //    Char2speech.text = "";
        //    // Turn off "Next" button, turn on "Choice" buttons
        //    nextButton.SetActive(false);
        //    allowSpace = false;
        //    Choice2a.SetActive(true); // function Choice2aFunct() Catch ya later… Uhhhhhhh, Mr. Ogre?
        //    Choice2b.SetActive(true); // function Choice2bFunct() Thanks again for the help! See ya!
        //}
        // ENCOUNTER AFTER CHOICE #2
        else if (primeInt == 300)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Catch you later Stew!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }

        else if (primeInt == 400)
        {
            Char1name.text = "YOU";
            Char1speech.text = "You too!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and #2 and switch scenes)
    public void Choice1aFunct()
    {
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        //ArtChar3.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        //Char3name.text = "OGRE";
        //Char3speech.text = "GRUGGA SMASH!";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }


    public void Choice1bFunct()
    {
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        //ArtChar3.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        //Char3name.text = "OGRE";
        //Char3speech.text = "GRUGGA SMASH!";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2aFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "OGRE";
        Char2speech.text = "Oh, my name’s Grugga, but most people call me Stewie!";
        primeInt = 299;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2bFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "OGRE";
        Char2speech.text = "Stay safe!";
        primeInt = 399;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange2a()
    {
        SceneManager.LoadScene("Scene2c");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("Scene3a");
    }
}