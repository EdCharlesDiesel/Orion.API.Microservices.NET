namespace Orion.Helpers.Graphs
{
    internal class RectangleManiaClass4
    {
        // O(n^2) time | O(n) space - where n is the number of coordinates
        public static int RectangleMania(Point[] coords)
        {
            HashSet<string> coordsTable = getCoordsTable(coords);
            return getRectangleCount(coords, coordsTable);
        }
        public static HashSet<string> getCoordsTable(Point[] coords)
        {
            HashSet<string> coordsTable = new HashSet<string>();
            foreach (Point coord in coords)
            {
                string coordstring = coordTostring(coord);
                coordsTable.Add(coordstring);
            }
            return coordsTable;
        }
        public static int getRectangleCount(Point[] coords, HashSet<string> coordsTable)
        {
            int rectangleCount = 0;
            foreach (Point coord1 in coords)
            {
                foreach (Point coord2 in coords)
                {
                    if (!isInUpperRight(coord1, coord2)) continue;
                    string upperCoordstring = coordTostring(new Point(coord1.X,
                    coord2.Y));
                    string rightCoordstring = coordTostring(new Point(coord2.X,
                    coord1.Y));
                    if (
                    coordsTable.Contains(upperCoordstring) &&
                    coordsTable.Contains(rightCoordstring)
                    ) rectangleCount++;
                }
            }
            return rectangleCount;
        }
        public static bool isInUpperRight(Point coord1, Point coord2)
        {
            return coord2.X > coord1.X && coord2.Y > coord1.Y;
        }
        public static string coordTostring(Point coord)
        {
            return coord.X + "-" + coord.Y;
        }
 
    }


}
