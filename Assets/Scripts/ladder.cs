using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


[RequireComponent(typeof(CharacterController))]
public class Ladder : MonoBehaviour
{
    public Transform playerController;
    bool inside = false;
    public float speed = 3f;
    public CharacterController player;
    public AudioSource sound;


    void OnValidate()
    {
        player=GetComponent<CharacterController>();
    }

    void Start()
    {
        inside = false;
        player=GetComponent<CharacterController>();
    }



    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Ladder")
        {
            Debug.Log("TouchingLadderTrue");
            player.enabled = false;
            inside = true;
        }


    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Ladder")
        {
            Debug.Log("TouchingLadderFalse");
            player.enabled = true;
            inside = true;
        }


    }

    void Update()
    {
        if (inside == true && Input.GetKey("w"))
        {
            player.transform.position += Vector3.up /
            speed * Time.deltaTime;
        }

        if (inside == true && Input.GetKey("s"))
        {
            player.transform.position += Vector3.down /
            speed * Time.deltaTime;
        }


    }


}