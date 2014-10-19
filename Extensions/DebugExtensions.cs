public static class DebugExtensions
{
  public static void Log(string message, params object[] args) { UnityEngine.Debug.Log(string.Format(message, args)); }
  public static void LogError(string message, params object[] args) { UnityEngine.Debug.LogError(string.Format(message, args)); }
  public static void LogWarning(string message, params object[] args) { UnityEngine.Debug.LogWarning(string.Format(message, args)); }
}
