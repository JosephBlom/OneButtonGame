using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{ 
    Button mybutton;
    
    [SerializeField] TextMeshProUGUI mytext;


    float timer = 0;
    string[] options = { "DiceRoller", "Upgrades", "Combat"};
    int optionStart = 0;

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
                Select();
                timer =  0;
            }
        }
        if (Input.GetButtonUp("Fire1"))
        {
            Next();
            timer = 0;
        }
        
    }

    private void Select()
    {
        SceneManager.LoadScene(options[optionStart]);
    }

    void Next()
    {
        optionStart++;
        if(optionStart > 2)
        {
            optionStart = 0;
        }
    }
}
