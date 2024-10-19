using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UI;

public class VoronoiTextureGenerator : MonoBehaviour
{
    public enum VoronoiMode
    {
        Greyscale,
        Floor,
        Crystal
    }

    public ComputeShader shader;
    [Space]
    [Header("Voronoi Settings")]
    public int textureSize = 1024;
    public int numberOfPoints = 50;
    public float seed;
    [Range(0,10)]
    public float saturation = 2;
    public bool textureIsTiled = false;
    public bool invertedColors = false;
    public VoronoiMode voronoiMode;
    [Range(0.0001f,0.1f)]
    internal float intersectionThreshold = 0.01f;

    [HideInInspector] internal RenderTexture resultTexture;

    public void Generate()
    {
        resultTexture = GenerateImage();
        shader.SetTexture(0, "Result", resultTexture);
        shader.SetInt("NumberOfPoints", Mathf.Clamp(numberOfPoints,1,1000));
        shader.SetFloat("seed", seed == 0 ? UnityEngine.Random.Range(0f, 99999f) : seed);
        shader.SetFloat("saturation", saturation);
        shader.SetFloat("intersectionThreshold", intersectionThreshold);
        shader.SetInt("voronoiMode", (int)voronoiMode);
        shader.SetBool("inverted", invertedColors);
        shader.SetBool("tiled", textureIsTiled);

        int threadGroupsX = Mathf.CeilToInt(resultTexture.width / 8.0f);
        int threadGroupsY = Mathf.CeilToInt(resultTexture.height / 8.0f);
        shader.Dispatch(0, threadGroupsX, threadGroupsY, 1);
    }

    RenderTexture GenerateImage()
    {
        RenderTexture finalTexture = null;
        finalTexture = new RenderTexture(textureSize, textureSize, 0, RenderTextureFormat.ARGB32);
        finalTexture.filterMode = FilterMode.Bilinear;
        finalTexture.enableRandomWrite = true;
        finalTexture.Create();

        return finalTexture;
    }

    private void OnValidate()
    {
        numberOfPoints = Mathf.Clamp(numberOfPoints, 1, 300);
    }
}

/*
 *  EDITOR
 */
#if UNITY_EDITOR
[CustomEditor(typeof(VoronoiTextureGenerator))]
public class VoronoiGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        VoronoiTextureGenerator voronoi = (VoronoiTextureGenerator)target;

        // Generate the texture
        if (GUILayout.Button("Generate"))
        {
            voronoi.Generate();
        }

        DrawDefaultInspector();

        // Voronoi floor, show intersection Threshold
        if (voronoi.voronoiMode == VoronoiTextureGenerator.VoronoiMode.Floor)
        {
            EditorGUILayout.LabelField("IntersectionThreshold");
            voronoi.intersectionThreshold = EditorGUILayout.Slider(voronoi.intersectionThreshold, 0.0001f, 0.05f);
        }

        // Texture preview
        if (voronoi.resultTexture != null)
        {
            Texture2D tempTexture = new Texture2D(voronoi.resultTexture.width, voronoi.resultTexture.height, TextureFormat.ARGB32, false);
            RenderTexture.active = voronoi.resultTexture;
            tempTexture.ReadPixels(new Rect(0, 0, voronoi.resultTexture.width, voronoi.resultTexture.height), 0, 0);
            tempTexture.Apply();
            RenderTexture.active = null;

            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.Label(tempTexture, GUILayout.Width(312), GUILayout.Height(312));
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }
        else
        {
            GUILayout.Label("Result Texture is null", new GUIStyle(GUI.skin.label){normal = { textColor = Color.red }});
        }


        // Export button
        if (GUILayout.Button("Export Texture"))
        {
            SaveUtils.SaveRenderTextureToFile(voronoi.resultTexture, SaveTextureFileFormat.PNG);
        }


    }
}
#endif