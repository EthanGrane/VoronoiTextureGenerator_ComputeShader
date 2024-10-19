using System.IO;
using UnityEditor;
using UnityEngine;

public enum SaveTextureFileFormat
{
    PNG,
    JPG,
    EXR
}

public static class SaveUtils
{
    public static void SaveRenderTextureToFile(RenderTexture renderTexture, SaveTextureFileFormat fileFormat = SaveTextureFileFormat.PNG, int jpgQuality = 95)
    {
        Texture2D tex;
        if (fileFormat != SaveTextureFileFormat.EXR)
            tex = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.ARGB32, false, false);
        else
            tex = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGBAFloat, false, true);

        var oldRt = RenderTexture.active;
        RenderTexture.active = renderTexture;
        tex.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        tex.Apply();
        RenderTexture.active = oldRt;

        string defaultName = "noiseTexture.png";
        string filePath = EditorUtility.SaveFilePanel("Save Texture", Application.dataPath, defaultName, "png");
        if (filePath == "" || filePath == null)
        {
            Debug.Log("Save texture canceled.");
            return;
        }

        SaveTexture2DToFile(tex, filePath, fileFormat, jpgQuality);

        if (Application.isPlaying)
            Object.Destroy(tex);
        else
            Object.DestroyImmediate(tex);
    }

    private static void SaveTexture2DToFile(Texture2D texture, string filePath, SaveTextureFileFormat fileFormat, int jpgQuality)
    {
        byte[] bytes;
        switch (fileFormat)
        {
            case SaveTextureFileFormat.JPG:
                bytes = texture.EncodeToJPG(jpgQuality);
                break;
            case SaveTextureFileFormat.EXR:
                bytes = texture.EncodeToEXR();
                break;
            case SaveTextureFileFormat.PNG:
            default:
                bytes = texture.EncodeToPNG();
                break;
        }

        File.WriteAllBytes(filePath, bytes);
        Debug.Log($"Texture saved on: {filePath}");
    }
}
