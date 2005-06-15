using FreeImageAPI;
using Engine.Core.Utility;

/// <summary>
///  A helper class that loads images
/// </summary>
public class Image_Loader
{
    /// <summary>
    /// Gets the copyright information
    /// </summary>
    /// <returns>A string containing the copyright</returns>
    public static void Get_CopyRight()
    {
        LogManager.DWriteLog("{0}", FreeImage.GetCopyrightMessage());
    }

    /// <summary>
    ///  Loads the specified image file
    /// </summary>
    public static void Load_Image()
    {
        FreeImage.Load(FIF.FIF_PNG, "John.png", 0); 
    }
}