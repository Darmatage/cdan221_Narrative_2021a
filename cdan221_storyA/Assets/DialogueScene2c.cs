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
        public Text Char3name;
        public Text Char3speech;
        public GameObject dialogue;
        public GameObject ArtChar1;
		public GameObject ArtChar2;
		public GameObject ArtChar3;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
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
		ArtChar3.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
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
				ArtChar3.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Jeez, what is this place?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
			    ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Jeez, what is this place?\n It reeks of vinegar!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 4){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AGATHA";
                Char2speech.text = "Ah! Hello, and welcome to Agatha’s kitchen!";
        }
       else if (primeInt == 5){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AGATHA";
                Char2speech.text = "Ah! Hello, and welcome to Agatha’s kitchen!\n Are you the new vinegar boy?";
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
                Choice1a.SetActive(true); // function Choice1aFunct() The what?
                Choice1b.SetActive(true); // function Choice1bFunct() Uhhhh… surprise!
	    }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AGATHA";
                Char2speech.text = "Here it is, my trusty vinegar station! Well, I’m sure you know what you're doing.";    
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false)	
                NextScene2Button.SetActive(false);			
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AGATHA";
                Char2speech.text = "I need 50 gallons of vinegar by dawn, otherwise it’s your turn in the juicer!";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AGATHA";
                Char2speech.text = "I need 50 gallons of vinegar by dawn, otherwise it’s your turn in the juicer!\n Hah hah hah!";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
		}
		else if (primeInt == 103){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AGATHA";
                Char2speech.text = "Kidding.";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
		}
		else if (primeInt == 104){
                Char1name.text = "YOU";
                Char1speech.text = "So, this is a vinegar station, huh?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
		}
		else if (primeInt == 105){
                Char1name.text = "YOU";
                Char1speech.text = "So, this is a vinegar station, huh?\n Looks like some kind of meat grinder that produces A liquid?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
		}
		else if (primeInt == 106){
                Char1name.text = "YOU";
                Char1speech.text = "So, this is a vinegar station, huh?\n Looks like some kind of meat grinder that produces A liquid?\n What the hell is going on here?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
		}
		else if (primeInt == 107){
                Char1name.text = "YOU";
                Char1speech.text = "That barrel.... it says 'for grinding'?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
		}
		else if (primeInt == 108){
                Char1name.text = "YOU";
                Char1speech.text = "The thought of what could be kept in that barrel is hauntng.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
		}
		else if (primeInt == 109){
                Char1name.text = "YOU";
                Char1speech.text = "The thought of what could be kept in that barrel is hauntng.\n Is that what I'm supposed to use to make Agatha her vinegar?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
		}
		else if (primeInt == 110){
                Char1name.text = "YOU";
                Char1speech.text = "I feel if I stay here long enough, Agatha will surely be the end of me.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
		}
		else if (primeInt == 111){
                Char1name.text = "YOU";
                Char1speech.text = "I feel if I stay here long enough, Agatha will surely be the end of me.\n I could always book it outta here and hop down that trash chute Agatha is scraping the left-over food into…";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct() Let's get to grinding!
                Choice1b.SetActive(true); // function Choice1bFunct() I'm as good as dead if I stay, down the chute!
		}
		
		else if (primeInt == 300){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "AH";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 301){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "BLUE HUMANOIDS"
				Char3speech.text = "HIDE HIDE HIDE!!!"
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 302){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "WHAT THE HELL!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 303){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Uhhhhh uhhh um...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 304){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Uhhhhh uhhh um...\n That barrel over there! That looks as good a spot as any!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 305){
		        ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
				ArtBG1.SetActive(false);
		        ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
        else if (primeInt == 306){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "On second thought.... this may have been the wrong call.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 307){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Lemme just hop out and-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 308){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Oh-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 309){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Oh-\n Oh no!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 310){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Oh-\n Oh no!\n Please open, please!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 311){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AGATHA";
                Char2speech.text = "Ohhhhh vinegar boy!";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 312){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AGATHA";
                Char2speech.text = "Ohhhhh vinegar boy!\n Where aaaaaaare youuuu?";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 313){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AGATHA";
                Char2speech.text = "COME OUT NOW!";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 314){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Well, at least it seems like Agatha won't be able to find me in here.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
        }
		else if (primeInt == 315){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "But will anyone find and rescue me?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(false);
				NextScene2Button.SetActive(true);
        }
       else if (primeInt == 400){
		        ArtChar1.SetActive(true);
			    ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AGATHA";
                Char2speech.text = "Woah! Nooooooo, come back here!";
				Char3name.text = ""
				Char3speech.text = ""
                nextButton.SetActive(true);
                allowSpace = false;
                NextScene1Button.SetActive(true);
				NextScene2Button.SetActive(false);
        }
	   

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and #2 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AGATHA";
                Char2speech.text = "Don’t play dumb with me! Come, let me show you around.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AGATHA";
                Char2speech.text = "Oh hoh, how delightful! After what happened to my previous vinegar boy, I thought the King would deny my requests for a replacement for sure! Here, let me show you to your station.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice2aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "So, what mysteries does this little barrel hold for me to discover? I'll just take a quick peek aaannnnn-";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Well, it's now or never! Outta the way Agatha, I'm no vinegar boy!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 399;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
        public void SceneChange2a(){
               SceneManager.LoadScene("Scene4a");
        }
        public void SceneChange2b(){
                SceneManager.LoadScene("Scene3b");
        }
}