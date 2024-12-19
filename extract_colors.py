import os
import re
import csv

values = {}

# Read and parse the color values
with open("raw_color_page.txt", "r") as f:
    line = f.readline()
    while line:
        match = re.match(r"\d+\s+([A-Z_]+)\s+(\d+),\s+(\d+),\s+(\d+)", line)
        if match:
            values[match.groups()[0]] = (
                int(match.groups()[1]),
                int(match.groups()[2]),
                int(match.groups()[3])
            )
        line = f.readline()

# Add None/Transparent with (0, 0, 0, 0)
rgba_values = {name: (*rgb, 255) for name, rgb in values.items()}
rgba_values["NONE_TRANSPARENT"] = (0, 0, 0, 0)

# Write RGB CSV (excluding Transparent)
with open("colors_rgb.csv", "w", newline="") as rgb_file:
    writer = csv.writer(rgb_file)
    for color in values.values():
        writer.writerow(color)

# Write RGBA CSV (including Transparent)
with open("colors_rgba.csv", "w", newline="") as rgba_file:
    writer = csv.writer(rgba_file)
    for color in rgba_values.values():
        writer.writerow(color)

pdn_content = [
    "ColorBgra[] minecraftColors = new ColorBgra[]",
    "{"
]
for name, rgba in rgba_values.items():
    pdn_content.append(f"    ColorBgra.FromBgra({rgba[2]}, {rgba[1]}, {rgba[0]}, {rgba[3]}),")
pdn_content[-1] = pdn_content[-1][:-1]  # Remove trailing comma from the last entry
pdn_content.extend("};")

# Write Java Enum to File
with open("Colors.cs_pdn", "w") as pdn_file:
    pdn_file.write("\n".join(pdn_content))

# Generate Java Enum Class
enum_content = [
    "public enum Colors {"
]
for name, rgba in rgba_values.items():
    enum_content.append(f"    {name}({rgba[0]}, {rgba[1]}, {rgba[2]}, {rgba[3]}),")
enum_content[-1] = enum_content[-1][:-1]  # Remove trailing comma from the last entry
enum_content.extend([
    "    ;",
    "",
    "    private final int r, g, b, a;",
    "",
    "    Colors(int r, int g, int b, int a) {",
    "        this.r = r;",
    "        this.g = g;",
    "        this.b = b;",
    "        this.a = a;",
    "    }",
    "",
    "    public int[] getRGB() {",
    "        return new int[]{r, g, b};",
    "    }",
    "",
    "    public int[] getRGBA() {",
    "        return new int[]{r, g, b, a};",
    "    }",
    "",
    "    public static int[][] getAllRGB() {",
    "        return java.util.Arrays.stream(values())",
    "            .filter(color -> color != NONE_TRANSPARENT)",
    "            .map(Colors::getRGB)",
    "            .toArray(int[][]::new);",
    "    }",
    "",
    "    public static int[][] getAllRGBA() {",
    "        return java.util.Arrays.stream(values())",
    "            .map(Colors::getRGBA)",
    "            .toArray(int[][]::new);",
    "    }",
    "}"
])

# Write Java Enum to File
with open("Colors.java", "w") as java_file:
    java_file.write("\n".join(enum_content))

print("CSV and Java Enum files generated successfully.")
