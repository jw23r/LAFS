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

    public Sprite ItemIcon { get { return _itemIcon; } } // NOTE: We can protect this data field by only allowing public access to read it but not change it:
  
    [Tooltip("sets items Icon")]
    [SerializeField]
    private Sprite _itemIcon;

    public Mesh ItemGameObject { get { return _itemGameObject; } }
    [Tooltip("mesh used to change item at desk")]
    [SerializeField]
    private Mesh _itemGameObject;

    public Material ItemGameObjectMaterial { get { return _itemGameObjectMaterial; } }
    [Tooltip("sets items material")]
    [SerializeField]
    private Material _itemGameObjectMaterial;
    public enum  investagionsOptions
    { CallPoilce, Accept, Refuse}
    [Tooltip("sets the correct button to hit")]
    public investagionsOptions instanceOfEnum;


    //public int CoolIntField { get { return _coolIntField; } } // NOTE: We can protect this data field by only allowing public access to read it but not change it:
    //[SerializeField]
    //private int _coolIntField = 0;
    #endregion Properties (end)
}

