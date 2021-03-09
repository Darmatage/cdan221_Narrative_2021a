using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2b : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        // public Text Char3name;
        // public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtChar1;
		public GameObject ArtChar2;
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

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
   }

void FixedUpdate(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Ouch… Maybe hopping out the window wasn't the brightest idea…";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
			    ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Woah, check out this garden! How have I never been out here before!?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "Welcome to the courtyard. That was quite a tumble you took, are you okay?";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
			 // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct() OGRE OGRE PLEASE DON’T SQUASH ME!
                Choice1b.SetActive(true); // function Choice1bFunct() OG-ahem! Uh, yeah I’m okay. Thanks for the concern.
        }
		
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "YOU";
                Char1speech.text = "Oh, uh, yikes. Sorry, I just got scared and thought-";
                Char2name.text = "";
                Char2speech.text = "";     
				nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false)
				NextScene2Button.SetActive(false);
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "Thought what? That because I’m a big ugly ogre my first instinct when seeing a puny human is to smash them into a red paste?";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 102){
                Char1name.text = "YOU";
                Char1speech.text = "Uhhhhhhh......";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
		}
		else if (primeInt == 103){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "Did you also think that I live in a cave and own a giant wooden club?";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 104){
                Char1name.text = "YOU";
                Char1speech.text = "N-no I was… it was an honest mistake, really.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 105){
                Char1name.text = "YOU";
                Char1speech.text = "N-no I was… it was an honest mistake, really. \nI wasn’t trying to generalize about the ogre race or anything. It’s just most ogres I’ve met-";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 106){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "MOST ogres you’ve met? So what, we’re all the same?";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 107){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "MOST ogres you’ve met? So what, we’re all the same? \nWell, I bet most ogres out there would have probably eaten you alive by now, wouldn’t they?";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 108){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 109){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "Down the hatch!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "YOU";
                Char1speech.text = "I’m trying to find my way to the dungeon, I’ve left an important item behind there and am a bit lost.";
                Char2name.text = "";
                Char2speech.text = "";               
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "Oh, just down this hatch my friend!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 202){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "Oh, just down this hatch my friend!\n I have to warn you though, it’s pretty spooky down there.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 203){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "They got the whole set-up going on.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 204){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "They got the whole set-up going on.\n We’re talking giant rats, skeletons hanging from shackles, eternal screaming of those who made an enemy of the king.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 205){
                Char1name.text = "YOU";
                Char1speech.text = "Uh-huh….. Okay, thanks for the tip.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 206){
                Char1name.text = "YOU";
                Char1speech.text = "Uh-huh….. Okay, thanks for the tip.\n Guess I’ll be on my way. Don’t wanna keep those rats waiting!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 207){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "Hey, I can't blame ya! Good luckdown there pal!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 208){
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct() Catch ya later… Uhhhhhhh, Mr. Ogre?
                Choice2b.SetActive(true); // function Choice2bFunct() Thanks again for the help! See ya!
     }
	 // ENCOUNTER AFTER CHOICE #2
       else if (primeInt == 300){
                Char1name.text = "YOU";
                Char1speech.text = "Catch you later Stew!";
                Char2name.text = "";
                Char2speech.text = "";  
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		
		else if (primeInt == 400){
                Char1name.text = "YOU";
                Char1speech.text = "You too!";
                Char2name.text = "";
                Char2speech.text = "";  
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and #2 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "Wha- excuse me?";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "Of course, I’m not some kind of heartless monster. Well, except in the arena. Anyway, where are you headed to?";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice2aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "Oh, my name’s Grugga, but most people call me Stewie!";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "OGRE";
                Char2speech.text = "Stay safe!";
                primeInt = 399;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange2a(){
               SceneManager.LoadScene("SceneGAMEOVER");
        }
        public void SceneChange2b(){
                SceneManager.LoadScene("Scene4a");
        }
}