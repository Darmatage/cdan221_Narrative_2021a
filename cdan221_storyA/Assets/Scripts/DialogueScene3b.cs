using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene1 : MonoBehaviour {
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
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameObject gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
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
                Char1name.text = "GUARD 1";
                Char1speech.text = "I still can’t believe how heavy this barrel is! I mean, couldn’t we have at least seen what was in it before hauling it to the docks?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
				ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
                Char1name.text = "GUARD 1";
                Char1speech.text = "I still can’t believe how heavy this barrel is! I mean, couldn’t we have at least seen what was in it before hauling it to the docks? \n What if it’s just full of something useless like bricks! And that rancid smell! It’s like there’s a family of dead skunks in here!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GUARD 2";
                Char2speech.text = "I dunno Rowan, I wouldn’t question the king and queen.";
        }
       else if (primeInt == 5){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GUARD 2";
                Char2speech.text = "I dunno Rowan, I wouldn’t question the king and queen. \n They were very clear, “Get rid of any and all barrels! Our boy used to love counting them, and now he’s gone!” Blah blah blah!";
        }
       else if (primeInt == 6){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				Char1name.text = "ROWAN";
                Char1speech.text = "Well Peter, no disrespect to the late prince, but I mean, he liked barrels so now we have to get rid of all them? Where’s the logic in that?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				Char1name.text = "ROWAN";
                Char1speech.text = "Well Peter, no disrespect to the late prince, but I mean, he liked barrels so now we have to get rid of all them? Where’s the logic in that? \n What kind of kid did the king raise if his favorite thing in life was counting bloody barrels?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PETER";
                Char2speech.text = "I feel you. It’s definitely an odd request. But I’m not trying to get on their bad side right now.";
        }
		 else if (primeInt == 9){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PETER";
                Char2speech.text = "I feel you. It’s definitely an odd request. But I’m not trying to get on their bad side right now. \n It’s been 2 weeks now, and still, no trace of the poor prince’s murderer. I’m sure the king will jump at any opportunity to bring anyone who gives him any lip straight to the gallows.";
        }
		else if (primeInt == 10){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				Char1name.text = "ROWAN";
                Char1speech.text = "Bah! This is rediculous. I'm not lugging around this barrel any longer!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 11){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				Char1name.text = "ROWAN";
                Char1speech.text = "Bah! This is rediculous. I'm not lugging around this barrel any longer! \n I mean, what the hell was Agatha cooking with? Ogre tusks?! I’d rather take my luck hunting down that dirty murderer than move this thing another inch!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 12){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PETER";
                Char2speech.text = "You're really gonna throw a tantrum right now?";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				Char1name.text = "ROWAN";
                Char1speech.text = "Damn straight! This god damn bunion is killing me! To hell with this stupid barrel! What is even inside this thing?!";
                Char2name.text = "";
                Char2speech.text = "";     
        }
		
		else if (primeInt == 101){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PETER";
                Char2speech.text = "Rowan, don't!";     
		}
        
		else if (primeInt == 102){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				Char1name.text = "ROWAN";
                Char1speech.text = "My god...";
                Char2name.text = "";
                Char2speech.text = "";   
		}				
        
		else if (primeInt == 103){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PETER";
                Char2speech.text = "What? What is it?";     
		}
        
		else if (primeInt == 104){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				Char1name.text = "ROWAN";
                Char1speech.text = "Take a look for yourself.";
                Char2name.text = "";
                Char2speech.text = "";  
				// Turn off "Next" button, turn on "SceneChange" button
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); // function Choice1aFunct()
               
		}				
        
		// ENCOUNTER AFTER CHOICE #2
       else if (primeInt == 200){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				Char1name.text = "ROWAN";
                Char1speech.text = "Ugh, whatever. Let's just pick up the pace at least.";
                Char2name.text = "";
                Char2speech.text = "";     
        }
		
		else if (primeInt == 201){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PETER";
                Char2speech.text = "Slow it down! I'm gonna trip if we keep up this speed!";     
		}
        
		else if (primeInt == 202){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				Char1name.text = "ROWAN";
                Char1speech.text = "You want some cheese with that wi-WOAH!";
                Char2name.text = "";
                Char2speech.text = "";   
		}				
        
		else if (primeInt == 203){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "PETER";
                Char2speech.text = "You moron, you couldn’t even handle your own speed! Now look, the barrel is all smashed, and… and. Oh my.";     
		}
		
		else if (primeInt == 204){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				Char1name.text = "ROWAN";
                Char1speech.text = "Is this what I think it is?";
                Char2name.text = "";
                Char2speech.text = ""; 
// Turn off "Next" button, turn on "SceneChange" button
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); // function Choice1aFunct()				
		}		
		
}
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "ROWAN";
                Char1speech.text = "Damn straight!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "ROWAN";
                Char1speech.text = "Ugh, whatever.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange2a(){
               SceneManager.LoadScene("SceneEnd");
        }
        public void SceneChange2b(){
                SceneManager.LoadScene("Scene2b");
        }
}