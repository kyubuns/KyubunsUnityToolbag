using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ToggleEnableButton : MonoBehaviour
{
  [SerializeField] List<GameObject> targetObjects;

  void OnClick()
  {
    foreach(var go in targetObjects) go.SetActive(go.activeSelf);
  }
}
