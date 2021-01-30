using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu(fileName = "New Person", menuName = "Person Data Object")]
    public class Person : ScriptableObject
{ 


    public string PersonNameTextField { get { return _personNameTextField; } } // NOTE: We can protect this data field by only allowing public access to read it but not change it:
[SerializeField]
private string _personNameTextField = string.Empty;
   
    public string ItemDescription { get { return _itemDescription; } } // NOTE: We can protect this data field by only allowing public access to read it but not change it:
    [SerializeField]
    private string _itemDescription = string.Empty;

    public string GoodRespone { get { return _goodRespone; } } // NOTE: We can protect this data field by only allowing public access to read it but not change it:
    [SerializeField]
    private string _goodRespone = string.Empty;
    public string BadRespone { get { return _badRespone; } } // NOTE: We can protect this data field by only allowing public access to read it but not change it:
    [SerializeField]
    private string _badRespone = string.Empty;

    public Item ItemGameObject { get { return _itemGameObject; } }
    [SerializeField]
    [Tooltip("not being used")]
    private Item _itemGameObject;


    public enum whatTheyUpTo 
    { Looking, Giving }

    public whatTheyUpTo instanceOfEnum;

    public enum maleOrFemale
    { Male, Female }

    public maleOrFemale instanceOfMaleOrFemale;
}
