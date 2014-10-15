using UnityEngine;
using System.Collections;

public class iOSOnly : MonoBehaviour
{
#if !UNITY_IOS
  void Awake()
  {
    Destroy(gameObject);
  }
#endif
}
