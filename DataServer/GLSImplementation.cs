﻿using System.ServiceModel;

namespace DataServer
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    internal class GLSImplementation
    {
        public GLSImplementation() { }

        // REMOVE - NOT A REAL FUNCTION
        public int foo() { return 1 + 1; }
    }
}
