// Name: MinecraftMapColorPalette
// Submenu: Color
// Author: Christian F. Brinkmann
// Title: MinecraftMapColorPalette
// Version: 1.21
// Desc:
// Keywords:
// URL: https://github.com/chrisb09/map-color-convert
// Help:


#region UICode
IntSliderControl AlphaThreshold = 128; // [0,256] Set Transparent for Alpha value smaller than
#endregion

ColorBgra[] minecraftColors = new ColorBgra[]
{
    ColorBgra.FromBgra(39, 125, 89, 255),
    ColorBgra.FromBgra(48, 153, 109, 255),
    ColorBgra.FromBgra(56, 178, 127, 255),
    ColorBgra.FromBgra(29, 94, 67, 255),
    ColorBgra.FromBgra(115, 164, 174, 255),
    ColorBgra.FromBgra(140, 201, 213, 255),
    ColorBgra.FromBgra(163, 233, 247, 255),
    ColorBgra.FromBgra(86, 123, 130, 255),
    ColorBgra.FromBgra(140, 140, 140, 255),
    ColorBgra.FromBgra(171, 171, 171, 255),
    ColorBgra.FromBgra(199, 199, 199, 255),
    ColorBgra.FromBgra(105, 105, 105, 255),
    ColorBgra.FromBgra(0, 0, 180, 255),
    ColorBgra.FromBgra(0, 0, 220, 255),
    ColorBgra.FromBgra(0, 0, 255, 255),
    ColorBgra.FromBgra(0, 0, 135, 255),
    ColorBgra.FromBgra(180, 112, 112, 255),
    ColorBgra.FromBgra(220, 138, 138, 255),
    ColorBgra.FromBgra(255, 160, 160, 255),
    ColorBgra.FromBgra(135, 84, 84, 255),
    ColorBgra.FromBgra(117, 117, 117, 255),
    ColorBgra.FromBgra(144, 144, 144, 255),
    ColorBgra.FromBgra(167, 167, 167, 255),
    ColorBgra.FromBgra(88, 88, 88, 255),
    ColorBgra.FromBgra(0, 87, 0, 255),
    ColorBgra.FromBgra(0, 106, 0, 255),
    ColorBgra.FromBgra(0, 124, 0, 255),
    ColorBgra.FromBgra(0, 65, 0, 255),
    ColorBgra.FromBgra(180, 180, 180, 255),
    ColorBgra.FromBgra(220, 220, 220, 255),
    ColorBgra.FromBgra(255, 255, 255, 255),
    ColorBgra.FromBgra(135, 135, 135, 255),
    ColorBgra.FromBgra(129, 118, 115, 255),
    ColorBgra.FromBgra(158, 144, 141, 255),
    ColorBgra.FromBgra(184, 168, 164, 255),
    ColorBgra.FromBgra(97, 88, 86, 255),
    ColorBgra.FromBgra(54, 76, 106, 255),
    ColorBgra.FromBgra(66, 94, 130, 255),
    ColorBgra.FromBgra(77, 109, 151, 255),
    ColorBgra.FromBgra(40, 57, 79, 255),
    ColorBgra.FromBgra(79, 79, 79, 255),
    ColorBgra.FromBgra(96, 96, 96, 255),
    ColorBgra.FromBgra(112, 112, 112, 255),
    ColorBgra.FromBgra(59, 59, 59, 255),
    ColorBgra.FromBgra(180, 45, 45, 255),
    ColorBgra.FromBgra(220, 55, 55, 255),
    ColorBgra.FromBgra(255, 64, 64, 255),
    ColorBgra.FromBgra(135, 33, 33, 255),
    ColorBgra.FromBgra(50, 84, 100, 255),
    ColorBgra.FromBgra(62, 102, 123, 255),
    ColorBgra.FromBgra(72, 119, 143, 255),
    ColorBgra.FromBgra(38, 63, 75, 255),
    ColorBgra.FromBgra(172, 177, 180, 255),
    ColorBgra.FromBgra(211, 217, 220, 255),
    ColorBgra.FromBgra(245, 252, 255, 255),
    ColorBgra.FromBgra(129, 133, 135, 255),
    ColorBgra.FromBgra(36, 89, 152, 255),
    ColorBgra.FromBgra(44, 109, 186, 255),
    ColorBgra.FromBgra(51, 127, 216, 255),
    ColorBgra.FromBgra(27, 67, 114, 255),
    ColorBgra.FromBgra(152, 53, 125, 255),
    ColorBgra.FromBgra(186, 65, 153, 255),
    ColorBgra.FromBgra(216, 76, 178, 255),
    ColorBgra.FromBgra(114, 40, 94, 255),
    ColorBgra.FromBgra(152, 108, 72, 255),
    ColorBgra.FromBgra(186, 132, 88, 255),
    ColorBgra.FromBgra(216, 153, 102, 255),
    ColorBgra.FromBgra(114, 81, 54, 255),
    ColorBgra.FromBgra(36, 161, 161, 255),
    ColorBgra.FromBgra(44, 197, 197, 255),
    ColorBgra.FromBgra(51, 229, 229, 255),
    ColorBgra.FromBgra(27, 121, 121, 255),
    ColorBgra.FromBgra(17, 144, 89, 255),
    ColorBgra.FromBgra(21, 176, 109, 255),
    ColorBgra.FromBgra(25, 204, 127, 255),
    ColorBgra.FromBgra(13, 108, 67, 255),
    ColorBgra.FromBgra(116, 89, 170, 255),
    ColorBgra.FromBgra(142, 109, 208, 255),
    ColorBgra.FromBgra(165, 127, 242, 255),
    ColorBgra.FromBgra(87, 67, 128, 255),
    ColorBgra.FromBgra(53, 53, 53, 255),
    ColorBgra.FromBgra(65, 65, 65, 255),
    ColorBgra.FromBgra(76, 76, 76, 255),
    ColorBgra.FromBgra(40, 40, 40, 255),
    ColorBgra.FromBgra(108, 108, 108, 255),
    ColorBgra.FromBgra(132, 132, 132, 255),
    ColorBgra.FromBgra(153, 153, 153, 255),
    ColorBgra.FromBgra(81, 81, 81, 255),
    ColorBgra.FromBgra(108, 89, 53, 255),
    ColorBgra.FromBgra(132, 109, 65, 255),
    ColorBgra.FromBgra(153, 127, 76, 255),
    ColorBgra.FromBgra(81, 67, 40, 255),
    ColorBgra.FromBgra(125, 44, 89, 255),
    ColorBgra.FromBgra(153, 54, 109, 255),
    ColorBgra.FromBgra(178, 63, 127, 255),
    ColorBgra.FromBgra(94, 33, 67, 255),
    ColorBgra.FromBgra(125, 53, 36, 255),
    ColorBgra.FromBgra(153, 65, 44, 255),
    ColorBgra.FromBgra(178, 76, 51, 255),
    ColorBgra.FromBgra(94, 40, 27, 255),
    ColorBgra.FromBgra(36, 53, 72, 255),
    ColorBgra.FromBgra(44, 65, 88, 255),
    ColorBgra.FromBgra(51, 76, 102, 255),
    ColorBgra.FromBgra(27, 40, 54, 255),
    ColorBgra.FromBgra(36, 89, 72, 255),
    ColorBgra.FromBgra(44, 109, 88, 255),
    ColorBgra.FromBgra(51, 127, 102, 255),
    ColorBgra.FromBgra(27, 67, 54, 255),
    ColorBgra.FromBgra(36, 36, 108, 255),
    ColorBgra.FromBgra(44, 44, 132, 255),
    ColorBgra.FromBgra(51, 51, 153, 255),
    ColorBgra.FromBgra(27, 27, 81, 255),
    ColorBgra.FromBgra(17, 17, 17, 255),
    ColorBgra.FromBgra(21, 21, 21, 255),
    ColorBgra.FromBgra(25, 25, 25, 255),
    ColorBgra.FromBgra(13, 13, 13, 255),
    ColorBgra.FromBgra(54, 168, 176, 255),
    ColorBgra.FromBgra(66, 205, 215, 255),
    ColorBgra.FromBgra(77, 238, 250, 255),
    ColorBgra.FromBgra(40, 126, 132, 255),
    ColorBgra.FromBgra(150, 154, 64, 255),
    ColorBgra.FromBgra(183, 188, 79, 255),
    ColorBgra.FromBgra(213, 219, 92, 255),
    ColorBgra.FromBgra(112, 115, 48, 255),
    ColorBgra.FromBgra(180, 90, 52, 255),
    ColorBgra.FromBgra(220, 110, 63, 255),
    ColorBgra.FromBgra(255, 128, 74, 255),
    ColorBgra.FromBgra(135, 67, 39, 255),
    ColorBgra.FromBgra(40, 153, 0, 255),
    ColorBgra.FromBgra(50, 187, 0, 255),
    ColorBgra.FromBgra(58, 217, 0, 255),
    ColorBgra.FromBgra(30, 114, 0, 255),
    ColorBgra.FromBgra(34, 60, 91, 255),
    ColorBgra.FromBgra(42, 74, 111, 255),
    ColorBgra.FromBgra(49, 86, 129, 255),
    ColorBgra.FromBgra(25, 45, 68, 255),
    ColorBgra.FromBgra(0, 1, 79, 255),
    ColorBgra.FromBgra(0, 1, 96, 255),
    ColorBgra.FromBgra(0, 2, 112, 255),
    ColorBgra.FromBgra(0, 1, 59, 255),
    ColorBgra.FromBgra(113, 124, 147, 255),
    ColorBgra.FromBgra(138, 152, 180, 255),
    ColorBgra.FromBgra(161, 177, 209, 255),
    ColorBgra.FromBgra(85, 93, 110, 255),
    ColorBgra.FromBgra(25, 57, 112, 255),
    ColorBgra.FromBgra(31, 70, 137, 255),
    ColorBgra.FromBgra(36, 82, 159, 255),
    ColorBgra.FromBgra(19, 43, 84, 255),
    ColorBgra.FromBgra(76, 61, 105, 255),
    ColorBgra.FromBgra(93, 75, 128, 255),
    ColorBgra.FromBgra(108, 87, 149, 255),
    ColorBgra.FromBgra(57, 46, 78, 255),
    ColorBgra.FromBgra(97, 76, 79, 255),
    ColorBgra.FromBgra(119, 93, 96, 255),
    ColorBgra.FromBgra(138, 108, 112, 255),
    ColorBgra.FromBgra(73, 57, 59, 255),
    ColorBgra.FromBgra(25, 93, 131, 255),
    ColorBgra.FromBgra(31, 114, 160, 255),
    ColorBgra.FromBgra(36, 133, 186, 255),
    ColorBgra.FromBgra(19, 70, 98, 255),
    ColorBgra.FromBgra(37, 82, 72, 255),
    ColorBgra.FromBgra(45, 100, 88, 255),
    ColorBgra.FromBgra(53, 117, 103, 255),
    ColorBgra.FromBgra(28, 61, 54, 255),
    ColorBgra.FromBgra(55, 54, 112, 255),
    ColorBgra.FromBgra(67, 66, 138, 255),
    ColorBgra.FromBgra(78, 77, 160, 255),
    ColorBgra.FromBgra(41, 40, 84, 255),
    ColorBgra.FromBgra(24, 28, 40, 255),
    ColorBgra.FromBgra(30, 35, 49, 255),
    ColorBgra.FromBgra(35, 41, 57, 255),
    ColorBgra.FromBgra(18, 21, 30, 255),
    ColorBgra.FromBgra(69, 75, 95, 255),
    ColorBgra.FromBgra(84, 92, 116, 255),
    ColorBgra.FromBgra(98, 107, 135, 255),
    ColorBgra.FromBgra(51, 56, 71, 255),
    ColorBgra.FromBgra(64, 64, 61, 255),
    ColorBgra.FromBgra(79, 79, 75, 255),
    ColorBgra.FromBgra(92, 92, 87, 255),
    ColorBgra.FromBgra(48, 48, 46, 255),
    ColorBgra.FromBgra(62, 51, 86, 255),
    ColorBgra.FromBgra(75, 62, 105, 255),
    ColorBgra.FromBgra(88, 73, 122, 255),
    ColorBgra.FromBgra(46, 38, 64, 255),
    ColorBgra.FromBgra(64, 43, 53, 255),
    ColorBgra.FromBgra(79, 53, 65, 255),
    ColorBgra.FromBgra(92, 62, 76, 255),
    ColorBgra.FromBgra(48, 32, 40, 255),
    ColorBgra.FromBgra(24, 35, 53, 255),
    ColorBgra.FromBgra(30, 43, 65, 255),
    ColorBgra.FromBgra(35, 50, 76, 255),
    ColorBgra.FromBgra(18, 26, 40, 255),
    ColorBgra.FromBgra(29, 57, 53, 255),
    ColorBgra.FromBgra(36, 70, 65, 255),
    ColorBgra.FromBgra(42, 82, 76, 255),
    ColorBgra.FromBgra(22, 43, 40, 255),
    ColorBgra.FromBgra(32, 42, 100, 255),
    ColorBgra.FromBgra(39, 51, 122, 255),
    ColorBgra.FromBgra(46, 60, 142, 255),
    ColorBgra.FromBgra(24, 31, 75, 255),
    ColorBgra.FromBgra(11, 15, 26, 255),
    ColorBgra.FromBgra(13, 18, 31, 255),
    ColorBgra.FromBgra(16, 22, 37, 255),
    ColorBgra.FromBgra(8, 11, 19, 255),
    ColorBgra.FromBgra(34, 33, 133, 255),
    ColorBgra.FromBgra(42, 41, 163, 255),
    ColorBgra.FromBgra(49, 48, 189, 255),
    ColorBgra.FromBgra(25, 25, 100, 255),
    ColorBgra.FromBgra(68, 44, 104, 255),
    ColorBgra.FromBgra(83, 54, 127, 255),
    ColorBgra.FromBgra(97, 63, 148, 255),
    ColorBgra.FromBgra(51, 33, 78, 255),
    ColorBgra.FromBgra(20, 17, 64, 255),
    ColorBgra.FromBgra(25, 21, 79, 255),
    ColorBgra.FromBgra(29, 25, 92, 255),
    ColorBgra.FromBgra(15, 13, 48, 255),
    ColorBgra.FromBgra(94, 88, 15, 255),
    ColorBgra.FromBgra(115, 108, 18, 255),
    ColorBgra.FromBgra(134, 126, 22, 255),
    ColorBgra.FromBgra(70, 66, 11, 255),
    ColorBgra.FromBgra(98, 100, 40, 255),
    ColorBgra.FromBgra(120, 122, 50, 255),
    ColorBgra.FromBgra(140, 142, 58, 255),
    ColorBgra.FromBgra(74, 75, 30, 255),
    ColorBgra.FromBgra(43, 31, 60, 255),
    ColorBgra.FromBgra(53, 37, 74, 255),
    ColorBgra.FromBgra(62, 44, 86, 255),
    ColorBgra.FromBgra(32, 23, 45, 255),
    ColorBgra.FromBgra(93, 127, 14, 255),
    ColorBgra.FromBgra(114, 155, 17, 255),
    ColorBgra.FromBgra(133, 180, 20, 255),
    ColorBgra.FromBgra(70, 95, 10, 255),
    ColorBgra.FromBgra(70, 70, 70, 255),
    ColorBgra.FromBgra(86, 86, 86, 255),
    ColorBgra.FromBgra(100, 100, 100, 255),
    ColorBgra.FromBgra(52, 52, 52, 255),
    ColorBgra.FromBgra(103, 123, 152, 255),
    ColorBgra.FromBgra(126, 150, 186, 255),
    ColorBgra.FromBgra(147, 175, 216, 255),
    ColorBgra.FromBgra(77, 92, 114, 255),
    ColorBgra.FromBgra(105, 117, 89, 255),
    ColorBgra.FromBgra(129, 144, 109, 255),
    ColorBgra.FromBgra(150, 167, 127, 255),
    ColorBgra.FromBgra(79, 88, 67, 255)
};

