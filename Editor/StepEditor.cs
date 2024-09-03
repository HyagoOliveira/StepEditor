using UnityEditor;

namespace ActionCode.StepEditor
{
    public class StepEditor
    {
        private const string key = "j";

        [MenuItem("Tools/Step _" + key)]
        private static void Step() => EditorApplication.Step();
    }
}