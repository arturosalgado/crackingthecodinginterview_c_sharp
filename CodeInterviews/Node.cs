﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class Node
    {
        public int Value;
        public Node Next;
        public Node(int Value)
        {
            this.Value = Value;   
        }
        public override string ToString()
        {
            return this.Value+"->";
        }

    }

    
}
