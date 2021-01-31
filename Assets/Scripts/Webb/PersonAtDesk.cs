using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PersonAtDesk : MonoBehaviour
{
    public static int currentPoints = 0;
  public List<Person> people;
  
    public GameObject itemAtDesklocation;
    public MeshFilter currentItem;
     public MeshRenderer currentItemMaterial;
    public static string currentText;
    public static string previousText;
    public static List<Person> personAtDesk;
    public static List<Item> inventory;
    
    // Start is called before the first frame update
    void Start()
    {

        personAtDesk = new List<Person>();
        inventory = new List<Item>();

        ChangePersonAtDesk();
    }

    // Update is called once per frame
    void Update()
    {
        /*  if (Input.GetButtonDown("Fire1"))
          {
              Accepte();

          }*/
        if(people.Count <= 0) SceneManager.LoadScene("EndofGame");


    }
    public void Accepte()
    {
        if (personAtDesk.Count > 0)
        {
            if (personAtDesk[0].instanceOfEnum.ToString() == "Giving")
            {
                if (inventory.Count < 6)
                {
                    if (personAtDesk[0].ItemGameObject.instanceOfEnum.ToString() == "Accept" )
                    {
                        print("you took the item");
                        currentPoints += personAtDesk[0].ItemGameObject.ItemPointValue;

                        inventory.Add(personAtDesk[0].ItemGameObject);

                        ChangePersonAtDesk();

                    }
                    else
                    {
                        inventory.Add(personAtDesk[0].ItemGameObject);
                     
                        currentPoints -= personAtDesk[0].ItemGameObject.ItemPointValue;
                        ChangePersonAtDesk();
                    }
                }
            }
           
         
        }
    }
    public void CallPoilce()
    {
        if (personAtDesk.Count > 0)
        {

            if (personAtDesk[0].instanceOfEnum.ToString() == "Giving")
            {
                if (personAtDesk[0].ItemGameObject.instanceOfEnum.ToString() == "CallPoilce")
                {
                    print("Crook is Arrtsted");
                    currentPoints += personAtDesk[0].ItemGameObject.ItemPointValue;
                    ChangePersonAtDesk();
                }
                else
                {
                    print("wasted police Time");
                    currentPoints -= personAtDesk[0].ItemGameObject.ItemPointValue;
                    ChangePersonAtDesk();




                }
            }
            }
    }
    public void Refuse()
    {

        if (personAtDesk.Count > 0)
        {
            if (personAtDesk[0].ItemGameObject.instanceOfEnum.ToString() == "Refuse")
            {
                print("Refused garbge");
                currentPoints += personAtDesk[0].ItemGameObject.ItemPointValue;

            }

            ChangePersonAtDesk();
        }
     
      
    }
    public void GiveItem0()
    {


        if (personAtDesk[0].instanceOfEnum.ToString() == "Looking")
        {
            if (inventory.Count < 1) return;

            print("got here");

            if (inventory[0] == personAtDesk[0].ItemGameObject)
            {
                currentText = personAtDesk[0].GoodRespone;
                currentPoints += personAtDesk[0].ItemGameObject.ItemPointValue;

                ChangePersonAtDesk();

                inventory.RemoveAt(0);
            }
            else
            {
                currentPoints -= personAtDesk[0].ItemGameObject.ItemPointValue;
                currentText = personAtDesk[0].BadRespone;
                ChangePersonAtDesk();

            }
        }
    }
    public void GiveItem1()
    {
       
        if (personAtDesk[0].instanceOfEnum.ToString() == "Looking")
        {
            if (inventory.Count <2) return;

            print("got here");

            if (inventory[1] == personAtDesk[0].ItemGameObject)
            {
                currentText = personAtDesk[0].GoodRespone;
                currentPoints += personAtDesk[0].ItemGameObject.ItemPointValue;

                ChangePersonAtDesk();

                inventory.RemoveAt(1);
            }
        else
        {
            currentPoints -= personAtDesk[0].ItemGameObject.ItemPointValue;
            currentText = personAtDesk[0].BadRespone;
            ChangePersonAtDesk();

        }
        }
    }
    public void GiveItem2()
    {
        if (personAtDesk[0].instanceOfEnum.ToString() == "Looking")
        {
            if (inventory.Count < 3) return;

         

            if (inventory[2] == personAtDesk[0].ItemGameObject)
            {
                currentText = personAtDesk[0].GoodRespone;
                currentPoints += personAtDesk[0].ItemGameObject.ItemPointValue;

                ChangePersonAtDesk();

                inventory.RemoveAt(2);
            }
            else
            {
                currentPoints -= personAtDesk[0].ItemGameObject.ItemPointValue;
                currentText = personAtDesk[0].BadRespone;
                ChangePersonAtDesk();

            }
        }
    }
    public void GiveItem3()
    {
        if (personAtDesk[0].instanceOfEnum.ToString() == "Looking")
        {
            if (inventory.Count < 4) return;

            print("got here");

            if (inventory[3] == personAtDesk[0].ItemGameObject)
            {
                currentText = personAtDesk[0].GoodRespone;
                currentPoints += personAtDesk[0].ItemGameObject.ItemPointValue;

                ChangePersonAtDesk();

                inventory.RemoveAt(3);
            }
            else
            {
                currentPoints -= personAtDesk[0].ItemGameObject.ItemPointValue;
                currentText = personAtDesk[0].BadRespone;
                ChangePersonAtDesk();

            }
        }
    }
    public void GiveItem4()
    {
        if (personAtDesk[0].instanceOfEnum.ToString() == "Looking")
        {
            if (inventory.Count < 5) return;

            print("got here");

            if (inventory[4] == personAtDesk[0].ItemGameObject)
            {
                currentText = personAtDesk[0].GoodRespone;
                currentPoints += personAtDesk[0].ItemGameObject.ItemPointValue;

                ChangePersonAtDesk();

                inventory.RemoveAt(4);
            }
            else
            {
                currentPoints -= personAtDesk[0].ItemGameObject.ItemPointValue;
                currentText = personAtDesk[0].BadRespone;
                ChangePersonAtDesk();

            }
        }
    }
    public void GiveItem5()
    {
        if (personAtDesk[0].instanceOfEnum.ToString() == "Looking")
        {
            if (inventory.Count < 6) return;

            print("got here");

            if (inventory[5] == personAtDesk[0].ItemGameObject)
            {
                currentText = personAtDesk[0].GoodRespone;
                currentPoints += personAtDesk[0].ItemGameObject.ItemPointValue;

                ChangePersonAtDesk();

                inventory.RemoveAt(5);
            }
            else
            {
                currentPoints -= personAtDesk[0].ItemGameObject.ItemPointValue;
                currentText = personAtDesk[0].BadRespone;
                ChangePersonAtDesk();

            }
        }
    }
    void ChangePersonAtDesk()
    {
        if (people.Count > 0)
        {
            previousText = currentText;
            personAtDesk.Clear();
            int x = Random.Range(0, people.Count);
            personAtDesk.Add(people[x]);

            currentItem.mesh = personAtDesk[0].ItemGameObject.ItemGameObject;
           currentItemMaterial.material = personAtDesk[0].ItemGameObject.ItemGameObjectMaterial;
            if (personAtDesk[0].instanceOfEnum.ToString() == "Looking") currentItem.mesh.Clear();
            currentText = personAtDesk[0].ItemDescription;
            people.RemoveAt(x);
        }
    }
}
