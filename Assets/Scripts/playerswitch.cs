using UnityEngine;

public class playerswitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Character1;
    public GameObject Character2;
    public CameraFollow cameraFollow;

    private Movement movementcharacter1;
    private Movement movementcharacter2;
    private bool characterOn = true;



    private void Awake()
    {
        movementcharacter1 = Character1.GetComponent<Movement>();
        movementcharacter2 = Character2.GetComponent<Movement>();
<<<<<<< Updated upstream
=======

        movementcharacter1.enabled = true;
        movementcharacter2.enabled = false;
        cameraFollow.SetTarget(Character2.transform);
>>>>>>> Stashed changes
    }
    // Update is called once per frame
    void Update()
    {
        HandleForm();
    }
    private void HandleForm()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            if (characterOn == true)
            {
                //Character2.SetActive(true);
                //Character1.SetActive(false);
                movementcharacter1.enabled = false;
                movementcharacter2.enabled = true;

                cameraFollow.SetTarget(Character2.transform);

                characterOn = false;
            }
            else
            {
                //Character1.SetActive(true);
                //Character2.SetActive(false);
                movementcharacter1.enabled = true;
                movementcharacter2.enabled = false;

                cameraFollow.SetTarget(Character1.transform);

                characterOn = true;


            }

        }
    }
}
