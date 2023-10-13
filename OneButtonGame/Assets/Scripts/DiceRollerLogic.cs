using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DiceRollerLogic : MonoBehaviour
{ 
    Button mybutton;
    
    [SerializeField] TextMeshProUGUI mytext;

    public static int pointCount = 0;

    float timer = 0;



    void Start()
    {
        mybutton = GetComponent<Button>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            timer += Time.deltaTime;
            if (timer > 3)
            {
                SceneManager.LoadScene("Menu");
                timer =  0;
            }
        }
        if (Input.GetButtonUp("Fire1"))
        {
            Roll();
            timer = 0;
        }
        
    }

    void Roll()
    {
        int diceRoll = Random.Range(1, 7);
        pointCount += diceRoll;
        mytext.text = "Points: " + pointCount;
    }
}
