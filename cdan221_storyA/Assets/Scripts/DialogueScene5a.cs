using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene5a : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		public Text Char2bname;
		public Text Char2bspeech;
		public Text Char3name;
		public Text Char3speech;
        public Text Char4name;
		public Text Char4speech;
        public GameObject dialogue;
        public GameObject ArtChar1;
        public GameObject ArtChar2;
		public GameObject ArtChar2b;
		public GameObject ArtChar3;
		public GameObject ArtChar4;
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
		ArtChar2.SetActive(false);
		ArtChar2b.SetActive(false);
		ArtChar3.SetActive(false);
		ArtChar4.SetActive(false);
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
                Char1name.text = "KEEPER";
                Char1speech.text = "So, you're gonna take on Crusher, huh? Aren't you confident? Oh well, he's all yours!";
                Char2name.text = "";
                Char2speech.text = "";
				Char2bname.text = "";
                Char2bspeech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				
				
        }
       else if (primeInt ==3){
				ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CRUSHER";
                Char2speech.text = "Bring it on! Bring it on then, tough guy! I'll turn you into dust! This is my fiftieth fight of the day, and I've won every single one of 'em so far! I can scrap with the best! Let's go!";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 4){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "YOU";
                Char3speech.text = "This guy must be pretty tough. He won fifty fights in a row? How?";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 5){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CRUSHER";
                Char2speech.text = "Eat my fists of fury!!! HYAHHHH!!!!!";
                Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				//Code for changing the scene
				nextButton.SetActive(false);
				allowSpace = false;
				Choice1a.SetActive(true);
				Choice1b.SetActive(true);
        }
       else if (primeInt == 6){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "YOU";
                Char3speech.text = "GET AWAY FROM ME!";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==7){
				ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "(You lightly slap Crusher as he flies towards you, instantly disintegrating him into dust. A bell rings out in the room.)";
        }
       else if (primeInt == 8){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
				Char1name.text = "KEEPER";
                Char1speech.text = "Wow, that took longer than it usually does. Hey, can somebody get the dustpan and come clean Crusher up?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 9){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar2b.SetActive(true);
				ArtChar3.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
				Char2name.text = "";
                Char2speech.text = "";
                Char2bname.text = "DUST PILE";
                Char2bspeech.text = "Hey! No fair! I wasn't ready! Rematch! Rematch!";
                Char3name.text = "";
                Char3speech.text = "";
		}
		else if (primeInt == 10){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
				Char1name.text = "KEEPER";
                Char1speech.text = "He'll be okay, we can just glue him back together. We have to do this after all his fights.";
                Char2name.text = "";
                Char2speech.text = "";
				Char2bname.text = "";
                Char2bspeech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 11){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar2b.SetActive(false);
				ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "YOU";
                Char3speech.text = "Where's my prize?";
        }
		else if (primeInt == 12){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
				Char1name.text = "KEEPER";
                Char1speech.text = "Not one for conversation, huh? Fine, fine. Here you go.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 13){
                ArtChar1.SetActive(true);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "(The dungeon keeper hands over the golden chalice, and your time machine back to the future. Right as you grab the cup, you hear the royal guards enter the dungeon.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 14){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
				ArtChar4.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "GUARD";
                Char4speech.text = "The prince has been killed! Place the castle on lockdown immediately!";
        }
		else if (primeInt == 15){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
				ArtChar4.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "YOU";
                Char3speech.text = "Alright, time to go!";
				Char4name.text = "";
                Char4speech.text = "";
        }else if (primeInt == 16){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
				ArtChar4.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "YOU";
                Char3speech.text = "Alright, time to go!";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 17){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
				ArtChar4.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "YOU";
                Char3speech.text = "(You press the gems adorning the chalice in a specific sequence and white light glows from the chalice.)";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 18){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
				ArtChar4.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "YOU";
                Char3speech.text = "(It grows brighter as it fills the room, blinding the guards. It grows brighter and brighter, until...)";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 19){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
				ArtChar4.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "YOU";
                Char3speech.text = "(It grows brighter as it fills the room, blinding the guards. It grows brighter and brighter, until...)";
				Char4name.text = "";
                Char4speech.text = "";
				//Code for changing the scene
				nextButton.SetActive(false);
				allowSpace = false;
				NextScene1Button.SetActive(true);
        }
		
		
		else if (primeInt == 100){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
				ArtChar4.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CRUSHER";
                Char2speech.text = "Really, Greenie? ALRIGHT, HOW DO YOU LIKE THIS?";
                Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		
		
		else if (primeInt == 101){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
				ArtChar4.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "YOU";
                Char3speech.text = "Are you planning to hit me at some point?";
				Char4name.text = "";
                Char4speech.text = "";
        }
		
		
		else if (primeInt == 102){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
				ArtChar4.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "(You dodge as Crusher runs toward you.)";
				Char4name.text = "";
                Char4speech.text = "";
        }
		
		else if (primeInt == 103){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar2b.SetActive(true);
				ArtChar3.SetActive(false);
				ArtChar4.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "(Crusher smacks into a chair, and disintegrates into fairy dust.)";
				Char4name.text = "";
                Char4speech.text = "";
        }
		
		else if (primeInt == 104){
                ArtChar1.SetActive(false);
			    ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
				ArtChar4.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "(In your surprise, you bang your shin against another chair.)";
				Char4name.text = "";
                Char4speech.text = "";
				primeInt = 7;
        }
		
		
}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
				ArtChar2.SetActive(false);
				ArtChar2b.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "YOU";
                Char3speech.text = "EEK!";
                Char4name.text = "";
                Char4speech.text = "";
                primeInt = 5;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
				ArtChar2.SetActive(false);
				ArtChar2b.SetActive(false);
				ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "YOU";
                Char3speech.text = "I've got you now, Greenie!";
                Char4name.text = "";
                Char4speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange2a(){
               SceneManager.LoadScene("SceneEnd2");
        }
        public void SceneChange2b(){
                SceneManager.LoadScene("Scene2b");
        }
}