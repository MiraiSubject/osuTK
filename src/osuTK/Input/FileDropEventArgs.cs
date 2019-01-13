﻿using System;

namespace osuTK.Input
{
    /// <summary>
    /// Defines the event data for <see cref="NativeWindow"/> events.
    /// </summary>
    public class FileDropEventArgs : EventArgs
    {
        public FileDropEventArgs(string fileName = null)
        {
            FileName = fileName;
        }

        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        public string FileName
        {
            get;
            set;
        }
    }
}
