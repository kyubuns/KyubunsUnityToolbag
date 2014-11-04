using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class PositionRounder
{
  static PositionRounder()
  {
    EditorApplication.hierarchyWindowChanged += OnHierarchyWindowChanged;
  }

  static void OnHierarchyWindowChanged()
  {
    foreach(var target in Selection.gameObjects)
    {
      var p = target.transform.localPosition;
      p.x = Mathf.Round(p.x * 1000.0f)/1000.0f;
      p.y = Mathf.Round(p.y * 1000.0f)/1000.0f;
      p.z = Mathf.Round(p.z * 1000.0f)/1000.0f;
      target.transform.localPosition = p;
    }
  }
}
