using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class EnablerCmtsDB
{
    public string welcome;
    public string brain_gym_thinking_caps;
    public string bubble_coloring;
    public string listening_activity;
    public string find_the_missing_card;
    public string brain_gym_earth_buttons;
    public string lets_talk;
    public string listening_and_talking;
    public string number_and_letters;
    public string goodbye_song;

    public EnablerCmtsDB()
    {
        welcome = Main_Blended.OBJ_main_blended.enablerComments[0];
        brain_gym_thinking_caps = Main_Blended.OBJ_main_blended.enablerComments[1];
        bubble_coloring = Main_Blended.OBJ_main_blended.enablerComments[2];
        listening_activity = Main_Blended.OBJ_main_blended.enablerComments[3];
        find_the_missing_card = Main_Blended.OBJ_main_blended.enablerComments[4];
        brain_gym_earth_buttons = Main_Blended.OBJ_main_blended.enablerComments[5];
        lets_talk = Main_Blended.OBJ_main_blended.enablerComments[6];
        listening_and_talking = Main_Blended.OBJ_main_blended.enablerComments[7];
        number_and_letters = Main_Blended.OBJ_main_blended.enablerComments[8];
        goodbye_song = Main_Blended.OBJ_main_blended.enablerComments[9];
    }
}