using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteScript : MonoBehaviour
{
    //This place is where you define whatever variables you want to use in the script
    // GameObject is a general definition for anything that exists in the hierarchy. Example: public GameObject BathroomMat
    //gameObject is whatever this script is attached to. it doesnt need to be defined up here.
    //Component is anything in the inspector that is connected to an object. This could be a Sprite Renderer, Collider, Script, etc. For Example: public SpriteRenderer spriteRender;

    //gameObject's components
    public Collider NoteCollider; // defining the collider component
    public MeshRenderer NoteMesh;

    //values related to the note
    public int NoteID;
    public bool isRead = false;
    public string noteMessage;

    //UI stuff

    public GameObject NotePanel;
    public Text noteUI_Text;
    public Image noteUI_Image;

    // Start is called before the first frame update
    void Start()
    {
        NoteCollider = gameObject.GetComponent<Collider>();
        NoteMesh = gameObject.GetComponent<MeshRenderer>();

     


    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {//When player first enters collider
        Debug.Log("Press E to Read");



    }


    private void OnTriggerStay(Collider other)
    {//when player stays/stands in collider
        //if (Input.GetMouseButtonDown(0))
        if (Input.GetKeyUp(KeyCode.E))
        {
            
            //UI appears!
            noteUI_Text.text = noteMessage;


            // noteUI_Image.sprite = 
            //noteUI_Image.enabled = true;  //.SetActive(true)
            // noteUI_Text.enabled = true;
            NotePanel.SetActive(true);
            isRead = true;
        }
        

        if(isRead == true)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                NotePanel.SetActive(false);
                isRead = false;
            }
        }
        



    }
    /*
    private void OnTriggerExit(Collider other)
    {//when player exits collider




    }
    */
}
