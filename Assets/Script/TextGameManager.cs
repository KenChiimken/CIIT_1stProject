using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, TimeTextMeshPro, StaminaTextMeshPro;
    public string storyText;
    public int TimeValue, StaminaValue;
    public GameObject Option1, Option2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        TimeTextMeshPro.text = TimeValue.ToString();
        StaminaTextMeshPro.text = StaminaValue.ToString();
    }

    public void Gotobusstop()
    {
        storyText = "You went to the bus stop and went home.";
        TimeValue += 10;
        StaminaValue -=5 ;
        Option1.SetActive(false);
        Option2.SetActive(true);
    }

    public void Gotocoffeeshop()
    {
        storyText = "You went to the coffee shop and missed the bus.";
        Option1.SetActive(true);
        Option2.SetActive(false);
        TimeValue -= 5;
        StaminaValue += 10;
    }
}
