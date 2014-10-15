using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeEnableButton : MonoBehaviour
{
  [SerializeField] List<GameObject> enableObjects;
  [SerializeField] List<GameObject> disableObjects;

  void OnClick()
  {
    foreach(var go in enableObjects) go.SetActive(true);
    foreach(var go in disableObjects) go.SetActive(false);
  }
}
