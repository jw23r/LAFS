using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonAtDesk : MonoBehaviour
{
    public float currentPoints = 100;
   public List<Person> people;
    public GameObject itemAtDesklocation;
    
   public static List<Person> personAtDesk;
    
    // Start is called before the first frame update
    void Start()
    {

        personAtDesk = new List<Person>();
        personAtDesk.Add(people[(Random.Range(0, people.Count))]);
        print(personAtDesk[0].ItemGameObject.ItemGameObject);
        Instantiate(personAtDesk[0].ItemGameObject.ItemGameObject, itemAtDesklocation.transform.position, itemAtDesklocation.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Accepte()
    {
        if (personAtDesk[0].instanceOfEnum.ToString() == "Giving")
        {
            if (personAtDesk[0].ItemGameObject.instanceOfEnum.ToString() == "Accept")
            {
                print("you took the item");
                currentPoints += personAtDesk[0].ItemGameObject.ItemPointValue;
                personAtDesk.Clear();
                personAtDesk.Add(people[(Random.Range(0, people.Count))]);



            }
            else
            {
                print("bad item");
                currentPoints -= personAtDesk[0].ItemGameObject.ItemPointValue;
                personAtDesk.Clear();
                personAtDesk.Add(people[(Random.Range(0, people.Count))]);


            }
        }
    }
    public void CallPoilce()
    {
        if (personAtDesk[0].instanceOfEnum.ToString() == "Giving")
        {
            if (personAtDesk[0].ItemGameObject.instanceOfEnum.ToString() == "CallPoilce")
            {
                print("Crook is Arrtsted");
                currentPoints += personAtDesk[0].ItemGameObject.ItemPointValue;
                personAtDesk.Clear();
                personAtDesk.Add(people[(Random.Range(0, people.Count))]);



            }
            else
            {
                print("wasted police Time");
                currentPoints -= personAtDesk[0].ItemGameObject.ItemPointValue;
                personAtDesk.Clear();
                personAtDesk.Add(people[(Random.Range(0, people.Count))]);



            }
        }
    }
    public void Refuse()
    {
        if (personAtDesk[0].instanceOfEnum.ToString() == "Giving")
        {

            if (personAtDesk[0].ItemGameObject.instanceOfEnum.ToString() == "Refuse")
            {
                print("Refused garbge");
                currentPoints += personAtDesk[0].ItemGameObject.ItemPointValue;
                personAtDesk.Clear();
                personAtDesk.Add(people[(Random.Range(0, people.Count))]);



            }
            else
            {
                print("Acctpted garbege");
                currentPoints -= personAtDesk[0].ItemGameObject.ItemPointValue;
                personAtDesk.Clear();
                personAtDesk.Add(people[(Random.Range(0, people.Count))]);



            }
        }
        if (personAtDesk[0].instanceOfEnum.ToString() == "Looking")
        {
            personAtDesk.Clear();
            personAtDesk.Add(people[(Random.Range(0, people.Count))]);

        }
    }
}
