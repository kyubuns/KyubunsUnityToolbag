﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class CopyTween : MonoBehaviour
{
  [SerializeField] public GameObject original;
  [SerializeField] public float delay;

  void Awake()
  {
    MoveComponents();
  }

  void Start()
  {
    MoveComponents();
  }

  void MoveComponents()
  {
    if(original == null) return;
    var from = original;
    var to = gameObject;
    var components = from.GetComponents<UITweener>();
    foreach(var component in components)
    {
      Type type = component.GetType();
      var copy = (UITweener)to.AddComponent(type);
      var fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
      foreach (var field in fields) field.SetValue(copy, field.GetValue(component));
      copy.delay = delay;
      copy.Sample(0.0f, false);
    }
    Destroy(this);
  }
}
