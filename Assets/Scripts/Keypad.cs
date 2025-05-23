
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class Keypad : MonoBehaviour
{
    public GameObject player;
    public GameObject keypadOB;
    public GameObject hud;
    public GameObject inv;


    public GameObject animateOB;
    public Animator ANI;


    public Text textOB;
    public string answer = "2005"; 

    public bool animate;


    void Start()
    {
        keypadOB.SetActive(false);

    }


    public void Number(int number)
    {
        textOB.text += number.ToString();
        
    }

    public void Execute()
    {
        if (textOB.text == answer)
        {

            textOB.text = "Right";
            ANI.SetBool("Open", true);
            animate = true;

            StartCoroutine(LoadEndGameSceneAfterDelay(1f));
            Debug.Log("Код правильний, сцена MainMenu має завантажитися...");
        }
        else
        {
           
            textOB.text = "Wrong";
        }


    }
    private IEnumerator LoadEndGameSceneAfterDelay(float delay)
    {
        Debug.Log($"Waiting {delay} seconds before loading scene...");
        yield return new WaitForSeconds(delay);
        Debug.Log("Loading MainMenu scene now...");
        SceneManager.LoadScene("MainMenu");
    }


    public void Clear()
    {
        {
            textOB.text = "";
            
        }
    }

    public void Exit()
    {
        keypadOB.SetActive(false);
        inv.SetActive(true);
        hud.SetActive(true);
        player.GetComponent<CharacterController>().enabled = true;
    }

    void Update() { 

        if (keypadOB.activeInHierarchy)
        {
            hud.SetActive(false);
            inv.SetActive(false);
            player.GetComponent<CharacterController>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

    }


}