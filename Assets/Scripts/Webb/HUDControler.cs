using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDControler : MonoBehaviour
{
    // Start is called before the first frame update
    public Button inventorySlot0;
    public Button inventorySlot1;
    public Button inventorySlot2;
    public Button inventorySlot3;
    public Button inventorySlot4;
    public Button inventorySlot5;
    public Sprite emptyInventory;
    public Text currenTextOnScreen;
    public Text previousTextOnScreen;
    public Text score;
    public Text timeOfDay;
    int hourOfDay = 01; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeInventoryIcon();
        ChangeTime();
    }
    void ChangeInventoryIcon() 
    { 
    if(PersonAtDesk.inventory.Count <= 0)
        {
            inventorySlot0.image.sprite = emptyInventory;
            inventorySlot1.image.sprite = emptyInventory;
            inventorySlot2.image.sprite = emptyInventory;
            inventorySlot3.image.sprite = emptyInventory;
            inventorySlot4.image.sprite = emptyInventory;
            inventorySlot5.image.sprite = emptyInventory;
        }
    if(PersonAtDesk.inventory.Count >= 1)
        {
            inventorySlot0.image.sprite = PersonAtDesk.inventory[0].ItemIcon;
        }
        if (PersonAtDesk.inventory.Count >= 2)
        {
            inventorySlot1.image.sprite = PersonAtDesk.inventory[1].ItemIcon;
        }
        else
        {
            inventorySlot1.image.sprite = emptyInventory;
         }
       
        if (PersonAtDesk.inventory.Count >= 3)
        {
            inventorySlot2.image.sprite = PersonAtDesk.inventory[2].ItemIcon;
        }
        else
        {
            inventorySlot2.image.sprite = emptyInventory;
        }
        if (PersonAtDesk.inventory.Count >= 4)
        {
            inventorySlot3.image.sprite = PersonAtDesk.inventory[3].ItemIcon;
        }
        else
        {
            inventorySlot3.image.sprite = emptyInventory;
        }
        if (PersonAtDesk.inventory.Count >= 5)
        {
            inventorySlot4.image.sprite = PersonAtDesk.inventory[4].ItemIcon;
        }
        else
        {
            inventorySlot4.image.sprite = emptyInventory;
        }
        if (PersonAtDesk.inventory.Count >= 6)
        {
            inventorySlot5.image.sprite = PersonAtDesk.inventory[5].ItemIcon;
        }
        else
        {
            inventorySlot5.image.sprite = emptyInventory;
        }
    }
    void UpdateText()
    {
        currenTextOnScreen.text = PersonAtDesk.currentText;
        previousTextOnScreen.text = PersonAtDesk.previousText;
        score.text = PersonAtDesk.currentPoints.ToString();
        timeOfDay.text = "0" + hourOfDay.ToString() + ":00";
    }
    void ChangeTime()
    {
        float x = 0;
        x += Time.deltaTime;
        if(x == 120)
        {
            hourOfDay += 1;
            x = 0;
        }
    }
}
