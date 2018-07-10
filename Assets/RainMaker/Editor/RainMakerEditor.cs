using System;
using UnityEngine;
using UnityEditor;

namespace DigitalRuby.RainMaker
{
    public class RainMakerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            {
                const float maxLogoWidth = 430.0f;
                EditorGUILayout.Separator();
                float w = EditorGUIUtility.currentViewWidth;
                Rect r = new Rect();
                r.width = Math.Min(w - 40.0f, maxLogoWidth);
                r.height = r.width / 2.7f;
                Rect r2 = GUILayoutUtility.GetRect(r.width, r.height);
                r.x = ((EditorGUIUtility.currentViewWidth - r.width) * 0.5f) - 4.0f;
                r.y = r2.y;
            }
            DrawDefaultInspector();
        }
    }

    [CustomEditor(typeof(RainScript))]
    public class RainMakerEditor3D : RainMakerEditor
    {
    }

    [CustomEditor(typeof(RainScript2D))]
    public class RainMakerEditor2D : RainMakerEditor
    {
    }
}