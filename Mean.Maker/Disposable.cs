﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mean.Maker
{
    public class Disposable : IDisposable
    {
        private readonly Action onDispose;
        private bool disposed;

        public Disposable(Action onDispose)
        {
            disposed = false;
            this.onDispose = onDispose;
        }

        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
                onDispose();
            }
        }
    }
}
