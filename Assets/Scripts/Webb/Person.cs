﻿using System.Collections;
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
    
    public ScriptableObject ItemGameObject { get { return _itemGameObject; } }
    [SerializeField]
    [Tooltip("not being used")]
    private ScriptableObject _itemGameObject;

}