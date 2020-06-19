using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
//J'appelle la fonction "loadLevel"
public string loadLevel;
//Setup du bouton "jouer"
public void startGame(){

    Application.LoadLevel (loadLevel);

   }
//Setup du bouton "quitter"
public void quitGame(){

    Application.Quit ();
}
}