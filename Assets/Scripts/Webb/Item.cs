using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;




[CreateAssetMenu(fileName = "New Item", menuName = "Item Data Object")]
public class Item : ScriptableObject
{

    #region Properties
    public string ItemNameTextField { get { return _itemNameTextField; } } // NOTE: We can protect this data field by only allowing public access to read it but not change it:
    [SerializeField]
    private string _itemNameTextField = string.Empty;

    public int ItemPointValue { get { return _itemPointValue; } } // NOTE: We can protect this data field by only allowing public access to read it but not change it:
    [SerializeField]
    private int _itemPointValue;

    public Texture ItemIcon { get { return _itemIcon; } } // NOTE: We can protect this data field by only allowing public access to read it but not change it:
    [SerializeField]
    private Texture _itemIcon;

    public GameObject ItemGameObject { get { return _itemGameObject; } }
    [SerializeField]
    [Tooltip("not being used")]
    private GameObject _itemGameObject;

    public enum  investagionsOptions
    { CallPoilce, Accept, Refuse}

    public investagionsOptions instanceOfEnum;


    //public int CoolIntField { get { return _coolIntField; } } // NOTE: We can protect this data field by only allowing public access to read it but not change it:
    //[SerializeField]
    //private int _coolIntField = 0;
    #endregion Properties (end)
}

