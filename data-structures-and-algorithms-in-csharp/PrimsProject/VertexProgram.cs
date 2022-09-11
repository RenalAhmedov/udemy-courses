using System;

namespace PrimsProject
{
    class Vertex
    {
        public String name;
        public int status;
        public int predecessor;
        public int length;

        public Vertex(String name)
        {
            this.name = name;
        }
    }
}