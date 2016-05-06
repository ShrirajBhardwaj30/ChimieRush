﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InstructionScript : MonoBehaviour {
	public GameObject textPanel;
	public static string[] instruction = new string[]{"It is a board game. You need to move from start and reach the finsh thing.","You should monve in the increasing order of numbers, i.e. from 1 to 118.","57-70 and 83-102 are dungeons.","If player confronts with lift, he has to take that no matter where it goes unless he does not have hack card.","Under some of the elements, proper instructions have written for what to do at each element.","You will get a card, once you read the green colored element.","Health Card: will get at oxygen, Iodine and Lutetium. In case if you landed on any red colored element, you can use health card to move from that element. If you don't have the health card you have to move to last safe house you have travelled.","Hack Card : will get at silicon. Using hack card you can control the movment of lifts in the game. You can make them move in the way you wish and you can also make them not move.","Strength Card: will get calcium and Molybdenum. Using Strength card you can actually move your pointer twice the number you will get on dice at that turn.","Trap Card: will get at Phosphorous. Using trap card you can lay trap at any position at any time when your turn comes. If anyone lands on the trap, he has to skip for 3 times.","Electric Card : will get at Germanium. Using electric card you can switch off current in all the blocks, so that lifts won't work untill again someone uses Electric Card.","Bulb Card :will get at Tungsten. player won't be able to see where the lifts are ! but they will work.","Magnet Card : will get at Iron. Player can move to Fe, Co Or Ni using this card.","Hydrogen card : will get at hydrogen. will save you from uranium blast.","Survival card : will get at Boron and cadmium. will save you from Uranium.","Acid card : user can use Acid card on opponent, He will move to hydrogen. only works when opponent is at 1A or 2A element.","Chems : user get some chems/money on copper, silver, gold, platinum. you can use chems to buy some cards.","Alpha/Beta/Gamma : you are asked a question. if you answer correctly you move 2 steps forward, if you answer incorrectly you move 1 step backward. if you chose not to answer you remain where you are.","Alpha/Beta/Gamma : you are asked a question for your opponent. if you answer correctly he moves 1 step back. if you answer incorrectly he moves 2 step forward. if you chose not to naswer he remains where he is.","The player who finishes first wins the game."};
	// Use this for initialization
	public static int current = 0;

	public void next(){
		if (current == 19) {
			SceneManager.LoadScene ("FirstScene");
			return;
		}
		current++;
		textPanel.GetComponent<Text> ().text = instruction [current];
	}

	public void prev(){
		if (current == 0) {
			SceneManager.LoadScene ("FirstScene");
			return;
		}
		current--;
		textPanel.GetComponent<Text> ().text = instruction [current];
	}

	public void goBack(){
		current = 0;
		SceneManager.LoadScene ("FirstScene");
	}

	void Start () {
		textPanel.GetComponent<Text> ().text = instruction [current];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
