using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene4a : MonoBehaviour {
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

void Start(){         // initial visibility settings
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
				ArtChar3.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Finally, the dungeon!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
			    ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Finally, the dungeon!\nCan’t believe how much of a relief it is to be down in this musty cave.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 4){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Hey you, have you seen a golden chalice laying around here by any chance?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PRISONER";
                Char2speech.text = "Who, me? You think I’d just tell you about a GOLDEN chalice if I happened to find one?";
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
			 // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct() Pretty please?
                Choice1b.SetActive(true); // function Choice1bFunct() Spill the beans before I spill your blood, pal!
	    }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PRISONER";
                Char2speech.text = "Well, there was a chalice, but as most valuable things go down here, it was confiscated by the dungeon keeper.";    
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);	
                NextScene2Button.SetActive(false);
				NextScene3Button.SetActive(false);				
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PRISONER";
                Char2speech.text = "Ya know, big guy with the black hood?";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PRISONER";
                Char2speech.text = "Ya know, big guy with the black hood?\nOh, speak of the devil.";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
		}
		else if (primeInt == 103){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DUNGEON KEEPER";
				Char3speech.text = "What’s this about my chalice?";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 104){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DUNGEON KEEPER";
				Char3speech.text = "What’s this about my chalice?\nYou want to get your grubby little hands on it?";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 105){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Well, I am the rightful owner of it.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 106){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DUNGEON KEEPER";
				Char3speech.text = "Hah, okay little man!";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 107){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DUNGEON KEEPER";
				Char3speech.text = "I'll tell ya what.";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 108){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DUNGEON KEEPER";
				Char3speech.text = "I'll tell ya what.\nTonight we’re holding the annual prison bloodbath.";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 109){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DUNGEON KEEPER";
				Char3speech.text = "I'll tell ya what.\nTonight we’re holding the annual prison bloodbath.\nTwo people enter, only one leaves.";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 110){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DUNGEON KEEPER";
				Char3speech.text = "You want your chalice, win against just one of the contenders.";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 111){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DUNGEON KEEPER";
				Char3speech.text = "You want your chalice, win against just one of the contenders.\nThis little chalice is nothing compared to the grand prize, so just one win should suffice.";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 112){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "You've gotta be kidding me...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 113){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DUNGEON KEEPER";
				Char3speech.text = "Cry me a boat bub.";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 114){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DUNGEON KEEPER";
				Char3speech.text = "Now, I’ll list three names, you pick who you wanna go up against and I’ll guide you to the right arena where you’ll wait for your opponent to show.";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 115){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "DUNGEON KEEPER";
				Char3speech.text = "Think carefully, names can be deceiving.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
				NextScene2Button.SetActive(true);
				NextScene3Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";               
	   }
}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PRISONER";
                Char2speech.text = "Man, you’re not gonna last a second down here.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PRISONER";
                Char2speech.text = "Oh wow, look at mister tough guy.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
        public void SceneChange2a(){
                SceneManager.LoadScene("Scene5a");
        }
        public void SceneChange2b(){
                SceneManager.LoadScene("Scene5b");
        }
		public void SceneChange2c(){
                SceneManager.LoadScene("Scene5c");
        }
}