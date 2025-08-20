namespace Orion.Helpers.Graphs
{
    internal class RectangleManiaClass2
    {
        static string UP = "up";
        static string RIGHT = "right";
        static string DOWN = "down";
        // O(n^2) time | O(n) space - where n is the number of coordinates
        public static int RectangleMania(Point[] coords)
        {
            Dictionary<string, Dictionary<int, List<Point>>> coordsTable = getCoordsTable(
            coords);
            return getRectangleCount(coords, coordsTable);
        }
        public static Dictionary<string, Dictionary<int, List<Point>>> getCoordsTable(
        Point[] coords)
        {
            Dictionary<string, Dictionary<int,
            List<Point>>> coordsTable = new Dictionary<string,
            Dictionary<int,
            List<Point>>>();
            coordsTable.Add("x", new Dictionary<int, List<Point>>());
            coordsTable.Add("y", new Dictionary<int, List<Point>>());
            foreach (Point coord in coords)
            {
                if (!coordsTable["x"].ContainsKey(coord.X))
                {
                    coordsTable["x"].Add(coord.X, new List<Point>());
                }
                if (!coordsTable["y"].ContainsKey(coord.Y))
                {
                    coordsTable["y"].Add(coord.Y, new List<Point>());
                }
                coordsTable["x"][coord.X].Add(coord);
                coordsTable["y"][coord.Y].Add(coord);
            }
            return coordsTable;
        }
        public static int getRectangleCount(Point[] coords, Dictionary<string, Dictionary<int,
        List<Point>>> coordsTable)
        {
            int rectangleCount = 0;
            foreach (Point coord in coords)
            {
                int lowerLeftY = coord.Y;
                rectangleCount += clockwiseCountRectangles(coord, coordsTable, UP,
                lowerLeftY);
            }
            return rectangleCount;
        }
        public static int clockwiseCountRectangles(
        Point coord1,
        Dictionary<string, Dictionary<int, List<Point>>> coordsTable,
        string direction,
        int lowerLeftY
        )
        {
            if (direction == DOWN)
            {
                List<Point> relevantCoords = coordsTable["x"][coord1.X];
                foreach (Point coord2 in relevantCoords)
                {
                    int lowerRightY = coord2.Y;
                    if (lowerRightY == lowerLeftY) return 1;
                }
                return 0;
            }

            int rectangleCount = 0;
            if (direction == UP)
            {
                List<Point> relevantCoords = coordsTable["x"][coord1.X];
                foreach (Point coord2 in relevantCoords)
                {
                    bool isAbove = coord2.Y > coord1.Y;
                    if (isAbove) rectangleCount += clockwiseCountRectangles(
                        coord2, coordsTable, RIGHT, lowerLeftY);
                }
            }
            else if (direction == RIGHT)
            {
                List<Point> relevantCoords = coordsTable["y"][coord1.Y];
                foreach (Point coord2 in relevantCoords)
                {
                    bool isRight = coord2.X > coord1.X;
                    if (isRight) rectangleCount += clockwiseCountRectangles(
                        coord2, coordsTable, DOWN, lowerLeftY);
                }
            }
            return rectangleCount;
        }
      
    }
    //public class Point
    //{
    //    public int x;
    //    public int y;
    //    public Point(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //}
}
