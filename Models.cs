class Models
{
    public int[,] alimentarGrafoA()
    {
        int[,] grafoA = new int[3, 3];
        int[] grauA = new int[3];
        //-------- A
        grafoA[0, 0] = 0;
        grafoA[0, 1] = 1;
        grafoA[0, 2] = 1;

        //-------- B
        grafoA[1, 0] = 1;
        grafoA[1, 1] = 0;
        grafoA[1, 2] = 1;
        //-------- C
        grafoA[2, 0] = 1;
        grafoA[2, 1] = 1;
        grafoA[2, 2] = 0;

        return grafoA;
    }


    public int[,] alimentarGrafoB()
    {
        int[,] grafoB = new int[5, 5];
        int[] grauB = new int[5];

        //-------- A
        grafoB[0, 0] = 0;
        grafoB[0, 1] = 1;
        grafoB[0, 2] = 1;
        grafoB[0, 3] = 0;
        grafoB[0, 4] = 1;

        //-------- B
        grafoB[1, 0] = 1;
        grafoB[1, 1] = 0;
        grafoB[1, 2] = 0;
        grafoB[1, 3] = 1;
        grafoB[1, 4] = 1;
        //-------- C
        grafoB[2, 0] = 1;
        grafoB[2, 1] = 0;
        grafoB[2, 2] = 0;
        grafoB[2, 3] = 1;
        grafoB[2, 4] = 1;
        //-------- D
        grafoB[3, 0] = 0;
        grafoB[3, 1] = 1;
        grafoB[3, 2] = 1;
        grafoB[3, 3] = 0;
        grafoB[3, 4] = 1;
        //-------- E
        grafoB[4, 0] = 1;
        grafoB[4, 1] = 1;
        grafoB[4, 2] = 1;
        grafoB[4, 3] = 1;
        grafoB[4, 4] = 0;
        return grafoB;
    }

    public int[,] alimentarGrafoC()
    {

        int[,] grafoC = new int[,] {
            { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
            { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
            { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
            { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
            { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
            { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
            { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
            { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
            { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };

        return grafoC;
    }

    public int[,] grafoComCusto()
    {
        int[,] custo = {
        { int.MaxValue, 2, int.MaxValue, 6, int.MaxValue },
        { 2, int.MaxValue, 3, 8, 5 },
        { int.MaxValue, 3, int.MaxValue, int.MaxValue, 7 },
        { 6, 8, int.MaxValue, int.MaxValue, 9 },
        { int.MaxValue, 5, 7, 9, int.MaxValue },
    };
        return custo;
    }

    public int[,] grafoMaximo()
    {

        int[,] grafoMatriz = new int[,] {
            { 0, 16, 13, 0, 0, 0 }, { 0, 0, 10, 12, 0, 0 },
            { 0, 4, 0, 0, 14, 0 },  { 0, 0, 9, 0, 0, 20 },
            { 0, 0, 0, 7, 0, 4 },   { 0, 0, 0, 0, 0, 0 }
        };

        return grafoMatriz;
    }

}