// See https://aka.ms/new-console-template for more information
List<string> testValues = new List<string>() { "4", "13 14 13", "30 17 3", "11 22 7", "5 7 5" };
foreach (string triangle in Result.triangleType(testValues))
    Console.WriteLine(triangle);
Console.ReadLine();

class Result
{

    /*
     * Complete the 'triangleType' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING_ARRAY triangleToy as parameter.
     */
    const string NoneOfThis = "None of this";
    const string Isosceles = "Isosceles";
    const string Equilateral = "Equilateral";

    public static List<string> triangleType(List<string> triangleToy)
    {
        List<string> result = new List<string>();

        int totalTriangles = Convert.ToInt32(triangleToy[0]);

        for (int i = 1; i <= totalTriangles; i++)
        {
            string[] vertexes = triangleToy[i].Split(' ');

            List<int> integerVertexes = vertexes.Select(int.Parse).ToList();

            integerVertexes.OrderByDescending(i => i);

            //trianglo invalido
            if (integerVertexes[0] > integerVertexes[1] + integerVertexes[2])
            {
                result.Add(NoneOfThis);
                continue;
            }

            //tutti i vertici sono uguali tra loro
            if (integerVertexes[0] == integerVertexes[1] && integerVertexes[0] == integerVertexes[2])
            {
                result.Add(Equilateral);
                continue;
            }

            //due vertici uguali
            if (integerVertexes[0] == integerVertexes[1] || integerVertexes[0] == integerVertexes[2] || integerVertexes[1] == integerVertexes[2])
            {
                result.Add(Isosceles);
                continue;
            }
            else
                result.Add(NoneOfThis);
        }

        return result;
    }

}

