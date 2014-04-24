﻿/// <summary>
/// file management
/// </summary>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SweNet
{
    partial class SwissEph
    {

		/// <summary>
		/// Load a file
		/// </summary>
		/// <param name="filename">File name</param>
		/// <returns>File loaded or null if file not found</returns>
        protected CFile LoadFile(String filename) {
            var h = OnLoadFile;
            if (h != null) {
                var e = new LoadFileEventArgs(filename);
                h(this, e);
                return e.File;
            }
            return null;
        }

		/// <summary>
		/// Event raised when loading a file is required
		/// </summary>
        public event EventHandler<LoadFileEventArgs> OnLoadFile;

    }
}
