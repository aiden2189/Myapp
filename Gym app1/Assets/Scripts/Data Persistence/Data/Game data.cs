using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    int width = 3;
    int height = 3;
    int depth = 3;
    int x;
    int y;
    int z;

    public string[] name = new string[2];

    public string[] rep = new string[3];

    public string[,,] weight3d;

    public string[] weight1d;

    public string[] savedweight;

    ExampleCollection weight;

    public void start()
    {
        weight3d = new string[width,height,depth];
        weight1d = new string[width * height * depth];

        weight = new ExampleCollection(width, height, depth);

        weight1d = Flatten3DArray(weight3d);
        
    }

    public GameData()
    {
        this.name[0] = "Name";
        this.name[1] = "Name";
        this.rep[0] = "monday exercise 1 rep 1";
        this.rep[1] = "monday exercise 1 rep 2";
        this.rep[2] = "monday exercise 1 rep 3";
        this.savedweight[count];

        int count = 0;
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                for (int z = 0; z < depth; z++) {
                    
                    savedweight[count] = weight[x,y,z];
                    count++;
                }
            }
        }
    }

    void Update()
    {
        weight[x, y, z] = weight3d[x, y, z];
    }

    string[] Flatten3DArray (string[,,] mda) 
    {
        int w = mda.GetLength(0);
        int h = mda.GetLength(1);
        int d = mda.GetLength(2);

        string[] a = new string[w*h*d];

        for (int x = 0; x < w; x++) {
            for (int y = 0; y < h; y++) {
                for (int z = 0; z < d; z++) {
                    
                    a[x + h * (y + d * z)] = mda[x,y,z];

                }
            }
        }

        return a;
    }
}

public class ExampleCollection
{
    string[] array;
    int width;
    int height;
    int depth;

    public ExampleCollection (int _width, int _height, int _depth)
    {
        width = _width;
        height = _height;
        depth = _depth;

        array = new string[width * height * depth];
    }

    public string this[int x, int y, int z]
    {
        get
        {
            return array[x + height * (y + depth * z)];
        }
        set
        {
            array[x + height * (y + depth * z)] = value;
        }
    }
}