using UnityEngine;
using UnityEditor;

public static class ObjectToViewTool
{
    [MenuItem("Five/Scene View/Move Object To View #&p")]
    private static void BringToView()
    {
        var target = Selection.activeGameObject;

        if (target == null) return;
        var zPos = target.transform.position.z;

        EditorApplication.ExecuteMenuItem("GameObject/Align With View");

        var pos = target.transform.position;
        pos = new Vector3(pos.x, pos.y, zPos);
        target.transform.position = pos;
    }
}