Dictionary<ColorBgra, ColorBgra> colorMap = new Dictionary<ColorBgra, ColorBgra>();

void PreRender(Surface dst, Surface src)
{
    HashSet<ColorBgra> uniqueColors = new HashSet<ColorBgra>();

    // Collect all unique colors in the source image
    for (int y = 0; y < src.Height; y++)
    {
        for (int x = 0; x < src.Width; x++)
        {
            uniqueColors.Add(src[x, y]);
        }
    }

    // Map each unique color to the closest Minecraft color
    foreach (ColorBgra originalColor in uniqueColors)
    {
        ColorBgra closestColor = FindClosestColor(originalColor, minecraftColors);
        colorMap[originalColor] = closestColor;
    }
}

// Helper function to find the closest Minecraft color
ColorBgra FindClosestColor(ColorBgra color, ColorBgra[] palette)
{
    ColorBgra closest = palette[0];
    int minDistanceSquared = int.MaxValue;

    foreach (ColorBgra targetColor in palette)
    {
        int distanceSquared = CalculateColorDistanceSquared(color, targetColor);
        if (distanceSquared < minDistanceSquared)
        {
            minDistanceSquared = distanceSquared;
            closest = targetColor;
        }
    }

    return closest;
}

// Calculate squared Euclidean distance between two colors
int CalculateColorDistanceSquared(ColorBgra a, ColorBgra b)
{
    int deltaR = a.R - b.R;
    int deltaG = a.G - b.G;
    int deltaB = a.B - b.B;
    return deltaR * deltaR + deltaG * deltaG + deltaB * deltaB;
}


// Here is the main multi-threaded render function
// The dst canvas is broken up into rectangles and
// your job is to write to each pixel of that rectangle
void Render(Surface dst, Surface src, Rectangle rect)
{
    // uint seed = RandomNumber.InitializeSeed(RandomNumberRenderSeed, rect.Location);
    // Delete this line if you don't need the selection outline shape
    PdnRegion selectionRegion = EnvironmentParameters.GetSelectionAsPdnRegion();

    ColorBgra transparent = ColorBgra.FromBgra(0,0,0,0);

    // Step through each row of the current rectangle
    for (int y = rect.Top; y < rect.Bottom; y++)
    {
        if (IsCancelRequested) return;
        // Step through each pixel on the current row of the rectangle
        for (int x = rect.Left; x < rect.Right; x++)
        {
            ColorBgra SrcPixel = src[x,y];

            if (SrcPixel.A < AlphaThreshold){
                dst[x, y] = transparent;
            } else {
                // Lookup remapped color from the dictionary
                ColorBgra RemappedColor = colorMap[SrcPixel];
                dst[x, y] = RemappedColor;
            }

            // Set the pixel to the remapped color
        }
    }
}